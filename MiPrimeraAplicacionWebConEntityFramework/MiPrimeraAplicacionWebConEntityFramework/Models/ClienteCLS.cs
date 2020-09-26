using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MiPrimeraAplicacionWebConEntityFramework.Models
{
    public class ClienteCLS
    {
        public int IDCliente { get; set; }
        public string Nombre { get; set; }
        public string APPaterno { get; set; }
        public string APMaterno { get; set; }
        public string Direccion { get; set; }
        public int BHabilitado { get; set; }
    }
}