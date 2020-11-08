using MiPrimeraAplicacionWebConEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MiPrimeraAplicacionWebConEntityFramework.Controllers
{
    public class MarcaController : Controller
    {
        // GET: Marca
        public ActionResult Index()
        {
            List<MarcaCLS> listaMarcas = null;
            using (var bd = new BDPasajeEntities())
            {
                listaMarcas = (from item in bd.Marca
                               where item.BHABILITADO==1
                                              select new MarcaCLS
                                              {
                                                  IIDMarca = item.IIDMARCA,
                                                  Nombre = item.NOMBRE,
                                                  Descripcion= item.DESCRIPCION
                                              }).ToList();
                
            }
            return View(listaMarcas);
        }

        public ActionResult Agregar() //nos crea la vista
        {
            return View();
        }
        
        [HttpPost]
        public ActionResult Agregar(MarcaCLS omarcaCLS) //nos ingresa los datos via post
        {
            if (ModelState.IsValid)
            {
                using (var bd = new BDPasajeEntities())
                {
                    Marca omarca = new Marca(); //clase de entity framework
                    omarca.NOMBRE = omarcaCLS.Nombre;
                    omarca.DESCRIPCION = omarcaCLS.Descripcion;
                    omarca.BHABILITADO = 1;
                    bd.Marca.Add(omarca);
                    bd.SaveChanges();
                }
            }
            else
            {
                return View(omarcaCLS);
            }
            return RedirectToAction("Index");
        }


        public ActionResult Editar(int id) // este id lo creamos en la vista index
        {
            MarcaCLS omarcaCLS = new MarcaCLS();
            using(var bd=new BDPasajeEntities())
            {
                //validamos IDMarca con id
                Marca omarca = bd.Marca.Where(p => p.IIDMARCA.Equals(id)).First();//where devuelve varias filas y first devuelve la primera
                omarcaCLS.IIDMarca = omarca.IIDMARCA;
                omarcaCLS.Nombre = omarca.NOMBRE;
                omarcaCLS.Descripcion = omarca.DESCRIPCION;
            }
            return View(omarcaCLS);
        }
    }
}