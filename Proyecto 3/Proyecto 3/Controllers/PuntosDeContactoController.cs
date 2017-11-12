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
        // GET: PuntosDeContacto
        public ActionResult Index()
        {
            Session["userID"] = 14;
            ViewBag.listaContactos = Contactos((int)Session["userID"]);
            return View();
        }

        public List<Contact_View> Contactos(int usuarioID)
        {
            TEC_QA_CRMEntities db = new TEC_QA_CRMEntities();
            return db.Contact_View.Where(x => x.ClientID == usuarioID).ToList();
        }
    }
}