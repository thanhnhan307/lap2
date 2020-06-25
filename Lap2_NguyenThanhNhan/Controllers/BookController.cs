using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lap2_NguyenThanhNhan.Models;

namespace Lap2_NguyenThanhNhan.Controllers
{
    public class BookController : Controller
    {
        private int university;

        // GET: Book
        public String HelloTeacher(String University)
        {
            return "Hello Nguyen Thanh Nhan - University:  HCMC University Of Technology " + university;
        }
        public ActionResult ListBook()
        {
            var books = new List<string>();
            books.Add("HTML5 & CSS3 the complete Manual - Author Name Book 1");
            books.Add("HTML5 & CSS Responsive web Design cookbook - Author Name Book 2");
            books.Add("Professional ASP.NET MVC5 - Author Name Book 2");
            ViewBag.Books = books;
            return View();
        }
        public ActionResult ListBookModel()
        {
            var books = new List<Book>();
            books.Add(new Book(1, "HTML5 & CSS3 The complete Manual", "Author Name Book 1", "/Content/Images/book1cover.png"));
            books.Add(new Book(2, "HTML5 & CSS Responsive  web Design cookbook", "Author Name Book 2", "/Content/Images/book2cover.png"));
            books.Add(new Book(3, "Professional ASP.NET MVC5", "Author Name Book 3", "/Content/Images/book3cover.png"));
            return View(books);
        }
        public ActionResult EditBook(int id)
        {
            var books = new List<Book>();
            books.Add(new Book(1, "HTML5 & CSS3 The complete Manual", "Author Name Book 1", "/Content/Images/book1cover.png"));
            books.Add(new Book(2, "HTML5 & CSS Responsive  web Design cookbook", "Author Name Book 2", "Content/Images/book2cover.png"));
            books.Add(new Book(3, "Professional ASP.NET MVC5", "Author Name Book 3", "/Content/Images/book3cover.png"));
            Book book = new Book();
            foreach (Book b  in books)
            {
                if(b.Id==id)
                {
                    book = b;
                    break;
                }
            }
            if (book == null)
            {
                return HttpNotFound();

            }
            return View(book);
        }

    }
}