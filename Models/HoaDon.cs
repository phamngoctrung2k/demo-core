using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace demo.Models
{
    [Table("HoaDon")]
    public class HoaDon
    {
        [Key]
        public int HoaDonID { get; set; }
        public string PersonID { get; set; }
        [DataType(DataType.Date)]
        public DateTime? NgayTao { get; set; }
        public Person Person{ get; set; }

    }
}