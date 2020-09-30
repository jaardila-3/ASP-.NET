using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MiPrimeraAplicacionWebConEntityFramework.Models;

namespace MiPrimeraAplicacionWebConEntityFramework.Controllers
{
    public class ViajeController : Controller
    {
        // GET: Viaje
        public ActionResult Index()
        {
            List<ViajeCLS> listaViajes = null;
            using (var bd=new BDPasajeEntities())
            {
                listaViajes = (from oviaje in bd.Viaje
                               join olugarorigen in bd.Lugar
                             on oviaje.IIDLUGARORIGEN equals olugarorigen.IIDLUGAR
                             join olugardestino in bd.Lugar
                             on oviaje.IIDLUGARDESTINO equals olugardestino.IIDLUGAR
                             join obus in bd.Bus
                             on oviaje.IIDBUS equals obus.IIDBUS
                               select new ViajeCLS
                               { 
                                   IDViaje=oviaje.IIDVIAJE,
                                   NombreBus=obus.PLACA,
                                   NombreLugarOrigen=olugarorigen.NOMBRE,
                                   NombreLugarDestino=olugardestino.NOMBRE
                               }).ToList();
            }
            return View(listaViajes);
        }
    }
}