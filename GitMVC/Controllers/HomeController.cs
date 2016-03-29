using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GitMVC.Controllers
{
    public class HomeController : Controller
    {

        public void Index()
        {
            Response.Write("From Index");
        }

        public void About()
        {
            Response.Write("From About");
        }

        public void Contact()
        {
            Response.Write("From Contact");
        }

    }
}
