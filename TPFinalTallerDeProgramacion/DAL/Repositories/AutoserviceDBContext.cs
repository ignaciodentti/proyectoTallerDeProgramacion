using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TPFinalTallerDeProgramacion.DAL.Repositories
{
    public class AutoserviceDBContext: DbContext
    {
        public AutoserviceDBContext(): base("Autoservice")
        {

        }
    }
}
