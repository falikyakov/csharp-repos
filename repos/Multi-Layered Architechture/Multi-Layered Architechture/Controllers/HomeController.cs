using BusinessEntities;
using BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Multi_Layered_Architechture.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            VotingRules bl=new VotingRules();
            List<Citizen> Voters = bl.GetVoters();
            return View(Voters);
        }
    }
}