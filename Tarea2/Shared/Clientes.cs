using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea2.Shared
{
    internal class Clientes
    {
        [Key]
        int ClienteID { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        string? Nombres { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Phone(ErrorMessage = "Debe usar exclusivamente numeros y \"(,),-\" ")]
        string? Telefono { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [Phone(ErrorMessage = "Debe usar exclusivamente numeros y \"(,),-\" ")]
        string? Celular { get; set; }
        [Required]
        [RegularExpression(@"^\d{9}$", ErrorMessage = "Debe ser un RNC valido")]
        string? RNC {get;set;}
        [Required(ErrorMessage ="Este campo es obligatorio")]
        [EmailAddress(ErrorMessage = "Debe ser un correo valido")]
        string? Email { get; set; }
        [Required(ErrorMessage = "Este campo es obligatorio")]

        string? Dirección { get; set; }
    }
}
