using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SuperFact.Entity.Model
{
    [Table("T_DATO_ADICIONAL", Schema = "SuperFact")]
    public class DatoAdicionalModel : EntidadBaseModel
    {
        public int IdCabeceraDocumento { get; set; }

        [ForeignKey(nameof(IdCabeceraDocumento))]
        public CabeceraDocumentoModel CabeceraDocumento { get; set; }

        public int IdTipoDatoAdicional { get; set; }

        [ForeignKey(nameof(IdTipoDatoAdicional))]
        public TipoDatoAdicionalModel TipoDatoAdicional { get; set; }

        [Required]
        [MaxLength(250)]
        public string Contenido { get; set; }
    }
}