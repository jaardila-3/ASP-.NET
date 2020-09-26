using MiPrimeraAplicacionWebConEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiPrimeraAplicacionWebConEntityFramework.Controllers
{
    public class ClienteController : Controller
    {
        // GET: Cliente
        public ActionResult Index()
        {
            List<ClienteCLS> listaClientes = null;
            using (var bd = new BDPasajeEntities())
            {
                listaClientes = (from item in bd.Cliente
                                   where item.BHABILITADO == 1
                                   select new ClienteCLS
                                   {
                                       IDCliente = item.IIDCLIENTE,
                                       Nombre = item.NOMBRE,
                                       APPaterno = item.APPATERNO,
                                       APMaterno = item.APMATERNO,
                                       Direccion = item.DIRECCION
                                   }).ToList();
            }
            return View(listaClientes);
        }
    }
}