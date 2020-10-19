using LibraryManagmentSystem.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LibraryManagmentSystem.Controllers
{
    public class BooksController : Controller
    {
        // GET: Books
        public ActionResult AddBook()
        {
            return View();
        }

        public ActionResult BooksList()
        {
            List<Book> booksList = GetBooksListMock();
            return View(booksList);
        }

        public ActionResult EditBook(int id)
        {
            List<Book> booksList = GetBooksListMock();
            var book = booksList.Where(b => b.BookId == id).FirstOrDefault();
            return View(book);
        }
        
        public ActionResult BookDetails(int id)
        {
            List<Book> booksList = GetBooksListMock();
            var book = booksList.Where(b => b.BookId == id).FirstOrDefault();
            return View(book);
        }

        public ActionResult DeleteBook(int id)
        {
            List<Book> booksList = GetBooksListMock();
            var book = booksList.Where(b => b.BookId == id).FirstOrDefault();
            return View(book);
        }

        private List<Book> GetBooksListMock()
        {
            List<Book> booksList = new List<Book>();
            Book book = new Book()
            {
                Author = "Judi",
                BookId = 1,
                Publisher = "Hills, Hirthe and Hackett",
                SerialNumber = "774906070-7",
                Title = "Pre-emptive context-sensitive model",
                Category = "Fantasy",
                Price = 90,
                ImageURL = "/Assets/book1.jpg"
            };
            booksList.Add(book);
            book = new Book()
            {
                Author = "Cal",
                BookId = 2,
                Publisher = "Kovacek-McLaughlin",
                SerialNumber = "185570333-5	",
                Title = "Expanded neutral architecture",
                Category = "Drama|Horror",
                Price = 23,
                ImageURL = "/Assets/book2.jpg"
            };
            booksList.Add(book);
            book = new Book()
            {
                Author = "Linnea",
                BookId = 3,
                Publisher = "Swaniawski, Pfannerstill and Greenfelder",
                SerialNumber = "992044842-7",
                Title = "Assimilated exuding initiative",
                Category = "Drama",
                Price = 56,
                ImageURL = "/Assets/book3.jpg"
            };
            booksList.Add(book);
            book = new Book()
            {
                Author = "Idell",
                BookId = 4,
                Publisher = "Weber, Halvorson and White",
                SerialNumber = "454563599-7",
                Title = "Multi-channelled radical customer loyalty",
                Category = "Adventure|Animation|Drama|Fantasy|Sci-Fi",
                Price = 94,
                ImageURL = "/Assets/book1.jpg"
            };
            booksList.Add(book);
            return booksList;
        }
    }
}