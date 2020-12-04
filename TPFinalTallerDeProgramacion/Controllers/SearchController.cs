using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPFinalTallerDeProgramacion.DAL.Interfaces;

namespace TPFinalTallerDeProgramacion.Controllers
{
    class SearchController
    {
        private readonly IUnitOfWork iUDT;

        public SearchController(IUnitOfWork pUnitOfWork)
        {
            iUDT = pUnitOfWork;
        }

        public void searchJuanAmador()
        {
            iUDT.ClientRepository.searchJuanAmador();
        }
    }
}
