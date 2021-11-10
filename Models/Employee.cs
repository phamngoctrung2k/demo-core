using System;
using System.ComponentModel.DataAnnotations;

namespace demo.Models
{
    public class Employee
    {
        [Key]
        public string EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public string PPhoneNumber { get; set; }

    }
}