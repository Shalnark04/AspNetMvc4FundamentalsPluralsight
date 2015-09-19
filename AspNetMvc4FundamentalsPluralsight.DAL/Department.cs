using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AspNetMvc4FundamentalsPluralsight.DAL
{
    public class Department
    {
        public virtual int DepartmentId { get; set; }
        public virtual string Name { get; set; }
        public virtual IEnumerable<Employee> Employees { get; set; }
    }
}
