using MarvelApi;
using MarvelApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PokWarVel.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            MarvelRequester r = new MarvelRequester();
            List<Characters> info = r.GetCharacters(limit: 100);
            //info.Where(i=>i.name=="") une requete linq

            return View(info);
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