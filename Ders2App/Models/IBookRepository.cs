using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ders2App.Models
{
    public interface IBookRepository
    {
        IEnumerable<Book> GetAllBooks();
        Book GetBookById(int bookid);
    }
}
