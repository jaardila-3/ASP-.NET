using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MiPrimeraAplicacionWebConEntityFramework.Models
{
    public class ClienteCLS
    {
        [Display(Name ="Id Cliente")]
        public int IDCliente { get; set; }

        [Display(Name = "Nombre Cliente")]
        [StringLength(100,ErrorMessage ="Longitud maxima 100")]
        [Required]
        public string Nombre { get; set; }

        [Display(Name = "Apellido Paterno")]
        [StringLength(150, ErrorMessage = "Longitud maxima 150")]
        [Required]
        public string APPaterno { get; set; }

        [Display(Name = "Apellido Materno")]
        [StringLength(150, ErrorMessage = "Longitud maxima 150")]
        [Required]
        public string APMaterno { get; set; }

        [Display(Name = "Direccion Cliente")]
        [StringLength(200, ErrorMessage = "Longitud maxima 200")]
        [Required]
        public string Direccion { get; set; }

        [Display(Name = "Sexo Cliente")]
        [Required]
        public int IDSexo { get; set; }

        public int BHabilitado { get; set; }
    }
}