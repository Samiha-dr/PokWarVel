using PokWarVel.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PokWarVel.Controllers
{
    public class EvalController : Controller
    {
        // GET: Eval
        public ActionResult Index()
        {   
            ;
            return View();
        }

        public ActionResult Eval (long id)
        {
            EvalModel Ev1=new EvalModel();
            MarvelApi.MarvelRequester Communicator= new MarvelApi.MarvelRequester();
            Ev1.MonHero= Communicator.GetCharacterById(id);
            return View(Ev1);

        }

        [HttpPost]

        public ActionResult Eval (long id,EvalModel E)
        {
             E.IdHero = id;
          
            if (E.Save())
            {
                ViewBag.Msg = "Enregistré";
            }
            else
            {
                ViewBag.Error = "Erreur lors de l'enregistrement";
            }
            
            MarvelApi.MarvelRequester communicator = new MarvelApi.MarvelRequester();
            E.MonHero = communicator.GetCharacterById(id);

            return View(E);
        }
        }

    }
}