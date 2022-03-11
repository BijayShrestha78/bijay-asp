using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class aspbijay : Controller
    {
        mainEntities db= new mainEntities();

        // GET: Main
        public ActionResult mainview()
        {
            List<employee> data = db.employees.ToList();
            return View();
        }
    }
}