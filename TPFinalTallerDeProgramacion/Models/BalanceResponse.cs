using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinalTallerDeProgramacion.Models
{
    class BalanceResponse
    {
        public BalanceResponse(int pID, int pBalance, string pErrorMessage)
        {
            ID = pID;
            Balance = pBalance;
            ErrorMessage = pErrorMessage;
        }

        public BalanceResponse()
        {

        }

        public int ID { get; set; }
        public int Balance { get; set; }
        public string ErrorMessage { get; set; }
    }
}
