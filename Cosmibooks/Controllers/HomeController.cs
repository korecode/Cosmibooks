using Microsoft.AspNetCore.Mvc;
using Cosmibooks.Data.Interfaces;
using Cosmibooks.ViewModels;

namespace Cosmibooks.Controllers
{
    public class HomeController : Controller
    {
        private IAllBooks _bookRep;
        public HomeController(IAllBooks bookRep)
        {
            _bookRep = bookRep;
        }

        public ViewResult Index()
        {
            var homeBooks = new HomeViewModel
            {
                favBooks = _bookRep.getFavBooks
            };
            return View(homeBooks);
        }
    }
}
