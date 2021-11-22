using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace demo.Models
{
    
    public class Teacher : Person
    {
        public string University { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

    }
}