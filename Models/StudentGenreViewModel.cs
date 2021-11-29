using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace demo.Models
{
    public class StudentGenreViewModel
    {
        public List<Student> Students { get; set; }
        public SelectList Address { get; set; }
        public string StudentAddress { get; set; }
        public string SearchString { get; set; }
    }
}