using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;


namespace FaryvetLogisticSupport.Models
{
    public class FARYVET_FLS_VehiculoTransporte
    {
        [Key]
        [Required]
        [Display(Name = "Número de placa")]
        public String NumeroPlaca { get; set; }

        [Required]
        public String Marca { get; set; }

        [Required]
        public String Modelo { get; set; }

        [Required]
        [Display(Name = "Año de fabricion")]
        public int AnnioFabricacion { get; set; }

        [Required]
        [Display(Name = "Capacidad de carga")]
        public float CapacidadCarga { get; set; }

        [Required]
        [Display(Name = "Capacidad de combustible")]
        public float CapacidadCombustible { get; set; }

        [Required]
        [Display(Name = "Fecha de RITEVE")]
        public String FechaRiteve { get; set; }

        [Required]
        [Display(Name = "Costo del marchamo")]
        public float CostoMarchamo { get; set; }

        [Required]
        [Display(Name = "CVO de Senasa")]
        public bool CVOSenasa { get; set; }

        [Required]
        public String Estado { get; set; }

        [Required]
        [Display(Name = "¿Está realizando una entrega?")]
        public bool IsEntrega { get; set; }

        [Display(Name = "Comentarios")]
        public String Comentario { get; set; }

        [Required]
        [Display(Name = "Licencia requerida")]
        public String LicenciaRequerida { get; set; }
    }
}
