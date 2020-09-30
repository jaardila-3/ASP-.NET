using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MiPrimeraAplicacionWebConEntityFramework.Models
{
    public class ViajeCLS
    {
        [Display(Name ="ID Viaje")]
        public int IDViaje { get; set; }

        [Display(Name = "Lugar Origen")]
        [Required]
        public int IDLugarOrigen { get; set; }

        [Display(Name = "Lugar Destino")]
        [Required]
        public int IDLugarDestino { get; set; }

        [Display(Name = "Precio")]
        [Required]
        public double Precio { get; set; }

        [Display(Name = "Fecha Viaje")]
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:YYYY-MM-DD}", ApplyFormatInEditMode = true)]
        public DateTime FechaViaje { get; set; }

        [Display(Name = "Bus")]
        [Required]
        public int IDBus { get; set; }

        [Display(Name = "Numero Asientos Disponibles")]
        [Required]
        public int NumeroAsientosDisponibles { get; set; }

        //propieades adicionales
        [Display(Name = "Lugar Origen")]
        public string NombreLugarOrigen { get; set; }

        [Display(Name = "Lugar Destino")]
        public string NombreLugarDestino { get; set; }

        [Display(Name = "Nombre Bus")]
        public string NombreBus { get; set; }

    }
}