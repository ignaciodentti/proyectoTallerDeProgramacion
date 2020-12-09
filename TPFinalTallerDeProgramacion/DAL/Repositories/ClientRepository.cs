using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using TPFinalTallerDeProgramacion.DAL.Interfaces;
using TPFinalTallerDeProgramacion.Modelo;

namespace TPFinalTallerDeProgramacion.DAL.Repositories
{
    class ClientRepository: GeneralRepository<Client, AutoserviceDBContext>, IClientRepository
    {
        public ClientRepository(AutoserviceDBContext pContext): base(pContext)
        {

        }
        public override void Add(Client pEntity)
        {
            throw new NotImplementedException();
        }

        public override void Delete(Client pEntity)
        {
            throw new NotImplementedException();
        }

        public override Client Get(int pId)
        {
            throw new NotImplementedException();
        }

        public override IList<Client> GetAll()
        {
            throw new NotImplementedException();
        }

        public override void Modify(Client pEtity)
        {
            throw new NotImplementedException();
        }
    }
}
