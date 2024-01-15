using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ContosoUniversity.Models;

namespace ContosoUniversity.Data
{
    public class ContosoUniversityContext : DbContext
    {
        public ContosoUniversityContext (DbContextOptions<ContosoUniversityContext> options)
            : base(options)
        {
        }

        public DbSet<ContosoUniversity.Models.Student> Student { get; set; } = default!;

        public DbSet<ContosoUniversity.Models.Course> Course { get; set; } = default!;

        public DbSet<ContosoUniversity.Models.Enrollment> Enrollment { get; set; } = default!;
    }
}
