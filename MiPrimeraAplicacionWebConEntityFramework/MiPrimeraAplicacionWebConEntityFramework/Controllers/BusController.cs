using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MiPrimeraAplicacionWebConEntityFramework.Models;

namespace MiPrimeraAplicacionWebConEntityFramework.Controllers
{
    public class BusController : Controller
    {
        // GET: Bus
        public ActionResult Index()
        {
            List<BusCLS> listaBuses = null;
            using(var bd=new BDPasajeEntities())
            {
                listaBuses = (from obus in bd.Bus
                              join osucursal in bd.Sucursal
                              on obus.IIDSUCURSAL equals osucursal.IIDSUCURSAL
                              join otipoBus in bd.TipoBus
                              on obus.IIDTIPOBUS equals otipoBus.IIDTIPOBUS
                              join otipoModelo in bd.Modelo
                              on obus.IIDMODELO equals otipoModelo.IIDMODELO
                              where obus.BHABILITADO==1
                              select new BusCLS
                              {
                                  IDBus = obus.IIDBUS,
                                  Placa = obus.PLACA,
                                  NombreModelo = otipoModelo.NOMBRE,
                                  NombreSucursal = osucursal.NOMBRE,
                                  NombreTipoBus = otipoBus.NOMBRE
                              }).ToList();
            }

            return View(listaBuses);
        }
    }
}