﻿using Dominio.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.DT
{
    public class DTPencaCompartida2
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public CriterioPremio criterioPremio { get; set; }
        public int torneo { get; set; }
        
    }
}
