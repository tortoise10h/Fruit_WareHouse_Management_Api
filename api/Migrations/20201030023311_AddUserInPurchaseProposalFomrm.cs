using Microsoft.EntityFrameworkCore.Migrations;

namespace api.Migrations
{
    public partial class AddUserInPurchaseProposalFomrm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "0a12b251-c5f6-43b4-ab81-aac3c19af44b", "283ecfb4-91e7-46cd-a1f1-424af2a9aba8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "192955e8-f106-4c09-8120-99909e832d38", "a33a3023-5922-4780-a255-83ae5a3d0582" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "4e3b0737-2682-41ed-850e-e28f58da3053", "13303781-d0c4-489a-8682-70d5411a3fd5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "55867d78-8673-4a4f-9b71-3989b1b2b55c", "a33a3023-5922-4780-a255-83ae5a3d0582" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "73fa172e-baa9-4235-bcfe-a826158b07e8", "084793b4-e989-43bd-895b-ce4026e202ea" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "8535a0b2-70b4-44a4-afa0-684efd6b0614", "8d2ce0f3-8e0a-449a-9a46-8b939f0ea7b5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "8ccf5253-33cc-45c0-a391-5564ef3c0835", "4452f1a8-85ad-4170-8170-83991d8cca4e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "96e18e74-c26a-4fd8-aa3e-27fc9fa77800", "8d2ce0f3-8e0a-449a-9a46-8b939f0ea7b5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ad7c5c61-b274-49aa-ace8-acb6c855ea86", "4452f1a8-85ad-4170-8170-83991d8cca4e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ba8fbf13-728b-4e3f-929d-be8022dc6424", "a33a3023-5922-4780-a255-83ae5a3d0582" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "bb9b07ae-7fc7-4cec-bc48-c32efe6ad51b", "4452f1a8-85ad-4170-8170-83991d8cca4e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "bedf9245-9a30-4a7a-8f7b-d9082f522aa4", "8d2ce0f3-8e0a-449a-9a46-8b939f0ea7b5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "c00dee5e-bc85-4074-8741-7ee4c66862e6", "8d2ce0f3-8e0a-449a-9a46-8b939f0ea7b5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "c5a91de8-95b3-4ed9-9bd9-073bfcac7dd8", "084793b4-e989-43bd-895b-ce4026e202ea" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "e25e6448-071f-478d-91c3-82552d98bb10", "40f9608d-94bd-4ee6-bf65-ae722e121dde" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "e3917b48-6d07-4e92-8c64-701e0bdb0e10", "8d2ce0f3-8e0a-449a-9a46-8b939f0ea7b5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "e47c4183-74a0-4660-b247-aa2de384d70b", "13303781-d0c4-489a-8682-70d5411a3fd5" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "084793b4-e989-43bd-895b-ce4026e202ea");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "13303781-d0c4-489a-8682-70d5411a3fd5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "283ecfb4-91e7-46cd-a1f1-424af2a9aba8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "40f9608d-94bd-4ee6-bf65-ae722e121dde");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4452f1a8-85ad-4170-8170-83991d8cca4e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d2ce0f3-8e0a-449a-9a46-8b939f0ea7b5");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a33a3023-5922-4780-a255-83ae5a3d0582");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0a12b251-c5f6-43b4-ab81-aac3c19af44b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "192955e8-f106-4c09-8120-99909e832d38");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4e3b0737-2682-41ed-850e-e28f58da3053");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55867d78-8673-4a4f-9b71-3989b1b2b55c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73fa172e-baa9-4235-bcfe-a826158b07e8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8535a0b2-70b4-44a4-afa0-684efd6b0614");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8ccf5253-33cc-45c0-a391-5564ef3c0835");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96e18e74-c26a-4fd8-aa3e-27fc9fa77800");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ad7c5c61-b274-49aa-ace8-acb6c855ea86");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ba8fbf13-728b-4e3f-929d-be8022dc6424");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bb9b07ae-7fc7-4cec-bc48-c32efe6ad51b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bedf9245-9a30-4a7a-8f7b-d9082f522aa4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c00dee5e-bc85-4074-8741-7ee4c66862e6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c5a91de8-95b3-4ed9-9bd9-073bfcac7dd8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e25e6448-071f-478d-91c3-82552d98bb10");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e3917b48-6d07-4e92-8c64-701e0bdb0e10");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e47c4183-74a0-4660-b247-aa2de384d70b");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "PurchaseProposalForms",
                nullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d0cdb3a2-0198-422e-8386-2f832f0a0670", "0f34f98f-1218-47ff-be7d-57b39140febf", "Admin", "admin" },
                    { "287041ab-c9cb-4f96-ae2f-b5fd44349683", "57747f1b-f18c-4e3d-928c-4a046a244163", "Sale", "sale" },
                    { "d21ec932-48b1-45ff-a4ae-f282b6fecaeb", "4de91b0d-d7d6-4feb-8a65-6855eb12baf0", "SuperAdmin", "superadmin" },
                    { "68fc8a61-7c39-4dd9-9b71-69e7b3828deb", "323f8d07-cc45-4536-a8fc-1f6ee21a877a", "WarehouseKeeperManager", "warehousekeepermanager" },
                    { "32e3b759-f48e-403a-9b16-a7050fadcbc8", "f53463fd-6780-4fa6-87ae-74c247a099ef", "WarehouseKeeper", "warehousekeeper" },
                    { "3e3b009c-799c-4a4c-86a5-d90daf8563ce", "05715d08-65a8-4a68-8b5f-ac3b208b6b8b", "Customer", "customer" },
                    { "08458f61-e622-4753-aca8-cf0a87608a19", "b564c7bd-eaa8-4baa-8d09-79f4488b8fac", "Boss", "boss" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "e4348093-1864-44c5-90fa-32a35a2073ec", 0, "5d4a0fb8-47f6-4cda-8df1-226665a3b854", "phungthanhdo@gmail.com", true, "Độ", "Phùng Thanh", false, null, "PHUNGTHANHDO@GMAIL.COM", "PHUNGTHANHDO@GMAIL.COM", "AQAAAAEAACcQAAAAEL/uX4zwT5UwBcRL5l0bZg/nU/TS56ikI7fsGBmcE3GZvKZziEFvQnTVQ6qiF30pqg==", null, false, "", false, "phungthanhdo@gmail.com" },
                    { "5b250552-61d2-45e2-902b-70cdf6b58e7a", 0, "4d00678d-0557-43a2-8703-36962e0e0864", "nguyenhue@gmail.com", true, "Huệ", "Nguyễn", false, null, "NGUYENHUE@GMAIL.COM", "NGUYENHUE@GMAIL.COM", "AQAAAAEAACcQAAAAEFp87XccXA+N4jc3zZV3P/AG2Mo0RK2C5b5Notm0kJB9lawhlnuOSipRGEBXME1BPA==", null, false, "", false, "nguyenhue@gmail.com" },
                    { "387216d3-d69c-4802-be9a-f876ae42f5df", 0, "37140ad3-4ce6-4316-95b9-4758a225779c", "hoxuanhuong@gmail.com", true, "Hương", "Hồ Xuân", false, null, "HOXUANHUONG@GMAIL.COM", "HOXUANHUONG@GMAIL.COM", "AQAAAAEAACcQAAAAEEJXTRUqbRA55j+edw+G/jK9EkilB1d3VHdjydDUZ3P1C2cUeE6d/icTm9FGGP3kBg==", null, false, "", false, "hoxuanhuong@gmail.com" },
                    { "d66d3245-a3cd-489c-9d3e-e515a4a25f67", 0, "381649df-2e79-48bf-b183-86cef1bf2292", "nguyenthanhlong@gmail.com", true, "Long", "Nguyễn Thành", false, null, "NGUYENTHANHLONG@GMAIL.COM", "NGUYENTHANHLONG@GMAIL.COM", "AQAAAAEAACcQAAAAEBzpKCCCeDVrCGwgA6J5ItRF+1WfELsilS0Ibzzp95oOLcilsAcxqa/Ghs4fJXKcVw==", null, false, "", false, "nguyenthanhlong@gmail.com" },
                    { "947b2125-a09e-4122-b0b2-19d154019a61", 0, "310924e1-02ac-4dc6-9ecc-0949dd528036", "huynhtranthanh@gmail.com", true, "Thành", "Huỳnh Trấn", false, null, "HUYNHTRANTHANH@GMAIL.COM", "HUYNHTRANTHANH@GMAIL.COM", "AQAAAAEAACcQAAAAENjvtoNMMYmygflYVrA/91k9PRfOVl/5U3U/lCles7ZhiyVLBNaYGWLgQFVShp6Rig==", null, false, "", false, "huynhtranthanh@gmail.com" },
                    { "97a944c9-6591-41d8-b0c5-231ba340e323", 0, "1b59cf32-1dc5-4cbd-a1b2-8ced1ba78a24", "caobaquat@gmail.com", true, "Quát", "Cao Bá", false, null, "CAOBAQUAT@GMAIL.COM", "CAOBAQUAT@GMAIL.COM", "AQAAAAEAACcQAAAAEHpTcWSIKIggPP1h+eTSJBi5a8byB5r0k6o9jIQPSS6cXakJz7fE3j3CEfXiHb/WNA==", null, false, "", false, "caobaquat@gmail.com" },
                    { "996cb637-0c0d-4449-b20a-f845e967968f", 0, "357858e3-c71a-44ae-ab6c-4d7a5d73af91", "truongthitramanh@gmail.com", true, "Anh", "Trương Thị Trâm", false, null, "TRUONGTHITRAMANH@GMAIL.COM", "TRUONGTHITRAMANH@GMAIL.COM", "AQAAAAEAACcQAAAAEOUpy57sZQTtzC1mFSyUGBos9tGXWdvtZXOxFotwlMa7JXOfiRf4Tc3lGZ1Cd29umQ==", null, false, "", false, "truongthitramanh@gmail.com" },
                    { "18f6f8d1-93fd-4f05-9ecb-6e807dda4115", 0, "25701c60-a460-49c7-89ab-e833175f3a37", "nguyentrunghieu@gmail.com", true, "Hiếu", "Nguyễn Trung", false, null, "NGUYENTRUNGHIEU@GMAIL.COM", "NGUYENTRUNGHIEU@GMAIL.COM", "AQAAAAEAACcQAAAAEF1CfgXV+nyjLfuIwAR+D0vwY27fAuFN+n7/DMuSbrcy8bWviFfzQ0LvImoOntajoA==", null, false, "", false, "nguyentrunghieu@gmail.com" },
                    { "aab88e65-ea84-41d1-8c29-66a269795ee5", 0, "1af7f3a2-0017-4435-83f5-44e47f405af4", "caothivananh@gmail.com", true, "Anh", "Cao Thị Vân", false, null, "CAOTHIVANANH@GMAIL.COM", "CAOTHIVANANH@GMAIL.COM", "AQAAAAEAACcQAAAAEJT75Crezs+ySw3WFGhVmIg+OukGjScBiTaswesRsY9uHZeng/EmiZSoXJrVAvFQOA==", null, false, "", false, "caothivananh@gmail.com" },
                    { "1df6771c-1fb8-4bbe-bfc3-92f703859b90", 0, "833d346d-dfb9-4343-912b-c4b15e2c6be1", "nguyennhuloc@gmail.com", true, "Lộc", "Nguyễn Như", false, null, "NGUYENNHULOC@GMAIL.COM", "NGUYENNHULOC@GMAIL.COM", "AQAAAAEAACcQAAAAEHyCVBHLxzKmbk2NEUk8EFBevaGLuOIkN9xO4NFkGd51ydLeocyUsqvyVs/fqTKMIQ==", null, false, "", false, "nguyennhuloc@gmail.com" },
                    { "c95c6655-ca3f-4971-ad8f-74b43918f4f4", 0, "c7fe0814-7f80-4239-983d-b24e1bf4d6e6", "phantantrung@gmail.com", true, "Trung", "Phan Tấn", false, null, "PHANTANTRUNG@GMAIL.COM", "PHANTANTRUNG@GMAIL.COM", "AQAAAAEAACcQAAAAEL0AokTTqeXPp0E8k1jhpiwXoqHN7iEWa5/j8Lx9MmKdfBXdCLv0CrZKWNu+5C2wyw==", null, false, "", false, "phantantrung@gmail.com" },
                    { "7780aea3-27e8-4a8c-a633-48cb266126df", 0, "5c78c5e7-f7b6-40c8-8d6a-df53813b1612", "phamvinhson@gmail.com", true, "Sơn", "Phạm Vĩnh", false, null, "PHAMVINHSON@GMAIL.COM", "PHAMVINHSON@GMAIL.COM", "AQAAAAEAACcQAAAAEB3G0gLD81i3fvljNHRtVh5MTkv8GEFfaX58XkshSEAxjbqEMxbu1S9BgqDzxkgKnQ==", null, false, "", false, "phamvinhson@gmail.com" },
                    { "e28aba9e-fe53-460e-bb34-c2027eb5004d", 0, "a0bc2677-df68-492b-9459-1bf6ba5109d0", "trankieuloan@gmail.com", true, "Loan", "Trần Kiều", false, null, "TRANKIEULOAN@GMAIL.COM", "TRANKIEULOAN@GMAIL.COM", "AQAAAAEAACcQAAAAECUJDhHpT1605eN12nHNfZECyEwAq53pHJSsRFAdSM3wbIqyzC2Oy1vbRNF9hZKjVw==", null, false, "", false, "trankieuloan@gmail.com" },
                    { "13b00890-d1f9-45b0-a2db-79c8e58f927f", 0, "e26c5854-6740-44a1-b5a9-6a6c31c84d2e", "yungadmin@gmail.com", true, "Admin", "Yung", false, null, "YUNGADMIN@GMAIL.COM", "YUNGADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEGZvZ62Ax0CA20skFAqmBBONPg/gQ15aNm6/uKrYgni0mHVSzZX9Lnyoc1Z75eMl0Q==", null, false, "", false, "yungadmin@gmail.com" },
                    { "8d0a4d6d-2ecc-4f0d-a5c6-d9ab6198a861", 0, "f8fa39b6-2f41-499e-80ed-dfe7378e2029", "lilsuperadmin@gmail.com", true, "Super Admin", "Lil", false, null, "LILSUPERADMIN@GMAIL.COM", "LILSUPERADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEJRfpdHzXlPC3gUlCHAlFjwVqcYmFGxPTKq9oiHx91C4NReMKpoootfFCdfGk1hD0w==", null, false, "", false, "lilsuperadmin@gmail.com" },
                    { "405bfeac-8e9a-4037-9706-0ede0504ee6b", 0, "5b36ff5c-3798-4825-8971-be349a457f23", "tranthaonguyen@gmail.com", true, "Nguyên", "Trần Thảo", false, null, "TRANTHAONGUYEN@GMAIL.COM", "TRANTHAONGUYEN@GMAIL.COM", "AQAAAAEAACcQAAAAEDHM+JT2w3XzLb/CpL23C7q1idyAghsoCsGhmapG34oCRJYRU8fo9TFD7FRjWYLQkg==", null, false, "", false, "tranthaonguyen@gmail.com" },
                    { "b2b480b1-49df-4b5a-a077-b85f3c400d13", 0, "d480cead-e4cf-4db5-a553-19ddb2ac7d2d", "truongtuantu@gmail.com", true, "Tú", "Trương Tuấn", false, null, "TRUONGTUANTU@GMAIL.COM", "TRUONGTUANTU@GMAIL.COM", "AQAAAAEAACcQAAAAEHrAr9xtZ7osCTV9wCzX8WNzyAjvwwc5PwG5dpZrpXmNWU0NsgApMuBHWlDiF1oMew==", null, false, "", false, "truongtuantu@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "8d0a4d6d-2ecc-4f0d-a5c6-d9ab6198a861", "d21ec932-48b1-45ff-a4ae-f282b6fecaeb" },
                    { "e4348093-1864-44c5-90fa-32a35a2073ec", "287041ab-c9cb-4f96-ae2f-b5fd44349683" },
                    { "5b250552-61d2-45e2-902b-70cdf6b58e7a", "32e3b759-f48e-403a-9b16-a7050fadcbc8" },
                    { "387216d3-d69c-4802-be9a-f876ae42f5df", "32e3b759-f48e-403a-9b16-a7050fadcbc8" },
                    { "d66d3245-a3cd-489c-9d3e-e515a4a25f67", "32e3b759-f48e-403a-9b16-a7050fadcbc8" },
                    { "947b2125-a09e-4122-b0b2-19d154019a61", "68fc8a61-7c39-4dd9-9b71-69e7b3828deb" },
                    { "97a944c9-6591-41d8-b0c5-231ba340e323", "68fc8a61-7c39-4dd9-9b71-69e7b3828deb" },
                    { "c95c6655-ca3f-4971-ad8f-74b43918f4f4", "287041ab-c9cb-4f96-ae2f-b5fd44349683" },
                    { "996cb637-0c0d-4449-b20a-f845e967968f", "3e3b009c-799c-4a4c-86a5-d90daf8563ce" },
                    { "aab88e65-ea84-41d1-8c29-66a269795ee5", "3e3b009c-799c-4a4c-86a5-d90daf8563ce" },
                    { "1df6771c-1fb8-4bbe-bfc3-92f703859b90", "3e3b009c-799c-4a4c-86a5-d90daf8563ce" },
                    { "18f6f8d1-93fd-4f05-9ecb-6e807dda4115", "3e3b009c-799c-4a4c-86a5-d90daf8563ce" },
                    { "7780aea3-27e8-4a8c-a633-48cb266126df", "08458f61-e622-4753-aca8-cf0a87608a19" },
                    { "e28aba9e-fe53-460e-bb34-c2027eb5004d", "08458f61-e622-4753-aca8-cf0a87608a19" },
                    { "13b00890-d1f9-45b0-a2db-79c8e58f927f", "d0cdb3a2-0198-422e-8386-2f832f0a0670" },
                    { "405bfeac-8e9a-4037-9706-0ede0504ee6b", "3e3b009c-799c-4a4c-86a5-d90daf8563ce" },
                    { "b2b480b1-49df-4b5a-a077-b85f3c400d13", "287041ab-c9cb-4f96-ae2f-b5fd44349683" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseProposalForms_UserId",
                table: "PurchaseProposalForms",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_PurchaseProposalForms_AspNetUsers_UserId",
                table: "PurchaseProposalForms",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_PurchaseProposalForms_AspNetUsers_UserId",
                table: "PurchaseProposalForms");

            migrationBuilder.DropIndex(
                name: "IX_PurchaseProposalForms_UserId",
                table: "PurchaseProposalForms");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "13b00890-d1f9-45b0-a2db-79c8e58f927f", "d0cdb3a2-0198-422e-8386-2f832f0a0670" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "18f6f8d1-93fd-4f05-9ecb-6e807dda4115", "3e3b009c-799c-4a4c-86a5-d90daf8563ce" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "1df6771c-1fb8-4bbe-bfc3-92f703859b90", "3e3b009c-799c-4a4c-86a5-d90daf8563ce" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "387216d3-d69c-4802-be9a-f876ae42f5df", "32e3b759-f48e-403a-9b16-a7050fadcbc8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "405bfeac-8e9a-4037-9706-0ede0504ee6b", "3e3b009c-799c-4a4c-86a5-d90daf8563ce" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "5b250552-61d2-45e2-902b-70cdf6b58e7a", "32e3b759-f48e-403a-9b16-a7050fadcbc8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "7780aea3-27e8-4a8c-a633-48cb266126df", "08458f61-e622-4753-aca8-cf0a87608a19" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "8d0a4d6d-2ecc-4f0d-a5c6-d9ab6198a861", "d21ec932-48b1-45ff-a4ae-f282b6fecaeb" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "947b2125-a09e-4122-b0b2-19d154019a61", "68fc8a61-7c39-4dd9-9b71-69e7b3828deb" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "97a944c9-6591-41d8-b0c5-231ba340e323", "68fc8a61-7c39-4dd9-9b71-69e7b3828deb" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "996cb637-0c0d-4449-b20a-f845e967968f", "3e3b009c-799c-4a4c-86a5-d90daf8563ce" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "aab88e65-ea84-41d1-8c29-66a269795ee5", "3e3b009c-799c-4a4c-86a5-d90daf8563ce" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "b2b480b1-49df-4b5a-a077-b85f3c400d13", "287041ab-c9cb-4f96-ae2f-b5fd44349683" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "c95c6655-ca3f-4971-ad8f-74b43918f4f4", "287041ab-c9cb-4f96-ae2f-b5fd44349683" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "d66d3245-a3cd-489c-9d3e-e515a4a25f67", "32e3b759-f48e-403a-9b16-a7050fadcbc8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "e28aba9e-fe53-460e-bb34-c2027eb5004d", "08458f61-e622-4753-aca8-cf0a87608a19" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "e4348093-1864-44c5-90fa-32a35a2073ec", "287041ab-c9cb-4f96-ae2f-b5fd44349683" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "08458f61-e622-4753-aca8-cf0a87608a19");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "287041ab-c9cb-4f96-ae2f-b5fd44349683");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32e3b759-f48e-403a-9b16-a7050fadcbc8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e3b009c-799c-4a4c-86a5-d90daf8563ce");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "68fc8a61-7c39-4dd9-9b71-69e7b3828deb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d0cdb3a2-0198-422e-8386-2f832f0a0670");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d21ec932-48b1-45ff-a4ae-f282b6fecaeb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13b00890-d1f9-45b0-a2db-79c8e58f927f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18f6f8d1-93fd-4f05-9ecb-6e807dda4115");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1df6771c-1fb8-4bbe-bfc3-92f703859b90");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "387216d3-d69c-4802-be9a-f876ae42f5df");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "405bfeac-8e9a-4037-9706-0ede0504ee6b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b250552-61d2-45e2-902b-70cdf6b58e7a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7780aea3-27e8-4a8c-a633-48cb266126df");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d0a4d6d-2ecc-4f0d-a5c6-d9ab6198a861");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "947b2125-a09e-4122-b0b2-19d154019a61");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "97a944c9-6591-41d8-b0c5-231ba340e323");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "996cb637-0c0d-4449-b20a-f845e967968f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aab88e65-ea84-41d1-8c29-66a269795ee5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2b480b1-49df-4b5a-a077-b85f3c400d13");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c95c6655-ca3f-4971-ad8f-74b43918f4f4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d66d3245-a3cd-489c-9d3e-e515a4a25f67");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e28aba9e-fe53-460e-bb34-c2027eb5004d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4348093-1864-44c5-90fa-32a35a2073ec");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "PurchaseProposalForms");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "40f9608d-94bd-4ee6-bf65-ae722e121dde", "f279a5e6-b04a-400d-a233-6dc595c61e8a", "Admin", "admin" },
                    { "a33a3023-5922-4780-a255-83ae5a3d0582", "c3992212-b6c6-49db-a567-2b5d3c9a1805", "Sale", "sale" },
                    { "283ecfb4-91e7-46cd-a1f1-424af2a9aba8", "1bd570a3-c5b3-44f2-a83e-97d8d3ab7953", "SuperAdmin", "superadmin" },
                    { "13303781-d0c4-489a-8682-70d5411a3fd5", "cf585c27-ef53-41db-8242-8bc8add4f4ae", "WarehouseKeeperManager", "warehousekeepermanager" },
                    { "4452f1a8-85ad-4170-8170-83991d8cca4e", "4f6d57e1-4ac2-44ca-baa0-b0b2c756fe41", "WarehouseKeeper", "warehousekeeper" },
                    { "8d2ce0f3-8e0a-449a-9a46-8b939f0ea7b5", "ec67ba97-d6d3-4418-a47a-228932254347", "Customer", "customer" },
                    { "084793b4-e989-43bd-895b-ce4026e202ea", "989e1559-95f5-4e34-886b-b88f4099b5f2", "Boss", "boss" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "55867d78-8673-4a4f-9b71-3989b1b2b55c", 0, "f05537b7-0c8b-49ea-a9d5-e3ba0c0d852a", "phungthanhdo@gmail.com", true, "Độ", "Phùng Thanh", false, null, "PHUNGTHANHDO@GMAIL.COM", "PHUNGTHANHDO@GMAIL.COM", "AQAAAAEAACcQAAAAEOqgWepnFTxXAHoixRBeyE1lU1sI6e7eNpvh/JUZToJ4yr7g6j6nQJpOAJ40ubf7CQ==", null, false, "", false, "phungthanhdo@gmail.com" },
                    { "8ccf5253-33cc-45c0-a391-5564ef3c0835", 0, "5ae5a028-9642-4929-acc4-538597b9acd6", "nguyenhue@gmail.com", true, "Huệ", "Nguyễn", false, null, "NGUYENHUE@GMAIL.COM", "NGUYENHUE@GMAIL.COM", "AQAAAAEAACcQAAAAECarTIwAK047XkdjpI3COQ4FMjCyuWUEtnFcJ2D5spUtGeEkJgMNVZlYgd2dPMMjxw==", null, false, "", false, "nguyenhue@gmail.com" },
                    { "bb9b07ae-7fc7-4cec-bc48-c32efe6ad51b", 0, "3ac9abe8-5ada-4e8c-a268-b9ca70bbc0a4", "hoxuanhuong@gmail.com", true, "Hương", "Hồ Xuân", false, null, "HOXUANHUONG@GMAIL.COM", "HOXUANHUONG@GMAIL.COM", "AQAAAAEAACcQAAAAENxQSQT3aUIKHwyUu/+ew7Lxj0e/OL4idy4dwVR3yez5mAWUZw0PfDGUxcyaCwYzXw==", null, false, "", false, "hoxuanhuong@gmail.com" },
                    { "ad7c5c61-b274-49aa-ace8-acb6c855ea86", 0, "dd9c255c-366f-463a-8f95-fe2c4de544c9", "nguyenthanhlong@gmail.com", true, "Long", "Nguyễn Thành", false, null, "NGUYENTHANHLONG@GMAIL.COM", "NGUYENTHANHLONG@GMAIL.COM", "AQAAAAEAACcQAAAAEJK4Uf8Ur3C1TePuZq/ftesDnCoCL6WKZlgoNKXK8hnshaepZ+lO78JPb/XBNcwL1g==", null, false, "", false, "nguyenthanhlong@gmail.com" },
                    { "e47c4183-74a0-4660-b247-aa2de384d70b", 0, "9360c00b-33a1-4f55-ba5a-2c06ed5777ba", "huynhtranthanh@gmail.com", true, "Thành", "Huỳnh Trấn", false, null, "HUYNHTRANTHANH@GMAIL.COM", "HUYNHTRANTHANH@GMAIL.COM", "AQAAAAEAACcQAAAAEJHbRNUpjLmt2CWSfXZF8hbhK1eAIEmLH3KXJ7pWzPB8ZrnvN6F0HdvIH3PBQfMCaQ==", null, false, "", false, "huynhtranthanh@gmail.com" },
                    { "4e3b0737-2682-41ed-850e-e28f58da3053", 0, "b997fb27-63b9-4e72-98a3-395a5fc89ac4", "caobaquat@gmail.com", true, "Quát", "Cao Bá", false, null, "CAOBAQUAT@GMAIL.COM", "CAOBAQUAT@GMAIL.COM", "AQAAAAEAACcQAAAAEDVVwZm1mVuHkWRtlCy4eK4t7pLd6jIliinKCd6iAiqijsyU/jtFWtkbWmL6pmxqFw==", null, false, "", false, "caobaquat@gmail.com" },
                    { "c00dee5e-bc85-4074-8741-7ee4c66862e6", 0, "8958b22e-82f3-4dc9-8ca1-2e6d42c3ccb3", "truongthitramanh@gmail.com", true, "Anh", "Trương Thị Trâm", false, null, "TRUONGTHITRAMANH@GMAIL.COM", "TRUONGTHITRAMANH@GMAIL.COM", "AQAAAAEAACcQAAAAEOWQextxXSvucy9syMvBNyeZqWEY/KS1kfGlwWkImwC9HqfhoRWxGB0AsBc4qhqayA==", null, false, "", false, "truongthitramanh@gmail.com" },
                    { "8535a0b2-70b4-44a4-afa0-684efd6b0614", 0, "c1a337ef-e2b8-4ef6-9934-13880927d57f", "nguyentrunghieu@gmail.com", true, "Hiếu", "Nguyễn Trung", false, null, "NGUYENTRUNGHIEU@GMAIL.COM", "NGUYENTRUNGHIEU@GMAIL.COM", "AQAAAAEAACcQAAAAEITMqou1QsPDRuM3lceldMDeDNPePVCHFWoWtD2/Uko5OKBUVGY2PKsD0pLFcs7IGA==", null, false, "", false, "nguyentrunghieu@gmail.com" },
                    { "96e18e74-c26a-4fd8-aa3e-27fc9fa77800", 0, "3d7e8955-cfd9-426a-a167-6b33253e5592", "caothivananh@gmail.com", true, "Anh", "Cao Thị Vân", false, null, "CAOTHIVANANH@GMAIL.COM", "CAOTHIVANANH@GMAIL.COM", "AQAAAAEAACcQAAAAEJzOqkbLazCXEyxbgcXrOZ7nseS/JNrXM9n0G8nuebbR1MFZylnu2Asir/vVabSszg==", null, false, "", false, "caothivananh@gmail.com" },
                    { "e3917b48-6d07-4e92-8c64-701e0bdb0e10", 0, "454a99b7-90d1-4e0c-b2b3-729611737566", "nguyennhuloc@gmail.com", true, "Lộc", "Nguyễn Như", false, null, "NGUYENNHULOC@GMAIL.COM", "NGUYENNHULOC@GMAIL.COM", "AQAAAAEAACcQAAAAEMI6JWCnV9f7cIwkCxAmUjg8Zz54oMxE6BjiwFYkYXEt/0v23ovHFBJ23UvT10WHVg==", null, false, "", false, "nguyennhuloc@gmail.com" },
                    { "ba8fbf13-728b-4e3f-929d-be8022dc6424", 0, "3d34ed56-ac5b-4705-ade4-e7177bcd5cf1", "phantantrung@gmail.com", true, "Trung", "Phan Tấn", false, null, "PHANTANTRUNG@GMAIL.COM", "PHANTANTRUNG@GMAIL.COM", "AQAAAAEAACcQAAAAEI33cnbEjvGYLCvTc/QvflzZk6WBajdAqU80r365OwOREKtxSxBwFFjyZMdb2Bbjyg==", null, false, "", false, "phantantrung@gmail.com" },
                    { "73fa172e-baa9-4235-bcfe-a826158b07e8", 0, "eec5e6c0-a211-4a3e-a72a-48ad234789e3", "phamvinhson@gmail.com", true, "Sơn", "Phạm Vĩnh", false, null, "PHAMVINHSON@GMAIL.COM", "PHAMVINHSON@GMAIL.COM", "AQAAAAEAACcQAAAAEODQiEBdKeYwzCCFyaJZu3utW3+BGKFkLN4W5LkpNSdn2VU8Nhxx4GyU9meJIVo1SA==", null, false, "", false, "phamvinhson@gmail.com" },
                    { "c5a91de8-95b3-4ed9-9bd9-073bfcac7dd8", 0, "f50f9cd4-af50-4e12-8fbc-14c0ee428584", "trankieuloan@gmail.com", true, "Loan", "Trần Kiều", false, null, "TRANKIEULOAN@GMAIL.COM", "TRANKIEULOAN@GMAIL.COM", "AQAAAAEAACcQAAAAEEbCXOUzGNMVeMlx5kTHTAXXvrhbLf2io5w3qUgk2PTfZjGEuziJa6AMgZoovQ5ESA==", null, false, "", false, "trankieuloan@gmail.com" },
                    { "e25e6448-071f-478d-91c3-82552d98bb10", 0, "71d19aa8-2055-4941-821d-c116b7b0363c", "yungadmin@gmail.com", true, "Admin", "Yung", false, null, "YUNGADMIN@GMAIL.COM", "YUNGADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEK1/NNGPa/+mM9esDr+2AWCDy4BaomSsGQ7njb8aJF1zweFkFp2f2nWxBqNRy/g5VQ==", null, false, "", false, "yungadmin@gmail.com" },
                    { "0a12b251-c5f6-43b4-ab81-aac3c19af44b", 0, "615822a1-822a-45ab-8b75-97d37445f8b7", "lilsuperadmin@gmail.com", true, "Super Admin", "Lil", false, null, "LILSUPERADMIN@GMAIL.COM", "LILSUPERADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEMIkf5lO7v1/QeyTmnOwW7EOb8ebsW8znApT8fC/40I5ksrn1oTCWdoAHKScsXZDRA==", null, false, "", false, "lilsuperadmin@gmail.com" },
                    { "bedf9245-9a30-4a7a-8f7b-d9082f522aa4", 0, "78e03ea3-d824-413d-bdb4-fcec799ea535", "tranthaonguyen@gmail.com", true, "Nguyên", "Trần Thảo", false, null, "TRANTHAONGUYEN@GMAIL.COM", "TRANTHAONGUYEN@GMAIL.COM", "AQAAAAEAACcQAAAAEI9ZU2+BV8nhfNU1fN3qeh3CS7/IA9c7rGUOxWPXD5VpLrwz+cFoe6+B0avCJ9klsg==", null, false, "", false, "tranthaonguyen@gmail.com" },
                    { "192955e8-f106-4c09-8120-99909e832d38", 0, "95c563c4-d09b-4c74-8b3a-0a30adcfebfd", "truongtuantu@gmail.com", true, "Tú", "Trương Tuấn", false, null, "TRUONGTUANTU@GMAIL.COM", "TRUONGTUANTU@GMAIL.COM", "AQAAAAEAACcQAAAAEEt7l0r2gJuXU+d52u4SBSwJgqwjjRAda/UGf9xZNHnDJY+Gk46idQbk3/KqLnFBrQ==", null, false, "", false, "truongtuantu@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "0a12b251-c5f6-43b4-ab81-aac3c19af44b", "283ecfb4-91e7-46cd-a1f1-424af2a9aba8" },
                    { "55867d78-8673-4a4f-9b71-3989b1b2b55c", "a33a3023-5922-4780-a255-83ae5a3d0582" },
                    { "8ccf5253-33cc-45c0-a391-5564ef3c0835", "4452f1a8-85ad-4170-8170-83991d8cca4e" },
                    { "bb9b07ae-7fc7-4cec-bc48-c32efe6ad51b", "4452f1a8-85ad-4170-8170-83991d8cca4e" },
                    { "ad7c5c61-b274-49aa-ace8-acb6c855ea86", "4452f1a8-85ad-4170-8170-83991d8cca4e" },
                    { "e47c4183-74a0-4660-b247-aa2de384d70b", "13303781-d0c4-489a-8682-70d5411a3fd5" },
                    { "4e3b0737-2682-41ed-850e-e28f58da3053", "13303781-d0c4-489a-8682-70d5411a3fd5" },
                    { "ba8fbf13-728b-4e3f-929d-be8022dc6424", "a33a3023-5922-4780-a255-83ae5a3d0582" },
                    { "c00dee5e-bc85-4074-8741-7ee4c66862e6", "8d2ce0f3-8e0a-449a-9a46-8b939f0ea7b5" },
                    { "96e18e74-c26a-4fd8-aa3e-27fc9fa77800", "8d2ce0f3-8e0a-449a-9a46-8b939f0ea7b5" },
                    { "e3917b48-6d07-4e92-8c64-701e0bdb0e10", "8d2ce0f3-8e0a-449a-9a46-8b939f0ea7b5" },
                    { "8535a0b2-70b4-44a4-afa0-684efd6b0614", "8d2ce0f3-8e0a-449a-9a46-8b939f0ea7b5" },
                    { "73fa172e-baa9-4235-bcfe-a826158b07e8", "084793b4-e989-43bd-895b-ce4026e202ea" },
                    { "c5a91de8-95b3-4ed9-9bd9-073bfcac7dd8", "084793b4-e989-43bd-895b-ce4026e202ea" },
                    { "e25e6448-071f-478d-91c3-82552d98bb10", "40f9608d-94bd-4ee6-bf65-ae722e121dde" },
                    { "bedf9245-9a30-4a7a-8f7b-d9082f522aa4", "8d2ce0f3-8e0a-449a-9a46-8b939f0ea7b5" },
                    { "192955e8-f106-4c09-8120-99909e832d38", "a33a3023-5922-4780-a255-83ae5a3d0582" }
                });
        }
    }
}
