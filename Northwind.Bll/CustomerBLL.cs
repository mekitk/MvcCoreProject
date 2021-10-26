using Microsoft.EntityFrameworkCore;
using Northwind.Dal.Contcrete.EntityFramework;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Northwind.Bll
{
    public class CustomerBLL

    {
        EfCustomerDal _efcustomerDal;
        public CustomerBLL()
        {
            _efcustomerDal = new EfCustomerDal();
        }
        NorthwindContext db = new NorthwindContext();
        public List<Customer> CustomerStoreProcedure()
        {
            try
            {
                //List<Customer> customers = db.Customers.FromSqlRaw("EXECUTE GetCustomer").ToList();
                List<Customer> list;
                string sql = "EXEC GetCustomer";
                list = db.Customers.FromSqlRaw<Customer>(sql).ToList();
                return list;
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }
        }
    }
