using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Project.Controllers
{
    public class ProductController : Controller
    {
        private readonly DataBasePhatTrienWebContext _context;
        public ProductController(DataBasePhatTrienWebContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ListProduct(int id)
        {
            try
            {
                List<Product> prolist = _context.Products.Where(p => p.CatergoryId== id).ToList();
                return View(prolist);
            }
            catch
            {
                return View();
            }

        }

        public IActionResult ProductDetails(int id)
        {
            try
            {
                List<Product> prolist = _context.Products.Where(p => p.ProductId == id).ToList();
                return View(prolist);
            }
            catch
            {
                return View();
            }

        }
    }
}
