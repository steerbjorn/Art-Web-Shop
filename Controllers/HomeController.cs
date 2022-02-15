using ArtWebshop.Data;
using ArtWebshop.Models;
using ArtWebshop.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ArtWebshop.Controllers
{    
    public class HomeController : Controller
    {
        private readonly ProductDbContext _prodContext;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, ProductDbContext prodContext)
        {
            _logger = logger;
            _prodContext = prodContext;
        }

        public async Task<IActionResult> Index()
        {
            ArtistProductViewModel artProdViewModel = new ArtistProductViewModel();
            artProdViewModel.Product = await _prodContext.Products
                .Include(a => a.Artist)
                .ToListAsync();
            Debug.WriteLine("\n\t" + artProdViewModel.Product.FirstOrDefault().Title);

            return View(artProdViewModel);
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
