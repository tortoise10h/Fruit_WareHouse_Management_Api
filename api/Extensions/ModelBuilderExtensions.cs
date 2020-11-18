using api.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.AspNetCore.Identity;
using api.Common.Enums;

namespace api.Extensions
{
    public static class ModelBuilderExtensions
    {
        public static void ConfigDBTablesRelationship(this ModelBuilder modelBuilder)
        {
            /** [ProductCategory] and [Product] */
            modelBuilder.Entity<Product>()
                .HasOne<ProductCategory>(p => p.ProductCategory)
                .WithMany(pc => pc.Products)
                .HasForeignKey(p => p.ProductCategoryId)
                .OnDelete(DeleteBehavior.NoAction);

            /** [PurchaseProposalDetail] and [Product] */
            modelBuilder.Entity<PurchaseProposalDetail>()
                .HasOne<Product>(ppd => ppd.Product)
                .WithMany(p => p.PurchaseProposalDetails)
                .HasForeignKey(ppd => ppd.ProductId)
                .OnDelete(DeleteBehavior.NoAction);

            /** [PurchaseProposalDetail] and [PurchaseProposalForm] */
            modelBuilder.Entity<PurchaseProposalDetail>()
                .HasOne<PurchaseProposalForm>(ppd => ppd.PurchaseProposalForm)
                .WithMany(p => p.PurchaseProposalDetails)
                .HasForeignKey(ppd => ppd.PurchaseProposalFormId)
                .OnDelete(DeleteBehavior.NoAction);

            /** [ProductUnit] and [Product] */
            modelBuilder.Entity<ProductUnit>()
                .HasOne<Product>(pu => pu.Product)
                .WithMany(p => p.ProductUnits)
                .HasForeignKey(pu => pu.ProductId)
                .OnDelete(DeleteBehavior.NoAction);

            /** [Supplier] and [Product] */
            modelBuilder.Entity<SupplierProduct>()
                .HasKey(sp => new { sp.SupplierId, sp.ProductId });

            modelBuilder.Entity<SupplierProduct>()
                .HasOne<Supplier>(sp => sp.Supplier)
                .WithMany(s => s.SupplierProducts)
                .HasForeignKey(sp => sp.SupplierId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<SupplierProduct>()
                .HasOne<Product>(sp => sp.Product)
                .WithMany(p => p.SupplierProducts)
                .HasForeignKey(sp => sp.ProductId)
                .OnDelete(DeleteBehavior.NoAction);

            /** [InventoryRecordDetail] and [Product] */
            modelBuilder.Entity<InventoryRecordDetail>()
                .HasOne<Product>(ird => ird.Product)
                .WithMany(p => p.InventoryRecordDetails)
                .HasForeignKey(ird => ird.ProductId)
                .OnDelete(DeleteBehavior.NoAction);

            /** [InventoryRecordDetail] and [InventoryRecordForm] */
            modelBuilder.Entity<InventoryRecordDetail>()
                .HasOne<InventoryRecordForm>(ird => ird.InventoryRecordForm)
                .WithMany(irf => irf.InventoryRecordDetails)
                .HasForeignKey(ird => ird.InventoryRecordId)
                .OnDelete(DeleteBehavior.NoAction);
        }

        public static void ConfigTablesRequirements(this ModelBuilder modelBuilder)
        {
            /** ProductCategory */
            modelBuilder
                .Entity<ProductCategory>()
                .HasQueryFilter(pc => EF.Property<bool>(pc, "IsDeleted") == false);

            /** Product */
            modelBuilder
                .Entity<Product>()
                .HasQueryFilter(p => EF.Property<bool>(p, "IsDeleted") == false);

            /** PurchaeProposalForm */
            modelBuilder
                .Entity<PurchaseProposalForm>()
                .HasQueryFilter(ppf => EF.Property<bool>(ppf, "IsDeleted") == false);

            /** PurchaseProposalDetail */
            modelBuilder
                .Entity<PurchaseProposalDetail>()
                .HasQueryFilter(ppd => EF.Property<bool>(ppd, "IsDeleted") == false);

            /** GoodsReceivingNote */
            modelBuilder
                .Entity<GoodsReceivingNote>()
                .HasQueryFilter(ppd => EF.Property<bool>(ppd, "IsDeleted") == false);

            /** GoodsReceivingDetail */
            modelBuilder
                .Entity<GoodsReceivingDetail>()
                .HasQueryFilter(ppd => EF.Property<bool>(ppd, "IsDeleted") == false);

            /** Order */
            modelBuilder
                .Entity<Order>()
                .HasQueryFilter(o => EF.Property<bool>(o, "IsDeleted") == false);

            /** OrderDetail */
            modelBuilder
                .Entity<OrderDetail>()
                .HasQueryFilter(od => EF.Property<bool>(od, "IsDeleted") == false);
        }

        public static void Seed(this ModelBuilder modelBuilder)
        {
            /*------------------------------------
             |                                   |
             |       SEED USERS AND ROLES        |
             |                                   |
             |-----------------------------------| */
            string bossRoleId = "c2d4b743-d9da-443c-9f5a-c2682750c805";
            string adminRoleId = "b979036b-d165-4bea-b6b6-16b22a3f54dd";
            string superAdminRoleId = "cc2a0eb3-8736-441d-9130-5b421db3ac0e";
            string customerRoleId = "423e498c-fc67-4853-ac4f-f3cd91d32e87";
            string saleRoleId = "78c5228f-f600-4545-abcd-f4cc21d18e4c";
            string warehouseKeeperRoleId = "6665ddaa-72f9-4f90-a6b1-43eb68dea610";
            string warehouseKeeperManagerRoleId = "6b30cb05-12f7-46c2-b95f-8d783c1f9eb1";

            string adminId = "308da0db-e863-4814-8930-de3540e5406d";

            string superAdminId = "927e4f6a-62ed-4e13-b002-7e133eb47bbc";

            string bossId1 = "e7610feb-110c-47d0-9a88-1bfdc12742a4";
            string bossId2 = "e9012ef1-cd3c-49a1-8726-7f8f8aba9f98";

            string customer3Id = "08b84a20-7e7d-4353-bb53-74c79732beed";
            string customer4Id = "b6256340-7bd0-4373-8549-c6a08053396b";
            string customer5Id = "6f8ce951-2f66-4a9e-a4fa-7a14f85b54c6";
            string customer6Id = "a0c9e67b-d593-4a56-93cd-063ec5d5d035";
            string customer7Id = "fd4fd02a-238d-4efc-a187-14d205a841f0";

            string warehouseKeeperManagerId1 = "3b488e0f-eb92-4994-a555-cbe4ecdf3672";
            string warehouseKeeperManagerId2 = "52999f6b-a605-45b0-b98f-b8880fc46027";

            string warehouseKeeperId1 = "39b465e2-c398-494f-bb62-d1eb02aa5471";
            string warehouseKeeperId2 = "ce4b2f5c-1fb9-4fe1-945c-20eca474ce16";
            string warehouseKeeperId3 = "fd9a7449-e604-48c1-a638-c564e17c1bc0";

            string saleId1 = "57b2db13-1d08-48a4-adca-41d837bb8937";
            string saleId2 = "3a6a1f70-8f67-4f8a-b1f9-267e5d621edb";
            string saleId3 = "5ce20f05-c625-43fc-ae25-a7514e9520db";

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
                        Id = saleRoleId,
                        Name = "Sale",
                        NormalizedName = "sale"
                    },
                    new IdentityRole
                    {
                        Id = superAdminRoleId,
                        Name = "SuperAdmin",
                        NormalizedName = "superadmin"
                    },
                    new IdentityRole
                    {
                        Id = warehouseKeeperManagerRoleId,
                        Name = "WarehouseKeeperManager",
                        NormalizedName = "warehousekeepermanager"
                    },
                    new IdentityRole
                    {
                        Id = warehouseKeeperRoleId,
                        Name = "WarehouseKeeper",
                        NormalizedName = "warehousekeeper"
                    },
                    new IdentityRole
                    {
                        Id = customerRoleId,
                        Name = "Customer",
                        NormalizedName = "customer"
                    },
                    new IdentityRole
                    {
                        Id = bossRoleId,
                        Name = "Boss",
                        NormalizedName = "boss"
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
                        Id = bossId1,
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
                        Id = bossId2,
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
                        Id = warehouseKeeperManagerId1,
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
                        Id = warehouseKeeperManagerId2,
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
                        Id = warehouseKeeperId1,
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
                        Id = warehouseKeeperId2,
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
                        Id = warehouseKeeperId3,
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
                        Id = saleId1,
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
                        Id = saleId2,
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
                        Id = saleId3,
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
                        RoleId = bossRoleId,
                        UserId = bossId1
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = bossRoleId,
                        UserId = bossId2
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
                        RoleId = warehouseKeeperManagerRoleId,
                        UserId = warehouseKeeperManagerId1
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = warehouseKeeperManagerRoleId,
                        UserId = warehouseKeeperManagerId2
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = warehouseKeeperRoleId,
                        UserId = warehouseKeeperId1
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = warehouseKeeperRoleId,
                        UserId = warehouseKeeperId2
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = warehouseKeeperRoleId,
                        UserId = warehouseKeeperId3
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = saleRoleId,
                        UserId = saleId1
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = saleRoleId,
                        UserId = saleId2
                    },
                    new IdentityUserRole<string>
                    {
                        RoleId = saleRoleId,
                        UserId = saleId3
                    }
                );

