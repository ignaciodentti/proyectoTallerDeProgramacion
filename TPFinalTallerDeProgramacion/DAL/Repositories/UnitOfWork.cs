using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPFinalTallerDeProgramacion.DAL.Interfaces;

namespace TPFinalTallerDeProgramacion.DAL.Repositories
{
    class UnitOfWork : IUnitOfWork
    {
        private readonly AutoserviceDBContext iDBContext;
        private static volatile UnitOfWork cinstance = null;
        private static readonly object cPadlock = new object();

        private UnitOfWork()
        {
            iDBContext = new AutoserviceDBContext();
            ClientRepository = new ClientRepository(iDBContext);        //Agregar todos los repos
        }

        public IClientRepository ClientRepository { get; set; }

        public static UnitOfWork Instance
        {
            get
            {
                if (cinstance == null)
                {
                    lock (cPadlock)
                    {
                        if (cinstance == null)
                        {
                            cinstance = new UnitOfWork();
                        }
                    }
                }
                return cinstance;
            }
        }

        public void Save()
        {
            iDBContext.SaveChanges();
        }

        public void Dispose()
        {
            iDBContext.Dispose();
        }
    }
}
