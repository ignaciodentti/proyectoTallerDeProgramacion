using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinalTallerDeProgramacion.Modelo
{
    public class Transaction
    {
        public Transaction()
        {

        }

        public DateTime dateTime { get; set; }
        public string description { get; set; }
        public virtual Account account { get; set; }
    }
}
