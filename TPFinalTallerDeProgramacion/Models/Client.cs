using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinalTallerDeProgramacion.Modelo
{
    public class Client
    {
        public Client()
        {
                
        }

        public int dni { get; set; }
        public string name { get; set; }
        public string segment { get; set; }     //DEBERIA SER UNA CLASE ENUMERADA
        public virtual IList<Card> cardList { get; set; }
        public virtual IList<Account> accountList { get; set; }
    }
}
