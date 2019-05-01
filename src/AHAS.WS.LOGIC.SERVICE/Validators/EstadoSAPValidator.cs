﻿using AHAS.WS.LOGIC.DOMAIN.Entities;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace AHAS.WS.LOGIC.SERVICE.Validators
{
    public class EstadoSAPValidator : AbstractValidator<EstadoSAP>
    {
        public EstadoSAPValidator()
        {
            RuleFor(x => x.CodigoSAP).NotNull();
            RuleFor(x => x.Estado).NotNull();
            RuleFor(x => x.Sigla).NotNull();

            RuleFor(x => x.Estado).Length(0, 10);
            RuleFor(x => x.Sigla).Length(0, 10);
        }
    }
}
