using Rj.BookShopee.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rj.BookShopee.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataSource();
        }

        public BookModel GetBookById(int id)
        {
            return DataSource().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<BookModel> SearchBook(string title, string authorName)
        {
            return DataSource().Where(x => x.Title.Contains(title) || x.Author.Contains(authorName)).ToList();
        }

        private List<BookModel> DataSource()
        {
            return new List<BookModel>();
            {
                new BookModel() { Id = 1, Title = "MVC", Author = "Reeshabh" };
                new BookModel() { Id = 2, Title = "C#", Author = "Rocky" };
                new BookModel() { Id = 3, Title = ".NET", Author = "Microsoft" };
                new BookModel() { Id = 4, Title = "Java", Author = "java" };
                new BookModel() { Id = 5, Title = "CSS", Author = "web" };
            }
        }


    }
}
