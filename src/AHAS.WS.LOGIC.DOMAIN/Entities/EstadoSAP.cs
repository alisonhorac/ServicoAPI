
namespace AHAS.WS.LOGIC.DOMAIN.Entities
{
    public class EstadoSAP : BaseEntity
    {
        public long CodigoSAP { get; set; }

        public string Sigla { get; set; }

        public string Estado { get; set; }
    }
}
