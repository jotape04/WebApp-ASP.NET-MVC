using Curso_Udemy_ASP.NET_MVC.Models.Domain;
using Microsoft.EntityFrameworkCore;

namespace Curso_Udemy_ASP.NET_MVC.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<BlogPost> BlogPosts { get; set; }
        public DbSet<Tag> Tags { get; set; }
    }
}
