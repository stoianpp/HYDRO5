using Data.Common;
using Data.Models;
using HydroAsp.App_Start;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace HydroAsp.Controllers
{
    public class HomeController: Controller
    {
        private readonly IDbRepository<Customer> repo;

        public HomeController(IDbRepository<Customer> repo)
        {
            //this.repo = repo;
            //var cust = new Customer
            //{
            //    Address = "Adres",
            //    CountryId = 1
            //};
            //repo.Add(cust);
            //repo.Save();
        }

        public ActionResult Index()
        {
            return View();
        }

        
    }
}