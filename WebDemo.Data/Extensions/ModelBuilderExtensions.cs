using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebDemo.Data.Entities;
using WebDemo.Data.StatusE;

namespace WebDemo.Data.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AppConfig>().HasData(
               new AppConfig() { Key = "HomeTitle", Value = "This is home page" },
               new AppConfig() { Key = "HomeKeyword", Value = "This is Keyword" },
               new AppConfig() { Key = "HomeDescription", Value = "This is Description" });


            modelBuilder.Entity<Language>().HasData(
                new Language() { Id = "vi-VN", Name = "Tiếng Việt", IsDefault = true },
                new Language() { Id = "en-US", Name = "English", IsDefault = false });


            modelBuilder.Entity<Contact>().HasData(
                new Contact() { Id = 1, Name = "Dũng", Position = "Web Admin", Email = "luongvietdung1212@gmail.com", PhoneNumber = 123456789, Status = Status.Active });


            modelBuilder.Entity<Category>().HasData(
              new Category()
              {
                  Id = 1, ParentId = null, IsShowOnHome = true, Status = Status.Active
              },
              new Category()
              {
                   Id = 2, ParentId = null, IsShowOnHome = true, Status = Status.Active
              },
              new Category()
              {
                   Id = 3, ParentId = null, IsShowOnHome = true, Status = Status.Active
              });


            modelBuilder.Entity<CategoryTranslation>().HasData(
              new CategoryTranslation() 
              { 
                  Id = 1, CategoryId = 1, Name = "Đồ ăn vặt", Description = "Đồ ăn vặt nhà làm", LanguageId = "vi-VN"
              },
              new CategoryTranslation() 
              { 
                  Id = 2, CategoryId = 1, Name = "Snacks", Description = "Snacks Homemade", LanguageId = "en-US"
              },
              new CategoryTranslation() 
              { 
                  Id = 3, CategoryId = 2, Name = "Cơm Trưa", Description = "Cơm Trưa nhà làm", LanguageId = "vi-VN"
              },
              new CategoryTranslation() 
              { 
                  Id = 4, CategoryId = 2, Name = "Lunch", Description = "Lunch Homemade", LanguageId = "en-US"
              },
              new CategoryTranslation() 
              { 
                  Id = 5, CategoryId = 3, Name = "Thức uống", Description = "Thức uống nhà làm", LanguageId = "vi-VN" 
              },
              new CategoryTranslation() 
              { 
                  Id = 6, CategoryId = 3, Name = "Drinks", Description = "Drinks Homemade", LanguageId = "en-US" 
              });


            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 1, 
                    Producer = "chef Hằng",
                    Price = 50000,
                    Stock = 0,
                    Tag = "ăn vặt, snacks, gà, chicken, khô gà, dried chicken",
                    ViewCount = 0,
                    OrdersCount = 0,
                    DateCreated = DateTime.Now,
                    Status = Status.Active
                },
                new Product()
                {
                    Id = 2,
                    Producer = "chef Giáp",
                    Price = 40000,
                    Stock = 0,
                    Tag = "cơm Trưa, lunch, gà, chicken, cơm gà cháy tỏi, chicken rice with garlic sauce",
                    ViewCount = 0,
                    OrdersCount = 0,
                    DateCreated = DateTime.Now,
                    Status = Status.Active
                },
                new Product()
                {
                    Id = 3,
                    Producer = "chef Hạ",
                    Price = 10000,
                    Stock = 0,
                    Tag = "thức uống, drinks, sữa đậu nành, soymilk",
                    ViewCount = 0,
                    OrdersCount = 0,
                    DateCreated = DateTime.Now,
                    Status = Status.Active
                });


            modelBuilder.Entity<ProductTranslation>().HasData(
                new ProductTranslation()
                {
                    Id = 1,
                    ProductId = 1,
                    Name = "Khô gà lá chanh",
                    Description = "Khô gà lá chanh được tẩm ướp đậm đà, sấy khô kì công bằng lò hiện đại, mang một hương vị riêng biệt mà không nơi nào có được.",
                    LanguageId = "vi-VN"
                },
                new ProductTranslation()
                {
                    Id = 2,
                    ProductId = 1,
                    Name = "Dried chicken with lemon leaves",
                    Description = "Dried chicken with lemon leaves is deeply marinated, dried in a modern oven, bringing a unique flavor.",
                    LanguageId = "en-US"
                },
                new ProductTranslation()
                {
                    Id = 3,
                    ProductId = 2,
                    Name = "Cơm gà cháy tỏi",
                    Description = "Cơm gà cháy tỏi được ướp đậm đà mang lại hương vị thơm ngon kích thích vị giác.",
                    LanguageId = "vi-VN"
                },
                new ProductTranslation()
                {
                    Id = 4,
                    ProductId = 2,
                    Name = "Chicken rice with garlic sauce",
                    Description = "Chicken rice with garlic sauce is deeply marinated and brings a delicious flavor that stimulates the taste buds.",
                    LanguageId = "en-US"
                },
                new ProductTranslation()
                {
                    Id = 5,
                    ProductId = 3,
                    Name = "Sữa đậu nành",
                    Description = "Sữa đậu nành thơm ngon nhà làm.",
                    LanguageId = "vi-VN"
                },
                new ProductTranslation()
                {
                    Id = 6,
                    ProductId = 3,
                    Name = "Soymilk",
                    Description = "Soymilk Homemade is delicious.",
                    LanguageId = "en-US"
                });


            modelBuilder.Entity<ProductInCategory>().HasData(
                new ProductInCategory() 
                { 
                    ProductId = 1, 
                    CategoryId = 1 
                },
                new ProductInCategory()
                {
                    ProductId = 2,
                    CategoryId = 2
                },
                new ProductInCategory()
                {
                    ProductId = 3,
                    CategoryId = 3
                });



            var roleId1 = new Guid("8D04DCE2-969A-435D-BBA4-DF3F325983DC");
            var roleId2 = new Guid("BEA0FA40-F9C9-4F04-85F7-165E527FBDE5");
            var adminId1 = new Guid("391F352A-C96E-4813-8220-E68C36F5A587");
            var adminId2 = new Guid("69BD714F-9576-45BA-B5B7-F00649BE00DE");

            modelBuilder.Entity<AppRole>().HasData(
                new AppRole
                {
                    Id = roleId1,
                    Name = "admin",
                    NormalizedName = "admin",
                    Description = "Administrator role"
                },
                new AppRole
                {
                    Id = roleId2,
                    Name = "user",
                    NormalizedName = "user",
                    Description = "User role"
                });


            var hasher = new PasswordHasher<AppUser>();

            modelBuilder.Entity<AppUser>().HasData(
                new AppUser
                {
                    Id = adminId1,
                    UserName = "admin",
                    NormalizedUserName = "admin",
                    Email = "luongvietdung1212@gmail.com",
                    NormalizedEmail = "luongvietdung1212@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Admin@123"),
                    SecurityStamp = string.Empty,
                    FirstName = "Dung",
                    LastName = "Luong",
                    DateOfBirthday = new DateTime(1997, 12, 12)
                },
                new AppUser
                {
                    Id = adminId2,
                    UserName = "test1",
                    NormalizedUserName = "test1",
                    Email = "test1@gmail.com",
                    NormalizedEmail = "test1@gmail.com@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Test1@123"),
                    SecurityStamp = string.Empty,
                    FirstName = "Dung",
                    LastName = "Luong",
                    DateOfBirthday = new DateTime(1997, 12, 12)
                });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(
                new IdentityUserRole<Guid>
                {
                    RoleId = roleId1,
                    UserId = adminId1
                },
                new IdentityUserRole<Guid>
                {
                    RoleId = roleId2,
                    UserId = adminId2
                });

        }
    }
}
