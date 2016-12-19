using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PokWarVel.Infra
{
    public class SessionUtil
    {
         public static int offsetGal
        {
            get { return (int)HttpContext.Current.Session["offsetGal"]; }
            set { HttpContext.Current.Session["offsetGal"] = value; }
        }

        public static int offsetGalSearch
        {
            get { return (int)HttpContext.Current.Session["offsetGalSearch"]; }
            set { HttpContext.Current.Session["offsetGaloffsetGalSearch"] = value; }
        }

    }
}