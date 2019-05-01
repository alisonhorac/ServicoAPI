using System;
using System.Collections.Generic;
using System.Text;

namespace AHAS.WS.LOGIC.DOMAIN.Entities
{
    public class Documento : BaseEntity
    {
        public string Sigla { get; set; }

        public string Denominacao { get; set; }
    }
}
