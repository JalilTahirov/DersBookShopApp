using Ders2App.Models;
using Ders2App.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Ders2App.Controllers
{
    public class HomeController :Controller
    {
        private IBookRepository _bookRepository;

        public HomeController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }




        // GET: /<controller>/
        public IActionResult Index()
        {

            HomeViewModel viewModel = new HomeViewModel() {
                Title = "Home",
                Books = _bookRepository.GetAllBooks(),
                Message = "We have a sale"
            };                   

           
            return View(viewModel);
        }



        public IActionResult About()
        {
            ViewBag.Title = "About";
            return View();
        }



    }
}
