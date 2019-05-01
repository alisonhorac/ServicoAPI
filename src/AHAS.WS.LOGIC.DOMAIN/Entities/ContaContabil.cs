using System;
using System.Collections.Generic;
using System.Text;

namespace AHAS.WS.LOGIC.DOMAIN.Entities
{
    public class ContaContabil : BaseEntity
    {
        public long Conta { get; set; }

        public string Balanco { get; set; }
    }
}
