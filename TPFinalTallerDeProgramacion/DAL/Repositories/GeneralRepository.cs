using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TPFinalTallerDeProgramacion.DAL.Interfaces;

namespace TPFinalTallerDeProgramacion.DAL.Repositories
{
    abstract class GeneralRepository<TEntity, TDbContext> : IGeneralRepository<TEntity>
        where TEntity : class
        where TDbContext: DbContext
    {
        protected readonly TDbContext iContext;
        public GeneralRepository(TDbContext pContext)
        {
            if (pContext == null)
            {
                throw new ArgumentNullException(nameof(pContext));
            }
            this.iContext = pContext;
        }
        public abstract void Add(TEntity pEntity);
        public abstract void Delete(TEntity pEntity);
        public abstract TEntity Get(int pId);
        public abstract IList<TEntity> GetAll();
        public abstract void Modify(TEntity pEtity);
    }
}
