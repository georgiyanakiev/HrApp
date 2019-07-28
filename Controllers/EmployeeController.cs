using HrApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;



namespace HrApp.Controllers
{
    public class EmployeeController : Controller
    {
        // GET: Employee
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ViewAll()
        {
            return View(GetAllEmployee());
        }

        IEnumerable<Employee> GetAllEmployee()
        {
            using (DBModel db = new DBModel())
            {
                return db.Employee.ToList<Employee>();
            }
        }
        public ActionResult AddOrEdit(int id = 0)
        {
            Employee emp = new Employee();
            return View(emp);
        }
        [HttpPost]
        public ActionResult AddOrEdit()
        {
            return View();
        }
    }
}