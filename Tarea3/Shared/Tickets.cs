using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea3.Shared
{
    internal class Tickets
    {
        [Key]
        public int TicketsId { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public int ClientesId { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public int SistemaId { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public int PrioridadId { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public DateTime Fecha { get; set; } = DateTime.Now;
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string? SolicitadoPor { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string? Asunto { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string? Descripción { get; set; }
    }
}
