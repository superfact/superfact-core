using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SuperFact.Entity.Model
{
    [Table("T_ANEXO", Schema = "SuperFact")]
    public class AnexoModel : EntidadBaseModel
    {
        public DateTime FechaGeneracion { get; set; }

        public DateTime FechaRespuesta { get; set; }

        public string XmlFirmado { get; set; }

        public string RepresentacionImpresa { get; set; }

        public short EstadoEnvio { get; set; }

        public string CodigoEstado { get; set; }

        public string DescripcionEstado { get; set; }

        public string CdrSunat { get; set; }

    }
}
