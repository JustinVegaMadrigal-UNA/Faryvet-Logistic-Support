using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FaryvetLogisticSupport.Models
{
    [Table("FLS_Factura", Schema="FARYVET")]

    public class FARYVET_FLS_Factura
    {
        [Key]
        [Required]
        [Display(Name = "Identificador")]
        public String Id { get; set; }

        [Required]
        [Display(Name = "Forma de despacho")]
        public String FormaDespacho { get; set; }

        [Required]
        [Display(Name = "Peso")]
        public float Peso { get; set; }

        [Required]
        [Display(Name = "Forma de cobro")]
        public String FormaCobro { get; set; }

        [Required]
        [Display(Name = "Moneda")]
        public String Moneda { get; set; }

        [ForeignKey("CLIENTEPK")]
        [Required]
        [Display(Name = "Cliente")]
        public String Cliente { get; set; }

        [Required]
        [Display(Name = "Comentarios")]
        public String Comentarios { get; set; }

        [Required]
        [Display(Name = "Provincia")]
        public String Provincia { get; set; }

        [Required]
        [Display(Name = "Canton")]
        public String Canton { get; set; }

        [Required]
        [Display(Name = "Distrito")]
        public String Distrito { get; set; }
    }
}
