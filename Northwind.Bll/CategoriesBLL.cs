using Northwind.Dal.Contcrete.EntityFramework;
using Northwind.Entities.Concrete;
using Northwind.Entities.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Northwind.Bll
{
   public class CategoriesBLL
    {
        EfCategoryDal _efCategoryDal;
        public CategoriesBLL()
        {
            _efCategoryDal = new EfCategoryDal();
        }
        NorthwindContext db = new NorthwindContext();
        public List<Category> GetCategoryList()
        {
           List<Category> categorylist =  _efCategoryDal.Getlist();
            List<string> ImageList = new List<string>();


            foreach (var item in categorylist)
            {
                var newimage = Convert.ToBase64String(item.Picture);
                ImageList.Add("data:image/png;base64," + newimage);
                item.ImageList = "data:image/svg+xml;base64," + newimage;
            }
           return categorylist;
        
        }


        public List<CategoryDTO> CategoryProductList()
        {
            using (NorthwindContext db = new NorthwindContext())
            {

                var employeeRecord = from e in db.Categories
                                     join d in db.Products on e.CategoryId equals d.CategoryId 
                                     select new CategoryDTO
                                     {
                                        CategoryId=e.CategoryId,
                                          CategoryName = e.CategoryName,
                                      
                                           ProductName = d.ProductName,
                                      
                                     };
                return employeeRecord.ToList();

            }  
        }
    }
}
