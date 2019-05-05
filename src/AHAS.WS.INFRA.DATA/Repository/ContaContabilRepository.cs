using AHAS.WS.INFRA.DATA.Context;
using AHAS.WS.LOGIC.DOMAIN.Entities;
using AHAS.WS.LOGIC.DOMAIN.Interfaces.Repository;
using System.Linq;

namespace AHAS.WS.INFRA.DATA.Repository
{
    public class ContaContabilRepository : BaseRepository<ContaContabil>, IContaContabilRepository
    {
        public ContaContabilRepository(DataBaseSQLContext context) : base(context)
        {
        }

        public bool Validar(long conta)
        {
            return db.Set<ContaContabil>().Where(x => x.Conta == conta).Count() > 0;
        }
    }
}
