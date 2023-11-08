using Microsoft.AspNetCore.Mvc;
using myinterfaceapp.Models;
using myinterfaceapp.Myrepository;
using System.Diagnostics;

namespace myinterfaceapp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IRepo _repo;

        public HomeController(ILogger<HomeController> logger,IRepo repo)
        {
            _logger = logger;
            this._repo = repo;
        }

        public IActionResult Index()
        {
            var x=_repo.getdata();
            return View(x);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}