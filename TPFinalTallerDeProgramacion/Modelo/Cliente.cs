using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinalTallerDeProgramacion.Modelo
{
    public class Cliente
    {
        public Cliente()
        {
                
        }

        public int DNI { get; set; }
        public string Nombre { get; set; }
        public string Segmento { get; set; }     //DEBERIA SER UNA CLASE ENUMERADA
        public virtual IList<Tarjeta> listaTarjetas { get; set; }
        public virtual IList<Cuenta> listaCuentas { get; set; }
    }
}
