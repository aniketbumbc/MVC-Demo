using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace Demo_MVC.Models
{

    [Table("employee")]
    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public string gender { get; set; }
        public string city { get; set; }
    }
}