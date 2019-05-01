using AHAS.WS.LOGIC.DOMAIN.Entities;
using System.Collections.Generic;

namespace AHAS.WS.LOGIC.DOMAIN.Interfaces.Repository
{
    public interface IRepository<Entidade> where Entidade : BaseEntity
    {
        void Inserir(Entidade obj);

        void Alterar(Entidade obj);

        void Excluir(int id);

        Entidade Consultar(int id);

        IList<Entidade> Listar();
    }
}
