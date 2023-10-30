using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tarea1.Shared
{
    public class Prioridades
    {
        [Key]
        public int PrioridadID { get; set; }
        [Required(ErrorMessage ="Este campo es obligatorio")]
        public string? Descripción { get; set; }
        [Required(ErrorMessage ="Este campo es obligatorio")]
        [Range(1,int.MaxValue, ErrorMessage ="La cantidad de dias de compromiso debe ser mayor de 1")]
        [RegularExpression(@"^\d$")]
        public int DíasCompromiso { get; set; }

    }
}
