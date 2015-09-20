using AspNetMvc4FundamentalsPluralsight.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMvc4FundamentalsPluralsight.MVC.Controllers
{
    public class DepartmentController : Controller
    {
        private readonly ICompanyDataSource _db;

        public DepartmentController(ICompanyDataSource db)
        {
            _db = db;
        }

        // GET: Department
        public ActionResult Details(int id)
        {
            var model = _db.Departments.Single(x => x.DepartmentId == id);

            return View(model);
        }
    }
}