using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinalTallerDeProgramacion.Modelo
{
    public class Account
    {
        public Account()
        {

        }

        public double balance { get; set; }
        public virtual Client Provider { get; set; }
        public virtual IList<Transaction> transactionList { get; set; }
    }
}
