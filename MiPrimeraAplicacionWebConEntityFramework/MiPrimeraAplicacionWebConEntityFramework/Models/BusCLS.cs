using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MiPrimeraAplicacionWebConEntityFramework.Models
{
    public class BusCLS
    {
        [Display(Name ="ID Bus")]
        public int IDBus { get; set; }

        [Display(Name = "Nombre Sucursal")]
        [Required]
        public int IDSucursal { get; set; }

        [Display(Name = "Tipo Bus")]
        [Required]
        public int IDTipoBus { get; set; }

        [Display(Name = "Placa")]
        [Required]
        [StringLength(100, ErrorMessage = "Longitud maxima 100")]
        public string Placa { get; set; }

        [Display(Name = "Fecha Compra")]
        [Required]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:YYYY-MM-DD}", ApplyFormatInEditMode = true)]
        public DateTime FechaCompra { get; set; }

        [Display(Name = "Nombre Modelo")]
        [Required]
        public int IDModelo { get; set; }

        [Display(Name = "Numero Filas")]
        [Required]
        public int NumeroFilas { get; set; }

        [Display(Name = "Numero Columnas")]
        [Required]
        public int NumeroColumnas { get; set; }

        [Display(Name = "Descripcion")]
        [Required]
        [StringLength(200, ErrorMessage = "Longitud maxima 200")]
        public string Descripcion { get; set; }

        public int BHabilitado { get; set; }

        [Display(Name = "Observacion")]
        [StringLength(200,ErrorMessage ="Longitud maxima 200")]
        public string Observacion { get; set; }

        [Display(Name = "Nombre Marca")]
        [Required]
        public int IDMarca { get; set; }

        //propiedades adicionales para el join
        [Display(Name = "Nombre Sucursal")]
        public string NombreSucursal { get; set; }

        [Display(Name = "Nombre Tipo Bus")]
        public string NombreTipoBus { get; set; }

        [Display(Name = "Nombre Modelo")]
        public string NombreModelo { get; set; }
    }
}