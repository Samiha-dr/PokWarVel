using MarvelApi;
using MarvelApi.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PokWarVel.Controllers
{
    public class SearchController : Controller
    {
        // GET: Search
        public ActionResult Index()
        {

            return View();
        }

        [HttpPost]
        public ActionResult Results(string Search)
        {
            MarvelRequester r = new MarvelRequester();
            List<Characters> info = r.GetCharacters(limit: 100);
            ////filtre 
            //List<Characters> trouve = new List<Characters>();
            //foreach (Characters item in info)
            //{
            //    if (item.name.Contains (Search))
            //    {
            //        trouve.Add(item);
            //    }
            //}


            //return View(trouve);
            //LINQ
            return View(info.Where(l => l.name.Contains(Search)));
        }
        
        
    } 
}