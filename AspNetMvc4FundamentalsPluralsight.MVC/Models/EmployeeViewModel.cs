using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AspNetMvc4FundamentalsPluralsight.MVC.Models
{
    public class EmployeeViewModel
    {
        [Required]
        [HiddenInput]
        public int DepartmentId { get; set; }

        [Required]
        public string Name { get; set; }

        [DataType(DataType.Date)]

        public DateTime HireDate { get; set; }
    }
}