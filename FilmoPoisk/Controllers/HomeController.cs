using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Filmopoisk.Models;

namespace FilmoPoisk.Controllers
{
    public class HomeController : Controller
    {
        
        private FilmContext filmContext = new FilmContext();

        public ActionResult Index(string searchString)
        {
            var films = from m in filmContext.Films
                         select m;
            
            if (!String.IsNullOrEmpty(searchString))
            {
                films = films.Where(film => film.Name.Contains(searchString)
                                    || film.Genre.Contains(searchString)
                                    ||  film.Actors.Select(n => n.Name).Contains(searchString) );
            }

            int filmCount = filmContext.Films.Count();
            int id = new Random().Next(1, filmCount+1);

            Film randomFilm = filmContext.Films.Find(id);
            ViewBag.RandomFilm = randomFilm;

            if(films != null)
            {
                ViewBag.Films = films;
            }
            else
            {
                ViewBag.Films = filmContext.Films;
            }
           
            return View();
        }


        // Поиск определенного фильма или рандомного, в случае если определенный не задан
        public ActionResult Details(int id = 0)
        {
            if(id == 0)
            {
                int filmCount = filmContext.Films.Count();
                id = new Random().Next(1, filmCount);
            }

            Film randomFilm = filmContext.Films.Find(id);
            if(randomFilm == null)
            {
                return HttpNotFound();
            }
            return View(randomFilm);
        }

        protected override void Dispose(bool disposing)
        {
            filmContext.Dispose();
            base.Dispose(disposing);
        }
    }
}