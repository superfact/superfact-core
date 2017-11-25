using System.ComponentModel.DataAnnotations.Schema;

namespace SuperFact.Entity.Model
{
    [Table("T_DOCUMENTO_DETALLE", Schema = "SuperFact")]
    public class DocumentoDetalleModel : EntidadBaseModel
    {
        public int IdCabeceraDocumento { get; set; }

        public virtual CabeceraDocumentoModel Cabecera { get; set; }

        public decimal Cantidad { get; set; }

        public int IdUnidadMedida { get; set; }

        public UnidadMedidaModel UnidadMedida { get; set; }

        public string CodigoItem { get; set; }

        public string Descripcion { get; set; }

        public decimal PrecioUnitario { get; set; }

        public int IdTipoPrecio { get; set; }

        public TipoPrecioModel TipoPrecio { get; set; }

        public decimal Impuesto { get; set; }

        public decimal ImpuestoSelectivo { get; set; }

        public decimal OtroImpuesto { get; set; }

        public decimal Descuento { get; set; }

        public decimal TotalVenta { get; set; }
    }
}