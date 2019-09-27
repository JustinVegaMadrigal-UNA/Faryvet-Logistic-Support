using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FaryvetLogisticSupport.Models
{
    public class FARYVET_FLS_Conductor
    {
        [Key]
        [Display (Name = "Número de indentificación")]
        public String NumeroIdentificacion { get; set; }

        [Required]
        public String Nombre { get; set; }

        [Required]
        [Display(Name = "Primer apellido")]
        public String PrimerApellido { get; set; }

        [Required]
        [Display(Name = "Segundo apellido")]
        public String SegundoApellido { get; set; }

        [Required]
        [Display(Name = "Fecha de contratación")]
        public String FechaContratacion { get; set; }

        [Required]
        public String Estado { get; set; }

        [Required]
        [Display(Name = "¿Realizando entrega?")]
        public bool IsEntrega { get; set; }
    }
}
