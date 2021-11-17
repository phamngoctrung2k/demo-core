using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using demo.Models;
namespace demo.Data{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext (DbContextOptions<ApplicationDBContext> options)
            : base(options)
        {
        }

        public DbSet<demo.Models.Movie> Movie { get; set; }

        public DbSet<demo.Models.Product> Product { get; set; }

        public DbSet<demo.Models.Student> Student { get; set; }

        public DbSet<demo.Models.Person> Person { get; set; }

        public DbSet<demo.Models.Employee> Employee { get; set; }

        public DbSet<demo.Models.HoaDon> HoaDon { get; set; }
    }

}
    
