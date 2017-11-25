using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SuperFact.Entity.Model
{
    [Table("T_ENDPOINT_SUNAT", Schema = "SuperFact")]
    public class DireccionSunatModel : TipoValorBaseModel
    {
        [Required]
        [StringLength(50)]
        public new string Codigo { get; set; }
    }
}
