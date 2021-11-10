using System;
using System.ComponentModel.DataAnnotations;

namespace demo.Models
{
    public class Person
    {
        [Key]
        public string PersonID { get; set; }
        public string PersonName { get; set; }

    }
}