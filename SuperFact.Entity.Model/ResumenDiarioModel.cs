using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SuperFact.Entity.Model
{
    [Table("T_RESUMEN_DIARIO", Schema = "SuperFact")]
    public class ResumenDiarioModel : EntidadBaseModel
    {
        public DateTime FechaEmision { get; set; }
        public DateTime FechaReferencia { get; set; }
        public string IdResumen { get; set; }
        public int IdEmpresa { get; set; }
        [ForeignKey(nameof(IdEmpresa))]
        public EmpresaModel Empresa { get; set; }

    }
}
