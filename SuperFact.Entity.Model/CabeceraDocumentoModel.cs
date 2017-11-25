using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SuperFact.Entity.Model
{
    [Table("T_CABECERA_DOCUMENTO", Schema = "SuperFact")]
    public class CabeceraDocumentoModel : EntidadBaseModel
    {
        public int IdTipoDocumento { get; set; }
        [ForeignKey(nameof(IdTipoDocumento))]
        public TipoDocumentoModel TipoDocumento { get; set; }

        public int IdEmisor { get; set; }
        [ForeignKey(nameof(IdEmisor))]
        public EmpresaModel Emisor { get; set; }

        public int IdReceptor { get; set; }
        [ForeignKey(nameof(IdReceptor))]
        public EmpresaModel Receptor { get; set; }

        public int IdMoneda { get; set; }
        [ForeignKey(nameof(IdMoneda))]
        public MonedaModel Moneda { get; set; }

        public int IdTipoOperacion { get; set; }
        [ForeignKey(nameof(IdTipoOperacion))]
        public TipoOperacionModel TipoOperacion { get; set; }

        public int? IdDocumentoAnticipo { get; set; }
        [ForeignKey(nameof(IdDocumentoAnticipo))]
        public virtual DocumentoAnticipoModel DocumentoAnticipo { get; set; }

        public int? IdGuiaTransportista { get; set; }
        [ForeignKey(nameof(IdGuiaTransportista))]
        public virtual GuiaTransportistaModel GuiaTransportista { get; set; }

        public int? IdAnexo { get; set; }
        [ForeignKey(nameof(IdAnexo))]
        public virtual AnexoModel Anexo { get; set; }

        public string IdDocumento { get; set; }

        public decimal Gravadas { get; set; }

        public decimal Gratuitas { get; set; }

        public decimal Inafectas { get; set; }

        public decimal Exoneradas { get; set; }

        public decimal DescuentoGlobal { get; set; }

        public decimal TotalVenta { get; set; }

        public decimal TotalIgv { get; set; }

        public decimal TotalIsc { get; set; }

        public decimal TotalOtrosTributos { get; set; }

        public string MontoEnLetras { get; set; }

        public string PlacaVehiculo { get; set; }

        public decimal MontoPercepcion { get; set; }

        public decimal MontoDetraccion { get; set; }

        public string EstadoDocumento { get; set; }

        public ICollection<DocumentoDetalleModel> Detalles { get; set; }

        public ICollection<DatoAdicionalModel> DatoAdicionales { get; set; }

        public ICollection<DocumentoRelacionadoModel> DocumentoRelacionados { get; set; }

        public ICollection<DiscrepanciaDocumentoModel> Discrepancias { get; set; }

        public CabeceraDocumentoModel()
        {
            Detalles = new HashSet<DocumentoDetalleModel>();
            DatoAdicionales = new HashSet<DatoAdicionalModel>();
            DocumentoRelacionados = new HashSet<DocumentoRelacionadoModel>();
            Discrepancias = new HashSet<DiscrepanciaDocumentoModel>();
        }
    }
}
