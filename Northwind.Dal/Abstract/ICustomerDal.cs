using Northwind.Entities.Concrete;
using NorthwindCore.DataAccess;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.Dal.Abstract
{
    public interface ICustomerDal : IEntityRepository<Customer>
    {
    }
}
