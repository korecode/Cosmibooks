using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Cosmibooks.Data.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;

namespace Cosmibooks.Data
{
    public class AppDBContent : IdentityDbContext<User>
    {

        public AppDBContent(DbContextOptions<AppDBContent> options) : base(options)
        {
            Database.EnsureCreated();
        }
        
        public DbSet<Book> Book { get; set;}

        

        public DbSet<Category> Category { get; set;}
        
    }
}
