using AHAS.WS.LOGIC.DOMAIN.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace AHAS.WS.LOGIC.DOMAIN.Interfaces.Service
{
    public interface IService<Entidade> where Entidade : BaseEntity
    {
        Entidade Post<V>(Entidade obj) where V : AbstractValidator<Entidade>;

        Entidade Put<V>(Entidade obj) where V : AbstractValidator<Entidade>;

        void Delete(int id);

        Entidade Get(int id);

        IList<Entidade> Get();
    }
}
