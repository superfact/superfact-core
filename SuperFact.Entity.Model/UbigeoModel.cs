using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SuperFact.Entity.Model
{
    [Table("T_UBIGEO", Schema = "SuperFact")]
    public class UbigeoModel : EntidadBaseModel
    {
        [Required]
        [MaxLength(6)]
        public string Codigo { get; set; }

        [Required]
        [MaxLength(250)]
        public string Descripcion { get; set; }

    }
}