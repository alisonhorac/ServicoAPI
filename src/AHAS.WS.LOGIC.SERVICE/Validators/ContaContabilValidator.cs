using AHAS.WS.LOGIC.DOMAIN.Entities;
using FluentValidation;

namespace AHAS.WS.LOGIC.SERVICE.Validators
{
    public class ContaContabilValidator : AbstractValidator<ContaContabil>
    {
        public ContaContabilValidator()
        {
            RuleFor(x => x.Balanco).NotNull();
            RuleFor(x => x.Conta).NotNull();

            RuleFor(x => x.Balanco).Length(2, 75);
        }
    }
}
