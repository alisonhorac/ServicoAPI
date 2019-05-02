using AHAS.WS.INFRA.DATA.Repository;
using AHAS.WS.LOGIC.DOMAIN.Entities;
using AHAS.WS.LOGIC.DOMAIN.Interfaces.Service;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;

namespace AHAS.WS.LOGIC.SERVICE.Services
{
    public class BaseService<Entidade> : IService<Entidade> where Entidade : BaseEntity
    {
        private BaseRepository<Entidade> repository = new BaseRepository<Entidade>();

        public Entidade Post<Validacao>(Entidade obj) where Validacao : AbstractValidator<Entidade>
        {
            Validate(obj, Activator.CreateInstance<Validacao>());

            repository.Inserir(obj);
            return obj;
        }

        public Entidade Put<Validacao>(Entidade obj) where Validacao : AbstractValidator<Entidade>
        {
            Validate(obj, Activator.CreateInstance<Validacao>());

            repository.Alterar(obj);
            return obj;
        }

        public void Delete(int id)
        {
            if (id == 0)
                throw new ArgumentException("ID informado inválido.");

            repository.Excluir(id);
        }

        public IList<Entidade> Get()
        {
            var result = repository.Listar();

            if (result == null)
                throw new HttpRequestException("Não foram encontrados resultados.");

            return result;
        }

        public Entidade Get(int id)
        {
            if (id == 0)
                throw new ArgumentException("ID informado inválido.");

            var result = repository.Consultar(id);

            if (result == null)
                throw new HttpRequestException("Não foram encontrados resultados.");

            return repository.Consultar(id);
        }

        private void Validate(Entidade obj, AbstractValidator<Entidade> validator)
        {
            if (obj == null)
                throw new Exception("Dados não foram fornecidos.");

            validator.ValidateAndThrow(obj);
        }
    }
}
