using Proyecto_3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto_3.Controllers
{
    public interface IReporteDeErrores
    {
        Boolean InsertarReporte(ErrorReport errorReport);
    }

    public class AgregarErrorDB : IReporteDeErrores
    {
        public Boolean InsertarReporte(ErrorReport errorReport)
        {
            try
            {
                TEC_QA_CRMEntities db = new TEC_QA_CRMEntities();
                var insert = db.ErrorReports.Add(errorReport);
                db.SaveChanges();
                if (insert != null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception ex)
            {
                return false;
            }
        }
    }

    public class InsertarReporte
    {
        IReporteDeErrores ErroresDB = new AgregarErrorDB();

        public InsertarReporte(IReporteDeErrores pReportes)
        {
            ErroresDB = pReportes;
        }

        public InsertarReporte()
        {

        }

        public Boolean RegistrarDB(ErrorReport reporte)
        {
            return ErroresDB.InsertarReporte(reporte);
        }
    }

    public class ReporteDeErroresController : Controller
    {
        
        // GET: ReporteDeErrores
        public ActionResult Index()
        {
            Session["UserID"] = 14;
             ViewBag.listaVentas = VentessdeUsuario((int)Session["UserID"]);
            return PartialView();
        }
        [HttpPost]
        public void RegistrarError(ErrorReport reporte)
        {
            InsertarReporte reporteDB = new InsertarReporte();
            reporteDB.RegistrarDB(reporte);
        }

        public List<Sale> VentessdeUsuario(int UsuarioID)
        {
            TEC_QA_CRMEntities db = new TEC_QA_CRMEntities();
            return db.Sales.Where(x => x.ClientID == UsuarioID).ToList();
        }
    }
}