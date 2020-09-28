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
                                       Direccion = item.DIRECCION,
                                       IDSexo = item.IIDSEXO.Value //agregar value
                                   }).ToList();
            }
            return View(listaClientes);
        }

        //creamos el combobox para sexo con una lista
        List<SelectListItem> listaSexo;
        private void LlenarSexo()
        {
            using (var bd=new BDPasajeEntities())
            {
                listaSexo = (from item in bd.Sexo
                             where item.BHABILITADO == 1
                             select new SelectListItem // las listas SelectListItem tienen dos propiedades que son
                             {
                                 Text = item.NOMBRE,//Text que es lo que el usuario va a escoger
                                 Value = item.IIDSEXO.ToString()//Value que es su valor interno o asignado
                             }).ToList();
                //para agregar "seleccione" en la primera posicion=0 de la lista se hace lo sgte:
                listaSexo.Insert(0, new SelectListItem { Text = "--Seleccione--", Value = "" });
            }
        }

        public ActionResult Agregar()
        {
            LlenarSexo();
            //con ViewBag puedes pasar info a la vista, despues de ViewBag puedes agregar lo que quiera, en este caso lista
            ViewBag.lista = listaSexo;//permite pasar la lista a la vista
            return View();
        }
    }
}