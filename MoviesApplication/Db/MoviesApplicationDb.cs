using MoviesApplication.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MoviesApplication.Db
{
    public class MoviesApplicationDb : DbContext
    {
        public MoviesApplicationDb() : base("DefaultConnection")
        { }

        public DbSet<Movie> Movies { get; set; }
        public DbSet<Review> Reviews { get; set; }
    }
}