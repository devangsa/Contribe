using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using ContribeBookStore.Models;

namespace ContribeBookStore.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

         StoreEntities storeDB = new StoreEntities();

        public ActionResult Index()
        {
            // Get most popular books
            var books = GetTopSellingBooks(5);

            return View(books);
        }

        private List<Book> GetTopSellingBooks (int count)
        {
            // Group the order details by book and return
            // the books with the highest count

            return storeDB.Books
                .OrderByDescending(a => a.OrderDetails.Count())
                .Take(count)
                .ToList();
        }
    }
}