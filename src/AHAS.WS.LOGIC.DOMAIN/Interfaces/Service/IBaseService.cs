using AHAS.WS.LOGIC.DOMAIN.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;

//Install-Package FluentValidation.AspNetCore -Version 8.3.0
namespace AHAS.WS.LOGIC.DOMAIN.Interfaces.Service
{
    public interface IBaseService<Entidade> where Entidade : BaseEntity
    {
        Entidade Post<V>(Entidade obj) where V : AbstractValidator<Entidade>;

        Entidade Put<V>(Entidade obj) where V : AbstractValidator<Entidade>;

        void Delete(int id);

        Entidade Get(int id);

        IList<Entidade> Get();
    }
}
