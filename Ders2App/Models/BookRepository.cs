using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ders2App.Models
{
    public class BookRepository : IBookRepository
    {
        private AppDbContext _dbContext;

        public BookRepository(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }


        public IEnumerable<Book> GetAllBooks()
        {
            return _dbContext.Books.OrderBy(b => b.Name);
        }

        public Book GetBookById(int bookid)
        {
            return _dbContext.Books.FirstOrDefault(b => b.id == bookid);
        }
    }
}
