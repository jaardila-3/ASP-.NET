using MiPrimeraAplicacionWebConEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiPrimeraAplicacionWebConEntityFramework.Controllers
{
    public class EmpleadoController : Controller
    {
        // GET: Empleado
        public ActionResult Index()
        {
            List<EmpleadoCLS> listaEmpleados = null;
            using (var bd= new BDPasajeEntities())
            {
                listaEmpleados = (from oempleado in bd.Empleado
                                  join otipousuario in bd.TipoUsuario
                                  on oempleado.IIDTIPOUSUARIO equals otipousuario.IIDTIPOUSUARIO
                                  join otipocontrato in bd.TipoContrato
                                  on oempleado.IIDTIPOCONTRATO equals otipocontrato.IIDTIPOCONTRATO
                                  where oempleado.BHABILITADO==1
                                  select new EmpleadoCLS
                                  {
                                      IDEmpleado = oempleado.IIDEMPLEADO,
                                      Nombre= oempleado.NOMBRE,
                                      APPaterno=oempleado.APPATERNO,
                                      APMaterno=oempleado.APMATERNO,
                                      NombreTipoUsuario=otipousuario.NOMBRE,
                                      NombreTipoContrato=otipocontrato.NOMBRE
                                  }).ToList();
            }
            return View(listaEmpleados);
        }
    }
}