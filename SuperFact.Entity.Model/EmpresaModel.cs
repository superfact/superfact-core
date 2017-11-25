using System.ComponentModel.DataAnnotations.Schema;

namespace SuperFact.Entity.Model
{
    [Table("T_ORGANIZACION", Schema = "SuperFact")]
    public class EmpresaModel : IEntity
    {
        public int Id { get; set; }

        public string NroDocumento { get; set; }

        public int IdTipoDocumento { get; set; }

        [ForeignKey(nameof(IdTipoDocumento))]
        public TipoDocumentoEmpresaModel TipoDocumento { get; set; }

        public string NombreLegal { get; set; }

        public string AliasEmpresa { get; set; }

        public string NombreComercial { get; set; }

        public string Direccion { get; set; }

        public string Urbanizacion { get; set; }

        public string CorreoElectronico { get; set; }

        public int IdUbigeo { get; set; }

        [ForeignKey(nameof(IdUbigeo))]
        public UbigeoModel Ubigeo { get; set; }
    }
}