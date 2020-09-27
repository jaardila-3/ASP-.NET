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
                                   where item.BHABILITADO == 1
                                   select new SucursalCLS
                                   {
                                       IDSucursal = item.IIDSUCURSAL,
                                       Nombre = item.NOMBRE,
                                       Direccion = item.DIRECCION,
                                       Telefono = item.TELEFONO,
                                       Email = item.EMAIL,
                                       FechaApertura = item.FECHAAPERTURA.Value//se debe colocar value y el valor no puede ser nulo en la bd
                                   }).ToList();
            }
            return View(listaSucursales);
        }

        public ActionResult Agregar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Agregar(SucursalCLS osucursalCLS) //nos ingresa los datos via post
        {
            if (ModelState.IsValid)
            {
                using (var bd = new BDPasajeEntities())
                {
                    Sucursal osucursal = new Sucursal(); //clase de entity framework
                    osucursal.NOMBRE = osucursalCLS.Nombre;
                    osucursal.DIRECCION = osucursalCLS.Direccion;
                    osucursal.TELEFONO = osucursalCLS.Telefono;
                    osucursal.EMAIL = osucursalCLS.Email;
                    osucursal.FECHAAPERTURA = osucursalCLS.FechaApertura;
                    osucursal.BHABILITADO = 1;
                    bd.Sucursal.Add(osucursal);
                    bd.SaveChanges();
                }
            }
            else
            {
                return View(osucursalCLS);//para que la informacion se mantenga y no se borre
            }
            return RedirectToAction("Index");
        }
    }
}