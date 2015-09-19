using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMvc4FundamentalsPluralsight.DAL
{
    public int MyProperty { get; set; } interface IDepartmentDataSource
    {
        IQueryable<Employee> Employees{get;}
        IQueryable<Department> Departments{get;}
    }
}
