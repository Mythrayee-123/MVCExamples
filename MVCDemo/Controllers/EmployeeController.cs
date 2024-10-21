using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            List<Employee> obj = new List<Employee>()
            {
                new Employee(){ Empid=101,Empname="Sharmila",Empsal=10000,Empaddress="Chennai"},
                new Employee(){ Empid=102,Empname="Sam",Empsal=50000,Empaddress="Texas"},
                new Employee(){ Empid=103,Empname="Daisy",Empsal=30000,Empaddress="bombay"},
                new Employee(){ Empid=104,Empname="Wyatt",Empsal=20000,Empaddress="Bangalore"},
                new Employee(){ Empid=105,Empname="Kim",Empsal=70000,Empaddress="California"},
            };
            return View(obj);
        }
    }
}