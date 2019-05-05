using AHAS.WS.LOGIC.DOMAIN.Entities;
using AHAS.WS.LOGIC.DOMAIN.Interfaces.Repository;
using AHAS.WS.LOGIC.DOMAIN.Interfaces.Service;
using System;
using System.Collections.Generic;
using System.Net.Http;

namespace AHAS.WS.LOGIC.SERVICE.Services
{
    public class BaseService<Entidade> : IBaseService<Entidade> where Entidade : BaseEntity
    {
        private readonly IRepository<Entidade> _baseRepository;

        public BaseService(IRepository<Entidade> baseRepository)
        {
            _baseRepository = baseRepository;
        }

        public Entidade Post(Entidade obj)
        {
            _baseRepository.Inserir(obj);
            return obj;
        }

        public Entidade Put(Entidade obj)
        {
            _baseRepository.Alterar(obj);
            return obj;
        }

        public void Delete(int id)
        {
            if (id == 0)
                throw new ArgumentException("ID informado inválido.");

            _baseRepository.Excluir(id);
        }

        public IList<Entidade> Get()
        {
            var result = _baseRepository.Listar();

            if (result == null)
                throw new HttpRequestException("Não foram encontrados resultados.");

            return result;
        }

        public Entidade Get(int id)
        {
            if (id == 0)
                throw new ArgumentException("ID informado inválido.");

            var result = _baseRepository.Consultar(id);

            if (result == null)
                throw new HttpRequestException("Não foram encontrados resultados.");


            return _baseRepository.Consultar(id);
        }
    }
}
