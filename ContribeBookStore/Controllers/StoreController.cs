using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ContribeBookStore.Models;
using System.Web.UI;

namespace ContribeBookStore.Controllers
{
    public class StoreController : Controller
    {
        StoreEntities storeDB = new StoreEntities();

        //
        // GET: /Store/

        public ActionResult Index()
        {
            var genres = storeDB.Genres.ToList();

            return View(genres);
        }

        //
        // GET: /Store/Browse?genre=Disco
        [HttpGet]
        public ActionResult Browse(string Genre)
        {
            var genre = new ContribeBookStore.Models.Genre();
            try
            {
                // Retrieve Genre and its Associated Books from database
                var genreModel = storeDB.Genres.Include("Books")
                    .Single(g => g.Name == Genre);

                return View(genreModel);
            }
            catch
            {
                ViewBag.ErrorMessage = "Books not found...";
                return View(genre);
            }
        }

        //
        // GET: /Store/Details/5

        public ActionResult Details(int id)
        {
            var book = storeDB.Books.Find(id);

            return View(book);
        }

        //
        // GET: /Store/GenreMenu

        [ChildActionOnly]

        public ActionResult GenreMenu()
        {
            
                var genres = storeDB.Genres.ToList();
                return PartialView(genres);
            
        }

        [HttpGet]
        public ActionResult Search(string title)
        {
            var genreModel = new ContribeBookStore.Models.Genre();
            try
            {
                // Retrieve Genre and its Associated books from database
                //var genreModel = storeDB.books.Single(g => g.Title == title);
                 genreModel = storeDB.Genres.Include("Books").Single(g => g.Books.FirstOrDefault().Title.Contains(title));

                return View(genreModel);
            }
            catch
            {
                ViewBag.ErrorMessage = "Books not found...";
                return View(genreModel);
            }
        }



    }
}