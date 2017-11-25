using System.ComponentModel.DataAnnotations;

namespace SuperFact.Entity.Model
{
    public class TipoValorBaseModel : EntidadBaseModel
    {
        [Required]
        [StringLength(5)]
        public string Codigo { get; set; }
        [Required]
        [StringLength(250)]
        public string Descripcion { get; set; }

        public string DescripcionCompleta => $"{Codigo}: {Descripcion}";
    }
}