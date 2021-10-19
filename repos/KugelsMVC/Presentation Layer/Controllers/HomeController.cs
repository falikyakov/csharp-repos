using Business_Logic;
using BusinessEntities;
using Data_Access;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Presentation_Layer.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
  
        public ActionResult Create()
        {
            return RedirectToRoute("CreateCustomer");
        }

        public ActionResult ShowCustomers()
        {
            AccessingDAL Adal = new AccessingDAL();
            return View(Adal.GetCustomerList());
        }

        public ActionResult ShowStores()
        {
            AccessingDAL Adal = new AccessingDAL();
            return View(Adal.GetStoreList());
        }

        public ActionResult ShowKugels()
        {
            AccessingDAL Adal = new AccessingDAL();
            return View(Adal.GetKugelList());
        }


        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}