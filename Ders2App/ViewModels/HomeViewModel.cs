using Ders2App.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Ders2App.ViewModels
{
    public class HomeViewModel
    {
        public string Title { get; set; }
        public IEnumerable<Book> Books { get; set; }

        public string Message { get; set; }
    }
}
