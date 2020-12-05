using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GestionDeInventarioInformatico;

namespace GestionDeInventarioInformatico.Controllers
{
    public class HomeController : Controller
    {
        private gestionDBEntities db = new gestionDBEntities();

        public ActionResult Index(string buscarEquipo, string buscarPeriferico)
        {
            Session["equipos"] = buscarEquipos(buscarEquipo);
            Session["busquedaEquipo"] = buscarEquipo;
            Session["busquedaPeriferico"] = buscarPeriferico;
            Session["perifericos"] = buscarPerifericos(buscarPeriferico);
            return View();
        }
        public ActionResult proveedores()
        {
            ViewData["proveedores"] = db.proveedores.ToList();
            return View();
        }

        public ActionResult reportes()
        {
           
            return View();
        }
        public List<equipos> buscarEquipos(string texto)
        {
            return db.equipos.Where(e => e.nombre.Contains(texto) || texto == null).ToList();
        }
        public List<perifericos> buscarPerifericos(string texto)
        {
            return db.perifericos.Where(e => e.nombre.Contains(texto) || texto == null).ToList();
        }
    }
}