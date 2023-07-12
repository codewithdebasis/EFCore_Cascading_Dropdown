using EFCore_Cascading_Dropdown.DBContext;
using EFCore_Cascading_Dropdown.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Diagnostics;

namespace EFCore_Cascading_Dropdown.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        private readonly InMemoryDBContext _context;


        public HomeController(ILogger<HomeController> logger, InMemoryDBContext context)
        {
            _logger = logger;

            _context = context;

            _context.Database.EnsureCreated();
        }

        public IActionResult Index()
        {
            var _categories = _context.Categories.ToList();
            var _products = new List<Product>();

            _categories.Add(new Category() { Id = 0, Name = "--Select Category--" });
            _products.Add(new Product() { Id = 0, Name = "--Select Product--" });

            ViewData["CategoryData"] = new SelectList(_categories.OrderBy(s => s.Id), "Id", "Name");
            ViewData["ProductData"] = new SelectList(_products.OrderBy(s => s.Id), "Id", "Name");

			string host = $"{Request.Scheme}://{Request.Host}{Request.PathBase}/";
			ViewData["BaseUrl"] = host;

			return View();
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