using Data.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    class LojaContext : DbContext
    {
        public DbSet<Eletrodomestico> Eletrodomesticos { get; set; }
        public DbSet<Eletronico> Eletronicos { get; set; }

        public LojaContext() : base ("Data Source=192.168.0.170;Initial Catalog=Site;Persist Security Info=True;User ID=UserSite;Password=74269")
        {

        }
    }
}
