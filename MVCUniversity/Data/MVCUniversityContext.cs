using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MVCUniversity.Models;

namespace MVCUniversity.Data
{
    public class MVCUniversityContext : DbContext
    {
        public MVCUniversityContext (DbContextOptions<MVCUniversityContext> options)
            : base(options)
        {
        }

        public DbSet<MVCUniversity.Models.Course> Course { get; set; }
    }
}
