//using DevExtreme.AspNet.Data;
//using DevExtreme.AspNet.Mvc;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.AspNetCore.Mvc.ModelBinding;
//using Microsoft.EntityFrameworkCore;
//using Newtonsoft.Json;
//using System;
//using System.Collections;
//using System.Collections.Generic;
//using System.Globalization;
//using System.Linq;
//using System.Threading.Tasks;
//using Northwind.Dal.Contcrete.EntityFramework;
//using Northwind.Entities.Concrete;

//namespace DevExtremeAspNetCoreApp1.Controllers
//{
//    [Route("api/[controller]/[action]")]
//    public class CustomersController : Controller
//    {
//        private NorthwindContext _context;

//        public CustomersController(NorthwindContext context) {
//            _context = context;
//        }

//        [HttpGet]
//        public async Task<IActionResult> Get(DataSourceLoadOptions loadOptions) {
//            var customers = _context.Customers.Select(i => new {
//                i.CustomerId,
//                i.CompanyName,
//                i.ContactName,
//                i.ContactTitle,
//                i.Address,
//                i.City,
//                i.Region,
//                i.Country,
//                i.Phone,
//                i.Fax
//            });

//            // If underlying data is a large SQL table, specify PrimaryKey and PaginateViaPrimaryKey.
//            // This can make SQL execution plans more efficient.
//            // For more detailed information, please refer to this discussion: https://github.com/DevExpress/DevExtreme.AspNet.Data/issues/336.
//            // loadOptions.PrimaryKey = new[] { "CustomerId" };
//            // loadOptions.PaginateViaPrimaryKey = true;

//            return Json(await DataSourceLoader.LoadAsync(customers, loadOptions));
//        }

//        [HttpPost]
//        public async Task<IActionResult> Post(string values) {
//            var model = new Customer();
//            var valuesDict = JsonConvert.DeserializeObject<IDictionary>(values);
//            PopulateModel(model, valuesDict);

//            if(!TryValidateModel(model))
//                return BadRequest(GetFullErrorMessage(ModelState));

//            var result = _context.Customers.Add(model);
//            await _context.SaveChangesAsync();

//            return Json(new { result.Entity.CustomerId });
//        }

//        [HttpPut]
//        public async Task<IActionResult> Put(int key, string values) {
//            var model = await _context.Customers.FirstOrDefaultAsync(item => item.CustomerId == key);
//            if(model == null)
//                return StatusCode(409, "Object not found");

//            var valuesDict = JsonConvert.DeserializeObject<IDictionary>(values);
//            PopulateModel(model, valuesDict);

//            if(!TryValidateModel(model))
//                return BadRequest(GetFullErrorMessage(ModelState));

//            await _context.SaveChangesAsync();
//            return Ok();
//        }

//        [HttpDelete]
//        public async Task Delete(int key) {
//            var model = await _context.Customers.FirstOrDefaultAsync(item => item.CustomerId == key);

//            _context.Customers.Remove(model);
//            await _context.SaveChangesAsync();
//        }


//        private void PopulateModel(Customer model, IDictionary values) {
//            string CUSTOMER_ID = nameof(Customer.CustomerId);
//            string COMPANY_NAME = nameof(Customer.CompanyName);
//            string CONTACT_NAME = nameof(Customer.ContactName);
//            string CONTACT_TİTLE = nameof(Customer.ContactTitle);
//            string ADDRESS = nameof(Customer.Address);
//            string CİTY = nameof(Customer.City);
//            string REGİON = nameof(Customer.Region);
//            string COUNTRY = nameof(Customer.Country);
//            string PHONE = nameof(Customer.Phone);
//            string FAX = nameof(Customer.Fax);

//            if(values.Contains(CUSTOMER_ID)) {
//                model.CustomerId = Convert.ToInt32(values[CUSTOMER_ID]);
//            }

//            if(values.Contains(COMPANY_NAME)) {
//                model.CompanyName = Convert.ToString(values[COMPANY_NAME]);
//            }

//            if(values.Contains(CONTACT_NAME)) {
//                model.ContactName = Convert.ToString(values[CONTACT_NAME]);
//            }

//            if(values.Contains(CONTACT_TİTLE)) {
//                model.ContactTitle = Convert.ToString(values[CONTACT_TİTLE]);
//            }

//            if(values.Contains(ADDRESS)) {
//                model.Address = Convert.ToString(values[ADDRESS]);
//            }

//            if(values.Contains(CİTY)) {
//                model.City = Convert.ToString(values[CİTY]);
//            }

//            if(values.Contains(REGİON)) {
//                model.Region = Convert.ToString(values[REGİON]);
//            }

//            if(values.Contains(COUNTRY)) {
//                model.Country = Convert.ToString(values[COUNTRY]);
//            }

//            if(values.Contains(PHONE)) {
//                model.Phone = Convert.ToString(values[PHONE]);
//            }

//            if(values.Contains(FAX)) {
//                model.Fax = Convert.ToString(values[FAX]);
//            }
//        }

//        private string GetFullErrorMessage(ModelStateDictionary modelState) {
//            var messages = new List<string>();

//            foreach(var entry in modelState) {
//                foreach(var error in entry.Value.Errors)
//                    messages.Add(error.ErrorMessage);
//            }

//            return String.Join(" ", messages);
//        }
//    }
//}