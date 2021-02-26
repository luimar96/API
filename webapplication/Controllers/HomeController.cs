using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace webapplication.Controllers
{

    public class HomeController : Controller
    {
        List<Book> bookList = new List<Book>();
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        [HttpGet]
        public ActionResult GetAllBooks()
        {
           

            bookList.Add(new Book { Id = 1, BookTitle = "Harry Potter and the Order of the Phoenix", BookAuthor = "J.K Rowling", BookInfo = "Den nya läraren i försvar mot svartkonster har vissa byråkratiska metoder som gör Hogwarts försvarslöst mot en ondskefull sammansvärjning." });
            bookList.Add(new Book { Id = 2, BookTitle = "A Promised Land ", BookAuthor = "Barack Obama", BookInfo = "A riveting, deeply personal account of history in the making-from the president who inspired us to believe in the power of democracyIn" });
            bookList.Add(new Book { Id = 2, BookTitle = "Wallflower ", BookAuthor = "Stephen Chbosky", BookInfo = "The book behind the film The Benefits of Being a Wallflower" });
            //var selectBook = bookList.Where(o => o.Id == id).FirstOrDefault();
            return new JsonResult { Data = bookList, JsonRequestBehavior = JsonRequestBehavior.AllowGet };

        }
        [HttpGet]
        public ActionResult SearchBook(int id)
        {
            
            bookList.Add(new Book { Id = 1, BookTitle = "Harry Potter and the Order of the Phoenix", BookAuthor = "J.K Rowling", BookInfo = "Den nya läraren i försvar mot svartkonster har vissa byråkratiska metoder som gör Hogwarts försvarslöst mot en ondskefull sammansvärjning." });
            bookList.Add(new Book { Id = 2, BookTitle = "A Promised Land ", BookAuthor = "Barack Obama", BookInfo = "A riveting, deeply personal account of history in the making-from the president who inspired us to believe in the power of democracyIn" });
            bookList.Add(new Book { Id = 2, BookTitle = "Wallflower ", BookAuthor = "Stephen Chbosky", BookInfo = "The book behind the film The Benefits of Being a Wallflower" });
            var selectBook = bookList.Where(o => o.Id == id).FirstOrDefault();
            return new JsonResult { Data = selectBook, JsonRequestBehavior = JsonRequestBehavior.AllowGet };


        }
        /*[HttpPost]
        public ActionResult CreateBook(Books book)
        {
            List<book> booklsit = new List<book>();


        }
        [HttpDelete]
        public ActionResult DeleteBookFromId()
        {

        }*/

    }
}
