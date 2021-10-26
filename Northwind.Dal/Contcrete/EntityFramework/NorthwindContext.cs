using Microsoft.EntityFrameworkCore;
using Northwind.Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Northwind.Dal.Contcrete.EntityFramework
{
    public class NorthwindContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"server=DESKTOP-AN4DOSQ\SQLEXPRESS;database=Northwind;trusted_connection=true;");

            optionsBuilder.UseSqlServer(@"workstation id=NorthwindMvcCore.mssql.somee.com;packet size=4096;user id=mekitk_SQLLogin_1;pwd=jtun81wlrg;data source=NorthwindMvcCore.mssql.somee.com;persist security info=False;initial catalog=NorthwindMvcCore");
        }
        public DbSet<Product> Products { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
