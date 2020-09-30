using MiPrimeraAplicacionWebConEntityFramework.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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


        public ActionResult Agregar()
        {
            ListarCombox();
            return View();
        }


        [HttpPost]
        public ActionResult Agregar(EmpleadoCLS oempleadoCLS)
        {
            if (!ModelState.IsValid)
            {
                ListarCombox();
                return View(oempleadoCLS);
            }
            else
            {
                using (var bd=new BDPasajeEntities())
                {
                    Empleado oempleado = new Empleado();
                    oempleado.NOMBRE = oempleadoCLS.Nombre;
                    oempleado.APPATERNO = oempleadoCLS.APPaterno;
                    oempleado.APMATERNO = oempleadoCLS.APMaterno;
                    oempleado.FECHACONTRATO = oempleadoCLS.FechaContrato;
                    oempleado.SUELDO = oempleadoCLS.Sueldo;
                    oempleado.IIDTIPOUSUARIO = oempleadoCLS.IDTipoUsuario;
                    oempleado.IIDTIPOCONTRATO = oempleadoCLS.IDTipoContrato;
                    oempleado.IIDSEXO = oempleadoCLS.IDSexo;
                    oempleado.BHABILITADO = 1;

                    bd.Empleado.Add(oempleado);
                    bd.SaveChanges();
                }
            }
            
            return RedirectToAction("Index");
        }


        public void ListarComboSexo()
        {
            //agregar
            List<SelectListItem> lista;
            using (var bd= new BDPasajeEntities())
            {
                lista = (from item in bd.Sexo
                         where item.BHABILITADO == 1
                         select new SelectListItem
                         {
                             Text=item.NOMBRE,
                             Value=item.IIDSEXO.ToString()
                         }).ToList();
                lista.Insert(0, new SelectListItem { Text = "--Seleccione--", Value = "" });
                ViewBag.listaSexo = lista;
            }
        }


        public void ListarTipoContrato()
        {
            //agregar
            List<SelectListItem> lista;
            using (var bd = new BDPasajeEntities())
            {
                lista = (from item in bd.TipoContrato
                         where item.BHABILITADO == 1
                         select new SelectListItem
                         {
                             Text = item.NOMBRE,
                             Value = item.IIDTIPOCONTRATO.ToString()
                         }).ToList();
                lista.Insert(0, new SelectListItem { Text = "--Seleccione--", Value = "" });
                ViewBag.listaTipoContrato = lista;
            }
        }


        public void ListarTipoUsuario()
        {
            //agregar
            List<SelectListItem> lista;
            using (var bd = new BDPasajeEntities())
            {
                lista = (from item in bd.TipoUsuario
                         where item.BHABILITADO == 1
                         select new SelectListItem
                         {
                             Text = item.NOMBRE,
                             Value = item.IIDTIPOUSUARIO.ToString()
                         }).ToList();
                lista.Insert(0, new SelectListItem { Text = "--Seleccione--", Value = "" });
                ViewBag.listaTipoUsuario = lista;
            }                       
        }

        public void ListarCombox()
        {
            ListarComboSexo();
            ListarTipoContrato();
            ListarTipoUsuario();
        }
    }
}