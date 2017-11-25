using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SuperFact.Entity.Model
{
    [Table("T_TIPO_DISCREPANCIA", Schema = "SuperFact")]
    public class TipoDiscrepanciaModel : TipoValorBaseModel
    {
        public int IdTipoDocumento { get; set; }

        [ForeignKey(nameof(IdTipoDocumento))]
        public TipoDocumentoModel TipoDocumento { get; set; }
    }
}
