using AHAS.WS.LOGIC.DOMAIN.Entities;
using FluentValidation;

namespace AHAS.WS.LOGIC.SERVICE.Validators.Rules
{
    public class EmpresaValidator : AbstractValidator<Empresa>
    {
        public EmpresaValidator()
        {
            RuleFor(x => x.CNPJ).NotNull();
            RuleFor(x => x.IE).NotNull();
            RuleFor(x => x.Unidade).NotNull();
            RuleFor(x => x.Centro).NotNull();
            RuleFor(x => x.Codigo).NotNull();
            RuleFor(x => x.LocalNegocio).NotNull();
            RuleFor(x => x.Sigla).NotNull();
            RuleFor(x => x.UF).NotNull();

            RuleFor(x => x.CNPJ).Length(5, 14);
            RuleFor(x => x.IE).Length(5, 14);
            RuleFor(x => x.Unidade).Length(2, 100);
            RuleFor(x => x.Centro).Length(4, 4);
            RuleFor(x => x.Codigo).Length(4, 4);
            RuleFor(x => x.LocalNegocio).Length(4, 4);
            RuleFor(x => x.Sigla).Length(2, 15);
            RuleFor(x => x.UF).Length(2, 2);
        }
    }
}
