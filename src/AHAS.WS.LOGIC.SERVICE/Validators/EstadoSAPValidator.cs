using AHAS.WS.LOGIC.DOMAIN.Entities;
using FluentValidation;

namespace AHAS.WS.LOGIC.SERVICE.Validators
{
    public class EstadoSAPValidator : AbstractValidator<EstadoSAP>
    {
        public EstadoSAPValidator()
        {
            RuleFor(x => x.CodigoSAP).NotNull();
            RuleFor(x => x.Estado).NotNull();
            RuleFor(x => x.Sigla).NotNull();

            RuleFor(x => x.Estado).Length(2, 25);
            RuleFor(x => x.Sigla).Length(2, 2);
        }
    }
}
