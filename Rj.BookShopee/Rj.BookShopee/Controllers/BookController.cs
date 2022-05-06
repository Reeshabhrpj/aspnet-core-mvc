using Microsoft.AspNetCore.Mvc;
using Rj.BookShopee.Models;
using Rj.BookShopee.Repository;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;


namespace Rj.BookShopee.Controllers
{
    public class BookController : Controller
    {
        private readonly BookRepository _bookRepository = null;

        public BookController()
        {
            _bookRepository = new BookRepository();
        }

      public ViewResult GetAllBooks()
        {
            var data = _bookRepository.GetAllBooks();
            return View();
        }
        public BookModel GetBook(int id)
        {
            return _bookRepository.GetBookById(id);
        }

        public List<BookModel> searchBooks(string bookName, string authorName)
        {
            return _bookRepository.SearchBook(bookName, authorName);
        }
    }
}
