using LAB5.Labclinic.Data.Business;
using LAB5.Labclinic.Data.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LAB5.Labclinic.Web.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
         
            return View();
        }
    }
}