using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace demo.Models
{
    [Table("ChuNhiem")]
    public class ChuNhiem
    {
        [Key]
        public string PersonID { get; set; }     
        public string TeacherName { get; set; }
        
        
        public DateTime NgaySinh { get; set; }
        public Person Person{ get; set; }

    }
}