using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace MoviesRepo.Data
{
    public class MasterDbContext : DbContext
    {
        public MasterDbContext([NotNull] DbContextOptions options) : base(options)
        {
        }

        public DbSet<Movie> Movies { get; set; }

        public class Movie
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public string Director { get; set; }
            public int YearReleased { get; set; }
        }
        
    }
}
