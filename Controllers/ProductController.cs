using Microsoft.AspNetCore.Mvc;
using RestrauntWebApi.Data;
using RestrauntWebApi.Models;

namespace RestrauntWebApi.Controllers
{
    public class ProductController : Controller
    {
        private Repository<Product> products;

        public ProductController(ApplicationDbContext context)
        {
            this.products = new Repository<Product>(context);
        }
        public async Task <IActionResult> Index()
        {
            return View(await products.GetAllAsync());
        }
    }
}
