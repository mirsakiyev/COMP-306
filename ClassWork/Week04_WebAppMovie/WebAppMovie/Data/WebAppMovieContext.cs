using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebAppMovie.Models
{
    public class WebAppMovieContext : DbContext
    {
        public WebAppMovieContext (DbContextOptions<WebAppMovieContext> options)
            : base(options)
        {
        }

        public DbSet<WebAppMovie.Models.Movie> Movie { get; set; }
    }
}
