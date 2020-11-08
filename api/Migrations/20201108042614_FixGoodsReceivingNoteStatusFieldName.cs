using Microsoft.EntityFrameworkCore.Migrations;

namespace api.Migrations
{
    public partial class FixGoodsReceivingNoteStatusFieldName : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "0340791f-16fa-40a0-85bd-f1c4e3ec3200", "577e0659-2823-418c-adcb-51c3ffeaeff1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "29b948d8-5bc0-4283-a976-5d7ee7cc44fb", "a1c82185-1564-4597-b6f3-9b02ec0470f0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "2eee0fd8-922b-4d0e-9bcf-938d52e6138f", "79c213a3-9d25-4a4c-8a98-6b835e76f409" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "33084d0e-c9cf-4fab-855d-d2ded8c2014f", "79c213a3-9d25-4a4c-8a98-6b835e76f409" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "33c46cfb-4148-4aa9-94db-baf54e48f245", "577e0659-2823-418c-adcb-51c3ffeaeff1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "37bd3362-f7a9-45ee-acc5-02b5f60ce844", "c039be79-d405-4764-b4df-b34749baf00f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "8066a7e6-7380-4835-abb8-cbc319f0c003", "1094b8c6-7886-47e1-bc8c-fb75f96de0c4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "81f75a25-e1ee-49ef-8f87-2727d77702f9", "79c213a3-9d25-4a4c-8a98-6b835e76f409" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "83c6372b-836f-4135-966f-614749c282fe", "79c213a3-9d25-4a4c-8a98-6b835e76f409" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ce6a0663-f618-40e0-8593-6d34716ce4bf", "c039be79-d405-4764-b4df-b34749baf00f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "d5f63816-eeab-4c7c-b809-6a3ec17dd66a", "c3952002-d133-4b53-8455-1c9490da5484" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "df1ec3f1-f9bb-48fa-8f0c-9d775ea0e27c", "1094b8c6-7886-47e1-bc8c-fb75f96de0c4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "e9a7cac1-af26-42a5-99ed-653894b5632d", "53fc3e0d-b293-4c85-b7f5-cac631edc594" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "f5797555-2658-4440-a2e8-9bb33f28daf9", "53fc3e0d-b293-4c85-b7f5-cac631edc594" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "f9773d51-e83c-47d0-884f-086a091ea4a3", "79c213a3-9d25-4a4c-8a98-6b835e76f409" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "fc7fe62f-a37e-40b6-8a7f-1e6c19be0f24", "577e0659-2823-418c-adcb-51c3ffeaeff1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "fe343239-c764-4b79-b7f3-b34805556a20", "c039be79-d405-4764-b4df-b34749baf00f" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1094b8c6-7886-47e1-bc8c-fb75f96de0c4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "53fc3e0d-b293-4c85-b7f5-cac631edc594");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "577e0659-2823-418c-adcb-51c3ffeaeff1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "79c213a3-9d25-4a4c-8a98-6b835e76f409");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a1c82185-1564-4597-b6f3-9b02ec0470f0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c039be79-d405-4764-b4df-b34749baf00f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c3952002-d133-4b53-8455-1c9490da5484");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0340791f-16fa-40a0-85bd-f1c4e3ec3200");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29b948d8-5bc0-4283-a976-5d7ee7cc44fb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2eee0fd8-922b-4d0e-9bcf-938d52e6138f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33084d0e-c9cf-4fab-855d-d2ded8c2014f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "33c46cfb-4148-4aa9-94db-baf54e48f245");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "37bd3362-f7a9-45ee-acc5-02b5f60ce844");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8066a7e6-7380-4835-abb8-cbc319f0c003");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "81f75a25-e1ee-49ef-8f87-2727d77702f9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "83c6372b-836f-4135-966f-614749c282fe");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ce6a0663-f618-40e0-8593-6d34716ce4bf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d5f63816-eeab-4c7c-b809-6a3ec17dd66a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df1ec3f1-f9bb-48fa-8f0c-9d775ea0e27c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9a7cac1-af26-42a5-99ed-653894b5632d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f5797555-2658-4440-a2e8-9bb33f28daf9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f9773d51-e83c-47d0-884f-086a091ea4a3");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fc7fe62f-a37e-40b6-8a7f-1e6c19be0f24");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fe343239-c764-4b79-b7f3-b34805556a20");

            migrationBuilder.RenameColumn(
                name: "status",
                table: "GoodsReceivingNotes",
                newName: "Status");

            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "GoodsReceivingNotes",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_GoodsReceivingNotes_UserId",
                table: "GoodsReceivingNotes",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_GoodsReceivingNotes_AspNetUsers_UserId",
                table: "GoodsReceivingNotes",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GoodsReceivingNotes_AspNetUsers_UserId",
                table: "GoodsReceivingNotes");

            migrationBuilder.DropIndex(
                name: "IX_GoodsReceivingNotes_UserId",
                table: "GoodsReceivingNotes");

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

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "GoodsReceivingNotes");

            migrationBuilder.RenameColumn(
                name: "Status",
                table: "GoodsReceivingNotes",
                newName: "status");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c3952002-d133-4b53-8455-1c9490da5484", "eabf1d81-cbac-45da-9257-dd2417c2d7ad", "Admin", "admin" },
                    { "577e0659-2823-418c-adcb-51c3ffeaeff1", "6778b337-d341-4949-937b-f2739b02d998", "Sale", "sale" },
                    { "a1c82185-1564-4597-b6f3-9b02ec0470f0", "d983068a-16cd-4482-9b56-94fa0960d43c", "SuperAdmin", "superadmin" },
                    { "1094b8c6-7886-47e1-bc8c-fb75f96de0c4", "6e7afe0a-30ea-4c21-a12e-f5e286ecf34d", "WarehouseKeeperManager", "warehousekeepermanager" },
                    { "c039be79-d405-4764-b4df-b34749baf00f", "4368e3c7-3e3f-428b-ae9c-92441b2d457d", "WarehouseKeeper", "warehousekeeper" },
                    { "79c213a3-9d25-4a4c-8a98-6b835e76f409", "5b7710bf-51d7-43c6-adf1-54f4807b749c", "Customer", "customer" },
                    { "53fc3e0d-b293-4c85-b7f5-cac631edc594", "affcb579-a81c-4ea0-baa4-aa51b9a5df09", "Boss", "boss" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0340791f-16fa-40a0-85bd-f1c4e3ec3200", 0, "48e15d98-81e8-41a7-86f7-51a76b899b71", "phungthanhdo@gmail.com", true, "Độ", "Phùng Thanh", false, null, "PHUNGTHANHDO@GMAIL.COM", "PHUNGTHANHDO@GMAIL.COM", "AQAAAAEAACcQAAAAEEVO4St09IcffjLrX3u3f8Zw0BIauk6cl3SPwGoZJWSSSYuLLAV4mzh0GUsRj8Kb/A==", null, false, "", false, "phungthanhdo@gmail.com" },
                    { "37bd3362-f7a9-45ee-acc5-02b5f60ce844", 0, "bbeb456b-5d87-4a9e-81f4-0698bc0af697", "nguyenhue@gmail.com", true, "Huệ", "Nguyễn", false, null, "NGUYENHUE@GMAIL.COM", "NGUYENHUE@GMAIL.COM", "AQAAAAEAACcQAAAAEGuEj6FQCuvF0YxTh4o+BgLlAb9/OMNj1Ec9DIjHgJ8EfxM6lBPpU6MQNEimu14HWA==", null, false, "", false, "nguyenhue@gmail.com" },
                    { "ce6a0663-f618-40e0-8593-6d34716ce4bf", 0, "fc2a368c-857a-4095-aa25-8ace4891a034", "hoxuanhuong@gmail.com", true, "Hương", "Hồ Xuân", false, null, "HOXUANHUONG@GMAIL.COM", "HOXUANHUONG@GMAIL.COM", "AQAAAAEAACcQAAAAEG8YC45nTXezrSXTXI2v2kc7S9ER0CobApAWByN/9dyMMweafECyCfY+oXLuOUfP1w==", null, false, "", false, "hoxuanhuong@gmail.com" },
                    { "fe343239-c764-4b79-b7f3-b34805556a20", 0, "29e42f16-5f93-4ce2-a34a-1cfb05c1ccd9", "nguyenthanhlong@gmail.com", true, "Long", "Nguyễn Thành", false, null, "NGUYENTHANHLONG@GMAIL.COM", "NGUYENTHANHLONG@GMAIL.COM", "AQAAAAEAACcQAAAAEFnIV5Yswx5mTxTTzi1HNsXKfoV5Ixf79aPmWpN0Sj6PsmbI6sDqtHXbsn8qVmd6oQ==", null, false, "", false, "nguyenthanhlong@gmail.com" },
                    { "8066a7e6-7380-4835-abb8-cbc319f0c003", 0, "5bc5e9c4-2035-48fb-b8ab-83d1bd5df76f", "huynhtranthanh@gmail.com", true, "Thành", "Huỳnh Trấn", false, null, "HUYNHTRANTHANH@GMAIL.COM", "HUYNHTRANTHANH@GMAIL.COM", "AQAAAAEAACcQAAAAEHf2YNnzsOB7cFbNe0PK786b+qvn6h3bz7hshue2+siDZorbCUWGB2RnGsD/zdIiuA==", null, false, "", false, "huynhtranthanh@gmail.com" },
                    { "df1ec3f1-f9bb-48fa-8f0c-9d775ea0e27c", 0, "0e20529b-34dc-4389-afb3-76df869d9080", "caobaquat@gmail.com", true, "Quát", "Cao Bá", false, null, "CAOBAQUAT@GMAIL.COM", "CAOBAQUAT@GMAIL.COM", "AQAAAAEAACcQAAAAECawn0pEbn/2hi3ERq6bYNvjvOWQ5xEyYPlzH+ZFXtz9lUFlPBlJhhv7xjYxLoe64w==", null, false, "", false, "caobaquat@gmail.com" },
                    { "f9773d51-e83c-47d0-884f-086a091ea4a3", 0, "51e65cf4-ccef-408b-8fb4-1b3695b20b4f", "truongthitramanh@gmail.com", true, "Anh", "Trương Thị Trâm", false, null, "TRUONGTHITRAMANH@GMAIL.COM", "TRUONGTHITRAMANH@GMAIL.COM", "AQAAAAEAACcQAAAAEEmvg4nn2HHmwVpeIMCdd6qJA3QPrgkq/ZBbbmlDA/2i/KHWlXfIqjWAsVfOnXx42Q==", null, false, "", false, "truongthitramanh@gmail.com" },
                    { "83c6372b-836f-4135-966f-614749c282fe", 0, "6cf7654b-609f-4d16-825d-a4a5ad61aa26", "nguyentrunghieu@gmail.com", true, "Hiếu", "Nguyễn Trung", false, null, "NGUYENTRUNGHIEU@GMAIL.COM", "NGUYENTRUNGHIEU@GMAIL.COM", "AQAAAAEAACcQAAAAEAiX56nzYeReZri2sxdzCnJAQKZ0EyqwN8FGGY4UzX8FiaX4YtkNK3Q/HjnAL59FXQ==", null, false, "", false, "nguyentrunghieu@gmail.com" },
                    { "2eee0fd8-922b-4d0e-9bcf-938d52e6138f", 0, "725d5f7a-a989-4b4e-8286-f31f1169569d", "caothivananh@gmail.com", true, "Anh", "Cao Thị Vân", false, null, "CAOTHIVANANH@GMAIL.COM", "CAOTHIVANANH@GMAIL.COM", "AQAAAAEAACcQAAAAEGPHcyxKfEAnzSD+TJwfkAG72Pv3afc/44SfSA3seKI7TC0ziXurmKbDh1/M4t5OPQ==", null, false, "", false, "caothivananh@gmail.com" },
                    { "33084d0e-c9cf-4fab-855d-d2ded8c2014f", 0, "fd123a45-828c-4e00-9e04-fd1c4ff1a391", "nguyennhuloc@gmail.com", true, "Lộc", "Nguyễn Như", false, null, "NGUYENNHULOC@GMAIL.COM", "NGUYENNHULOC@GMAIL.COM", "AQAAAAEAACcQAAAAEEo3HlOz9ed2U9J6HpSCLyNeIwPpTb7xpdBcQUkbma4EkaF5CStww9wzUI5Gds3G0A==", null, false, "", false, "nguyennhuloc@gmail.com" },
                    { "33c46cfb-4148-4aa9-94db-baf54e48f245", 0, "0f09f774-9dc1-4a0b-be18-a2bb8ebefe84", "phantantrung@gmail.com", true, "Trung", "Phan Tấn", false, null, "PHANTANTRUNG@GMAIL.COM", "PHANTANTRUNG@GMAIL.COM", "AQAAAAEAACcQAAAAEDoXFDNJGIKHgO+IyAMkKCqfmcOqI3z6//aLslXVsCXoy0rml+Wscru6rW+8Pi/aSw==", null, false, "", false, "phantantrung@gmail.com" },
                    { "f5797555-2658-4440-a2e8-9bb33f28daf9", 0, "b6977643-7024-49a9-a57b-992401808a2c", "phamvinhson@gmail.com", true, "Sơn", "Phạm Vĩnh", false, null, "PHAMVINHSON@GMAIL.COM", "PHAMVINHSON@GMAIL.COM", "AQAAAAEAACcQAAAAEFebH97hZLZhXfDhx5BgZ3r5o1XpRYGQ62LFc5n9pr/gjNeTroixZPbMUuZLDzgiYg==", null, false, "", false, "phamvinhson@gmail.com" },
                    { "e9a7cac1-af26-42a5-99ed-653894b5632d", 0, "9be5db4d-b975-4109-8f12-5ddfc39058a7", "trankieuloan@gmail.com", true, "Loan", "Trần Kiều", false, null, "TRANKIEULOAN@GMAIL.COM", "TRANKIEULOAN@GMAIL.COM", "AQAAAAEAACcQAAAAEKECQW2pUmhKeMelKsxsLLQ/rvYQklo40GSWifcV50qYjzVNc06DsJ/XX9Ho65PSfQ==", null, false, "", false, "trankieuloan@gmail.com" },
                    { "d5f63816-eeab-4c7c-b809-6a3ec17dd66a", 0, "ab38fec6-c51f-4fe6-9029-c0a045377632", "yungadmin@gmail.com", true, "Admin", "Yung", false, null, "YUNGADMIN@GMAIL.COM", "YUNGADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEPs3bmGQxEOypTQlo7gpV3IxRy9RL1uNJcyQnt183VumcB9MZCIJhqcaxfvOIZG4PQ==", null, false, "", false, "yungadmin@gmail.com" },
                    { "29b948d8-5bc0-4283-a976-5d7ee7cc44fb", 0, "09bab8ab-80a8-40f6-a1c2-547cfda1226f", "lilsuperadmin@gmail.com", true, "Super Admin", "Lil", false, null, "LILSUPERADMIN@GMAIL.COM", "LILSUPERADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAECld6p5YFniaP6EW7x7F+Ida23rITjI3KuXXyMdkusljb9qC784nvD4pt5wUj6GZJQ==", null, false, "", false, "lilsuperadmin@gmail.com" },
                    { "81f75a25-e1ee-49ef-8f87-2727d77702f9", 0, "80c757ff-af72-4b31-a9e2-d0d8ea5c5321", "tranthaonguyen@gmail.com", true, "Nguyên", "Trần Thảo", false, null, "TRANTHAONGUYEN@GMAIL.COM", "TRANTHAONGUYEN@GMAIL.COM", "AQAAAAEAACcQAAAAECCnawPeVOX87IuJGV7DAVd9g/95hwNtGjTmdlFL42cWHdBcSi9CMaLJqWBbx1RkjQ==", null, false, "", false, "tranthaonguyen@gmail.com" },
                    { "fc7fe62f-a37e-40b6-8a7f-1e6c19be0f24", 0, "334b452b-010f-405f-bd22-f8872bd39b58", "truongtuantu@gmail.com", true, "Tú", "Trương Tuấn", false, null, "TRUONGTUANTU@GMAIL.COM", "TRUONGTUANTU@GMAIL.COM", "AQAAAAEAACcQAAAAEEVKXofhfqI66ouNccmwTLFriahKT1ND3YAlwJ3Z02bbOcpERFocpuvtPOIKUF78bg==", null, false, "", false, "truongtuantu@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "29b948d8-5bc0-4283-a976-5d7ee7cc44fb", "a1c82185-1564-4597-b6f3-9b02ec0470f0" },
                    { "0340791f-16fa-40a0-85bd-f1c4e3ec3200", "577e0659-2823-418c-adcb-51c3ffeaeff1" },
                    { "37bd3362-f7a9-45ee-acc5-02b5f60ce844", "c039be79-d405-4764-b4df-b34749baf00f" },
                    { "ce6a0663-f618-40e0-8593-6d34716ce4bf", "c039be79-d405-4764-b4df-b34749baf00f" },
                    { "fe343239-c764-4b79-b7f3-b34805556a20", "c039be79-d405-4764-b4df-b34749baf00f" },
                    { "8066a7e6-7380-4835-abb8-cbc319f0c003", "1094b8c6-7886-47e1-bc8c-fb75f96de0c4" },
                    { "df1ec3f1-f9bb-48fa-8f0c-9d775ea0e27c", "1094b8c6-7886-47e1-bc8c-fb75f96de0c4" },
                    { "33c46cfb-4148-4aa9-94db-baf54e48f245", "577e0659-2823-418c-adcb-51c3ffeaeff1" },
                    { "f9773d51-e83c-47d0-884f-086a091ea4a3", "79c213a3-9d25-4a4c-8a98-6b835e76f409" },
                    { "2eee0fd8-922b-4d0e-9bcf-938d52e6138f", "79c213a3-9d25-4a4c-8a98-6b835e76f409" },
                    { "33084d0e-c9cf-4fab-855d-d2ded8c2014f", "79c213a3-9d25-4a4c-8a98-6b835e76f409" },
                    { "83c6372b-836f-4135-966f-614749c282fe", "79c213a3-9d25-4a4c-8a98-6b835e76f409" },
                    { "f5797555-2658-4440-a2e8-9bb33f28daf9", "53fc3e0d-b293-4c85-b7f5-cac631edc594" },
                    { "e9a7cac1-af26-42a5-99ed-653894b5632d", "53fc3e0d-b293-4c85-b7f5-cac631edc594" },
                    { "d5f63816-eeab-4c7c-b809-6a3ec17dd66a", "c3952002-d133-4b53-8455-1c9490da5484" },
                    { "81f75a25-e1ee-49ef-8f87-2727d77702f9", "79c213a3-9d25-4a4c-8a98-6b835e76f409" },
                    { "fc7fe62f-a37e-40b6-8a7f-1e6c19be0f24", "577e0659-2823-418c-adcb-51c3ffeaeff1" }
                });
        }
    }
}
