using Northwind.Dal.Abstract;
using Northwind.Entities.Concrete;
using NorthwindCore.DataAccess.EntityFramework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.Dal.Contcrete.EntityFramework
{
    public class EfCustomerDal : EfEntityRepositoryBase<Customer, NorthwindContext>, ICustomerDal
    {

    }
}

