using App.Web.Mvc.App.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace App.Web.Mvc.App.Data
{
    public class DbSeeder
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Category>().HasData(
                new Category {Id=1, CategoryName="Pizza"},
                new Category { Id=2, CategoryName="Makarna"}
                );

            modelBuilder.Entity<User>().HasData(
                new User { Id=1, UserName="Elif", Email="elif@gmail.com", Password="12345"},
                new User { Id=2, UserName ="Ayşe", Email ="ayse@gmail.com",Password="23456"}
                );
            modelBuilder.Entity<Post>().HasData(
                new Post { Id=1, PostTitle="Sağlıklı Yemekler", UserId=1},
                new Post { Id=2, PostTitle="Makarna Sosları", UserId=2}
                );
        }
    }
}
