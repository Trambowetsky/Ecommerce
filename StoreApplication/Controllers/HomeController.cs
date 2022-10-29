using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using StoreApplication.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace StoreApplication.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        AppDbContext context;
        private const int pageSize = 8;

        public HomeController(ILogger<HomeController> logger, AppDbContext dbContext)
        {
            _logger = logger;
            context = dbContext;
        }

        public async Task<IActionResult> Index(int page = 1)
        {
            IQueryable<ProductModel> source = context.ProductModels.Select(x => x);
            var count = await source.CountAsync();
            List<ProductModel> items = await source.Skip((page - 1) * pageSize).Take(pageSize).ToListAsync();
            var pageViewModel = new PageViewModel(count, page, pageSize);
            var viewModel = new IndexViewModel
            {
                PageViewModel = pageViewModel,
                Models = items
            };
            return View(viewModel);
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
