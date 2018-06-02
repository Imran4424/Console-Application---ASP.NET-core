using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApplication
{
    class SchoolContext : DbContext
    {
        public DbSet<Student> students { get; set; }
        public DbSet<Course>  courses { get; set; }
    }
}
