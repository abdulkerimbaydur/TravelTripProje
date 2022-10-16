using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProje.Models.Siniflar;

namespace TravelTripProje.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult Index()
        {
            Context c = new Context();
          
                var bloglar = c.blogs.ToList();
                return View(bloglar);           
        }
        public ActionResult BlogDetay (int id)
        {

            return View();

        }
    }
}