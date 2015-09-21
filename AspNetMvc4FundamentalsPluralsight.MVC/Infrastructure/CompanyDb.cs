using AspNetMvc4FundamentalsPluralsight.DAL;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AspNetMvc4FundamentalsPluralsight.MVC.Infrastructure
{
    public class CompanyDb : DbContext, ICompanyDataSource
    {
        public CompanyDb()
            : base("DefaultConnection")// connectionstring name define in your web.config
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        IQueryable<Employee> ICompanyDataSource.Employees
        {
            get { return Employees; }
        }

        IQueryable<Department> ICompanyDataSource.Departments
        {
            get { return Departments; }
        }

        public void Save()
        {
            SaveChanges();
        }
    }
}