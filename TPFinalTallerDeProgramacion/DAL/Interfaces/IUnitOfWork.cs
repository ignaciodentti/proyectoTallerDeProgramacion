using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinalTallerDeProgramacion.DAL.Interfaces
{
    interface IUnitOfWork: IDisposable
    {
        IClientRepository ClientRepository { get; }
        
        void Save();
    }
}
