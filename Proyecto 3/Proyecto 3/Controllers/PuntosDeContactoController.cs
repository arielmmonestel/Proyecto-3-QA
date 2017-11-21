using Proyecto_3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Proyecto_3.Controllers
{
    public class PuntosDeContactoController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            if (this.Request.QueryString["UserID"] != null) { 
            Session["UserID"] = Convert.ToString(this.Request.QueryString["UserID"]);

            Session["Username"] = Convert.ToString(this.Request.QueryString["Username"]);
            }
            //Session["UserID"] = 14;
            ViewBag.listaContactos = Contactos(Convert.ToInt32(Session["UserID"]));
            return View();
        }

        public List<Contact_View> Contactos(int usuarioID)
        {
            TEC_QA_CRMEntities db = new TEC_QA_CRMEntities();
            return db.Contact_View.Where(x => x.ClientID == usuarioID).ToList();
        }
    }
}