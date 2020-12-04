using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinalTallerDeProgramacion.DAL.Interfaces
{
    interface IGeneralRepository<TEntity> where TEntity: class
    { 
        void Add(TEntity pEntity);
        void Delete(TEntity pEntity);
        void Modify(TEntity pEtity);
        TEntity Get(int pId);
        IList<TEntity> GetAll();
    }
}
