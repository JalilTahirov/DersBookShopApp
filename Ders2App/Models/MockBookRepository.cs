using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ders2App.Models
{
    public class MockBookRepository : IBookRepository
    {
        private List<Book> _books;

        public MockBookRepository()
        {
            if (_books == null)
            {
                InitializeBooks();
            }
        }

        private void InitializeBooks()
        {
            _books = new List<Book>
                {
                    new Book {id = 1, Name = "ASP.net core", Price = 12.95M, ShortDescription = "Some description for this book"},
                    new Book {id = 2, Name = "C# in a nutshell", Price = 12.95M, ShortDescription = "Different description for  book"},
                    new Book {id = 3, Name = "JavaScript", Price = 12.95M, ShortDescription = "Different description for  book"}

            };
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return _books;
        }

        public Book GetBookById(int bookId)
        {
            return _books.FirstOrDefault(b => b.id == bookId);
        }
    }
}
