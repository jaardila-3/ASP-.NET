using MiPrimeraAplicacionWebConEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiPrimeraAplicacionWebConEntityFramework.Controllers
{
    public class SucursalController : Controller
    {
        // GET: Sucursal
        public ActionResult Index()
        {
            List<SucursalCLS> listaSucursales = null;
            using(var bd=new BDPasajeEntities())
            {
                listaSucursales = (from item in bd.Sucursal
                                   where item.BHABILITADO==1
                                  select new SucursalCLS
                                  {
                                      IDSucursal = item.IIDSUCURSAL,
                                      Nombre = item.NOMBRE,
                                      Telefono = item.TELEFONO,
                                      Email = item.EMAIL
                                  }).ToList();
            }
            return View(listaSucursales);
        }
    }
}