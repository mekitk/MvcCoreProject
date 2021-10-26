using Northwind.Dal.Abstract;
using Northwind.Entities.Concrete;
using NorthwindCore.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.Dal.Contcrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {
        public void test(int a, string b)
        {
           
        }
    }
}
