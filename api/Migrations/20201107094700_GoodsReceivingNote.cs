using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace api.Migrations
{
    public partial class GoodsReceivingNote : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "04c1916f-eb52-46db-981c-762b9957e25c", "3ee11948-4c99-4fbd-8e61-ef3601bce794" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "0a27c5af-06f0-464b-80b9-bbefcd963730", "5079e708-33e5-4419-8ff5-9901304ae134" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "21ba26ca-04ab-4ef9-8667-b7ea9a908d46", "26aceecc-20b9-4934-82d1-7ff18eb3da23" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "380e17cb-fe13-4107-9621-d257e6ba6dba", "375da43b-81b4-4977-9158-7f44988fd3e4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "6ad07f1d-4c95-4532-a831-e4cc80543fc0", "26aceecc-20b9-4934-82d1-7ff18eb3da23" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "7f689288-ce66-4c15-b5e8-2782dc8559bd", "375da43b-81b4-4977-9158-7f44988fd3e4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "84f8b688-c9d7-4084-8cf0-1ae773a303ea", "375da43b-81b4-4977-9158-7f44988fd3e4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "85ce5c89-56dd-4fbf-b2ad-0ccfe069679e", "a2c3f740-cb6e-494b-93f7-1105ee89996d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "9dcd0027-cae0-4af6-b9e8-1f1a6a96efe2", "a2c3f740-cb6e-494b-93f7-1105ee89996d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "b4f1c462-acce-49b4-895a-7d1d989ad264", "3ee11948-4c99-4fbd-8e61-ef3601bce794" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "d0fec2f3-fcbf-4fcc-bc2a-f14d31065dc7", "a2c3f740-cb6e-494b-93f7-1105ee89996d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "d475f04e-6f9a-4f13-b8ea-b099b5aa84db", "375da43b-81b4-4977-9158-7f44988fd3e4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "d65c44d7-3f3a-41e5-b42d-1e60fb7fe90a", "523d34bb-4034-4752-9e72-2412e97d7617" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "d9dceed0-3978-4136-ba4d-89feee4a0445", "2b864b94-804d-4ee7-868c-976268cd8c19" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "e88e0cbd-3988-40f7-8991-dfa33282a6f5", "5079e708-33e5-4419-8ff5-9901304ae134" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "f1bee162-1c5a-4890-acb0-d2cdaf55a8c8", "5079e708-33e5-4419-8ff5-9901304ae134" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "f4191ce9-fca7-4f54-bfef-e918192984c0", "375da43b-81b4-4977-9158-7f44988fd3e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "26aceecc-20b9-4934-82d1-7ff18eb3da23");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2b864b94-804d-4ee7-868c-976268cd8c19");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "375da43b-81b4-4977-9158-7f44988fd3e4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3ee11948-4c99-4fbd-8e61-ef3601bce794");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5079e708-33e5-4419-8ff5-9901304ae134");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "523d34bb-4034-4752-9e72-2412e97d7617");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a2c3f740-cb6e-494b-93f7-1105ee89996d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04c1916f-eb52-46db-981c-762b9957e25c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0a27c5af-06f0-464b-80b9-bbefcd963730");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21ba26ca-04ab-4ef9-8667-b7ea9a908d46");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "380e17cb-fe13-4107-9621-d257e6ba6dba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6ad07f1d-4c95-4532-a831-e4cc80543fc0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7f689288-ce66-4c15-b5e8-2782dc8559bd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84f8b688-c9d7-4084-8cf0-1ae773a303ea");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "85ce5c89-56dd-4fbf-b2ad-0ccfe069679e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9dcd0027-cae0-4af6-b9e8-1f1a6a96efe2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b4f1c462-acce-49b4-895a-7d1d989ad264");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0fec2f3-fcbf-4fcc-bc2a-f14d31065dc7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d475f04e-6f9a-4f13-b8ea-b099b5aa84db");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d65c44d7-3f3a-41e5-b42d-1e60fb7fe90a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d9dceed0-3978-4136-ba4d-89feee4a0445");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e88e0cbd-3988-40f7-8991-dfa33282a6f5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f1bee162-1c5a-4890-acb0-d2cdaf55a8c8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f4191ce9-fca7-4f54-bfef-e918192984c0");

            migrationBuilder.CreateTable(
                name: "GoodsReceivingNotes",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedAt = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    status = table.Column<int>(nullable: false),
                    SupplierName = table.Column<string>(nullable: true),
                    SupplierId = table.Column<int>(nullable: false),
                    Decription = table.Column<string>(nullable: true),
                    ExceptionReason = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoodsReceivingNotes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GoodsReceivingDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedAt = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    GoodsReceivingNoteId = table.Column<int>(nullable: false),
                    Quantity = table.Column<double>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoodsReceivingDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GoodsReceivingDetails_GoodsReceivingNotes_GoodsReceivingNoteId",
                        column: x => x.GoodsReceivingNoteId,
                        principalTable: "GoodsReceivingNotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GoodsReceivingDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "6d176cd3-bb32-446e-8805-d8d846b1e224", "b1e783d2-29a2-4ad1-af8e-e9871e78ffbf", "Admin", "admin" },
                    { "9763a45d-acad-4d5a-a6c0-6c395007765e", "64d37a32-d1eb-4e4b-b8f2-defd8a1a4a65", "Sale", "sale" },
                    { "0d5b49f3-9c6e-400d-905d-1ce4c32fe89f", "5b0531cc-df23-4e30-9490-4d20faf18f7e", "SuperAdmin", "superadmin" },
                    { "fd8e5cfa-30ae-473b-9ca3-c43d28c29f9f", "065d9b34-5b71-4508-8536-a3d9000faef3", "WarehouseKeeperManager", "warehousekeepermanager" },
                    { "80c68b9a-9567-4acf-a1a1-55cd93489a5e", "4d128e77-4fa3-4c0f-a8a2-64cb27755987", "WarehouseKeeper", "warehousekeeper" },
                    { "875f2812-b28f-4135-bf58-f072fe3de158", "7e8fc4a0-8b21-43ec-91c6-39aba0c3cac3", "Customer", "customer" },
                    { "2027c67f-9417-47a7-89c4-da9bd5072fd4", "e1228026-fae5-42b4-992a-d8a55f951d4c", "Boss", "boss" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "30dab8fa-2de3-43e9-9196-f4174d3ef369", 0, "a623a907-6676-447d-88b8-27b6128c47a6", "phungthanhdo@gmail.com", true, "Độ", "Phùng Thanh", false, null, "PHUNGTHANHDO@GMAIL.COM", "PHUNGTHANHDO@GMAIL.COM", "AQAAAAEAACcQAAAAELk9dr++Vs3S7c2Ocbe0Oar+0Dwkd8IutL7EIIHXWxyb9HV0a+LHZUce1Fy0kMXaVg==", null, false, "", false, "phungthanhdo@gmail.com" },
                    { "fa91cfed-d3e5-495a-998d-8939a753f2a6", 0, "0de06739-0cb1-49fd-98ca-f4e1d90a785a", "nguyenhue@gmail.com", true, "Huệ", "Nguyễn", false, null, "NGUYENHUE@GMAIL.COM", "NGUYENHUE@GMAIL.COM", "AQAAAAEAACcQAAAAEAPusCRxCdA3+McuwiUJI/NXp9bexaFRuEEPVYHlu0sTWb/P/w0R/0hKO5JN0ZK4bA==", null, false, "", false, "nguyenhue@gmail.com" },
                    { "275ccd8e-f8c5-4b18-b7ef-96138b62670e", 0, "ab4d4f15-c583-40ec-8ec6-fe7dc0612136", "hoxuanhuong@gmail.com", true, "Hương", "Hồ Xuân", false, null, "HOXUANHUONG@GMAIL.COM", "HOXUANHUONG@GMAIL.COM", "AQAAAAEAACcQAAAAECDLpApFU4iv1rNrtWcHcYE4GXb0518djKuJu+PucS12tjaUcM5zRPH5Go8AH0HSzg==", null, false, "", false, "hoxuanhuong@gmail.com" },
                    { "9dacd3c4-0de2-4aef-9f6f-70cfe2804c33", 0, "af2ae480-2ad1-4d5a-8f70-816716435b38", "nguyenthanhlong@gmail.com", true, "Long", "Nguyễn Thành", false, null, "NGUYENTHANHLONG@GMAIL.COM", "NGUYENTHANHLONG@GMAIL.COM", "AQAAAAEAACcQAAAAEDQHV4XUG5TZkDKFKJDQs1rrciOhUDWgby5Xo4b68T1eLLo+JpNRjGfGuGKGw10O8w==", null, false, "", false, "nguyenthanhlong@gmail.com" },
                    { "b662d244-731d-4a9d-b0b5-56d0d361ff0f", 0, "22995175-3364-4cf6-86fa-31bd17643dd5", "huynhtranthanh@gmail.com", true, "Thành", "Huỳnh Trấn", false, null, "HUYNHTRANTHANH@GMAIL.COM", "HUYNHTRANTHANH@GMAIL.COM", "AQAAAAEAACcQAAAAEBZC5FDMzCqYnt5VAaBN/aiqVVIirrC9d19Rt8M6sCx0gVR9bM4S1GYSPaSF7LusuQ==", null, false, "", false, "huynhtranthanh@gmail.com" },
                    { "61538861-71d6-44d1-81b7-9ec0e0262c54", 0, "fc42bc03-110b-46ab-8b95-47ecbcb5a419", "caobaquat@gmail.com", true, "Quát", "Cao Bá", false, null, "CAOBAQUAT@GMAIL.COM", "CAOBAQUAT@GMAIL.COM", "AQAAAAEAACcQAAAAEHy1fZAKT/OPZuOiArv4jj+r/RqUDVLrUK4g6VZ8J2JBTxfFVNIx30fl7ZWl1AiL+A==", null, false, "", false, "caobaquat@gmail.com" },
                    { "f7cb4b66-1c25-49ea-983b-c267e5ecc916", 0, "7b274671-e053-47f7-8f7b-362f86f9a7d1", "truongthitramanh@gmail.com", true, "Anh", "Trương Thị Trâm", false, null, "TRUONGTHITRAMANH@GMAIL.COM", "TRUONGTHITRAMANH@GMAIL.COM", "AQAAAAEAACcQAAAAEMNQ24PPYH6cDJxWzfmTB8uQYUV61zN61lXJ2KMSSCvk48boB+VtQTIyrCdPGhRAuA==", null, false, "", false, "truongthitramanh@gmail.com" },
                    { "c197acbd-9ab8-45d6-bf90-58de9792cddc", 0, "d3cdb0f8-6d6e-4605-8c2c-48bdaa3bcf45", "nguyentrunghieu@gmail.com", true, "Hiếu", "Nguyễn Trung", false, null, "NGUYENTRUNGHIEU@GMAIL.COM", "NGUYENTRUNGHIEU@GMAIL.COM", "AQAAAAEAACcQAAAAEKZiOI90Vpd+iZkNBRMkUcHPkTXKe+qtf4+PgdR7DxRp+S2FVnFFNZDXLdF+8U1m8g==", null, false, "", false, "nguyentrunghieu@gmail.com" },
                    { "5c32abf2-3dd2-4b16-a50f-bdc06d8edcaa", 0, "89aaf398-feea-4f8d-ac17-af8cfbf2e8f0", "caothivananh@gmail.com", true, "Anh", "Cao Thị Vân", false, null, "CAOTHIVANANH@GMAIL.COM", "CAOTHIVANANH@GMAIL.COM", "AQAAAAEAACcQAAAAEAwGc041NyQibDstbDMwUHHSCvw5iRYXbnTz6524G6535mnNZrOOCmSn4Gmq3CnO0w==", null, false, "", false, "caothivananh@gmail.com" },
                    { "82b0beeb-18c0-4bb8-b2d9-a4c62f02f449", 0, "266519b6-7982-4d9d-a657-87b9aaffe6a2", "nguyennhuloc@gmail.com", true, "Lộc", "Nguyễn Như", false, null, "NGUYENNHULOC@GMAIL.COM", "NGUYENNHULOC@GMAIL.COM", "AQAAAAEAACcQAAAAEFptRCCD/+oppbp0HJQ9i0R555cT9xjNbpuSayMDEKnpVCKxLQe5DUqB3wP/4hrZ7g==", null, false, "", false, "nguyennhuloc@gmail.com" },
                    { "9e26febb-7d23-4fb7-9a3a-fc084a26a79a", 0, "f06609ea-a768-40ea-b0b5-e7360bb41882", "phantantrung@gmail.com", true, "Trung", "Phan Tấn", false, null, "PHANTANTRUNG@GMAIL.COM", "PHANTANTRUNG@GMAIL.COM", "AQAAAAEAACcQAAAAEEb7Bak5c7KJSi1xNY7A+dhRpj7x7USLLW/ef9vyIB3xRGmocfhTq+vvntY/va1yEw==", null, false, "", false, "phantantrung@gmail.com" },
                    { "07aac85e-183b-4674-8423-41ae14ea7450", 0, "e9e9b119-980c-410d-aa53-389ce4b7cd5a", "phamvinhson@gmail.com", true, "Sơn", "Phạm Vĩnh", false, null, "PHAMVINHSON@GMAIL.COM", "PHAMVINHSON@GMAIL.COM", "AQAAAAEAACcQAAAAEPLHwasOyqWL62MdFV/yi1ALu6ch6dO41HvxQ4UQ46qADp9Myfzzi9cxWfQ5LuZrFw==", null, false, "", false, "phamvinhson@gmail.com" },
                    { "03b3d9a5-e863-4e98-a953-5770975a9bad", 0, "13e57c27-f665-48b2-a34a-ec98a853fd4b", "trankieuloan@gmail.com", true, "Loan", "Trần Kiều", false, null, "TRANKIEULOAN@GMAIL.COM", "TRANKIEULOAN@GMAIL.COM", "AQAAAAEAACcQAAAAEIqx5PbgGbwSYUMBspwhPekhYElK6TFIpyVMdgEXRAfdIUE6v+21LPlDvu/pFgMp5Q==", null, false, "", false, "trankieuloan@gmail.com" },
                    { "019c57e9-704a-4719-b836-ec61e2b31f0f", 0, "75054df3-4719-4b8f-a829-21e5e86566c8", "yungadmin@gmail.com", true, "Admin", "Yung", false, null, "YUNGADMIN@GMAIL.COM", "YUNGADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEB8VDNLUJPDNooZt+BmoLFB/Aurhak83zk1xjNb7Yrp7dYbqqRG5LlSNZufB92Mr5w==", null, false, "", false, "yungadmin@gmail.com" },
                    { "8a5d8929-1f42-4d11-a9f6-e4f42580e51e", 0, "ad0bd460-fe38-47cd-ba36-89c9a2cbf325", "lilsuperadmin@gmail.com", true, "Super Admin", "Lil", false, null, "LILSUPERADMIN@GMAIL.COM", "LILSUPERADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEKQX5UwDAxB6VR5wzoXPqZJiNti9DjUSfd3SlMrtWriLE7UKzQbO4clDebwy7BIWdg==", null, false, "", false, "lilsuperadmin@gmail.com" },
                    { "e11a5c32-6e8d-4c61-9f5a-8ef49dca5a7c", 0, "049b89ed-018a-4c9b-ae43-9fb2d16f7fec", "tranthaonguyen@gmail.com", true, "Nguyên", "Trần Thảo", false, null, "TRANTHAONGUYEN@GMAIL.COM", "TRANTHAONGUYEN@GMAIL.COM", "AQAAAAEAACcQAAAAENQ+KwXfPJJHW0k7xFbbWg0HCUwaGiTt3oE1btONorWNZOQBWQpsajdBEnqNZoO3kA==", null, false, "", false, "tranthaonguyen@gmail.com" },
                    { "f352c3a6-8828-412d-b577-f03670d99119", 0, "ab7e63fa-ffd6-4f01-9bee-fcf491e52cd2", "truongtuantu@gmail.com", true, "Tú", "Trương Tuấn", false, null, "TRUONGTUANTU@GMAIL.COM", "TRUONGTUANTU@GMAIL.COM", "AQAAAAEAACcQAAAAEGcSdLuN36qZEdDLpEbHQMbvZBv991xAfZIlXEPmtsiqff+SefjbAfwO+oVLVEJyOw==", null, false, "", false, "truongtuantu@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "8a5d8929-1f42-4d11-a9f6-e4f42580e51e", "0d5b49f3-9c6e-400d-905d-1ce4c32fe89f" },
                    { "30dab8fa-2de3-43e9-9196-f4174d3ef369", "9763a45d-acad-4d5a-a6c0-6c395007765e" },
                    { "fa91cfed-d3e5-495a-998d-8939a753f2a6", "80c68b9a-9567-4acf-a1a1-55cd93489a5e" },
                    { "275ccd8e-f8c5-4b18-b7ef-96138b62670e", "80c68b9a-9567-4acf-a1a1-55cd93489a5e" },
                    { "9dacd3c4-0de2-4aef-9f6f-70cfe2804c33", "80c68b9a-9567-4acf-a1a1-55cd93489a5e" },
                    { "b662d244-731d-4a9d-b0b5-56d0d361ff0f", "fd8e5cfa-30ae-473b-9ca3-c43d28c29f9f" },
                    { "61538861-71d6-44d1-81b7-9ec0e0262c54", "fd8e5cfa-30ae-473b-9ca3-c43d28c29f9f" },
                    { "9e26febb-7d23-4fb7-9a3a-fc084a26a79a", "9763a45d-acad-4d5a-a6c0-6c395007765e" },
                    { "f7cb4b66-1c25-49ea-983b-c267e5ecc916", "875f2812-b28f-4135-bf58-f072fe3de158" },
                    { "5c32abf2-3dd2-4b16-a50f-bdc06d8edcaa", "875f2812-b28f-4135-bf58-f072fe3de158" },
                    { "82b0beeb-18c0-4bb8-b2d9-a4c62f02f449", "875f2812-b28f-4135-bf58-f072fe3de158" },
                    { "c197acbd-9ab8-45d6-bf90-58de9792cddc", "875f2812-b28f-4135-bf58-f072fe3de158" },
                    { "07aac85e-183b-4674-8423-41ae14ea7450", "2027c67f-9417-47a7-89c4-da9bd5072fd4" },
                    { "03b3d9a5-e863-4e98-a953-5770975a9bad", "2027c67f-9417-47a7-89c4-da9bd5072fd4" },
                    { "019c57e9-704a-4719-b836-ec61e2b31f0f", "6d176cd3-bb32-446e-8805-d8d846b1e224" },
                    { "e11a5c32-6e8d-4c61-9f5a-8ef49dca5a7c", "875f2812-b28f-4135-bf58-f072fe3de158" },
                    { "f352c3a6-8828-412d-b577-f03670d99119", "9763a45d-acad-4d5a-a6c0-6c395007765e" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_GoodsReceivingDetails_GoodsReceivingNoteId",
                table: "GoodsReceivingDetails",
                column: "GoodsReceivingNoteId");

            migrationBuilder.CreateIndex(
                name: "IX_GoodsReceivingDetails_ProductId",
                table: "GoodsReceivingDetails",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GoodsReceivingDetails");

            migrationBuilder.DropTable(
                name: "GoodsReceivingNotes");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "019c57e9-704a-4719-b836-ec61e2b31f0f", "6d176cd3-bb32-446e-8805-d8d846b1e224" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "03b3d9a5-e863-4e98-a953-5770975a9bad", "2027c67f-9417-47a7-89c4-da9bd5072fd4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "07aac85e-183b-4674-8423-41ae14ea7450", "2027c67f-9417-47a7-89c4-da9bd5072fd4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "275ccd8e-f8c5-4b18-b7ef-96138b62670e", "80c68b9a-9567-4acf-a1a1-55cd93489a5e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "30dab8fa-2de3-43e9-9196-f4174d3ef369", "9763a45d-acad-4d5a-a6c0-6c395007765e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "5c32abf2-3dd2-4b16-a50f-bdc06d8edcaa", "875f2812-b28f-4135-bf58-f072fe3de158" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "61538861-71d6-44d1-81b7-9ec0e0262c54", "fd8e5cfa-30ae-473b-9ca3-c43d28c29f9f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "82b0beeb-18c0-4bb8-b2d9-a4c62f02f449", "875f2812-b28f-4135-bf58-f072fe3de158" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "8a5d8929-1f42-4d11-a9f6-e4f42580e51e", "0d5b49f3-9c6e-400d-905d-1ce4c32fe89f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "9dacd3c4-0de2-4aef-9f6f-70cfe2804c33", "80c68b9a-9567-4acf-a1a1-55cd93489a5e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "9e26febb-7d23-4fb7-9a3a-fc084a26a79a", "9763a45d-acad-4d5a-a6c0-6c395007765e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "b662d244-731d-4a9d-b0b5-56d0d361ff0f", "fd8e5cfa-30ae-473b-9ca3-c43d28c29f9f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "c197acbd-9ab8-45d6-bf90-58de9792cddc", "875f2812-b28f-4135-bf58-f072fe3de158" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "e11a5c32-6e8d-4c61-9f5a-8ef49dca5a7c", "875f2812-b28f-4135-bf58-f072fe3de158" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "f352c3a6-8828-412d-b577-f03670d99119", "9763a45d-acad-4d5a-a6c0-6c395007765e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "f7cb4b66-1c25-49ea-983b-c267e5ecc916", "875f2812-b28f-4135-bf58-f072fe3de158" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "fa91cfed-d3e5-495a-998d-8939a753f2a6", "80c68b9a-9567-4acf-a1a1-55cd93489a5e" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0d5b49f3-9c6e-400d-905d-1ce4c32fe89f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2027c67f-9417-47a7-89c4-da9bd5072fd4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6d176cd3-bb32-446e-8805-d8d846b1e224");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "80c68b9a-9567-4acf-a1a1-55cd93489a5e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "875f2812-b28f-4135-bf58-f072fe3de158");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9763a45d-acad-4d5a-a6c0-6c395007765e");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fd8e5cfa-30ae-473b-9ca3-c43d28c29f9f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "019c57e9-704a-4719-b836-ec61e2b31f0f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "03b3d9a5-e863-4e98-a953-5770975a9bad");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "07aac85e-183b-4674-8423-41ae14ea7450");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "275ccd8e-f8c5-4b18-b7ef-96138b62670e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "30dab8fa-2de3-43e9-9196-f4174d3ef369");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5c32abf2-3dd2-4b16-a50f-bdc06d8edcaa");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "61538861-71d6-44d1-81b7-9ec0e0262c54");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "82b0beeb-18c0-4bb8-b2d9-a4c62f02f449");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8a5d8929-1f42-4d11-a9f6-e4f42580e51e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9dacd3c4-0de2-4aef-9f6f-70cfe2804c33");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9e26febb-7d23-4fb7-9a3a-fc084a26a79a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b662d244-731d-4a9d-b0b5-56d0d361ff0f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c197acbd-9ab8-45d6-bf90-58de9792cddc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e11a5c32-6e8d-4c61-9f5a-8ef49dca5a7c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f352c3a6-8828-412d-b577-f03670d99119");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f7cb4b66-1c25-49ea-983b-c267e5ecc916");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fa91cfed-d3e5-495a-998d-8939a753f2a6");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2b864b94-804d-4ee7-868c-976268cd8c19", "751f72a7-084b-4a6a-b6a1-153fed577774", "Admin", "admin" },
                    { "5079e708-33e5-4419-8ff5-9901304ae134", "22d9bd21-2e29-4c5e-82f3-73b5a5e3f65d", "Sale", "sale" },
                    { "523d34bb-4034-4752-9e72-2412e97d7617", "ac7822f8-c9bf-44d4-8275-f60eafcd3376", "SuperAdmin", "superadmin" },
                    { "3ee11948-4c99-4fbd-8e61-ef3601bce794", "0cc903ea-2312-4e74-ac04-90dc22612180", "WarehouseKeeperManager", "warehousekeepermanager" },
                    { "a2c3f740-cb6e-494b-93f7-1105ee89996d", "8834a9f7-9c93-4179-8a6f-2010008c267f", "WarehouseKeeper", "warehousekeeper" },
                    { "375da43b-81b4-4977-9158-7f44988fd3e4", "ff918693-6eb6-4564-85d0-327744c54a84", "Customer", "customer" },
                    { "26aceecc-20b9-4934-82d1-7ff18eb3da23", "29357050-7c3a-4676-83d3-152373ec90b3", "Boss", "boss" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "f1bee162-1c5a-4890-acb0-d2cdaf55a8c8", 0, "1bf64a7e-2e94-4745-988d-b8ae98864a0f", "phungthanhdo@gmail.com", true, "Độ", "Phùng Thanh", false, null, "PHUNGTHANHDO@GMAIL.COM", "PHUNGTHANHDO@GMAIL.COM", "AQAAAAEAACcQAAAAEOBh2rfQTzJ/tCAxwSIHTDNCumioTFohO8tDkPXo0yv4vlV8BipaxTFUtOaRgIRLPA==", null, false, "", false, "phungthanhdo@gmail.com" },
                    { "d0fec2f3-fcbf-4fcc-bc2a-f14d31065dc7", 0, "746625e1-07c1-4238-bdbc-f8101aad5805", "nguyenhue@gmail.com", true, "Huệ", "Nguyễn", false, null, "NGUYENHUE@GMAIL.COM", "NGUYENHUE@GMAIL.COM", "AQAAAAEAACcQAAAAEOGT1qw7Hnep8Hc00uwSALdSmq8rNlYM80ZvY7guajSIxZpnOAXPi2+h6vwRCEOZaA==", null, false, "", false, "nguyenhue@gmail.com" },
                    { "9dcd0027-cae0-4af6-b9e8-1f1a6a96efe2", 0, "c151f167-496e-4770-aa26-b4b8b2554d14", "hoxuanhuong@gmail.com", true, "Hương", "Hồ Xuân", false, null, "HOXUANHUONG@GMAIL.COM", "HOXUANHUONG@GMAIL.COM", "AQAAAAEAACcQAAAAEObeDnLOkIILDkhq+L4bPFrnTdU9xoOg2pTnRq+vhdfgZzujjvGXYo57HVDA3s1X/A==", null, false, "", false, "hoxuanhuong@gmail.com" },
                    { "85ce5c89-56dd-4fbf-b2ad-0ccfe069679e", 0, "7550bd7a-7571-467f-9687-8be743196213", "nguyenthanhlong@gmail.com", true, "Long", "Nguyễn Thành", false, null, "NGUYENTHANHLONG@GMAIL.COM", "NGUYENTHANHLONG@GMAIL.COM", "AQAAAAEAACcQAAAAECUEhpn6O+dwpqRHUmCvkgtIyDroHSvZvvB7cHJvVJmRE4GR9NMFj0RV4dIgZQQ08Q==", null, false, "", false, "nguyenthanhlong@gmail.com" },
                    { "04c1916f-eb52-46db-981c-762b9957e25c", 0, "4e4366c5-1f5a-4727-9040-e989aa469594", "huynhtranthanh@gmail.com", true, "Thành", "Huỳnh Trấn", false, null, "HUYNHTRANTHANH@GMAIL.COM", "HUYNHTRANTHANH@GMAIL.COM", "AQAAAAEAACcQAAAAEH4B+g21wHFD+bpTxmXVS7hu9ZoalVFbTNWGxkSH5aO82aMJJ6LgI7CrICYadrc9Ow==", null, false, "", false, "huynhtranthanh@gmail.com" },
                    { "b4f1c462-acce-49b4-895a-7d1d989ad264", 0, "8e041071-6834-4857-b177-ac90032adf73", "caobaquat@gmail.com", true, "Quát", "Cao Bá", false, null, "CAOBAQUAT@GMAIL.COM", "CAOBAQUAT@GMAIL.COM", "AQAAAAEAACcQAAAAEBEEWtFKdYRbCrp9oxCu7DGCsIoqwm8mhKdZ3trI7iSdonmlVTjgAhHTFRi2Jcipfw==", null, false, "", false, "caobaquat@gmail.com" },
                    { "7f689288-ce66-4c15-b5e8-2782dc8559bd", 0, "d3952326-6a6a-418c-8af9-98c37ebf20c0", "truongthitramanh@gmail.com", true, "Anh", "Trương Thị Trâm", false, null, "TRUONGTHITRAMANH@GMAIL.COM", "TRUONGTHITRAMANH@GMAIL.COM", "AQAAAAEAACcQAAAAEEKLreT/hE1q7w96W6HZ+/uiMIYUU/GZoBvv475X4P0IEE+K+NeHsleRX+sdhzWnKA==", null, false, "", false, "truongthitramanh@gmail.com" },
                    { "380e17cb-fe13-4107-9621-d257e6ba6dba", 0, "386a20e0-51ac-47d3-9e01-c467b506d985", "nguyentrunghieu@gmail.com", true, "Hiếu", "Nguyễn Trung", false, null, "NGUYENTRUNGHIEU@GMAIL.COM", "NGUYENTRUNGHIEU@GMAIL.COM", "AQAAAAEAACcQAAAAEByvUvbx27rH4DInYePyKqse8xB0p6dCBe5DBewAP+5GuJAtzzfZR0FJoUl+4K3j1w==", null, false, "", false, "nguyentrunghieu@gmail.com" },
                    { "f4191ce9-fca7-4f54-bfef-e918192984c0", 0, "c1c330be-0330-4d11-b686-059cc339d7f0", "caothivananh@gmail.com", true, "Anh", "Cao Thị Vân", false, null, "CAOTHIVANANH@GMAIL.COM", "CAOTHIVANANH@GMAIL.COM", "AQAAAAEAACcQAAAAEF5a5Pj+0TGoh7MK2yRlCWS7HbDXVVNKdNr5WbgrUiGHq5a/sU1e8ybG2uVh6mpGIw==", null, false, "", false, "caothivananh@gmail.com" },
                    { "d475f04e-6f9a-4f13-b8ea-b099b5aa84db", 0, "7b613ea6-3d25-4403-8ed6-cf3a72779bd6", "nguyennhuloc@gmail.com", true, "Lộc", "Nguyễn Như", false, null, "NGUYENNHULOC@GMAIL.COM", "NGUYENNHULOC@GMAIL.COM", "AQAAAAEAACcQAAAAEGkQ30O32QpBHvVVMkels7iwCIJoDE98xbhgpcKo57t67+dQ2BhBo3/Zz3Q7l/SOMg==", null, false, "", false, "nguyennhuloc@gmail.com" },
                    { "0a27c5af-06f0-464b-80b9-bbefcd963730", 0, "a6566cfd-5ab1-4fa8-8f96-b965d653c55b", "phantantrung@gmail.com", true, "Trung", "Phan Tấn", false, null, "PHANTANTRUNG@GMAIL.COM", "PHANTANTRUNG@GMAIL.COM", "AQAAAAEAACcQAAAAEFUp+yK/2Bg0bdtY7Eowd0fQ48IVgGiWOo/Bt5TWYZZ2R+f3NR9sFZoUNz48/9Y5BA==", null, false, "", false, "phantantrung@gmail.com" },
                    { "6ad07f1d-4c95-4532-a831-e4cc80543fc0", 0, "24450a34-2cac-4af0-a94e-4ec53b7e6439", "phamvinhson@gmail.com", true, "Sơn", "Phạm Vĩnh", false, null, "PHAMVINHSON@GMAIL.COM", "PHAMVINHSON@GMAIL.COM", "AQAAAAEAACcQAAAAEEICaidCntH1Nh0XF8r+qjV26FHFdd8TClrwbS3OL1jtMRzT9RvRQtOe2W9+iYtegw==", null, false, "", false, "phamvinhson@gmail.com" },
                    { "21ba26ca-04ab-4ef9-8667-b7ea9a908d46", 0, "8d818f3a-c124-48a6-b0f4-0cb28a90309a", "trankieuloan@gmail.com", true, "Loan", "Trần Kiều", false, null, "TRANKIEULOAN@GMAIL.COM", "TRANKIEULOAN@GMAIL.COM", "AQAAAAEAACcQAAAAEDqkPAzE3rlfBDTyqxduLOeps+OtjHwLNfb7T9B1Lbe24XqHTu3iULjQ8dv6m/4VVw==", null, false, "", false, "trankieuloan@gmail.com" },
                    { "d9dceed0-3978-4136-ba4d-89feee4a0445", 0, "04fe1263-6eb8-4b0e-a9b9-9fb278be97ee", "yungadmin@gmail.com", true, "Admin", "Yung", false, null, "YUNGADMIN@GMAIL.COM", "YUNGADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEPGW3n6sbZTfXfIB5sIQIAMAljNXN1YIg1BbBi3W7fGIjI2sQmvgYLs8+YRxPOs/zg==", null, false, "", false, "yungadmin@gmail.com" },
                    { "d65c44d7-3f3a-41e5-b42d-1e60fb7fe90a", 0, "1952fd19-3a3f-498b-8f7e-e7bfb631346f", "lilsuperadmin@gmail.com", true, "Super Admin", "Lil", false, null, "LILSUPERADMIN@GMAIL.COM", "LILSUPERADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEONIPpdvwcIhTjwkhMBxYBuEag8Qg+eulMQ25GHdRBPUT5xOhesbxqnY+89bENiM+w==", null, false, "", false, "lilsuperadmin@gmail.com" },
                    { "84f8b688-c9d7-4084-8cf0-1ae773a303ea", 0, "37cd7c90-fc68-4ebd-a2b5-2d46ebf50ad9", "tranthaonguyen@gmail.com", true, "Nguyên", "Trần Thảo", false, null, "TRANTHAONGUYEN@GMAIL.COM", "TRANTHAONGUYEN@GMAIL.COM", "AQAAAAEAACcQAAAAEJ4wiszqPLRD2p8Ztch3tQc8rpCIVPKJxo9sYR6ZwBCAtdN3AZU0T7CAVo6KosuTiw==", null, false, "", false, "tranthaonguyen@gmail.com" },
                    { "e88e0cbd-3988-40f7-8991-dfa33282a6f5", 0, "303055fe-c2e3-4f82-b631-67603edd3a0b", "truongtuantu@gmail.com", true, "Tú", "Trương Tuấn", false, null, "TRUONGTUANTU@GMAIL.COM", "TRUONGTUANTU@GMAIL.COM", "AQAAAAEAACcQAAAAEDdirr+iMrwUdz3d4axS8jg0NoZ7GxP/X0k8UxtNnScxK25RRPTWTQ7dPGGWmRHi2w==", null, false, "", false, "truongtuantu@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "d65c44d7-3f3a-41e5-b42d-1e60fb7fe90a", "523d34bb-4034-4752-9e72-2412e97d7617" },
                    { "f1bee162-1c5a-4890-acb0-d2cdaf55a8c8", "5079e708-33e5-4419-8ff5-9901304ae134" },
                    { "d0fec2f3-fcbf-4fcc-bc2a-f14d31065dc7", "a2c3f740-cb6e-494b-93f7-1105ee89996d" },
                    { "9dcd0027-cae0-4af6-b9e8-1f1a6a96efe2", "a2c3f740-cb6e-494b-93f7-1105ee89996d" },
                    { "85ce5c89-56dd-4fbf-b2ad-0ccfe069679e", "a2c3f740-cb6e-494b-93f7-1105ee89996d" },
                    { "04c1916f-eb52-46db-981c-762b9957e25c", "3ee11948-4c99-4fbd-8e61-ef3601bce794" },
                    { "b4f1c462-acce-49b4-895a-7d1d989ad264", "3ee11948-4c99-4fbd-8e61-ef3601bce794" },
                    { "0a27c5af-06f0-464b-80b9-bbefcd963730", "5079e708-33e5-4419-8ff5-9901304ae134" },
                    { "7f689288-ce66-4c15-b5e8-2782dc8559bd", "375da43b-81b4-4977-9158-7f44988fd3e4" },
                    { "f4191ce9-fca7-4f54-bfef-e918192984c0", "375da43b-81b4-4977-9158-7f44988fd3e4" },
                    { "d475f04e-6f9a-4f13-b8ea-b099b5aa84db", "375da43b-81b4-4977-9158-7f44988fd3e4" },
                    { "380e17cb-fe13-4107-9621-d257e6ba6dba", "375da43b-81b4-4977-9158-7f44988fd3e4" },
                    { "6ad07f1d-4c95-4532-a831-e4cc80543fc0", "26aceecc-20b9-4934-82d1-7ff18eb3da23" },
                    { "21ba26ca-04ab-4ef9-8667-b7ea9a908d46", "26aceecc-20b9-4934-82d1-7ff18eb3da23" },
                    { "d9dceed0-3978-4136-ba4d-89feee4a0445", "2b864b94-804d-4ee7-868c-976268cd8c19" },
                    { "84f8b688-c9d7-4084-8cf0-1ae773a303ea", "375da43b-81b4-4977-9158-7f44988fd3e4" },
                    { "e88e0cbd-3988-40f7-8991-dfa33282a6f5", "5079e708-33e5-4419-8ff5-9901304ae134" }
                });
        }
    }
}