            /*------------------------------------
             |                                   |
             | SEED PRODUCT AND PRODUCT CATEGORY |
             |                                   |
             |-----------------------------------| */
            int productCategoryId1 = 1;
            int productCategoryId2 = 2;

            modelBuilder.Entity<ProductCategory>()
               .HasData(
                   new ProductCategory
                   {
                       Id = productCategoryId1,
                       Name = "Trái cây Việt Nam"
                   },
                   new ProductCategory
                   {
                       Id = productCategoryId2,
                       Name = "Trái cây nhập khẩu"
                   }
                );

            modelBuilder.Entity<Product>()
                .HasData(
                    new Product
                    {
                        Id = 48,
                        Name = "Bơ Đăk Lăk",
                        Price = 90000,
                        ProductCategoryId = productCategoryId1,
                        DefaultUnit = "Kg",
                        MinQuantity = 0,
                        MaxQuantity = 1000,
                        PurchasePrice = 20000,
                        Quantity = 262,
                        Status = ProductStatus.Available,
                        SKU = "SP-TCVN-00048"
                    },
                    new Product
                    {
                        Id = 1,
                        Name = "Bòn Bon Thái",
                        Price = 25000,
                        ProductCategoryId = productCategoryId1,
                        DefaultUnit = "Kg",
                        MinQuantity = 0,
                        MaxQuantity = 1000,
                        PurchasePrice = 20000,
                        Quantity = 896,
                        Status = ProductStatus.Available,
                        SKU = "SP-TCVN-00001"
                    },
                    new Product
                    {
                        Id = 2,
                        Name = "Bưởi Đoan Hùng",
                        Price = 60000,
                        ProductCategoryId = productCategoryId1,
                        DefaultUnit = "Kg",
                        MinQuantity = 0,
                        MaxQuantity = 1000,
                        PurchasePrice = 20000,
                        Quantity = 259,
                        Status = ProductStatus.Available,
                        SKU = "SP-TCVN-00002"
                    },
                    new Product
                    {
                        Id = 3,
                        Name = "Cam Xã Đoài (Vinh, Nghệ An)",
                        Price = 85000,
                        ProductCategoryId = productCategoryId1,
                        DefaultUnit = "Kg",
                        MinQuantity = 0,
                        MaxQuantity = 1000,
                        PurchasePrice = 20000,
                        Quantity = 251,
                        Status = ProductStatus.Available,
                        SKU = "SP-TCVN-00003"
                    },
                    new Product
                    {
                        Id = 4,
                        Name = "Cam xoàn Lai Vung",
                        Price = 65000,
                        ProductCategoryId = productCategoryId1,
                        DefaultUnit = "Kg",
                        MinQuantity = 0,
                        MaxQuantity = 1000,
                        PurchasePrice = 20000,
                        Quantity = 979,
                        Status = ProductStatus.Available,
                        SKU = "SP-TCVN-00004"
                    },
                    new Product
                    {
                        Id = 5,
                        Name = "Chanh dây",
                        Price = 47000,
                        ProductCategoryId = productCategoryId1,
                        DefaultUnit = "Kg",
                        MinQuantity = 0,
                        MaxQuantity = 1000,
                        PurchasePrice = 20000,
                        Quantity = 6,
                        Status = ProductStatus.Available,
                        SKU = "SP-TCVN-00005"
                    },
                    new Product
                    {
                        Id = 6,
                        Name = "Chôm chôm nhãn",
                        Price = 64000,
                        ProductCategoryId = productCategoryId1,
                        DefaultUnit = "Kg",
                        MinQuantity = 0,
                        MaxQuantity = 1000,
                        PurchasePrice = 20000,
                        Quantity = 311,
                        Status = ProductStatus.Available,
                        SKU = "SP-TCVN-00006"
                    },
                    new Product
                    {
                        Id = 7,
                        Name = "Chôm chôm Thái",
                        Price = 19000,
                        ProductCategoryId = productCategoryId1,
                        DefaultUnit = "Kg",
                        MinQuantity = 0,
                        MaxQuantity = 1000,
                        PurchasePrice = 20000,
                        Quantity = 900,
                        Status = ProductStatus.Available,
                        SKU = "SP-TCVN-00007"
                    },
                    new Product
                    {
                        Id = 8,
                        Name = "Chuối cau lửa",
                        Price = 41000,
                        ProductCategoryId = productCategoryId1,
                        DefaultUnit = "Kg",
                        MinQuantity = 0,
                        MaxQuantity = 1000,
                        PurchasePrice = 20000,
                        Quantity = 21,
                        Status = ProductStatus.Available,
                        SKU = "SP-TCVN-00008"
                    },
                    new Product
                    {
                        Id = 9,
                        Name = "Chuối già hương",
                        Price = 15000,
                        ProductCategoryId = productCategoryId1,
                        DefaultUnit = "Kg",
                        MinQuantity = 0,
                        MaxQuantity = 1000,
                        PurchasePrice = 20000,
                        Quantity = 298,
                        Status = ProductStatus.Available,
                        SKU = "SP-TCVN-00009"
                    },
                    new Product
                    {
                        Id = 10,
                        Name = "Chuối sứ",
                        Price = 15000,
                        ProductCategoryId = productCategoryId1,
                        DefaultUnit = "Kg",
                        MinQuantity = 0,
                        MaxQuantity = 1000,
                        PurchasePrice = 20000,
                        Quantity = 592,
                        Status = ProductStatus.Available,
                        SKU = "SP-TCVN-00010"
                    },
                    new Product
                    {
                        Id = 11,
                        Name = "Dâu tây Đà Lạt",
                        Price = 96000,
                        ProductCategoryId = productCategoryId1,
                        DefaultUnit = "Kg",
                        MinQuantity = 0,
                        MaxQuantity = 1000,
                        PurchasePrice = 20000,
                        Quantity = 171,
                        Status = ProductStatus.Available,
                        SKU = "SP-TCVN-00011"
                    },
                    new Product
                    {
                        Id = 12,
                        Name = "Đu đủ vàng",
                        Price = 27000,
                        ProductCategoryId = productCategoryId1,
                        DefaultUnit = "Kg",
                        MinQuantity = 0,
                        MaxQuantity = 1000,
                        PurchasePrice = 20000,
                        Quantity = 543,
                        Status = ProductStatus.Available,
                        SKU = "SP-TCVN-00012"
                    },
                    new Product
                    {
                        Id = 13,
                        Name = "Dưa đỏ không hạt",
                        Price = 15000,
                        ProductCategoryId = productCategoryId1,
                        DefaultUnit = "Kg",
                        MinQuantity = 0,
                        MaxQuantity = 1000,
                        PurchasePrice = 20000,
                        Quantity = 253,
                        Status = ProductStatus.Available,
                        SKU = "SP-TCVN-00013"
                    },
                    new Product
                    {
                        Id = 14,
                        Name = "Dưa hấu hắc mỹ nhân",
                        Price = 35000,
                        ProductCategoryId = productCategoryId1,
                        DefaultUnit = "Kg",
                        MinQuantity = 0,
                        MaxQuantity = 1000,
                        PurchasePrice = 20000,
                        Quantity = 324,
                        Status = ProductStatus.Available,
                        SKU = "SP-TCVN-00014"
                    },
                    new Product
                    {
                        Id = 15,
                        Name = "Dưa lê trắng",
                        Price = 63000,
                        ProductCategoryId = productCategoryId1,
                        DefaultUnit = "Kg",
                        MinQuantity = 0,
                        MaxQuantity = 1000,
                        PurchasePrice = 20000,
                        Quantity = 743,
                        Status = ProductStatus.Available,
                        SKU = "SP-TCVN-00015"
                    },
                    new Product
                    {
                        Id = 16,
                        Name = "Dưa lưới giống Nhật",
                        Price = 345000,
                        ProductCategoryId = productCategoryId1,
                        DefaultUnit = "Kg",
                        MinQuantity = 0,
                        MaxQuantity = 1000,
                        PurchasePrice = 20000,
                        Quantity = 811,
                        Status = ProductStatus.Available,
                        SKU = "SP-TCVN-00016"
                    },
                    new Product
                    {
                        Id = 17,
                        Name = "Dưa lưới ruột đỏ",
                        Price = 57000,
                        ProductCategoryId = productCategoryId1,
                        DefaultUnit = "Kg",
                        MinQuantity = 0,
                        MaxQuantity = 1000,
                        PurchasePrice = 20000,
                        Quantity = 105,
                        Status = ProductStatus.Available,
                        SKU = "SP-TCVN-00017"
                    },
                    new Product
                    {
                        Id = 18,
                        Name = "Dưa lưới vàng",
                        Price = 81000,
                        ProductCategoryId = productCategoryId1,
                        DefaultUnit = "Kg",
                        MinQuantity = 0,
                        MaxQuantity = 1000,
                        PurchasePrice = 20000,
                        Quantity = 495,
                        Status = ProductStatus.Available,
                        SKU = "SP-TCVN-00018"
                    },
                    new Product
                    {
                        Id = 19,
                        Name = "Dứa Việt Nam",
                        Price = 57000,
                        ProductCategoryId = productCategoryId1,
                        DefaultUnit = "Kg",
                        MinQuantity = 0,
                        MaxQuantity = 1000,
                        PurchasePrice = 20000,
                        Quantity = 322,
                        Status = ProductStatus.Available,
                        SKU = "SP-TCVN-00019"
                    },
                    new Product
                    {
                        Id = 20,
                        Name = "Dừa xiêm Bến Tre",
                        Price = 20000,
                        ProductCategoryId = productCategoryId1,
                        DefaultUnit = "Kg",
                        MinQuantity = 0,
                        MaxQuantity = 1000,
                        PurchasePrice = 20000,
                        Quantity = 759,
                        Status = ProductStatus.Available,
                        SKU = "SP-TCVN-00020"
                    },
                    new Product
                    {
                        Id = 21,
                        Name = "Hồng chín Đà Lạt",
                        Price = 86000,
                        ProductCategoryId = productCategoryId1,
                        DefaultUnit = "Kg",
                        MinQuantity = 0,
                        MaxQuantity = 1000,
                        PurchasePrice = 20000,
                        Quantity = 42,
                        Status = ProductStatus.Available,
                        SKU = "SP-TCVN-00021"
                    },
                    new Product
                    {
                        Id = 22,
                        Name = "Hồng giòn Đà Lạt",
                        Price = 34000,
                        ProductCategoryId = productCategoryId1,
                        DefaultUnit = "Kg",
                        MinQuantity = 0,
                        MaxQuantity = 1000,
                        PurchasePrice = 20000,
                        Quantity = 728,
                        Status = ProductStatus.Available,
                        SKU = "SP-TCVN-00022"
                    },
                    new Product
                    {
                        Id = 23,
                        Name = "Hồng xiêm Tiền Giang",
                        Price = 42000,
                        ProductCategoryId = productCategoryId1,
                        DefaultUnit = "Kg",
                        MinQuantity = 0,
                        MaxQuantity = 1000,
                        PurchasePrice = 20000,
                        Quantity = 420,
                        Status = ProductStatus.Available,
                        SKU = "SP-TCVN-00023"
                    },
                    new Product
                    {
                        Id = 24,
                        Name = "Cherry New Zealand Gift Box 2kg",
                        Price = 1600000,
                        ProductCategoryId = productCategoryId2,
                        DefaultUnit = "Kg",
                        MinQuantity = 0,
                        MaxQuantity = 1000,
                        PurchasePrice = 20000,
                        Quantity = 369,
                        Status = ProductStatus.Available,
                        SKU = "SP-TCNK-00024"
                    },
                    new Product
                    {
                        Id = 25,
                        Name = "Kiwi ruột đỏ NewZealand",
                        Price = 66000,
                        ProductCategoryId = productCategoryId2,
                        DefaultUnit = "Kg",
                        MinQuantity = 0,
                        MaxQuantity = 1000,
                        PurchasePrice = 20000,
                        Quantity = 969,
                        Status = ProductStatus.Available,
                        SKU = "SP-TCNK-00025"
                    },
                    new Product
                    {
                        Id = 26,
                        Name = "Kiwi Vàng New Zealand",
                        Price = 235000,
                        ProductCategoryId = productCategoryId2,
                        DefaultUnit = "Kg",
                        MinQuantity = 0,
                        MaxQuantity = 1000,
                        PurchasePrice = 20000,
                        Quantity = 818,
                        Status = ProductStatus.Available,
                        SKU = "SP-TCNK-00026"
                    },
                    new Product
                    {
                        Id = 27,
                        Name = "Kiwi Xanh New Zealand",
                        Price = 135000,
                        ProductCategoryId = productCategoryId2,
                        DefaultUnit = "Kg",
                        MinQuantity = 0,
                        MaxQuantity = 1000,
                        PurchasePrice = 20000,
                        Quantity = 655,
                        Status = ProductStatus.Available,
                        SKU = "SP-TCNK-00027"
                    },
                    new Product
                    {
                        Id = 28,
                        Name = "Táo Breeze NewZealand",
                        Price = 83000,
                        ProductCategoryId = productCategoryId2,
                        DefaultUnit = "Kg",
                        MinQuantity = 0,
                        MaxQuantity = 1000,
                        PurchasePrice = 20000,
                        Quantity = 852,
                        Status = ProductStatus.Available,
                        SKU = "SP-TCNK-00028"
                    },
                    new Product
                    {
                        Id = 29,
                        Name = "Táo Envy New Zealand",
                        Price = 235000,
                        ProductCategoryId = productCategoryId2,
                        DefaultUnit = "Kg",
                        MinQuantity = 0,
                        MaxQuantity = 1000,
                        PurchasePrice = 20000,
                        Quantity = 509,
                        Status = ProductStatus.Available,
                        SKU = "SP-TCNK-00029"
                    },
                    new Product
                    {
                        Id = 30,
                        Name = "Táo Jazz New Zealand",
                        Price = 110000,
                        ProductCategoryId = productCategoryId2,
                        DefaultUnit = "Kg",
                        MinQuantity = 0,
                        MaxQuantity = 1000,
                        PurchasePrice = 20000,
                        Quantity = 904,
                        Status = ProductStatus.Available,
                        SKU = "SP-TCNK-00030"
                    },
                    new Product
                    {
                        Id = 31,
                        Name = "Táo Kiku (Size lớn) - Táo Newzealand",
                        Price = 119000,
                        ProductCategoryId = productCategoryId2,
                        DefaultUnit = "Kg",
                        MinQuantity = 0,
                        MaxQuantity = 1000,
                        PurchasePrice = 20000,
                        Quantity = 29,
                        Status = ProductStatus.Available,
                        SKU = "SP-TCNK-00031"
                    },
                    new Product
                    {
                        Id = 32,
                        Name = "Táo Rockit Newzealand",
                        Price = 155000,
                        ProductCategoryId = productCategoryId2,
                        DefaultUnit = "Kg",
                        MinQuantity = 0,
                        MaxQuantity = 1000,
                        PurchasePrice = 20000,
                        Quantity = 306,
                        Status = ProductStatus.Available,
                        SKU = "SP-TCNK-00032"
                    },
                    new Product
                    {
                        Id = 33,
                        Name = "Táo Royal Gala Newzealand",
                        Price = 99000,
                        ProductCategoryId = productCategoryId2,
                        DefaultUnit = "Kg",
                        MinQuantity = 0,
                        MaxQuantity = 1000,
                        PurchasePrice = 20000,
                        Quantity = 976,
                        Status = ProductStatus.Available,
                        SKU = "SP-TCNK-00033"
                    },
                    new Product
                    {
                        Id = 34,
                        Name = "Táo xanh Newzealand",
                        Price = 110000,
                        ProductCategoryId = productCategoryId2,
                        DefaultUnit = "Kg",
                        MinQuantity = 0,
                        MaxQuantity = 1000,
                        PurchasePrice = 20000,
                        Quantity = 726,
                        Status = ProductStatus.Available,
                        SKU = "SP-TCNK-00034"
                    },
                    new Product
                    {
                        Id = 35,
                        Name = "Chanh vàng Sunkist Mỹ",
                        Price = 51250,
                        ProductCategoryId = productCategoryId2,
                        DefaultUnit = "Kg",
                        MinQuantity = 0,
                        MaxQuantity = 1000,
                        PurchasePrice = 20000,
                        Quantity = 998,
                        Status = ProductStatus.Available,
                        SKU = "SP-TCNK-00035"
                    },
                    new Product
                    {
                        Id = 36,
                        Name = "Cherry đỏ Canada",
                        Price = 519000,
                        ProductCategoryId = productCategoryId2,
                        DefaultUnit = "Kg",
                        MinQuantity = 0,
                        MaxQuantity = 1000,
                        PurchasePrice = 20000,
                        Quantity = 675,
                        Status = ProductStatus.Available,
                        SKU = "SP-TCNK-00036"
                    },
                    new Product
                    {
                        Id = 37,
                        Name = "Cherry Đỏ Mỹ",
                        Price = 490000,
                        ProductCategoryId = productCategoryId2,
                        DefaultUnit = "Kg",
                        MinQuantity = 0,
                        MaxQuantity = 1000,
                        PurchasePrice = 20000,
                        Quantity = 389,
                        Status = ProductStatus.Available,
                        SKU = "SP-TCNK-00037"
                    },
                    new Product
                    {
                        Id = 38,
                        Name = "Hồng giòn Mỹ",
                        Price = 409000,
                        ProductCategoryId = productCategoryId2,
                        DefaultUnit = "Kg",
                        MinQuantity = 0,
                        MaxQuantity = 1000,
                        PurchasePrice = 20000,
                        Quantity = 813,
                        Status = ProductStatus.Available,
                        SKU = "SP-TCNK-00038"
                    },
                    new Product
                    {
                        Id = 39,
                        Name = "Lựu Mỹ",
                        Price = 399000,
                        ProductCategoryId = productCategoryId2,
                        DefaultUnit = "Kg",
                        MinQuantity = 0,
                        MaxQuantity = 1000,
                        PurchasePrice = 20000,
                        Quantity = 885,
                        Status = ProductStatus.Available,
                        SKU = "SP-TCNK-00039"
                    },
                    new Product
                    {
                        Id = 40,
                        Name = "Mận đen Mỹ",
                        Price = 410000,
                        ProductCategoryId = productCategoryId2,
                        DefaultUnit = "Kg",
                        MinQuantity = 0,
                        MaxQuantity = 1000,
                        PurchasePrice = 20000,
                        Quantity = 672,
                        Status = ProductStatus.Available,
                        SKU = "SP-TCNK-00040"
                    },
                    new Product
                    {
                        Id = 41,
                        Name = "Mận đỏ Red Plum Mỹ",
                        Price = 420000,
                        ProductCategoryId = productCategoryId2,
                        DefaultUnit = "Kg",
                        MinQuantity = 0,
                        MaxQuantity = 1000,
                        PurchasePrice = 20000,
                        Quantity = 485,
                        Status = ProductStatus.Available,
                        SKU = "SP-TCNK-00041"
                    },
                    new Product
                    {
                        Id = 42,
                        Name = "Mận khủng long (tím) Mỹ",
                        Price = 46000,
                        ProductCategoryId = productCategoryId2,
                        DefaultUnit = "Kg",
                        MinQuantity = 0,
                        MaxQuantity = 1000,
                        PurchasePrice = 20000,
                        Quantity = 802,
                        Status = ProductStatus.Available,
                        SKU = "SP-TCNK-00042"
                    },
                    new Product
                    {
                        Id = 43,
                        Name = "Mận khủng long (xanh) Mỹ",
                        Price = 420000,
                        ProductCategoryId = productCategoryId2,
                        DefaultUnit = "Kg",
                        MinQuantity = 0,
                        MaxQuantity = 1000,
                        PurchasePrice = 20000,
                        Quantity = 764,
                        Status = ProductStatus.Available,
                        SKU = "SP-TCNK-00043"
                    },
                    new Product
                    {
                        Id = 44,
                        Name = "Mận khủng long đen Mỹ",
                        Price = 109000,
                        ProductCategoryId = productCategoryId2,
                        DefaultUnit = "Kg",
                        MinQuantity = 0,
                        MaxQuantity = 1000,
                        PurchasePrice = 20000,
                        Quantity = 439,
                        Status = ProductStatus.Available,
                        SKU = "SP-TCNK-00044"
                    },
                    new Product
                    {
                        Id = 45,
                        Name = "Mận khủng long đỏ Mỹ",
                        Price = 94000,
                        ProductCategoryId = productCategoryId2,
                        DefaultUnit = "Kg",
                        MinQuantity = 0,
                        MaxQuantity = 1000,
                        PurchasePrice = 20000,
                        Quantity = 21,
                        Status = ProductStatus.Available,
                        SKU = "SP-TCNK-00045"
                    },
                    new Product
                    {
                        Id = 46,
                        Name = "Mận khủng long Farmily Tree Mỹ",
                        Price = 32000,
                        ProductCategoryId = productCategoryId2,
                        DefaultUnit = "Kg",
                        MinQuantity = 0,
                        MaxQuantity = 1000,
                        PurchasePrice = 20000,
                        Quantity = 819,
                        Status = ProductStatus.Available,
                        SKU = "SP-TCNK-00046"
                    }
                );
        }
    }
}