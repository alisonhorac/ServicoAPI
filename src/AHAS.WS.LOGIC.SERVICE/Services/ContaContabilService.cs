using AHAS.WS.LOGIC.DOMAIN.Interfaces.Repository;
using AHAS.WS.LOGIC.DOMAIN.Interfaces.Service;
using System;

namespace AHAS.WS.LOGIC.SERVICE.Services
{
    public class ContaContabilService : IContaContabilService
    {
        private readonly IContaContabilRepository _contaContabilRepository;

        public ContaContabilService(IContaContabilRepository contaContabilRepository)
        {
            _contaContabilRepository = contaContabilRepository;
        }

        public bool Validate(long id)
        {
            throw new NotImplementedException();
        }
    }
}
