using Microsoft.EntityFrameworkCore.Migrations;

namespace api.Migrations
{
    public partial class AddPriceFieldForGoodsReceivingNoteAndDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "01eeeedc-afcc-48f6-82fe-740ab870dc1e", "8c365b7f-fe07-456b-af5c-f2b4e1664bab" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "034ea3fc-7f19-4b3a-95ce-3eeacec1dfd5", "e2799531-780f-46f5-bfa1-7260e13ce9cc" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "0e10be1e-d027-4264-8085-1fb2912a72f4", "8c365b7f-fe07-456b-af5c-f2b4e1664bab" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "30175e6f-9285-4f5e-ad0c-50ee3e30f5e4", "1c8e8638-6958-40e2-a6da-5fd9a1d90737" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "30f1f9b1-f9f7-42f9-ae64-cf47425caef9", "453e219e-c852-4038-a6cf-ebcefdab0e6e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "356096a4-e37c-4504-bf77-2a9e77b2472b", "8c365b7f-fe07-456b-af5c-f2b4e1664bab" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "3566b9ed-2cc8-42db-b812-14e756dbd3d3", "4a526ad2-3051-4ad0-99da-f365ab0e4cd8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "3e9bdc07-72b7-4bc1-ad34-70b81cfcadd5", "8c365b7f-fe07-456b-af5c-f2b4e1664bab" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "4ff8841c-4c0e-4fef-8d59-3eb9c4b7185b", "1c8e8638-6958-40e2-a6da-5fd9a1d90737" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "55ef1e13-3fb6-4017-bf0e-60f2987b7e92", "e2799531-780f-46f5-bfa1-7260e13ce9cc" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "7d0745f1-9708-47ba-87d3-b764af830815", "8c365b7f-fe07-456b-af5c-f2b4e1664bab" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "890a3758-7089-4bb5-a653-04160a908fa1", "453e219e-c852-4038-a6cf-ebcefdab0e6e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "9e8ed0cb-2bc0-4f99-8109-a0a3a1c5b33f", "1c8e8638-6958-40e2-a6da-5fd9a1d90737" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a72bdc63-9dc8-4e41-ad68-283b622f44d4", "5110f20d-8ac2-488e-b595-73c40b01ca14" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "c2b998f4-f028-4711-9b48-a463d41f846e", "6da5a37c-6dfb-4c0f-8c50-0ee015e2b8ff" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "f78eb325-3e13-46a5-914a-dc7dfaf1e7a8", "e2799531-780f-46f5-bfa1-7260e13ce9cc" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "f7b257c9-40ce-4630-8a98-62f3cc493bd0", "6da5a37c-6dfb-4c0f-8c50-0ee015e2b8ff" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1c8e8638-6958-40e2-a6da-5fd9a1d90737");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "453e219e-c852-4038-a6cf-ebcefdab0e6e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4a526ad2-3051-4ad0-99da-f365ab0e4cd8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5110f20d-8ac2-488e-b595-73c40b01ca14");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6da5a37c-6dfb-4c0f-8c50-0ee015e2b8ff");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8c365b7f-fe07-456b-af5c-f2b4e1664bab");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e2799531-780f-46f5-bfa1-7260e13ce9cc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "01eeeedc-afcc-48f6-82fe-740ab870dc1e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "034ea3fc-7f19-4b3a-95ce-3eeacec1dfd5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0e10be1e-d027-4264-8085-1fb2912a72f4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30175e6f-9285-4f5e-ad0c-50ee3e30f5e4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30f1f9b1-f9f7-42f9-ae64-cf47425caef9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "356096a4-e37c-4504-bf77-2a9e77b2472b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3566b9ed-2cc8-42db-b812-14e756dbd3d3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3e9bdc07-72b7-4bc1-ad34-70b81cfcadd5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4ff8841c-4c0e-4fef-8d59-3eb9c4b7185b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55ef1e13-3fb6-4017-bf0e-60f2987b7e92");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7d0745f1-9708-47ba-87d3-b764af830815");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "890a3758-7089-4bb5-a653-04160a908fa1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e8ed0cb-2bc0-4f99-8109-a0a3a1c5b33f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a72bdc63-9dc8-4e41-ad68-283b622f44d4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c2b998f4-f028-4711-9b48-a463d41f846e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f78eb325-3e13-46a5-914a-dc7dfaf1e7a8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f7b257c9-40ce-4630-8a98-62f3cc493bd0");

            migrationBuilder.AddColumn<double>(
                name: "TotalPrice",
                table: "GoodsReceivingNotes",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "SinglePurchasePrice",
                table: "GoodsReceivingDetails",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "TotalPrice",
                table: "GoodsReceivingDetails",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "81d03a17-08b8-4ed6-906d-e6091bf3c902", "c79438c8-3399-4eed-a562-99b301524aaf", "Admin", "admin" },
                    { "e43eec88-a0d9-4aee-98eb-202e477b379d", "5e738a2c-f846-4705-9e29-5ae0dbb2bd6f", "Sale", "sale" },
                    { "9d31ab5d-bf92-4303-8788-7ec70b39cf61", "eadbc7d0-c1c0-49e8-8e4f-5e2524325168", "SuperAdmin", "superadmin" },
                    { "d6f401b4-c668-47fe-a277-02a7165e8d37", "1871bf2f-99aa-4a97-aced-f5e75727d470", "WarehouseKeeperManager", "warehousekeepermanager" },
                    { "f6cc5a05-c5cb-48d5-bbbc-ab93f3c9e3b5", "d219a51e-37d8-4bf5-be4b-7f21ec936669", "WarehouseKeeper", "warehousekeeper" },
                    { "8aacc251-5e0b-4f12-85f4-6d1d42ab6c21", "f84cf994-20c1-489a-bf42-086d9c2bc338", "Customer", "customer" },
                    { "c2e432a4-c3fb-4f5c-83bd-ba5ea419b0d3", "738a610c-4ef7-4eb0-8c70-757ef6298e3e", "Boss", "boss" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "6f3784b1-7b20-4477-bdb7-e65adead92c1", 0, "e661042f-9d8d-4374-b382-16126899e1e0", "phungthanhdo@gmail.com", true, "Độ", "Phùng Thanh", false, null, "PHUNGTHANHDO@GMAIL.COM", "PHUNGTHANHDO@GMAIL.COM", "AQAAAAEAACcQAAAAEA76Zqgx0AODO8+jMcoMcQiDmn1iUK2XeEYTR9rOg9kP1kgyoYV4nh+cT0ru4XyxNA==", null, false, "", false, "phungthanhdo@gmail.com" },
                    { "27c5019e-d329-4af1-b804-d51ef74a15f8", 0, "cfc4ea0f-8894-4e0f-98c3-950e2edac51b", "nguyenhue@gmail.com", true, "Huệ", "Nguyễn", false, null, "NGUYENHUE@GMAIL.COM", "NGUYENHUE@GMAIL.COM", "AQAAAAEAACcQAAAAEFTbmmUrOtnP1AW5BGBlcrKLSu1ka2bk9fR3BSGVxIKNWGzEpmV3znLAtMUBy4pOQA==", null, false, "", false, "nguyenhue@gmail.com" },
                    { "64a19c5f-1737-400b-be24-617302bc2863", 0, "20dfdf5f-9a75-4249-b9fc-79c63137ff3f", "hoxuanhuong@gmail.com", true, "Hương", "Hồ Xuân", false, null, "HOXUANHUONG@GMAIL.COM", "HOXUANHUONG@GMAIL.COM", "AQAAAAEAACcQAAAAEGCNBFJP8w5oA3QSz4paqNH1/QZDUncuyt8J4dcVhzfwl1PF0DBL7ZSW3D1Dw1BVZw==", null, false, "", false, "hoxuanhuong@gmail.com" },
                    { "db6a9170-2f64-4e95-bd51-7a74890d1e20", 0, "89fccacc-9a9d-4bc4-a78c-0f3d668449f3", "nguyenthanhlong@gmail.com", true, "Long", "Nguyễn Thành", false, null, "NGUYENTHANHLONG@GMAIL.COM", "NGUYENTHANHLONG@GMAIL.COM", "AQAAAAEAACcQAAAAEABm84ReEBQHY/XrZc6RREM7pUFmy99mlcsJ7izJkR1TDq6In0NEZOfz1kAyEyxgEQ==", null, false, "", false, "nguyenthanhlong@gmail.com" },
                    { "bf3fded8-0ac5-4ef6-b514-6294911490e6", 0, "b8c42319-ee28-4924-8a78-2c0d9fbca543", "huynhtranthanh@gmail.com", true, "Thành", "Huỳnh Trấn", false, null, "HUYNHTRANTHANH@GMAIL.COM", "HUYNHTRANTHANH@GMAIL.COM", "AQAAAAEAACcQAAAAEJidnsJ8u8qXD3AnZoQEijWZgymNjS4sTc/pQXjG1nbDcHdUWp5tnYgexiR4OpLxVw==", null, false, "", false, "huynhtranthanh@gmail.com" },
                    { "61d4ac57-b8ab-4568-88e2-a58a0e7435c2", 0, "d342ca3f-8ec2-4903-9cb7-17ba8eafce86", "caobaquat@gmail.com", true, "Quát", "Cao Bá", false, null, "CAOBAQUAT@GMAIL.COM", "CAOBAQUAT@GMAIL.COM", "AQAAAAEAACcQAAAAEN93SzQAb1DF2HTpwv2FR1ZkQGMMkXajjiJMktrbDW7rfa4/f7zStbS02XE5vWZNZw==", null, false, "", false, "caobaquat@gmail.com" },
                    { "08032829-999f-4289-9c51-9c9fc40f5b96", 0, "41d97c58-4194-446f-a696-1b011ff75f9f", "truongthitramanh@gmail.com", true, "Anh", "Trương Thị Trâm", false, null, "TRUONGTHITRAMANH@GMAIL.COM", "TRUONGTHITRAMANH@GMAIL.COM", "AQAAAAEAACcQAAAAECMjc0z7m6wbZjsg/cUjldgc0SlnPZTYfdLf3RTMfmF51EVhdwf+IKnHIQBRbWWUhA==", null, false, "", false, "truongthitramanh@gmail.com" },
                    { "83fcee97-7760-4f6b-af7e-d85ecd08a635", 0, "c94fe711-4ff7-4e4c-affb-af0fd195cf5b", "nguyentrunghieu@gmail.com", true, "Hiếu", "Nguyễn Trung", false, null, "NGUYENTRUNGHIEU@GMAIL.COM", "NGUYENTRUNGHIEU@GMAIL.COM", "AQAAAAEAACcQAAAAENR5tj8J5+tAG/srwfMkg5uLitwMv6zqOMkMHr3AoHX1nrKV/2MN36t1c6EByCor9Q==", null, false, "", false, "nguyentrunghieu@gmail.com" },
                    { "ca0b88dd-1a86-4a5b-a32a-61e26e2dae98", 0, "27b55d01-ad2e-4cf7-a7ca-64ffb5227a8a", "caothivananh@gmail.com", true, "Anh", "Cao Thị Vân", false, null, "CAOTHIVANANH@GMAIL.COM", "CAOTHIVANANH@GMAIL.COM", "AQAAAAEAACcQAAAAEOj6AkhPyN9XcQe+V74BRyetbLVBKVxoPAItMc/R1p+a57msR/OiyPWSZFdfn23ecA==", null, false, "", false, "caothivananh@gmail.com" },
                    { "d067a018-4fe5-4a51-a4b3-de0e10e3d45a", 0, "c0c2c3f7-8450-4ecf-96a0-b11787bfa7e2", "nguyennhuloc@gmail.com", true, "Lộc", "Nguyễn Như", false, null, "NGUYENNHULOC@GMAIL.COM", "NGUYENNHULOC@GMAIL.COM", "AQAAAAEAACcQAAAAEEFIkwFyrMBHb4vW1divflNnkmJbn4GA0lRQf0Vl8hA7EBW19WVi+u1X9GBN5dnp5A==", null, false, "", false, "nguyennhuloc@gmail.com" },
                    { "c0d6de61-d00a-4325-ab70-c28c94ab6bf8", 0, "1499b04a-b1e9-415e-91d2-0eb5464a0ac7", "phantantrung@gmail.com", true, "Trung", "Phan Tấn", false, null, "PHANTANTRUNG@GMAIL.COM", "PHANTANTRUNG@GMAIL.COM", "AQAAAAEAACcQAAAAENygNRTIf99VYHunpEwPKzHSgpjxoht9KFBDLYU8TT/zPfH3OU0Q4KnTz8UkRkzSuA==", null, false, "", false, "phantantrung@gmail.com" },
                    { "8d416719-6882-479c-96da-f635b9236ccd", 0, "d389b12c-836a-44aa-bbdb-8231358e1b7d", "phamvinhson@gmail.com", true, "Sơn", "Phạm Vĩnh", false, null, "PHAMVINHSON@GMAIL.COM", "PHAMVINHSON@GMAIL.COM", "AQAAAAEAACcQAAAAEL9G3G0CTLcM39z5a7CD41FwI/1aP7pmFWsfUU5tFd9WcRDYNR4EjyLHiE4c0Xw8rw==", null, false, "", false, "phamvinhson@gmail.com" },
                    { "4148ee17-2e7a-478b-aaf5-66247f3430bf", 0, "080c1b52-d7c9-4854-ae67-9833a3939b62", "trankieuloan@gmail.com", true, "Loan", "Trần Kiều", false, null, "TRANKIEULOAN@GMAIL.COM", "TRANKIEULOAN@GMAIL.COM", "AQAAAAEAACcQAAAAELtfNQA+mswx0VpEBraVpvS/yAP24f1kqAyu9w+YW+5sr/C4VfXRT1Kc0LsudY6mWg==", null, false, "", false, "trankieuloan@gmail.com" },
                    { "a480943b-7f93-4d2d-aa01-2d08442ffaa7", 0, "b30a9398-56d6-41a8-b3d4-2898d7bcb530", "yungadmin@gmail.com", true, "Admin", "Yung", false, null, "YUNGADMIN@GMAIL.COM", "YUNGADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEODxUY4FSQDV67FCcZjfUWKyDlo3Iejgr2bvPrbL+TYsN4aiAeAHQOMXRqx0/FVHnA==", null, false, "", false, "yungadmin@gmail.com" },
                    { "1870d0f0-f650-4132-9cab-a531c20ca511", 0, "7056af87-9748-47b5-ba5a-0939c6bc2666", "lilsuperadmin@gmail.com", true, "Super Admin", "Lil", false, null, "LILSUPERADMIN@GMAIL.COM", "LILSUPERADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEGKSDrq52quegJW67KWBwuPG70hh6XcnBJq5z4wgHGl8dSRJ0/d+Q24fQ698McarVA==", null, false, "", false, "lilsuperadmin@gmail.com" },
                    { "a1aa24a8-0fe3-4175-a06b-7adb4f647344", 0, "f5ab42c0-7d6f-422a-8eeb-cee4639d1610", "tranthaonguyen@gmail.com", true, "Nguyên", "Trần Thảo", false, null, "TRANTHAONGUYEN@GMAIL.COM", "TRANTHAONGUYEN@GMAIL.COM", "AQAAAAEAACcQAAAAEGQCnxdDO4RmMpYorehsNU1SmyIoB3vEopG6O7hisrgSO9ZY6Fb8AgskW0TAB0oiyw==", null, false, "", false, "tranthaonguyen@gmail.com" },
                    { "a9231cd5-0cd3-47c7-9e13-d56337b93246", 0, "ff07ce54-6271-45ad-87ac-4a092ff04c28", "truongtuantu@gmail.com", true, "Tú", "Trương Tuấn", false, null, "TRUONGTUANTU@GMAIL.COM", "TRUONGTUANTU@GMAIL.COM", "AQAAAAEAACcQAAAAEJHIDsMYez6jp4G3qkpCjlXIbnlbYxQAckyFBcVLibTQwr1nE9fgqOqf8c4+oCeXJA==", null, false, "", false, "truongtuantu@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "1870d0f0-f650-4132-9cab-a531c20ca511", "9d31ab5d-bf92-4303-8788-7ec70b39cf61" },
                    { "6f3784b1-7b20-4477-bdb7-e65adead92c1", "e43eec88-a0d9-4aee-98eb-202e477b379d" },
                    { "27c5019e-d329-4af1-b804-d51ef74a15f8", "f6cc5a05-c5cb-48d5-bbbc-ab93f3c9e3b5" },
                    { "64a19c5f-1737-400b-be24-617302bc2863", "f6cc5a05-c5cb-48d5-bbbc-ab93f3c9e3b5" },
                    { "db6a9170-2f64-4e95-bd51-7a74890d1e20", "f6cc5a05-c5cb-48d5-bbbc-ab93f3c9e3b5" },
                    { "bf3fded8-0ac5-4ef6-b514-6294911490e6", "d6f401b4-c668-47fe-a277-02a7165e8d37" },
                    { "61d4ac57-b8ab-4568-88e2-a58a0e7435c2", "d6f401b4-c668-47fe-a277-02a7165e8d37" },
                    { "c0d6de61-d00a-4325-ab70-c28c94ab6bf8", "e43eec88-a0d9-4aee-98eb-202e477b379d" },
                    { "08032829-999f-4289-9c51-9c9fc40f5b96", "8aacc251-5e0b-4f12-85f4-6d1d42ab6c21" },
                    { "ca0b88dd-1a86-4a5b-a32a-61e26e2dae98", "8aacc251-5e0b-4f12-85f4-6d1d42ab6c21" },
                    { "d067a018-4fe5-4a51-a4b3-de0e10e3d45a", "8aacc251-5e0b-4f12-85f4-6d1d42ab6c21" },
                    { "83fcee97-7760-4f6b-af7e-d85ecd08a635", "8aacc251-5e0b-4f12-85f4-6d1d42ab6c21" },
                    { "8d416719-6882-479c-96da-f635b9236ccd", "c2e432a4-c3fb-4f5c-83bd-ba5ea419b0d3" },
                    { "4148ee17-2e7a-478b-aaf5-66247f3430bf", "c2e432a4-c3fb-4f5c-83bd-ba5ea419b0d3" },
                    { "a480943b-7f93-4d2d-aa01-2d08442ffaa7", "81d03a17-08b8-4ed6-906d-e6091bf3c902" },
                    { "a1aa24a8-0fe3-4175-a06b-7adb4f647344", "8aacc251-5e0b-4f12-85f4-6d1d42ab6c21" },
                    { "a9231cd5-0cd3-47c7-9e13-d56337b93246", "e43eec88-a0d9-4aee-98eb-202e477b379d" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "08032829-999f-4289-9c51-9c9fc40f5b96", "8aacc251-5e0b-4f12-85f4-6d1d42ab6c21" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "1870d0f0-f650-4132-9cab-a531c20ca511", "9d31ab5d-bf92-4303-8788-7ec70b39cf61" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "27c5019e-d329-4af1-b804-d51ef74a15f8", "f6cc5a05-c5cb-48d5-bbbc-ab93f3c9e3b5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "4148ee17-2e7a-478b-aaf5-66247f3430bf", "c2e432a4-c3fb-4f5c-83bd-ba5ea419b0d3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "61d4ac57-b8ab-4568-88e2-a58a0e7435c2", "d6f401b4-c668-47fe-a277-02a7165e8d37" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "64a19c5f-1737-400b-be24-617302bc2863", "f6cc5a05-c5cb-48d5-bbbc-ab93f3c9e3b5" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "6f3784b1-7b20-4477-bdb7-e65adead92c1", "e43eec88-a0d9-4aee-98eb-202e477b379d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "83fcee97-7760-4f6b-af7e-d85ecd08a635", "8aacc251-5e0b-4f12-85f4-6d1d42ab6c21" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "8d416719-6882-479c-96da-f635b9236ccd", "c2e432a4-c3fb-4f5c-83bd-ba5ea419b0d3" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a1aa24a8-0fe3-4175-a06b-7adb4f647344", "8aacc251-5e0b-4f12-85f4-6d1d42ab6c21" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a480943b-7f93-4d2d-aa01-2d08442ffaa7", "81d03a17-08b8-4ed6-906d-e6091bf3c902" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a9231cd5-0cd3-47c7-9e13-d56337b93246", "e43eec88-a0d9-4aee-98eb-202e477b379d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "bf3fded8-0ac5-4ef6-b514-6294911490e6", "d6f401b4-c668-47fe-a277-02a7165e8d37" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "c0d6de61-d00a-4325-ab70-c28c94ab6bf8", "e43eec88-a0d9-4aee-98eb-202e477b379d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ca0b88dd-1a86-4a5b-a32a-61e26e2dae98", "8aacc251-5e0b-4f12-85f4-6d1d42ab6c21" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "d067a018-4fe5-4a51-a4b3-de0e10e3d45a", "8aacc251-5e0b-4f12-85f4-6d1d42ab6c21" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "db6a9170-2f64-4e95-bd51-7a74890d1e20", "f6cc5a05-c5cb-48d5-bbbc-ab93f3c9e3b5" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "81d03a17-08b8-4ed6-906d-e6091bf3c902");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8aacc251-5e0b-4f12-85f4-6d1d42ab6c21");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d31ab5d-bf92-4303-8788-7ec70b39cf61");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c2e432a4-c3fb-4f5c-83bd-ba5ea419b0d3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d6f401b4-c668-47fe-a277-02a7165e8d37");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "e43eec88-a0d9-4aee-98eb-202e477b379d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f6cc5a05-c5cb-48d5-bbbc-ab93f3c9e3b5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "08032829-999f-4289-9c51-9c9fc40f5b96");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1870d0f0-f650-4132-9cab-a531c20ca511");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "27c5019e-d329-4af1-b804-d51ef74a15f8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4148ee17-2e7a-478b-aaf5-66247f3430bf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "61d4ac57-b8ab-4568-88e2-a58a0e7435c2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "64a19c5f-1737-400b-be24-617302bc2863");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f3784b1-7b20-4477-bdb7-e65adead92c1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "83fcee97-7760-4f6b-af7e-d85ecd08a635");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d416719-6882-479c-96da-f635b9236ccd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a1aa24a8-0fe3-4175-a06b-7adb4f647344");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a480943b-7f93-4d2d-aa01-2d08442ffaa7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a9231cd5-0cd3-47c7-9e13-d56337b93246");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bf3fded8-0ac5-4ef6-b514-6294911490e6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c0d6de61-d00a-4325-ab70-c28c94ab6bf8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ca0b88dd-1a86-4a5b-a32a-61e26e2dae98");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d067a018-4fe5-4a51-a4b3-de0e10e3d45a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "db6a9170-2f64-4e95-bd51-7a74890d1e20");

            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "GoodsReceivingNotes");

            migrationBuilder.DropColumn(
                name: "SinglePurchasePrice",
                table: "GoodsReceivingDetails");

            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "GoodsReceivingDetails");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "4a526ad2-3051-4ad0-99da-f365ab0e4cd8", "a4a67e79-3066-4f14-9a7f-5429dad829cd", "Admin", "admin" },
                    { "1c8e8638-6958-40e2-a6da-5fd9a1d90737", "b507e809-fec1-49d4-83d3-c3eeb5043403", "Sale", "sale" },
                    { "5110f20d-8ac2-488e-b595-73c40b01ca14", "bcd4f8e5-1e77-4d76-b18a-a657aeb686b6", "SuperAdmin", "superadmin" },
                    { "6da5a37c-6dfb-4c0f-8c50-0ee015e2b8ff", "bcadcff9-3490-491b-9898-0e2182bc26f8", "WarehouseKeeperManager", "warehousekeepermanager" },
                    { "e2799531-780f-46f5-bfa1-7260e13ce9cc", "9ac37733-0702-4810-88db-165746d70023", "WarehouseKeeper", "warehousekeeper" },
                    { "8c365b7f-fe07-456b-af5c-f2b4e1664bab", "00590235-ce0f-46c0-b166-93e6de784836", "Customer", "customer" },
                    { "453e219e-c852-4038-a6cf-ebcefdab0e6e", "bfa5dee6-9d9f-443f-b3e1-1eeb5d1ef80f", "Boss", "boss" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "4ff8841c-4c0e-4fef-8d59-3eb9c4b7185b", 0, "8b03878a-825c-42e4-8dcf-83004e473764", "phungthanhdo@gmail.com", true, "Độ", "Phùng Thanh", false, null, "PHUNGTHANHDO@GMAIL.COM", "PHUNGTHANHDO@GMAIL.COM", "AQAAAAEAACcQAAAAEE/IPSrwhFh8dwJmtrrzGqpaMFnZfpOWpRzqYhh2SHcebqLX6C5hO/x5b9j9ACaE2g==", null, false, "", false, "phungthanhdo@gmail.com" },
                    { "034ea3fc-7f19-4b3a-95ce-3eeacec1dfd5", 0, "127a2efd-4e3a-418c-a838-08bf1939493b", "nguyenhue@gmail.com", true, "Huệ", "Nguyễn", false, null, "NGUYENHUE@GMAIL.COM", "NGUYENHUE@GMAIL.COM", "AQAAAAEAACcQAAAAEBH+GV4z2NxWMhnA23f6d2OD18DzZ6Y7+bCRuW4b2W9x5df+F+70ZGIKAVkk/SrFyw==", null, false, "", false, "nguyenhue@gmail.com" },
                    { "55ef1e13-3fb6-4017-bf0e-60f2987b7e92", 0, "07577a50-4cc9-4b6d-92aa-9e964b79c893", "hoxuanhuong@gmail.com", true, "Hương", "Hồ Xuân", false, null, "HOXUANHUONG@GMAIL.COM", "HOXUANHUONG@GMAIL.COM", "AQAAAAEAACcQAAAAELNnY4TLbOT57e+SpMm0mE4K4G7cItkKuu8ayh37G+z5nYwOcVQLbVBttKiImdNaJQ==", null, false, "", false, "hoxuanhuong@gmail.com" },
                    { "f78eb325-3e13-46a5-914a-dc7dfaf1e7a8", 0, "9376397f-f0c2-43e5-944d-cf614ad2f41e", "nguyenthanhlong@gmail.com", true, "Long", "Nguyễn Thành", false, null, "NGUYENTHANHLONG@GMAIL.COM", "NGUYENTHANHLONG@GMAIL.COM", "AQAAAAEAACcQAAAAEAaJ/2wBTIi//vHTQdIOOT9W4odIT30h3SthcFx5Hw0T8Ew3dNs0kKyHDwmTQEEOVA==", null, false, "", false, "nguyenthanhlong@gmail.com" },
                    { "f7b257c9-40ce-4630-8a98-62f3cc493bd0", 0, "e7423ffd-94ec-45b0-9a7f-60afcdcd1f29", "huynhtranthanh@gmail.com", true, "Thành", "Huỳnh Trấn", false, null, "HUYNHTRANTHANH@GMAIL.COM", "HUYNHTRANTHANH@GMAIL.COM", "AQAAAAEAACcQAAAAEHT6jo8CKEyGBUobS1oj+OZBUrt/bK0vTRD1Fq7Ijfe8LJ89M26QaMvbWbsBl9GglQ==", null, false, "", false, "huynhtranthanh@gmail.com" },
                    { "c2b998f4-f028-4711-9b48-a463d41f846e", 0, "5efb3701-1a3a-4c87-8235-a86454a8a8cb", "caobaquat@gmail.com", true, "Quát", "Cao Bá", false, null, "CAOBAQUAT@GMAIL.COM", "CAOBAQUAT@GMAIL.COM", "AQAAAAEAACcQAAAAEM2Jzpex5Ar8ItNE2nR/pr2CuRwRkTqffgkdVXukoJmm5Vyv4DMjwNgQYH9bXkBLlQ==", null, false, "", false, "caobaquat@gmail.com" },
                    { "7d0745f1-9708-47ba-87d3-b764af830815", 0, "2bd51e99-a5d8-4ccd-888b-4bc3fb23a004", "truongthitramanh@gmail.com", true, "Anh", "Trương Thị Trâm", false, null, "TRUONGTHITRAMANH@GMAIL.COM", "TRUONGTHITRAMANH@GMAIL.COM", "AQAAAAEAACcQAAAAEMBwRcUPZd86yt6Ce3sKVi2tby3B/O6AyRNbtVpK4TuGHVeyAWCamFgwbKWnvn9Lqw==", null, false, "", false, "truongthitramanh@gmail.com" },
                    { "356096a4-e37c-4504-bf77-2a9e77b2472b", 0, "1d6fcf4c-f388-4317-ab22-e48b7c6b91cf", "nguyentrunghieu@gmail.com", true, "Hiếu", "Nguyễn Trung", false, null, "NGUYENTRUNGHIEU@GMAIL.COM", "NGUYENTRUNGHIEU@GMAIL.COM", "AQAAAAEAACcQAAAAEMybUKdZdF+W59ACZxBmfSnaNmi5g/qr0wsrBCrqk42HHYYxTybOQQSxxlc6SBAdkw==", null, false, "", false, "nguyentrunghieu@gmail.com" },
                    { "0e10be1e-d027-4264-8085-1fb2912a72f4", 0, "ffbc8ed2-2fe6-4ebd-8a59-96d482e62a02", "caothivananh@gmail.com", true, "Anh", "Cao Thị Vân", false, null, "CAOTHIVANANH@GMAIL.COM", "CAOTHIVANANH@GMAIL.COM", "AQAAAAEAACcQAAAAEOg+sLwFccTm5CArYP0tlBNLTgXxBs07WwNfsM/Lw7eJFWkvLQxf7zL8K4yvozDpQw==", null, false, "", false, "caothivananh@gmail.com" },
                    { "3e9bdc07-72b7-4bc1-ad34-70b81cfcadd5", 0, "3bc222b2-16c2-4b41-b031-c7da47d38d63", "nguyennhuloc@gmail.com", true, "Lộc", "Nguyễn Như", false, null, "NGUYENNHULOC@GMAIL.COM", "NGUYENNHULOC@GMAIL.COM", "AQAAAAEAACcQAAAAEAq4UmXaKXNkRbgd8g3YvRqY32h+t6Mlu5ul9cU1HJx6wMI72ZAcAxXsvKDL7VDU2Q==", null, false, "", false, "nguyennhuloc@gmail.com" },
                    { "30175e6f-9285-4f5e-ad0c-50ee3e30f5e4", 0, "481be90c-b1c0-4565-a42c-d7d24fb652f4", "phantantrung@gmail.com", true, "Trung", "Phan Tấn", false, null, "PHANTANTRUNG@GMAIL.COM", "PHANTANTRUNG@GMAIL.COM", "AQAAAAEAACcQAAAAEDHRUnBXk3tUed4u7UN7n5KIkP7i5CUfa7wBl5/J+LJzc/mQwaiLC9759rPfXpwHpw==", null, false, "", false, "phantantrung@gmail.com" },
                    { "30f1f9b1-f9f7-42f9-ae64-cf47425caef9", 0, "aeea4bd1-08b3-45cc-99ed-290dee9e2e59", "phamvinhson@gmail.com", true, "Sơn", "Phạm Vĩnh", false, null, "PHAMVINHSON@GMAIL.COM", "PHAMVINHSON@GMAIL.COM", "AQAAAAEAACcQAAAAEOzdKy/lK52Vl6V9xPj7RXvAzMXWGXpPXbEEJXhsN84wh7a1ttSwmtFgb77HdSQYwA==", null, false, "", false, "phamvinhson@gmail.com" },
                    { "890a3758-7089-4bb5-a653-04160a908fa1", 0, "dc1c4397-5e6d-44ba-9cf9-cdf4b2dee33a", "trankieuloan@gmail.com", true, "Loan", "Trần Kiều", false, null, "TRANKIEULOAN@GMAIL.COM", "TRANKIEULOAN@GMAIL.COM", "AQAAAAEAACcQAAAAECx2NFMSALakRPKzHfOVvLa0GVq9X0ocicnvIjVXKYYNlKF5L+kQVz4J8ZfDRkJQiw==", null, false, "", false, "trankieuloan@gmail.com" },
                    { "3566b9ed-2cc8-42db-b812-14e756dbd3d3", 0, "ef5c383d-2b3c-4a7f-a065-26d8b1c1bf3a", "yungadmin@gmail.com", true, "Admin", "Yung", false, null, "YUNGADMIN@GMAIL.COM", "YUNGADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEHzEy5+Xo8xi3MEbyB0C3nN7bR3TzwTFg3KCFdAHP01aZV8WDcoIlG1auNY41oqqtw==", null, false, "", false, "yungadmin@gmail.com" },
                    { "a72bdc63-9dc8-4e41-ad68-283b622f44d4", 0, "c962a8e7-5cd3-4ce4-a2c1-110937dbbc01", "lilsuperadmin@gmail.com", true, "Super Admin", "Lil", false, null, "LILSUPERADMIN@GMAIL.COM", "LILSUPERADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEEnteEeK/T3fcGuAk0lVc++jl/8TYphPZCYYA9J4gxkmsYgw4ib7RXyeGmfe65RNfw==", null, false, "", false, "lilsuperadmin@gmail.com" },
                    { "01eeeedc-afcc-48f6-82fe-740ab870dc1e", 0, "2c007e09-5180-45ca-8158-37896f4509ab", "tranthaonguyen@gmail.com", true, "Nguyên", "Trần Thảo", false, null, "TRANTHAONGUYEN@GMAIL.COM", "TRANTHAONGUYEN@GMAIL.COM", "AQAAAAEAACcQAAAAEF3Jxy4kdzgZ39sMw6vKWMb0mUVSCI9LA1f8AaA6Y6mhp3aeSxNFTeLjH8yRkGycYg==", null, false, "", false, "tranthaonguyen@gmail.com" },
                    { "9e8ed0cb-2bc0-4f99-8109-a0a3a1c5b33f", 0, "d040c385-e970-495f-8789-4113501e93f4", "truongtuantu@gmail.com", true, "Tú", "Trương Tuấn", false, null, "TRUONGTUANTU@GMAIL.COM", "TRUONGTUANTU@GMAIL.COM", "AQAAAAEAACcQAAAAEArf/eCx13QkOCZMTqJsmhThucrBbCs5CcYsDrRWwPZkeQLeZdVd4ookNUXVGfHBNg==", null, false, "", false, "truongtuantu@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "a72bdc63-9dc8-4e41-ad68-283b622f44d4", "5110f20d-8ac2-488e-b595-73c40b01ca14" },
                    { "4ff8841c-4c0e-4fef-8d59-3eb9c4b7185b", "1c8e8638-6958-40e2-a6da-5fd9a1d90737" },
                    { "034ea3fc-7f19-4b3a-95ce-3eeacec1dfd5", "e2799531-780f-46f5-bfa1-7260e13ce9cc" },
                    { "55ef1e13-3fb6-4017-bf0e-60f2987b7e92", "e2799531-780f-46f5-bfa1-7260e13ce9cc" },
                    { "f78eb325-3e13-46a5-914a-dc7dfaf1e7a8", "e2799531-780f-46f5-bfa1-7260e13ce9cc" },
                    { "f7b257c9-40ce-4630-8a98-62f3cc493bd0", "6da5a37c-6dfb-4c0f-8c50-0ee015e2b8ff" },
                    { "c2b998f4-f028-4711-9b48-a463d41f846e", "6da5a37c-6dfb-4c0f-8c50-0ee015e2b8ff" },
                    { "30175e6f-9285-4f5e-ad0c-50ee3e30f5e4", "1c8e8638-6958-40e2-a6da-5fd9a1d90737" },
                    { "7d0745f1-9708-47ba-87d3-b764af830815", "8c365b7f-fe07-456b-af5c-f2b4e1664bab" },
                    { "0e10be1e-d027-4264-8085-1fb2912a72f4", "8c365b7f-fe07-456b-af5c-f2b4e1664bab" },
                    { "3e9bdc07-72b7-4bc1-ad34-70b81cfcadd5", "8c365b7f-fe07-456b-af5c-f2b4e1664bab" },
                    { "356096a4-e37c-4504-bf77-2a9e77b2472b", "8c365b7f-fe07-456b-af5c-f2b4e1664bab" },
                    { "30f1f9b1-f9f7-42f9-ae64-cf47425caef9", "453e219e-c852-4038-a6cf-ebcefdab0e6e" },
                    { "890a3758-7089-4bb5-a653-04160a908fa1", "453e219e-c852-4038-a6cf-ebcefdab0e6e" },
                    { "3566b9ed-2cc8-42db-b812-14e756dbd3d3", "4a526ad2-3051-4ad0-99da-f365ab0e4cd8" },
                    { "01eeeedc-afcc-48f6-82fe-740ab870dc1e", "8c365b7f-fe07-456b-af5c-f2b4e1664bab" },
                    { "9e8ed0cb-2bc0-4f99-8109-a0a3a1c5b33f", "1c8e8638-6958-40e2-a6da-5fd9a1d90737" }
                });
        }
    }
}
