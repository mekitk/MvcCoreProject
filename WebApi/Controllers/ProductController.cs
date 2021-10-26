using Microsoft.AspNetCore.Mvc;
using Northwind.Bll;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class ProductController : Controller
    {
        private ProductBLL _product;

        public ProductController()
        {
            _product = new ProductBLL();
        }
        [HttpGet]
        public List<Product> Get()
        {
            
            var bb = _product.GetProductList();
            return bb;
        }
        public IActionResult Index()
        {
            var bb = _product.GetProductList();
            return View(bb);
        }
    }
}
