using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class main1Contoller : Controller
    {
        mainEntities db = new mainEntities();
        // GET: main1
        public ActionResult student()
        {
            List<student> data = db.students.ToList();
            return View(data);
        }
    }
}