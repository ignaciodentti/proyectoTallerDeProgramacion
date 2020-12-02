﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinalTallerDeProgramacion.Modelo
{
    public class Movimiento
    {
        public Movimiento()
        {

        }

        public DateTime FechaHora { get; set; }
        public string Descripcion { get; set; }
        public virtual Cuenta Cuenta { get; set; }
    }
}
