using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MoviesApplication.Models
{
    public class Movie
    {
        public int ID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DatePosted { get; set; }
        public ICollection<Review> Reviews { get; set; }
    }
}