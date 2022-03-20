using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Webgentle.BookStore.Models;

namespace Webgentle.BookStore.Repository
{
    public class BookRepository
    {
        public List<BookModel> GetAllBooks()
        {
            return DataStore();
        }

        public BookModel GetBookById(int id)
        {
            return DataStore().Where(x => x.Id == id).FirstOrDefault();
        }

        public List<BookModel> SearchBook(string title, string author)
        {
            return DataStore().Where(x => x.Title.Contains(title) || x.Author.Contains(author)).ToList();
        }

        private List<BookModel> DataStore()
        {
            return new List<BookModel>()
            {
                new BookModel(){ Id=1, Title="MVC", Author="Nitish"},
                new BookModel(){ Id=2, Title="ASP.NET", Author="Nitish"},
                new BookModel(){ Id=3, Title="WEB API", Author="Monika"},
                new BookModel(){ Id=4, Title="Angular", Author="Prabhu"},
                new BookModel(){ Id=5, Title="Java", Author="Prabhu"}
            };
        }
    }
}
