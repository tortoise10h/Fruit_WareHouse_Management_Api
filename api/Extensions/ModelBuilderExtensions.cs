using api.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.AspNetCore.Identity;

namespace api.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void ConfigDBTablesRelationship(this ModelBuilder modelBuilder)
        {
        }

        public static void ConfigTablesRequirements(this ModelBuilder modelBuilder)
        {
        }

        public static void Seed(this ModelBuilder modelBuilder)
        {
            /*------------------------------------
             |                                   |
             |       SEED USERS AND ROLES        |
             |                                   |
             |-----------------------------------| */
            string adminRoleId = Guid.NewGuid().ToString();
            string superAdminRoleId = Guid.NewGuid().ToString();
            string customerRoleId = Guid.NewGuid().ToString();

            string adminId = Guid.NewGuid().ToString();
            string superAdminId = Guid.NewGuid().ToString();
            string customer1Id = Guid.NewGuid().ToString();
            string customer2Id = Guid.NewGuid().ToString();
            string customer3Id = Guid.NewGuid().ToString();
            string customer4Id = Guid.NewGuid().ToString();
            string customer5Id = Guid.NewGuid().ToString();
            string customer6Id = Guid.NewGuid().ToString();
            string customer7Id = Guid.NewGuid().ToString();
            string customer8Id = Guid.NewGuid().ToString();
            string customer9Id = Guid.NewGuid().ToString();
            string customer10Id = Guid.NewGuid().ToString();
            string customer11Id = Guid.NewGuid().ToString();
            string customer12Id = Guid.NewGuid().ToString();
            string customer13Id = Guid.NewGuid().ToString();
            string customer14Id = Guid.NewGuid().ToString();
            string customer15Id = Guid.NewGuid().ToString();

            modelBuilder.Entity<IdentityRole>()
                .HasData(
                    new IdentityRole
                    {
                        Id = adminRoleId,
                        Name = "Admin",
                        NormalizedName = "admin"
                    },
                    new IdentityRole
                    {
                        Id = superAdminRoleId,
                        Name = "SuperAdmin",
                        NormalizedName = "superadmin"
                    },
                    new IdentityRole
                    {
                        Id = customerRoleId,
                        Name = "Customer",
                        NormalizedName = "customer"
                    }
                );

            var hasher = new PasswordHasher<ApplicationUser>();
            modelBuilder.Entity<ApplicationUser>()
                .HasData(
                    new ApplicationUser
                    {
                        Id = superAdminId,
                        FirstName = "Super Admin",
                        LastName = "Lil",
                        UserName = "lilsuperadmin@gmail.com",
                        NormalizedUserName = "lilsuperadmin@gmail.com".ToUpper(),
                        Email = "lilsuperadmin@gmail.com",
                        NormalizedEmail = "lilsuperadmin@gmail.com".ToUpper(),
                        EmailConfirmed = true,
                        PasswordHash = hasher.HashPassword(null, "12345678"),
                        SecurityStamp = string.Empty
                    },
                    new ApplicationUser
                    {
                        Id = adminId,
                        FirstName = "Admin",
                        LastName = "Yung",
                        UserName = "yungadmin@gmail.com",
                        NormalizedUserName = "yungadmin@gmail.com".ToUpper(),
                        Email = "yungadmin@gmail.com",
                        NormalizedEmail = "yungadmin@gmail.com".ToUpper(),
                        EmailConfirmed = true,
                        PasswordHash = hasher.HashPassword(null, "12345678"),
                        SecurityStamp = string.Empty
                    },
                    new ApplicationUser
                    {
                        Id = customer1Id,
                        FirstName = "Loan",
                        LastName = "Trần Kiều",
                        UserName = "trankieuloan@gmail.com",
                        NormalizedUserName = "trankieuloan@gmail.com".ToUpper(),
                        Email = "trankieuloan@gmail.com",
                        NormalizedEmail = "trankieuloan@gmail.com".ToUpper(),
                        EmailConfirmed = true,
                        PasswordHash = hasher.HashPassword(null, "12345678"),
                        SecurityStamp = string.Empty
                    },
                    new ApplicationUser
                    {
                        Id = customer2Id,
                        FirstName = "Sơn",
                        LastName = "Phạm Vĩnh",
                        UserName = "phamvinhson@gmail.com",
                        NormalizedUserName = "phamvinhson@gmail.com".ToUpper(),
                        Email = "phamvinhson@gmail.com",
                        NormalizedEmail = "phamvinhson@gmail.com".ToUpper(),
                        EmailConfirmed = true,
                        PasswordHash = hasher.HashPassword(null, "12345678"),
                        SecurityStamp = string.Empty
                    },
                    new ApplicationUser
                    {
                        Id = customer3Id,
                        FirstName = "Hiếu",
                        LastName = "Nguyễn Trung",
                        UserName = "nguyentrunghieu@gmail.com",
                        NormalizedUserName = "nguyentrunghieu@gmail.com".ToUpper(),
                        Email = "nguyentrunghieu@gmail.com",
                        NormalizedEmail = "nguyentrunghieu@gmail.com".ToUpper(),
                        EmailConfirmed = true,
                        PasswordHash = hasher.HashPassword(null, "12345678"),
                        SecurityStamp = string.Empty
                    },
                    new ApplicationUser
                    {
                        Id = customer4Id,
                        FirstName = "Lộc",
                        LastName = "Nguyễn Như",
                        UserName = "nguyennhuloc@gmail.com",
                        NormalizedUserName = "nguyennhuloc@gmail.com".ToUpper(),
                        Email = "nguyennhuloc@gmail.com",
                        NormalizedEmail = "nguyennhuloc@gmail.com".ToUpper(),
                        EmailConfirmed = true,
                        PasswordHash = hasher.HashPassword(null, "12345678"),
                        SecurityStamp = string.Empty
                    },
                    new ApplicationUser
                    {
                        Id = customer5Id,
                        FirstName = "Anh",
                        LastName = "Cao Thị Vân",
                        UserName = "caothivananh@gmail.com",
                        NormalizedUserName = "caothivananh@gmail.com".ToUpper(),
                        Email = "caothivananh@gmail.com",
                        NormalizedEmail = "caothivananh@gmail.com".ToUpper(),
                        EmailConfirmed = true,
                        PasswordHash = hasher.HashPassword(null, "12345678"),
                        SecurityStamp = string.Empty
                    },
                    new ApplicationUser
                    {
                        Id = customer6Id,
                        FirstName = "Nguyên",
                        LastName = "Trần Thảo",
                        UserName = "tranthaonguyen@gmail.com",
                        NormalizedUserName = "tranthaonguyen@gmail.com".ToUpper(),
                        Email = "tranthaonguyen@gmail.com",
                        NormalizedEmail = "tranthaonguyen@gmail.com".ToUpper(),
                        EmailConfirmed = true,
                        PasswordHash = hasher.HashPassword(null, "12345678"),
                        SecurityStamp = string.Empty
                    },
                    new ApplicationUser
                    {
                        Id = customer7Id,
                        FirstName = "Anh",
                        LastName = "Trương Thị Trâm",
                        UserName = "truongthitramanh@gmail.com",
                        NormalizedUserName = "truongthitramanh@gmail.com".ToUpper(),
                        Email = "truongthitramanh@gmail.com",
                        NormalizedEmail = "truongthitramanh@gmail.com".ToUpper(),
                        EmailConfirmed = true,
                        PasswordHash = hasher.HashPassword(null, "12345678"),
                        SecurityStamp = string.Empty
                    },
                    new ApplicationUser
                    {
                        Id = customer8Id,
                        FirstName = "Quát",
                        LastName = "Cao Bá",
                        UserName = "caobaquat@gmail.com",
                        NormalizedUserName = "caobaquat@gmail.com".ToUpper(),
                        Email = "caobaquat@gmail.com",
                        NormalizedEmail = "caobaquat@gmail.com".ToUpper(),
                        EmailConfirmed = true,
                        PasswordHash = hasher.HashPassword(null, "12345678"),
                        SecurityStamp = string.Empty
                    },
                    new ApplicationUser
                    {
                        Id = customer9Id,
                        FirstName = "Thành",
                        LastName = "Huỳnh Trấn",
                        UserName = "huynhtranthanh@gmail.com",
                        NormalizedUserName = "huynhtranthanh@gmail.com".ToUpper(),
                        Email = "huynhtranthanh@gmail.com",
                        NormalizedEmail = "huynhtranthanh@gmail.com".ToUpper(),
                        EmailConfirmed = true,
                        PasswordHash = hasher.HashPassword(null, "12345678"),
                        SecurityStamp = string.Empty
                    },
                    new ApplicationUser
                    {
                        Id = customer10Id,
                        FirstName = "Long",
                        LastName = "Nguyễn Thành",
                        UserName = "nguyenthanhlong@gmail.com",
                        NormalizedUserName = "nguyenthanhlong@gmail.com".ToUpper(),
                        Email = "nguyenthanhlong@gmail.com",
                        NormalizedEmail = "nguyenthanhlong@gmail.com".ToUpper(),
                        EmailConfirmed = true,
                        PasswordHash = hasher.HashPassword(null, "12345678"),
                        SecurityStamp = string.Empty
                    },
                    new ApplicationUser
                    {
                        Id = customer11Id,
                        FirstName = "Hương",
                        LastName = "Hồ Xuân",
                        UserName = "hoxuanhuong@gmail.com",
                        NormalizedUserName = "hoxuanhuong@gmail.com".ToUpper(),
                        Email = "hoxuanhuong@gmail.com",
                        NormalizedEmail = "hoxuanhuong@gmail.com".ToUpper(),
                        EmailConfirmed = true,
                        PasswordHash = hasher.HashPassword(null, "12345678"),
                        SecurityStamp = string.Empty
                    },
                    new ApplicationUser
                    {
                        Id = customer12Id,
                        FirstName = "Huệ",
                        LastName = "Nguyễn",
                        UserName = "nguyenhue@gmail.com",
                        NormalizedUserName = "nguyenhue@gmail.com".ToUpper(),
                        Email = "nguyenhue@gmail.com",
                        NormalizedEmail = "nguyenhue@gmail.com".ToUpper(),
                        EmailConfirmed = true,
                        PasswordHash = hasher.HashPassword(null, "12345678"),
                        SecurityStamp = string.Empty
                    },
                    new ApplicationUser
                    {
                        Id = customer13Id,
                        FirstName = "Độ",
                        LastName = "Phùng Thanh",
                        UserName = "phungthanhdo@gmail.com",
                        NormalizedUserName = "phungthanhdo@gmail.com".ToUpper(),
                        Email = "phungthanhdo@gmail.com",
                        NormalizedEmail = "phungthanhdo@gmail.com".ToUpper(),
                        EmailConfirmed = true,
                        PasswordHash = hasher.HashPassword(null, "12345678"),
                        SecurityStamp = string.Empty
                    },
                    new ApplicationUser
                    {
                        Id = customer14Id,
                        FirstName = "Trung",
                        LastName = "Phan Tấn",
                        UserName = "phantantrung@gmail.com",
                        NormalizedUserName = "phantantrung@gmail.com".ToUpper(),
                        Email = "phantantrung@gmail.com",
                        NormalizedEmail = "phantantrung@gmail.com".ToUpper(),
                        EmailConfirmed = true,
                        PasswordHash = hasher.HashPassword(null, "12345678"),
                        SecurityStamp = string.Empty
                    },
                    new ApplicationUser
                    {
                        Id = customer15Id,
                        FirstName = "Tú",
                        LastName = "Trương Tuấn",
                        UserName = "truongtuantu@gmail.com",
                        NormalizedUserName = "truongtuantu@gmail.com".ToUpper(),
                        Email = "truongtuantu@gmail.com",
                        NormalizedEmail = "truongtuantu@gmail.com".ToUpper(),
                        EmailConfirmed = true,
                        PasswordHash = hasher.HashPassword(null, "12345678"),
                        SecurityStamp = string.Empty
                    }
                );

            modelBuilder.Entity<IdentityUserRole<string>>()
                .HasData(
                    new IdentityUserRole<string>
                    {
                        RoleId = adminRoleId,
                        UserId = adminId
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = superAdminRoleId,
                        UserId = superAdminId
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = customerRoleId,
                        UserId = customer1Id
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = customerRoleId,
                        UserId = customer2Id
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = customerRoleId,
                        UserId = customer3Id
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = customerRoleId,
                        UserId = customer4Id
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = customerRoleId,
                        UserId = customer5Id
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = customerRoleId,
                        UserId = customer6Id
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = customerRoleId,
                        UserId = customer7Id
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = customerRoleId,
                        UserId = customer8Id
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = customerRoleId,
                        UserId = customer9Id
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = customerRoleId,
                        UserId = customer10Id
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = customerRoleId,
                        UserId = customer11Id
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = customerRoleId,
                        UserId = customer12Id
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = customerRoleId,
                        UserId = customer13Id
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = customerRoleId,
                        UserId = customer14Id
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = customerRoleId,
                        UserId = customer15Id
                    }
                );
        }
    }
}