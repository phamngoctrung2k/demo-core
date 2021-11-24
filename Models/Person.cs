using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace demo.Models
{
    [Table("Person")]
    public class Person
    {
        [Key]
        [Required(ErrorMessage ="Khong dc de chong")]
        public string PersonID { get; set; }
        
        public string PersonCode {get; set; }
        public string FullName { get; set; }

    }
}