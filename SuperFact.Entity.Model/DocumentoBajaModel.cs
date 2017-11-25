using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SuperFact.Entity.Model
{
    [Table("T_DOCUMENTO_BAJA", Schema = "SuperFact")]
    public class DocumentoBajaModel : EntidadBaseModel
    {
        public DateTime FechaEmision { get; set; }
        public DateTime FechaReferencia { get; set; }
        public string IdBaja { get; set; }
        public int IdEmpresa { get; set; }
        [ForeignKey(nameof(IdEmpresa))]
        public EmpresaModel Empresa { get; set; }
    }
    [Table("T_DOCUMENTO_DETALLE_BAJA", Schema = "SuperFact")]
    public class DocumentoDetalleBajaModel : EntidadBaseModel
    {
        public int IdDocumentoBaja { get; set; }
        public int CorrelativoInicio { get; set; }
        public int CorrelativoFin { get; set; }

    }
}
