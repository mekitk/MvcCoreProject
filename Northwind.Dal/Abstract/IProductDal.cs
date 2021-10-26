using Northwind.Entities.Concrete;
using NorthwindCore.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.Dal.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
        public void test(int a,string b);


    }
}
