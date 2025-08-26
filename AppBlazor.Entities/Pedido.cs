using System.ComponentModel.DataAnnotations;

namespace AppBlazor.Entities
{
    public class Pedido
    {
        [Required(ErrorMessage = "El ID es requerido")]
        [Range(1, int.MaxValue, ErrorMessage = "El valor debe ser un número positivo")]
        public int idPedido { get; set; }

        [Required(ErrorMessage = "El nombre del cliente es requerido")]
        [StringLength(100, ErrorMessage = "El nombre del cliente no puede exceder 100 caracteres")]
        public string cliente { get; set; } = null!;

        [Required(ErrorMessage = "La fecha es requerida")]
        public DateTime fecha { get; set; }

        [Required(ErrorMessage = "El estado es requerido")]
        [StringLength(50, ErrorMessage = "El estado no puede exceder 50 caracteres")]
        public string estado { get; set; } = null!;

        [Required(ErrorMessage = "El total es requerido")]
        [Range(0, int.MaxValue, ErrorMessage = "El total debe ser mayor que 0")]
        public int total { get; set; }
    }
}
