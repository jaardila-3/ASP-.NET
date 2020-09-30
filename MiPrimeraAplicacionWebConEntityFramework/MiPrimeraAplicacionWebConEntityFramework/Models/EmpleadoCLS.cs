using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MiPrimeraAplicacionWebConEntityFramework.Models
{
    public class EmpleadoCLS
    {
        [Display(Name ="ID Empleado")]        
        public int IDEmpleado { get; set; }

        [Display(Name = "Nombre Empleado")]
        [Required]
        [StringLength(100,ErrorMessage ="Longitud maxima 100")]
        public string Nombre { get; set; }

        [Display(Name = "Apellido Paterno")]
        [Required]
        [StringLength(200, ErrorMessage = "Longitud maxima 200")]
        public string APPaterno { get; set; }

        [Display(Name = "Apellido Materno")]
        [Required]
        [StringLength(200, ErrorMessage = "Longitud maxima 200")]
        public string APMaterno { get; set; }

        [Display(Name = "Fecha de Contrato")]
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString ="{0:YYYY-MM-DD}",ApplyFormatInEditMode =true)]
        public DateTime FechaContrato { get; set; }

        [Display(Name = "Sueldo")]
        [Required]
        [Range(0,10000000,ErrorMessage ="Fuera de rango")]
        public decimal Sueldo { get; set; }

        [Display(Name = "Tipo Usuario")]
        [Required]
        public int IDTipoUsuario { get; set; }

        [Display(Name = "Tipo Contrato")]
        [Required]
        public int IDTipoContrato { get; set; }

        [Display(Name = "Sexo")]
        [Required]
        public int IDSexo { get; set; }

        public int BHabilitado { get; set; }

        //propiedades adicionales para hacer join en bd
        [Display(Name = "Tipo Contrato")]
        public string NombreTipoContrato { get; set; }

        [Display(Name = "Tipo Usuario")]
        public string NombreTipoUsuario { get; set; }
    }   
}