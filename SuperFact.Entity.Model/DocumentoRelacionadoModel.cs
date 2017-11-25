using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SuperFact.Entity.Model
{
    [Table("T_DOCUMENTO_RELACIONADO", Schema = "SuperFact")]
    public class DocumentoRelacionadoModel : EntidadBaseModel
    {
        public int IdCabeceraDocumento { get; set; }

        [ForeignKey(nameof(IdCabeceraDocumento))]
        public CabeceraDocumentoModel CabeceraDocumento { get; set; }

        [Required]
        [MaxLength(15)]
        public string NroDocumento { get; set; }

        [Required]
        [MaxLength(2)]
        public string TipoDocumento { get; set; }
    }
}