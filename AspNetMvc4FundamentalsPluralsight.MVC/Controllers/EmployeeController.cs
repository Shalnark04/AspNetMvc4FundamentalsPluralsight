using AspNetMvc4FundamentalsPluralsight.DAL;
using AspNetMvc4FundamentalsPluralsight.MVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMvc4FundamentalsPluralsight.MVC.Controllers
{
    public class EmployeeController : Controller
    {
        private ICompanyDataSource _db;

        public EmployeeController(ICompanyDataSource db)
        {
            _db = db;
        }

        [Authorize(Roles="Admin")]
        public ActionResult Create(int departmentId)
        {
            var vm = new EmployeeViewModel();
            
            return View(vm);
        }

        [Authorize(Roles = "Admin")]
        [ValidateAntiForgeryToken]
        [HttpPost]
        public ActionResult Create(EmployeeViewModel vm)
        {
            if(ModelState.IsValid)
            {
                var dpt = _db.Departments.Single(x => x.DepartmentId == vm.DepartmentId);
                var newEmployee = new Employee();
                newEmployee.Name = vm.Name;
                newEmployee.HireDate = vm.HireDate;
                dpt.Employees.Add(newEmployee);

                _db.Save();

                return RedirectToAction("Details", "Department", new { id = vm.DepartmentId });
            }
            return View(vm);
        }
    }
}