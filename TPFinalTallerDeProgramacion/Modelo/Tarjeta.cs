using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinalTallerDeProgramacion.Modelo
{
    public class Tarjeta
    {
        public Tarjeta()
        {

        }

        public int Numero { get; set; }
        public string Nombre { get; set; }
        public string Tipo { get; set; }
        public virtual Cliente Cliente { get; set; }
    }
}
