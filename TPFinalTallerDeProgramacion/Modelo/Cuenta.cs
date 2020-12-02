using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinalTallerDeProgramacion.Modelo
{
    public class Cuenta
    {
        public Cuenta()
        {

        }

        public double Saldo { get; set; }
        public virtual Cliente Proveedor { get; set; }
        public virtual IList<Movimiento> listaMovimientos { get; set; }
    }
}
