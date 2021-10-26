using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Northwind.Dal.Contcrete.EntityFramework;
using Northwind.Entities.Concrete;
using Northwind.Entities.Dto;
using Microsoft.EntityFrameworkCore;

namespace Northwind.Bll
{
     public class ProductBLL
    {
        EfProductDal _efproductDal;
        public ProductBLL()
        {
            _efproductDal = new EfProductDal();
        }
        NorthwindContext db = new NorthwindContext();
        public List<Product> GetProductList()
        {
            List<Product> prodcutlist = _efproductDal.Getlist();
            List<string> ImageList = new List<string>();


          
            return prodcutlist;

        }

        
        }
    }

