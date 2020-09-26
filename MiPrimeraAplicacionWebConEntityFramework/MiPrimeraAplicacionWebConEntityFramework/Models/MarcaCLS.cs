using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MiPrimeraAplicacionWebConEntityFramework.Models
{
    public class MarcaCLS
    {
        [Display(Name = "ID Marca")] //tag notation
        public int IIDMarca { get; set; }

        [Display(Name = "Nombre Marca")]
        [Required]
        [StringLength(100,ErrorMessage ="La longitud maxima es 100")]
        public string Nombre { get; set; }

        [Display(Name = "Descripcion Marca")]
        [Required]
        [StringLength(200, ErrorMessage = "La longitud maxima es 200")]
        public string Descripcion { get; set; }

        public int BHabilitado { get; set; }
    }
}