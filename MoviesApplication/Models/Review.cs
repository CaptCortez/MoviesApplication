using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MoviesApplication.Models
{
    public class Review
    {
        public int ID { get; set; }
        public DateTime DatePosted { get; set; }
        public double Rating { get; set; }
        public string Body { get; set; }
        public User Reviewer { get; set; }
    }
}
