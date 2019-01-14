using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcWebUI.Models;
using Oracle.ManagedDataAccess.Client;

namespace MvcWebUI.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            CityListViewModel model;
            using (var context = new ApplicationDbContext())
            {
                model = new CityListViewModel
                {
                    CityList = context.Cities.ToList()
                };
            }
            return View(model);
        }

        [HttpPost]
        public ActionResult Login()
        {
            return View();
        }
    }
}