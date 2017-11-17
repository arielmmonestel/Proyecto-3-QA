using Proyecto_3.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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

        public static bool EmailEsValido(string emailaddress)
        {
            if (emailaddress != null)
            {
                try
                {
                    var emailAddress = new EmailAddressAttribute();
                    return emailAddress.IsValid(emailaddress);

                }

                catch (FormatException)
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        public static Boolean ValidarReporte(ErrorReport reporte)
        {
            Boolean reporteValido = true;
            try
            {
                if (reporte.SaleID == null || reporte.ProductName == null || reporte.ErrorDate == null || reporte.ContactMail == null || reporte.ErrorDescription == null)
                {
                    reporteValido = false;
                    reporte.errorMessage = "Debe llenar todos los campos";
                }
                else if (!EmailEsValido(reporte.ContactMail))
                {
                    reporteValido = false;
                    reporte.errorMessage = "El correo no es valido";
                }
            }
            catch (Exception)
            {

                reporte.errorMessage = "Debe llenar todos campos";
            }
            return reporteValido;
        }

        public Boolean RegistrarDB(ErrorReport reporte)
        {
            if(ValidarReporte(reporte) == true)
            {
                return ErroresDB.InsertarReporte(reporte);
            }
            else
            {
                return false;
            }
        }
    }

    public class ReporteDeErroresController : Controller
    {
        
        // GET: ReporteDeErrores
        public ActionResult Index()
        {
            //Session["userID"] = 14;
            ViewBag.listaVentas = VentasdeUsuario(Convert.ToInt32(Session["UserID"]));
            return PartialView();
        }

        public ActionResult TabladeErrores()
        {
           // Session["userID"] = 14;
            ViewBag.listadeErrores = ReportesdeUsuario(Convert.ToInt32(Session["UserID"]));
            return View();
        }
        [HttpPost]
        public ActionResult RegistrarError(ErrorReport reporte)
        {
            InsertarReporte reporteDB = new InsertarReporte();
            reporteDB.RegistrarDB(reporte);
            return RedirectToAction("TabladeErrores");
        }

        public List<Sale> VentasdeUsuario(int usuarioID)
        {
            TEC_QA_CRMEntities db = new TEC_QA_CRMEntities();
            return db.Sales.Where(x => x.ClientID == usuarioID).ToList();
        }

        public List<ErrorReport> ReportesdeUsuario(int usuarioID)
        {
            TEC_QA_CRMEntities db = new TEC_QA_CRMEntities();
            return db.ErrorReports.Where(x => x.UserID == usuarioID).ToList();
        }
        
    }
}