﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Models
{
    public class Eletronico : Base
    {
        public decimal Valor { get; set; }
        public string Nome { get; set; }
        public string Marca { get; set; }
    }
}
