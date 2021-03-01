using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace webapplication.Controllers
{
    //[Route("api/BookLibrary")]
    public class HomeController : Controller
    {
        List<Book> bookList = new List<Book>();
        public HomeController()
        {
            GetAllBooks();

        }
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        [HttpGet]
        public ActionResult GetAllBooks()
        {
            bookList.Add(new Book(1, "Harry Potter and the Order of the Phoenix", "J.K Rowling", "Den nya läraren i försvar mot svartkonster har vissa byråkratiska metoder som gör Hogwarts försvarslöst mot en ondskefull sammansvärjning."));
            bookList.Add(new Book(id: 2, title: "A Promised Land ", author: "Barack Obama", info: "A riveting, deeply personal account of history in the making-from the president who inspired us to believe in the power of democracyIn"));
            bookList.Add(new Book(id: 3, title: "Wallflower ", author: "Stephen Chbosky", info: "The book behind the film The Benefits of Being a Wallflower"));
            return new JsonResult { Data = bookList, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
        [HttpGet]
        public ActionResult SearchBook(int id)
        {

            var selectbook = bookList.Where(o => o.Id == id).FirstOrDefault();
            return new JsonResult { Data = selectbook, JsonRequestBehavior = JsonRequestBehavior.AllowGet };


        }
        [HttpPost]
        public ActionResult CreateBook(Book book)
        {

            bookList.Add(book);
            return new HttpStatusCodeResult(200);

        }
        
        [HttpDelete]
        public ActionResult DeleteBookFromId(int id)
        {
            var selectbook = bookList.Where(o => o.Id == id).FirstOrDefault();
            bookList.Remove(selectbook);
            return new HttpStatusCodeResult(200);

        }

    }
}
