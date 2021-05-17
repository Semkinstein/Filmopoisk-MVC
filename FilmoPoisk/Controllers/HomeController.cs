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


        public ActionResult Index()
        {
            return View();
        }


        // Поиск фильмов по строке из формы
        public ActionResult FilmSearch(string searchString)
        {
            var films = from m in filmContext.Films
                        select m;


            if (!String.IsNullOrEmpty(searchString))
            {
                films = films.Where(film => film.Name.Contains(searchString)
                                    || film.Genre.Contains(searchString)
                                    || film.Actors.Select(n => n.Name).Contains(searchString));
            }
            else
            {
                return PartialView(filmContext.Films.ToList());
            }

            if (films.Count() == 0)
            {
                return PartialView("Фильмов не найдено(");
            }

            return PartialView(films.ToList());
        }

        // Поиск фильмов по клику на актера
        public ActionResult FilmByActor(int id)
        {
            var films = from m in filmContext.Films
                        select m;

            films = films.Where(film => film.Actors.Select(n => n.Id).Contains(id));
            if (films.Count() == 0)
            {
                return PartialView("Фильмов не найдено(");
            }

            return PartialView("FilmSearch", films.ToList());
        }

        // Передача данных о фильме в частичное представление
        public ActionResult FilmDetails(int id = 1)
        {
            Film selectedFilm = filmContext.Films.Find(id);
            if(selectedFilm == null)
            {
                return HttpNotFound();
            }
            return PartialView(selectedFilm);
        }

        // Закрытие БД
        protected override void Dispose(bool disposing)
        {
            filmContext.Dispose();
            base.Dispose(disposing);
        }
    }
}