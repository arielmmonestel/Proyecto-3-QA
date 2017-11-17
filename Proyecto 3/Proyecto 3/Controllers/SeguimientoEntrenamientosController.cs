using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proyecto_3.Models;

namespace Proyecto_3.Controllers
{
    public class SeguimientoEntrenamientosController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            SeguimientoAEntrenamientos entrenamientos = new SeguimientoAEntrenamientos();
            ViewBag.misEntrenamientos = entrenamientos.getTrainings(Convert.ToInt32(Session["UserID"]));
            ViewBag.misProdRelacionados = entrenamientos.getRelationatedProducts(Convert.ToInt32(Session["UserID"]));
            return PartialView();
        }



    }

    public class SeguimientoAEntrenamientos
    {
        ISeguimientoAEntrenamientos DB = new SeguimientoEntrenamientosDB();


       public SeguimientoAEntrenamientos( ISeguimientoAEntrenamientos pDB)
        {
            DB = pDB;
        }
       public SeguimientoAEntrenamientos()
        {
        }
        public List<getTrainings_Result> getTrainings(int pUserID)
        {
            return DB.getMisEntrenamientos(pUserID);
        }
        public List<getRelationatedProducts_Result> getRelationatedProducts(int pUserID)
        {
            return DB.getRelationatedProducts(pUserID);
        }
    }

    public interface ISeguimientoAEntrenamientos
    {
        List<getTrainings_Result> getMisEntrenamientos(int pUserID);
        List<getRelationatedProducts_Result> getRelationatedProducts(int pUserID);
    }

    public class SeguimientoEntrenamientosDB :ISeguimientoAEntrenamientos{
        public List<getTrainings_Result> getMisEntrenamientos(int pUserID)
        {
            TEC_QA_CRMEntities db = new TEC_QA_CRMEntities();
            return db.getTrainings(pUserID).ToList<getTrainings_Result>();

        }
        public List<getRelationatedProducts_Result> getRelationatedProducts(int pUserID)
        {
            TEC_QA_CRMEntities db = new TEC_QA_CRMEntities();
            return db.getRelationatedProducts(pUserID).ToList<getRelationatedProducts_Result>();

        }
    }
}