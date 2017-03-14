using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Demo_MVC.Models
{
    public class EmployeeContext:DbContext
    {
        public DbSet<Employee> Employess { get; set; }
    }
}