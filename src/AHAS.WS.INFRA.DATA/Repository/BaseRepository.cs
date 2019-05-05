using AHAS.WS.INFRA.DATA.Context;
using AHAS.WS.LOGIC.DOMAIN.Entities;
using AHAS.WS.LOGIC.DOMAIN.Interfaces.Repository;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace AHAS.WS.INFRA.DATA.Repository
{
    public class BaseRepository<Entidade> : IRepository<Entidade> where Entidade : BaseEntity
    {
        protected DataBaseSQLContext db;

        public BaseRepository(DataBaseSQLContext context)
        {
            db = context;
        }

        public void Alterar(Entidade obj)
        {
            try
            {
                db.Entry(obj).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                db.SaveChanges();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public Entidade Consultar(int id)
        {
            try
            {
                return db.Set<Entidade>().Find(id);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void Excluir(int id)
        {
            try
            {
                db.Set<Entidade>().Remove(db.Set<Entidade>().Find(id));
                db.SaveChanges();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public void Inserir(Entidade obj)
        {
            try
            {
                db.Set<Entidade>().Add(obj);
                db.SaveChanges();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public IList<Entidade> Listar()
        {
            try
            {
                return db.Set<Entidade>().ToList();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
