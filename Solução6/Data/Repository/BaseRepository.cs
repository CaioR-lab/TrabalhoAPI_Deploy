using Data.Context;
using Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Repository
{
    public abstract class BaseRepository<T> where T : Base
    {
        public virtual void Create(T model)
        {
            using (var context = new LojaContext())
            {
                context.Set<T>().Add(model);
                context.SaveChanges();
            }
        }

        public virtual T Read(int Id)
        {
            T model = Activator.CreateInstance<T>();

            using (var context = new LojaContext())
            {
                model = context.Set<T>().Find(Id);
            }
            return model;
        }

        public virtual List<T> Read()
        {
            List<T> lista = new List<T>();
            using (var context = new LojaContext())
            {
                lista = context.Set<T>().ToList();
            }
            return lista;
        }

        public virtual void Update(T model)
        {
            using (var context = new LojaContext())
            {
                context.Entry<T>(model).State = System.Data.Entity.EntityState.Modified;
                context.SaveChanges();
            }
        }

        public virtual void Delete(int Id)
        {
            using (var context = new LojaContext())
            {

                context.Entry<T>(Read(Id)).State = System.Data.Entity.EntityState.Deleted;
                context.SaveChanges();
            }
        }
    }
}
