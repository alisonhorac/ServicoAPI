using AHAS.WS.INFRA.DATA.Context;
using AHAS.WS.LOGIC.DOMAIN.Entities;
using AHAS.WS.LOGIC.DOMAIN.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AHAS.WS.INFRA.DATA.Repository
{
    public class BaseRepository<Entidade> : IRepository<Entidade> where Entidade : BaseEntity
    {
        private DataBaseSQLContext context = new DataBaseSQLContext();

        public void Alterar(Entidade obj)
        {
            context.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
        }

        public Entidade Consultar(int id)
        {
            return context.Set<Entidade>().Find(id);
        }

        public void Excluir(int id)
        {
            context.Set<Entidade>().Remove(context.Set<Entidade>().Find(id));
            context.SaveChanges();
        }

        public void Inserir(Entidade obj)
        {
            context.Set<Entidade>().Add(obj);
            context.SaveChanges();
        }

        public IList<Entidade> Listar()
        {
            return context.Set<Entidade>().ToList();
        }
    }
}
