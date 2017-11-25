using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SuperFact.Entity.Model
{
    [Table("T_CERTIFICADO_DIGITAL", Schema = "SuperFact")]
    public class CertificadoDigitalModel : EntidadBaseModel
    {
        public int IdEmpresa { get; set; }
        [ForeignKey(nameof(IdEmpresa))]
        public EmpresaModel Empresa { get; set; }
        public string CertificadoDigital { get; set; }

        public string ClaveCertificado { get; set; }
        public bool IsUsado { get; set; }
    }
}
