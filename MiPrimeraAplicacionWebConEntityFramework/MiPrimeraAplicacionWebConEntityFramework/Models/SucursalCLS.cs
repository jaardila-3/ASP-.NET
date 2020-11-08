using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MiPrimeraAplicacionWebConEntityFramework.Models
{
    public class SucursalCLS
    {
        [Display(Name ="Id sucursal")]
        [Required]
        public int IDSucursal { get; set; }

        [Display(Name = "Nombre sucursal")]
        [StringLength(100, ErrorMessage ="Longitud maxima 100")]
        [Required]
        public string Nombre { get; set; }

        [Display(Name = "Direccion sucursal")]
        [StringLength(200, ErrorMessage = "Longitud maxima 200")]
        [Required]
        public string Direccion { get; set; }

        [Display(Name = "Telefono sucursal")]
        [StringLength(10, ErrorMessage = "Longitud maxima 10")]
        [Required]
        public string Telefono { get; set; }

        [Display(Name = "Email sucursal")]
        [StringLength(100, ErrorMessage = "Longitud maxima 100")]
        [EmailAddress(ErrorMessage ="Ingrese un email valido")]
        [Required]
        public string Email { get; set; }

        [Display(Name = "Fecha Apertura sucursal")]
        [Required]
        [DataType(DataType.Date)]//AYUDA EN LA VISTA
        [DisplayFormat(DataFormatString ="{0:YYYY-MM-DD}", ApplyFormatInEditMode =true)]//DA FORMATO
        public DateTime FechaApertura { get; set; }
        public int BHabilitado { get; set; }
    }
}