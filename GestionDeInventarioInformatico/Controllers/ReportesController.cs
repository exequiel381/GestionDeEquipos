using iTextSharp.text;
using iTextSharp.text.html.simpleparser;
using iTextSharp.text.pdf;
using Rotativa;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using System.Net;
using GestionDeInventarioInformatico;

namespace GestionDeInventarioInformatico.Controllers
{
    public class ReportesController : Controller
    {
        // GET: Reportes
        private gestionDBEntities db = new gestionDBEntities();
        public ActionResult equiposPorDepartamento()
        {
            var Departamentos = db.departamentos;
            var equipos = db.equipos.Include(e => e.departamentos).Include(e => e.unidadAlmacenamiento).Include(e => e.marcas)
                                  .Include(e => e.proveedores).Include(e => e.ramtipo).Include(e => e.tipoEquipos).Include(e => e.unidadAlmacenamiento1);

            ViewData["equipos"] = equipos.ToList();
            ViewData["departamentos"] = Departamentos.ToList();
            return View();
        }

        public ActionResult DescargarEquiposPorDepartamento()
        {
            return new ActionAsPdf("equiposPorDepartamento");
        }
    }
}