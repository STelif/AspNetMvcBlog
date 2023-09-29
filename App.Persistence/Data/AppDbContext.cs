using App.Web.Mvc.App.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;

namespace App.Web.Mvc.App.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext>options):base(options)
        {        
        }
        public DbSet<Category> Category { get; set; }
        public DbSet<CategoryPost> CategoryPost { get; set; }
        public DbSet<Page> Page { get; set; }
        public DbSet<Post> Post { get; set; }
        public DbSet<PostComment> PostComment { get; set; }
        public DbSet<PostImage> PostImage { get; set; }
        public DbSet<Setting> Setting { get; set; }
        public DbSet<User> User { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            DbSeeder.Seed(modelBuilder);
        }


    }
}
