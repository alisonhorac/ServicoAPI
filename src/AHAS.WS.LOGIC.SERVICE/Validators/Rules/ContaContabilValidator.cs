using AHAS.WS.INFRA.DATA.Context;
using AHAS.WS.INFRA.DATA.Repository;
using AHAS.WS.LOGIC.DOMAIN.Entities;
using AHAS.WS.LOGIC.DOMAIN.Interfaces.Repository;
using FluentValidation;
using System;

namespace AHAS.WS.LOGIC.SERVICE.Validators.Rules
{
    public class ContaContabilValidator : AbstractValidator<ContaContabil>
    {
        //DataBaseSQLContext _db = new DataBaseSQLContext();
        public ContaContabilValidator()
        {
            RuleFor(x => x.Balanco)
                .NotNull()
                .Length(2, 75);

            RuleFor(x => x.Conta)
                .NotNull()
                .Must(ContaValida).WithMessage("inválida.")
                .Must(ContaDuplicada).WithMessage("duplicada.");
        }

        private bool ContaValida(long arg)
        {
            return (arg.ToString().StartsWith("1") || arg.ToString().StartsWith("2"));
        }

        private bool ContaDuplicada(long arg)
        {
            return false;//_repository.Validar(arg);
        }
    }
}
