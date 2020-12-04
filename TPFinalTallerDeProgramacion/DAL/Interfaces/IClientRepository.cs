using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPFinalTallerDeProgramacion.Modelo;

namespace TPFinalTallerDeProgramacion.DAL.Interfaces
{
    interface IClientRepository: IGeneralRepository<Client>
    {
        void searchJuanAmador();
    }
}
