using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinalTallerDeProgramacion.Modelo
{
    public class Card
    {
        public Card()
        {

        }

        public int number { get; set; }
        public string name { get; set; }
        public string type { get; set; }
        public virtual Client client { get; set; }
    }
}
