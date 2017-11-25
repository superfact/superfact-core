using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SuperFact.Entity.Model
{
    [Table("T_PARAMETRO_ORGANIZACION", Schema = "SuperFact")]
    public class ParametroEmpresaModel : EntidadBaseModel
    {
        public int IdEmpresa { get; set; }
        [ForeignKey(nameof(IdEmpresa))]
        public EmpresaModel Empresa { get; set; }

        public decimal TasaIgv { get; set; }

        public decimal TasaIsc { get; set; }

        public decimal TasaDetraccion { get; set; }      

        public string UsuarioSol { get; set; }

        public string ClaveSol { get; set; }
    }
}
