using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using DevExtremeAspNetCoreApp1.Models;
using Microsoft.AspNetCore.Mvc;
using Northwind.Bll;
using Northwind.Dal.Contcrete.EntityFramework;
using WebApi.Controllers;

namespace DevExtremeAspNetCoreApp1.Controllers
{
    public class HomeController : Controller
    {

        ProductController pc = new ProductController();
        
        public object Index()
        {
           
            return View();
            
        }
        [HttpGet]
        public object Get(DataSourceLoadOptions loadOptions)
        {
            CategoriesBLL categoriesBLL = new CategoriesBLL();
            return DataSourceLoader.Load(categoriesBLL.GetCategoryList(), loadOptions);
        }
        [HttpGet]
        public object GetLinq(DataSourceLoadOptions loadOptions)
        {
            CategoriesBLL categoriesBLL = new CategoriesBLL();
            return DataSourceLoader.Load(categoriesBLL.CategoryProductList(), loadOptions);
        }
        [HttpGet]
        public object GetProduct(DataSourceLoadOptions loadOptions)
        {
            ProductBLL productsbll = new ProductBLL();
            return DataSourceLoader.Load(productsbll.GetProductList(), loadOptions);
        }
        
          
        [HttpGet]
        public object GetStoreProcedure(DataSourceLoadOptions loadOptions)
        {
            CustomerBLL customersbll = new CustomerBLL();
            return DataSourceLoader.Load(customersbll.CustomerStoreProcedure(), loadOptions);
        }

        [HttpGet]
        public object ProductApiData(DataSourceLoadOptions loadOptions)
        {
            
            return DataSourceLoader.Load(pc.Get(), loadOptions);
        }
        public IActionResult About()
        {
            //var deneme = pc.Get();
            return View();
        }

        public IActionResult Product()
        {
            return View();
        }

        public IActionResult Customer()
        {
            return View();
        }

        public IActionResult ProductFromApi()
        {

            return View();
        }

    }
}
