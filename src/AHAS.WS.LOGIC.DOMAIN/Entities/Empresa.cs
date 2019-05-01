
namespace AHAS.WS.LOGIC.DOMAIN.Entities
{
    public class Empresa : BaseEntity
    {
        public string CNPJ { get; set; }

        public string IE { get; set; }

        public string Unidade { get; set; }

        public string UF { get; set; }

        public string Codigo { get; set; }

        public string LocalNegocio { get; set; }

        public string Centro { get; set; }

        public string Sigla { get; set; }
    }
}
