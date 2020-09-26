using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiPrimeraAplicacionWebConEntityFramework.Models
{
    public class SucursalCLS
    {
        public int IDSucursal { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Email { get; set; }
        public DateTime FechaApertura { get; set; }
        public int BHabilitado { get; set; }
    }
}