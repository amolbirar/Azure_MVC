using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCApplication1.Models;

namespace MVCApplication1.Controllers
{
    public class MovieController : Controller
    {
        // GET: Movie
        public ActionResult Random()
        {
            var movie = new Movie {Name = "Movie Title 1"};
            return View(movie);
        }
    }
}