using AHAS.WS.LOGIC.DOMAIN.Entities;

namespace AHAS.WS.LOGIC.DOMAIN.Interfaces.Repository
{
    public interface IContaContabilRepository : IRepository<ContaContabil>
    {
        bool Validar(long conta);
    }
}
