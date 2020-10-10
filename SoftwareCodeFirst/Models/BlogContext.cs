using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SoftwareCodeFirst.Models
{
    public class BlogContext : DbContext
    {
        public BlogContext():base("BlogPostsDb")
        { 
        
        }
        public DbSet<BlogPost> BlogPosts { get; set; }
    }
}