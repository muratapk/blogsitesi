using EntityLayer.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Concrete
{
  public class Context:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-5I2R27G\\SQLEXPRESS;Initial Catalog=blog;Integrated Security=True");

        }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Category> Categories { get; set; } 
        public DbSet<Comment> Comments { get; set; }    
        public DbSet<Contact> Contacts { get; set; }
        public DbSet<Writter> Writers { get; set; }
        public DbSet<About> Abouts { get; set; }


    }
}
