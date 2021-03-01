using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace webapplication.Controllers
{
    public class Book

    {
        public int Id { get; set; }
        public string BookTitle { get; set; }
        public string BookAuthor { get; set; }
        public string BookInfo { get; set; }
       
        public Book(int id, string title, string author, string info)
        {
            this.Id = id;
            this.BookTitle = title;
            this.BookAuthor = author;
            this.BookInfo = info;
        }
    }
}