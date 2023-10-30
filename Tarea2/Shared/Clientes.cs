using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2.Shared
{
    public class Clientes
    {
        [Key]
        public int ClienteID { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string? Nombres { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Phone(ErrorMessage = "Debe usar exclusivamente numeros y \"(,),-\" ")]
        public string? Telefono { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Phone(ErrorMessage = "Debe usar exclusivamente numeros y \"(,),-\" ")]
        public string? Celular { get; set; }
        [Required]
        [RegularExpression(@"^\d{9}$", ErrorMessage = "Debe ser un RNC valido")]
        public string? RNC {get;set;}
        [Required(ErrorMessage ="Este campo es obligatorio")]
        [EmailAddress(ErrorMessage = "Debe ser un correo valido")]
        public string? Email { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        public string? Dirección { get; set; }
    }
}
