using System.ComponentModel.DataAnnotations.Schema;

namespace SuperFact.Entity.Model
{
    [Table("T_GUIA_TRANSPORTISTA", Schema = "SuperFact")]
    public class GuiaTransportistaModel : EntidadBaseModel
    {
        public int IdModoTransporte { get; set; }

        public ModalidadTransporteModel ModalidadTransporte { get; set; }

        public int IdTipoDocTransportista { get; set; }

        public TipoDocumentoEmpresaModel TipoDocTransportista { get; set; }

        public int IdUnidadMedida { get; set; }

        public UnidadMedidaModel UnidadMedida { get; set; }

        public string CodigoAutorizacion { get; set; }

        public string MarcaVehiculo { get; set; }

        public string NombreTransportista { get; set; }

        public string NroLicencia { get; set; }

        public string RucTransportista { get; set; }

        public decimal PesoBruto { get; set; }
    }
}