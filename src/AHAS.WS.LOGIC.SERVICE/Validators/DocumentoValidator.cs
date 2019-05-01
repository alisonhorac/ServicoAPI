using AHAS.WS.LOGIC.DOMAIN.Entities;
using FluentValidation;

namespace AHAS.WS.LOGIC.SERVICE.Validators
{
    public class DocumentoValidator : AbstractValidator<Documento>
    {
        public DocumentoValidator()
        {
            RuleFor(x => x.Sigla).NotNull();
            RuleFor(x => x.Denominacao).NotNull();

            RuleFor(x => x.Sigla).Length(2, 2);
            RuleFor(x => x.Denominacao).Length(2, 50);
        }
    }
}
