using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SuperFact.Entity.Model
{
    [Table("T_DOCUMENTO_ANTECIPO", Schema = "SuperFact")]
    public class DocumentoAnticipoModel : EntidadBaseModel
    {
        [Required]
        public string NroDocAnticipo { get; set; }

        public int IdTipoDocumento { get; set; }

        [ForeignKey(nameof(IdTipoDocumento))]
        public TipoDocumentoModel TipoDocumento { get; set; }

        public int IdMoneda { get; set; }

        [ForeignKey(nameof(IdMoneda))]
        public MonedaModel Moneda { get; set; }

        public decimal MontoAnticipo { get; set; }
    }
}