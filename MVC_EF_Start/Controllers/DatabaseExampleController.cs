//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Mvc;
//using Microsoft.EntityFrameworkCore;
//using MVC_EF_Start.DataAccess;
//using MVC_EF_Start.Models;

//namespace MVC_EF_Start.Controllers
//{
//  public class DatabaseExampleController : Controller
//  {
//    public ApplicationDbContext dbContext;

//    public DatabaseExampleController(ApplicationDbContext context)
//    {
//      dbContext = context;
//    }

//    public IActionResult Index()
//    {
//      return View();
//    }

//    public async Task<ViewResult> DatabaseOperations()
//    {
//      // CREATE operation
//      Company MyCompany = new Company();
//      MyCompany.symbol = "MCOB";
//      MyCompany.name = "ISM";
//      MyCompany.date = "ISM";
//      MyCompany.isEnabled = true;
//      MyCompany.type = "ISM";
//      MyCompany.iexId = "ISM";

//      Quote MyCompanyQuote1 = new Quote();
//      //MyCompanyQuote1.EquityId = 123;
//      MyCompanyQuote1.date = "11-23-2018";
//      MyCompanyQuote1.open = 46.13F;
//      MyCompanyQuote1.high = 47.18F;
//      MyCompanyQuote1.low = 44.67F;
//      MyCompanyQuote1.close = 47.01F;
//      MyCompanyQuote1.volume = 37654000;
//      MyCompanyQuote1.unadjustedVolume = 37654000;
//      MyCompanyQuote1.change = 1.43F;
//      MyCompanyQuote1.changePercent = 0.03F;
//      MyCompanyQuote1.vwap = 9.76F;
//      MyCompanyQuote1.label = "Nov 23";
//      MyCompanyQuote1.changeOverTime = 0.56F;
//      MyCompanyQuote1.symbol = "MCOB";

//      Quote MyCompanyQuote2 = new Quote();
//      //MyCompanyQuote1.EquityId = 123;
//      MyCompanyQuote2.date = "11-23-2018";
//      MyCompanyQuote2.open = 46.13F;
//      MyCompanyQuote2.high = 47.18F;
//      MyCompanyQuote2.low = 44.67F;
//      MyCompanyQuote2.close = 47.01F;
//      MyCompanyQuote2.volume = 37654000;
//      MyCompanyQuote2.unadjustedVolume = 37654000;
//      MyCompanyQuote2.change = 1.43F;
//      MyCompanyQuote2.changePercent = 0.03F;
//      MyCompanyQuote2.vwap = 9.76F;
//      MyCompanyQuote2.label = "Nov 23";
//      MyCompanyQuote2.changeOverTime = 0.56F;
//      MyCompanyQuote2.symbol = "MCOB";

//      dbContext.Companies.Add(MyCompany);
//      dbContext.Quotes.Add(MyCompanyQuote1);
//      dbContext.Quotes.Add(MyCompanyQuote2);


//           // dbContext.Students.Add

//    //dbContext.SaveChanges();

//      //// READ operation
//      //Company CompanyRead1 = dbContext.Companies
//      //                        .Where(c => c.symbol == "MCOB")
//      //                        .First();

//      //Company CompanyRead2 = dbContext.Companies
//      //                        .Include(c => c.Quotes)
//      //                        .Where(c => c.symbol == "MCOB")
//      //                        .First();

//      //      // UPDATE operation
//      //      CompanyRead1.iexId = "MCOB";
//      //      dbContext.Companies.Update(CompanyRead1);
//      //      dbContext.SaveChanges();
//      //      await dbContext.SaveChangesAsync();

//            // DELETE operation
//            //dbContext.Companies.Remove(CompanyRead1);
//            //await dbContext.SaveChangesAsync();

//            Student S = new Student();
//            S.Name = "ABC";
//            S.age = 24;

//            Course C = new Course();
//            C.Name = "SDM";

//            Enrolment E = new Enrolment();
//            E.student = S;
//            E.course = C;

//            dbContext.Enrolments.Add(E);
//           // dbContext.SaveChanges();

//            //return View();

//            // Query 1. Aggregations
//            int StuCount = dbContext.Students.Count();
//            int CourseCount = dbContext.Courses.Count();

//            ViewData["student_count"] = StuCount;
//            ViewData["course_count"] = CourseCount;

