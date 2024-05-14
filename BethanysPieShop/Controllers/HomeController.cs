using BethanysPieShop.Models;
using BethanysPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.IO.Pipelines;

namespace BethanysPieShop.Controllers
{
    public class HomeController : Controller
        
    {
        private readonly IPieRepository _iPieRepository;
        public HomeController(IPieRepository iPieRepository)
        {
            _iPieRepository = iPieRepository;
        }

        public IActionResult Index()
        {
            var pies = _iPieRepository.PiesOfTheWeek;
            var homeViewModel = new HomeViewModel(pies); 
            return View(homeViewModel);
        }
    }
}