//            // Query 2: Read all Students
//            // Features include which includes Orders associated with each Customer
//            Student[] StuRead1 = dbContext.Students
//                                  .Include(c => c.Name)
//                                  //.ThenInclude(o => o.)
//                                  .Take(100)
//                                  .ToArray();

//            return View(StuRead1);
//        }




//        public IActionResult PointQueryAction(int id)
//        {

//            // Query 3: Customer point query based on id in url
//            Student StuDetailRead = dbContext.Students
//                                    .Include(c => c.Name)
//                                    //.ThenInclude(o => o.Item)
//                                    .Where(c => c.Id == id)
//                                    .First();

//            return View(StuDetailRead);
//        }

//        public ViewResult LINQOperations()
//        {
//            Student Stu1 = dbContext.Students
//                                            .Where(s => s.age >= 23)
//                                             //.Select(s => s.Name);
//                                             .First();

//            Student Stu2 = dbContext.Students

//                                            .Where(c => c.Name.StartsWith("A"))
//                                            .First();

//            Course cou = dbContext.Courses
//                                    .Where(co => co.Name.StartsWith("D"))
//                                    .FirstOrDefault();

//            return View(Stu1);
//        }

//        //public ViewResult LINQOperations()
//        //{
//        //  Company CompanyRead1 = dbContext.Companies
//        //                                  .Where(c => c.symbol == "MCOB")
//        //                                  .First();

//        //  Company CompanyRead2 = dbContext.Companies
//        //                                  .Include(c => c.Id)
//        //                                  .Where(c => c.symbol == "MCOB")
//        //                                  .First();

//        //  Quote Quote1 = dbContext.Companies
//        //                          .Include(c => c.Quotes)
//        //                          .Where(c => c.symbol == "MCOB")
//        //                          .FirstOrDefault()
//        //                          .Quotes
//        //                          .FirstOrDefault();

//        //  return View();
//        //}

//    }
//}



using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_EF_Start.DataAccess;
using MVC_EF_Start.Models;

namespace MVC_EF_Start.Controllers
{
    public class DatabaseExampleController : Controller
    {
        // instantiation of the entity framework
        public ApplicationDbContext dbContext;

        // this is a constructor. has same name as class
        // sets connection of entity framework to dbcontext
        public DatabaseExampleController(ApplicationDbContext context)
        {
            dbContext = context;
        }

        public IActionResult Index()
        {
            Customer customer1 = new Customer();
            customer1.Name = "Jai";

            Customer customer2 = new Customer();
            customer2.Name = "Veeru";

            Item item1 = new Item();
            item1.ItemName = "Guns";

            Item item2 = new Item();
            item2.ItemName = "Coin";

            Order order1 = new Order();
            order1.Customer = customer1;
            order1.Item = item1;
            order1.TotalPaid = 8.23;

            Order order2 = new Order();
            order2.Customer = customer2;
            order2.Item = item2;
            order2.TotalPaid = 5.50;

            Order order3 = new Order();
            order3.Customer = customer2;
            order3.Item = item1;
            order3.TotalPaid = 5.34;

            dbContext.Customers.Add(customer1);
            dbContext.Customers.Add(customer2);

            dbContext.Items.Add(item1);
            dbContext.Items.Add(item2);

            dbContext.Orders.Add(order1);
            dbContext.Orders.Add(order2);
            dbContext.Orders.Add(order3);

            dbContext.SaveChanges();
            return View();
        }

        public IActionResult DatabaseOperations()
        {
            // Query 1. Aggregations
            int orderCount = dbContext.Orders.Count();
            int customerCount = dbContext.Customers.Count();

            ViewData["order_count"] = orderCount;
            ViewData["customer_count"] = customerCount;

            // Query 2: Read all customers
            // Features include which includes Orders associated with each Customer
            Customer[] CustomerRead1 = dbContext.Customers
                                  .Include(c => c.Orders)
                                  .ThenInclude(o => o.Item)
                                  .Take(100)
                                  .ToArray();

            return View(CustomerRead1);
        }


        public IActionResult PointQueryAction(int id)
        {

            // Query 3: Customer point query based on id in url
            Customer CustomerDetailRead = dbContext.Customers
                                    .Include(c => c.Orders)
                                    .ThenInclude(o => o.Item)
                                    .Where(c => c.Id == id)
                                    .First();

            return View(CustomerDetailRead);
        }
    }
}