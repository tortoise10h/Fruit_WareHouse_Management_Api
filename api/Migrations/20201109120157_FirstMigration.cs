using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace api.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    Name = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(nullable: false),
                    UserName = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(maxLength: 256, nullable: true),
                    Email = table.Column<string>(maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(nullable: false),
                    PasswordHash = table.Column<string>(nullable: true),
                    SecurityStamp = table.Column<string>(nullable: true),
                    ConcurrencyStamp = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(nullable: false),
                    TwoFactorEnabled = table.Column<bool>(nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(nullable: true),
                    LockoutEnabled = table.Column<bool>(nullable: false),
                    AccessFailedCount = table.Column<int>(nullable: false),
                    FirstName = table.Column<string>(nullable: true),
                    LastName = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ProductCategories",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedAt = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductCategories", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(nullable: false),
                    ClaimType = table.Column<string>(nullable: true),
                    ClaimValue = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(nullable: false),
                    ProviderKey = table.Column<string>(nullable: false),
                    ProviderDisplayName = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    RoleId = table.Column<string>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(nullable: false),
                    LoginProvider = table.Column<string>(nullable: false),
                    Name = table.Column<string>(nullable: false),
                    Value = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PurchaseProposalForms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedAt = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Deadline = table.Column<DateTime>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    OnTimeOrNotStatus = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ExceptionReason = table.Column<string>(nullable: true),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseProposalForms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PurchaseProposalForms_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedAt = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    SKU = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    DefaultUnit = table.Column<string>(nullable: true),
                    PurchasePrice = table.Column<double>(nullable: false),
                    Price = table.Column<double>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    Quantity = table.Column<double>(nullable: false),
                    ProductCategoryId = table.Column<int>(nullable: false),
                    MinQuantity = table.Column<double>(nullable: true),
                    MaxQuantity = table.Column<double>(nullable: true),
                    LastSaledDate = table.Column<DateTime>(nullable: true),
                    QuantityOrdered = table.Column<double>(nullable: false),
                    QuantityForSale = table.Column<double>(nullable: false),
                    QuantityReturned = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_ProductCategories_ProductCategoryId",
                        column: x => x.ProductCategoryId,
                        principalTable: "ProductCategories",
                        principalColumn: "Id");
                });

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
                    Status = table.Column<int>(nullable: false),
                    SupplierName = table.Column<string>(nullable: true),
                    SupplierId = table.Column<int>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    ExceptionReason = table.Column<string>(nullable: true),
                    PurchaseProposalFormId = table.Column<int>(nullable: false),
                    TotalPrice = table.Column<double>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoodsReceivingNotes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GoodsReceivingNotes_PurchaseProposalForms_PurchaseProposalFormId",
                        column: x => x.PurchaseProposalFormId,
                        principalTable: "PurchaseProposalForms",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GoodsReceivingNotes_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductUnits",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedAt = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Name = table.Column<string>(nullable: true),
                    RatioFromDefault = table.Column<double>(nullable: false),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductUnits", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductUnits_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "PurchaseProposalDetails",
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
                    PurchaseProposalFormId = table.Column<int>(nullable: false),
                    Quantity = table.Column<double>(nullable: false),
                    QuantityPurchased = table.Column<double>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseProposalDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_PurchaseProposalDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_PurchaseProposalDetails_PurchaseProposalForms_PurchaseProposalFormId",
                        column: x => x.PurchaseProposalFormId,
                        principalTable: "PurchaseProposalForms",
                        principalColumn: "Id");
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
                    SinglePurchasePrice = table.Column<double>(nullable: false),
                    TotalPrice = table.Column<double>(nullable: false),
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
                    { "b979036b-d165-4bea-b6b6-16b22a3f54dd", "32efc935-28a4-4eae-8f21-fbe7b7832516", "Admin", "admin" },
                    { "78c5228f-f600-4545-abcd-f4cc21d18e4c", "d9ef224e-6706-4ec3-8b01-bd861f7954f4", "Sale", "sale" },
                    { "cc2a0eb3-8736-441d-9130-5b421db3ac0e", "4280671d-160d-4c52-9770-851bccbef2ae", "SuperAdmin", "superadmin" },
                    { "6b30cb05-12f7-46c2-b95f-8d783c1f9eb1", "65499a65-f9e4-4840-8349-9ee128e8c552", "WarehouseKeeperManager", "warehousekeepermanager" },
                    { "6665ddaa-72f9-4f90-a6b1-43eb68dea610", "0fa75002-9f39-453b-a890-dacdd612722a", "WarehouseKeeper", "warehousekeeper" },
                    { "423e498c-fc67-4853-ac4f-f3cd91d32e87", "035e9991-d889-41e8-9922-f6d5d17ab72a", "Customer", "customer" },
                    { "c2d4b743-d9da-443c-9f5a-c2682750c805", "147e9cd6-6a56-449b-bbb1-ed9f009e632d", "Boss", "boss" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5ce20f05-c625-43fc-ae25-a7514e9520db", 0, "590eaef5-7905-4b8e-814a-b6bea6d24d50", "truongtuantu@gmail.com", true, "Tú", "Trương Tuấn", false, null, "TRUONGTUANTU@GMAIL.COM", "TRUONGTUANTU@GMAIL.COM", "AQAAAAEAACcQAAAAEBU9g6Dh+3H0DAv5dBwRRns6WYGLhVDuLpDExjcEl2cpPP/dSWKzqS1lq1IMwXqoYw==", null, false, "", false, "truongtuantu@gmail.com" },
                    { "3a6a1f70-8f67-4f8a-b1f9-267e5d621edb", 0, "a6d8a432-60fd-4139-a427-0a21b8803519", "phantantrung@gmail.com", true, "Trung", "Phan Tấn", false, null, "PHANTANTRUNG@GMAIL.COM", "PHANTANTRUNG@GMAIL.COM", "AQAAAAEAACcQAAAAEG1ASImQXfmzmXC/2MjufxKOwq3SaimEjb+PMZZXF6ix9Cb958zYEgoFwXPr0GymYQ==", null, false, "", false, "phantantrung@gmail.com" },
                    { "57b2db13-1d08-48a4-adca-41d837bb8937", 0, "c6c8d176-27d0-42ee-9666-2eb04f6abdfb", "phungthanhdo@gmail.com", true, "Độ", "Phùng Thanh", false, null, "PHUNGTHANHDO@GMAIL.COM", "PHUNGTHANHDO@GMAIL.COM", "AQAAAAEAACcQAAAAED6zqkbvW7kf1MPqa4EZNQU3fVx/33SRNrw6JGg7RM1RgFntUZUNmu95umry/xMXtg==", null, false, "", false, "phungthanhdo@gmail.com" },
                    { "fd9a7449-e604-48c1-a638-c564e17c1bc0", 0, "a46fe729-b366-437d-8140-a6a93ccd65a8", "nguyenhue@gmail.com", true, "Huệ", "Nguyễn", false, null, "NGUYENHUE@GMAIL.COM", "NGUYENHUE@GMAIL.COM", "AQAAAAEAACcQAAAAEM3nyaTSjIcPXAkz9NWTiiO+EVuoY7fKJ9bs24boMfeiJ1zY4xfSqtM909f0zm8dvA==", null, false, "", false, "nguyenhue@gmail.com" },
                    { "ce4b2f5c-1fb9-4fe1-945c-20eca474ce16", 0, "c7840bb9-29c4-4740-9c4b-434fdeccd366", "hoxuanhuong@gmail.com", true, "Hương", "Hồ Xuân", false, null, "HOXUANHUONG@GMAIL.COM", "HOXUANHUONG@GMAIL.COM", "AQAAAAEAACcQAAAAEDs7CbHF4FefQJlFQf9F7RMoM/rJrD/+67qZAq0MsO0kiYDQRFIxTSHbj2tvqm+67w==", null, false, "", false, "hoxuanhuong@gmail.com" },
                    { "39b465e2-c398-494f-bb62-d1eb02aa5471", 0, "563ed447-b044-49a8-927e-67e857646fe5", "nguyenthanhlong@gmail.com", true, "Long", "Nguyễn Thành", false, null, "NGUYENTHANHLONG@GMAIL.COM", "NGUYENTHANHLONG@GMAIL.COM", "AQAAAAEAACcQAAAAECIRwb3YtyUfQ6AjEGy9p6UYwzfdcDCLOjjUv9/bNxOAjxmTVuVMPEDP2OXZYC1sag==", null, false, "", false, "nguyenthanhlong@gmail.com" },
                    { "52999f6b-a605-45b0-b98f-b8880fc46027", 0, "b029fbf1-b701-4403-8197-07e470103f88", "huynhtranthanh@gmail.com", true, "Thành", "Huỳnh Trấn", false, null, "HUYNHTRANTHANH@GMAIL.COM", "HUYNHTRANTHANH@GMAIL.COM", "AQAAAAEAACcQAAAAELk2utqX9PQBO7tEtPmCQzzeQNFm5pytwWfHFksoZPUt56MenEKKVONgao4Tee33KA==", null, false, "", false, "huynhtranthanh@gmail.com" },
                    { "3b488e0f-eb92-4994-a555-cbe4ecdf3672", 0, "53b47278-36c5-4c5a-8a5b-9c99916e26b2", "caobaquat@gmail.com", true, "Quát", "Cao Bá", false, null, "CAOBAQUAT@GMAIL.COM", "CAOBAQUAT@GMAIL.COM", "AQAAAAEAACcQAAAAEA4fkn3GOAcYq2mrPoOXTUOWyySRwCFupvA4/Sw/U6xqgb944//YeyTOVhDVXsOT6A==", null, false, "", false, "caobaquat@gmail.com" },
                    { "b6256340-7bd0-4373-8549-c6a08053396b", 0, "d3156c80-0a3c-43ed-ad75-2e078104ef5b", "nguyennhuloc@gmail.com", true, "Lộc", "Nguyễn Như", false, null, "NGUYENNHULOC@GMAIL.COM", "NGUYENNHULOC@GMAIL.COM", "AQAAAAEAACcQAAAAEIxwQFDF8GxdtTwejS5Fo1B3fDhi3Q9L72xUfOGxmZoJ3a8dYv52SPDqsccyHTnmTw==", null, false, "", false, "nguyennhuloc@gmail.com" },
                    { "a0c9e67b-d593-4a56-93cd-063ec5d5d035", 0, "420fc063-a629-4875-9693-5047cbdbacab", "tranthaonguyen@gmail.com", true, "Nguyên", "Trần Thảo", false, null, "TRANTHAONGUYEN@GMAIL.COM", "TRANTHAONGUYEN@GMAIL.COM", "AQAAAAEAACcQAAAAECJ/NIqMuoOudEfX6gdfXX0rbnJWmzfBy0/PpTkafcw1jSlAasz6cmunrHOB8RgMXw==", null, false, "", false, "tranthaonguyen@gmail.com" },
                    { "6f8ce951-2f66-4a9e-a4fa-7a14f85b54c6", 0, "b9e24b09-4ea6-4696-ae67-6db802e66f1d", "caothivananh@gmail.com", true, "Anh", "Cao Thị Vân", false, null, "CAOTHIVANANH@GMAIL.COM", "CAOTHIVANANH@GMAIL.COM", "AQAAAAEAACcQAAAAEOzbv01eXnB6lHEDejokO2vxqyDmpijcSSY3TZPdeqZSzKvqd5M5CxWCu1AUfzOlvA==", null, false, "", false, "caothivananh@gmail.com" },
                    { "08b84a20-7e7d-4353-bb53-74c79732beed", 0, "29f25be6-9fab-47fe-8e9a-5486cf90b122", "nguyentrunghieu@gmail.com", true, "Hiếu", "Nguyễn Trung", false, null, "NGUYENTRUNGHIEU@GMAIL.COM", "NGUYENTRUNGHIEU@GMAIL.COM", "AQAAAAEAACcQAAAAEILtaPM0ciwfsGnBXjQ2dRRorK32hDwePZYdy2y4ncT8t+57uwo7q6GY6AhBOuN3dg==", null, false, "", false, "nguyentrunghieu@gmail.com" },
                    { "e9012ef1-cd3c-49a1-8726-7f8f8aba9f98", 0, "ec03f7ce-4bf4-4d12-a6de-a9b28a057023", "phamvinhson@gmail.com", true, "Sơn", "Phạm Vĩnh", false, null, "PHAMVINHSON@GMAIL.COM", "PHAMVINHSON@GMAIL.COM", "AQAAAAEAACcQAAAAEPlpH6OlLTVcVW8pqZqfXOZSsLkyuh6PeOZgnfGhGKx66qWkAnTAaf5GIjMZryScVA==", null, false, "", false, "phamvinhson@gmail.com" },
                    { "e7610feb-110c-47d0-9a88-1bfdc12742a4", 0, "9e2fe854-b82c-41f5-8082-92d15b9da72d", "trankieuloan@gmail.com", true, "Loan", "Trần Kiều", false, null, "TRANKIEULOAN@GMAIL.COM", "TRANKIEULOAN@GMAIL.COM", "AQAAAAEAACcQAAAAELM1xpkmg8osvlYsiIUFUJfXoiD9jfofItL2jZKkRgKpHIgq6IkVWCVvkwTUIqeRoQ==", null, false, "", false, "trankieuloan@gmail.com" },
                    { "308da0db-e863-4814-8930-de3540e5406d", 0, "74ef69c6-cb50-4b45-9d74-dbfaeb0bb15f", "yungadmin@gmail.com", true, "Admin", "Yung", false, null, "YUNGADMIN@GMAIL.COM", "YUNGADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEBSUmVyH+0PkR/0soUR58jScDPnWpBWFs+y+YHQ1TxY0WGpSi8QD8WLW8DWf/1qWew==", null, false, "", false, "yungadmin@gmail.com" },
                    { "927e4f6a-62ed-4e13-b002-7e133eb47bbc", 0, "3e8f78c8-e9f0-454e-a379-d2879cecf559", "lilsuperadmin@gmail.com", true, "Super Admin", "Lil", false, null, "LILSUPERADMIN@GMAIL.COM", "LILSUPERADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAENTXWV+zrb8vPmogcEBNX9QwjG2vgfHEHYsrkMq5Dr5HifVa06DRZiDKPxFpplRoLw==", null, false, "", false, "lilsuperadmin@gmail.com" },
                    { "fd4fd02a-238d-4efc-a187-14d205a841f0", 0, "ef2aebe7-20b2-4131-9576-5e24c20c0c06", "truongthitramanh@gmail.com", true, "Anh", "Trương Thị Trâm", false, null, "TRUONGTHITRAMANH@GMAIL.COM", "TRUONGTHITRAMANH@GMAIL.COM", "AQAAAAEAACcQAAAAEOLXtixKNFO60h7mjPRyHlTwSpK7toA/NMiK9WDzWpfTV08xXyeQWdKIoJ9I0wMJPQ==", null, false, "", false, "truongthitramanh@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "ProductCategories",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "IsDeleted", "LastModifiedAt", "LastModifiedBy", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Trái cây Việt Nam" },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Trái cây nhập khẩu" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "927e4f6a-62ed-4e13-b002-7e133eb47bbc", "cc2a0eb3-8736-441d-9130-5b421db3ac0e" },
                    { "5ce20f05-c625-43fc-ae25-a7514e9520db", "78c5228f-f600-4545-abcd-f4cc21d18e4c" },
                    { "3a6a1f70-8f67-4f8a-b1f9-267e5d621edb", "78c5228f-f600-4545-abcd-f4cc21d18e4c" },
                    { "57b2db13-1d08-48a4-adca-41d837bb8937", "78c5228f-f600-4545-abcd-f4cc21d18e4c" },
                    { "ce4b2f5c-1fb9-4fe1-945c-20eca474ce16", "6665ddaa-72f9-4f90-a6b1-43eb68dea610" },
                    { "39b465e2-c398-494f-bb62-d1eb02aa5471", "6665ddaa-72f9-4f90-a6b1-43eb68dea610" },
                    { "52999f6b-a605-45b0-b98f-b8880fc46027", "6b30cb05-12f7-46c2-b95f-8d783c1f9eb1" },
                    { "3b488e0f-eb92-4994-a555-cbe4ecdf3672", "6b30cb05-12f7-46c2-b95f-8d783c1f9eb1" },
                    { "fd9a7449-e604-48c1-a638-c564e17c1bc0", "6665ddaa-72f9-4f90-a6b1-43eb68dea610" },
                    { "a0c9e67b-d593-4a56-93cd-063ec5d5d035", "423e498c-fc67-4853-ac4f-f3cd91d32e87" },
                    { "6f8ce951-2f66-4a9e-a4fa-7a14f85b54c6", "423e498c-fc67-4853-ac4f-f3cd91d32e87" },
                    { "b6256340-7bd0-4373-8549-c6a08053396b", "423e498c-fc67-4853-ac4f-f3cd91d32e87" },
                    { "08b84a20-7e7d-4353-bb53-74c79732beed", "423e498c-fc67-4853-ac4f-f3cd91d32e87" },
                    { "e9012ef1-cd3c-49a1-8726-7f8f8aba9f98", "c2d4b743-d9da-443c-9f5a-c2682750c805" },
                    { "e7610feb-110c-47d0-9a88-1bfdc12742a4", "c2d4b743-d9da-443c-9f5a-c2682750c805" },
                    { "308da0db-e863-4814-8930-de3540e5406d", "b979036b-d165-4bea-b6b6-16b22a3f54dd" },
                    { "fd4fd02a-238d-4efc-a187-14d205a841f0", "423e498c-fc67-4853-ac4f-f3cd91d32e87" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DefaultUnit", "Description", "IsDeleted", "LastModifiedAt", "LastModifiedBy", "LastSaledDate", "MaxQuantity", "MinQuantity", "Name", "Price", "ProductCategoryId", "PurchasePrice", "Quantity", "QuantityForSale", "QuantityOrdered", "QuantityReturned", "SKU", "Status" },
                values: new object[,]
                {
                    { 32, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000.0, 0.0, "Táo Rockit Newzealand", 155000.0, 2, 20000.0, 306.0, 0.0, 0.0, 0.0, "SP-TCNK-00032", 1 },
                    { 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000.0, 0.0, "Táo Kiku (Size lớn) - Táo Newzealand", 119000.0, 2, 20000.0, 29.0, 0.0, 0.0, 0.0, "SP-TCNK-00031", 1 },
                    { 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000.0, 0.0, "Táo Jazz New Zealand", 110000.0, 2, 20000.0, 904.0, 0.0, 0.0, 0.0, "SP-TCNK-00030", 1 },
                    { 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000.0, 0.0, "Táo Envy New Zealand", 235000.0, 2, 20000.0, 509.0, 0.0, 0.0, 0.0, "SP-TCNK-00029", 1 },
                    { 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000.0, 0.0, "Kiwi ruột đỏ NewZealand", 66000.0, 2, 20000.0, 969.0, 0.0, 0.0, 0.0, "SP-TCNK-00025", 1 },
                    { 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000.0, 0.0, "Kiwi Xanh New Zealand", 135000.0, 2, 20000.0, 655.0, 0.0, 0.0, 0.0, "SP-TCNK-00027", 1 },
                    { 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000.0, 0.0, "Kiwi Vàng New Zealand", 235000.0, 2, 20000.0, 818.0, 0.0, 0.0, 0.0, "SP-TCNK-00026", 1 },
                    { 33, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000.0, 0.0, "Táo Royal Gala Newzealand", 99000.0, 2, 20000.0, 976.0, 0.0, 0.0, 0.0, "SP-TCNK-00033", 1 },
                    { 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000.0, 0.0, "Táo Breeze NewZealand", 83000.0, 2, 20000.0, 852.0, 0.0, 0.0, 0.0, "SP-TCNK-00028", 1 },
                    { 34, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000.0, 0.0, "Táo xanh Newzealand", 110000.0, 2, 20000.0, 726.0, 0.0, 0.0, 0.0, "SP-TCNK-00034", 1 },
                    { 42, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000.0, 0.0, "Mận khủng long (tím) Mỹ", 46000.0, 2, 20000.0, 802.0, 0.0, 0.0, 0.0, "SP-TCNK-00042", 1 },
                    { 36, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000.0, 0.0, "Cherry đỏ Canada", 519000.0, 2, 20000.0, 675.0, 0.0, 0.0, 0.0, "SP-TCNK-00036", 1 },
                    { 37, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000.0, 0.0, "Cherry Đỏ Mỹ", 490000.0, 2, 20000.0, 389.0, 0.0, 0.0, 0.0, "SP-TCNK-00037", 1 },
                    { 38, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000.0, 0.0, "Hồng giòn Mỹ", 409000.0, 2, 20000.0, 813.0, 0.0, 0.0, 0.0, "SP-TCNK-00038", 1 },
                    { 39, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000.0, 0.0, "Lựu Mỹ", 399000.0, 2, 20000.0, 885.0, 0.0, 0.0, 0.0, "SP-TCNK-00039", 1 },
                    { 40, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000.0, 0.0, "Mận đen Mỹ", 410000.0, 2, 20000.0, 672.0, 0.0, 0.0, 0.0, "SP-TCNK-00040", 1 },
                    { 41, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000.0, 0.0, "Mận đỏ Red Plum Mỹ", 420000.0, 2, 20000.0, 485.0, 0.0, 0.0, 0.0, "SP-TCNK-00041", 1 },
                    { 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000.0, 0.0, "Cherry New Zealand Gift Box 2kg", 1600000.0, 2, 20000.0, 369.0, 0.0, 0.0, 0.0, "SP-TCNK-00024", 1 },
                    { 43, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000.0, 0.0, "Mận khủng long (xanh) Mỹ", 420000.0, 2, 20000.0, 764.0, 0.0, 0.0, 0.0, "SP-TCNK-00043", 1 },
                    { 44, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000.0, 0.0, "Mận khủng long đen Mỹ", 109000.0, 2, 20000.0, 439.0, 0.0, 0.0, 0.0, "SP-TCNK-00044", 1 },
                    { 35, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000.0, 0.0, "Chanh vàng Sunkist Mỹ", 51250.0, 2, 20000.0, 998.0, 0.0, 0.0, 0.0, "SP-TCNK-00035", 1 },
                    { 23, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000.0, 0.0, "Hồng xiêm Tiền Giang", 42000.0, 1, 20000.0, 420.0, 0.0, 0.0, 0.0, "SP-TCVN-00023", 1 },
                    { 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000.0, 0.0, "Dưa hấu hắc mỹ nhân", 35000.0, 1, 20000.0, 324.0, 0.0, 0.0, 0.0, "SP-TCVN-00014", 1 },
                    { 21, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000.0, 0.0, "Hồng chín Đà Lạt", 86000.0, 1, 20000.0, 42.0, 0.0, 0.0, 0.0, "SP-TCVN-00021", 1 },
                    { 48, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000.0, 0.0, "Bơ Đăk Lăk", 90000.0, 1, 20000.0, 262.0, 0.0, 0.0, 0.0, "SP-TCVN-00048", 1 },
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000.0, 0.0, "Bòn Bon Thái", 25000.0, 1, 20000.0, 896.0, 0.0, 0.0, 0.0, "SP-TCVN-00001", 1 },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000.0, 0.0, "Bưởi Đoan Hùng", 60000.0, 1, 20000.0, 259.0, 0.0, 0.0, 0.0, "SP-TCVN-00002", 1 },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000.0, 0.0, "Cam Xã Đoài (Vinh, Nghệ An)", 85000.0, 1, 20000.0, 251.0, 0.0, 0.0, 0.0, "SP-TCVN-00003", 1 },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000.0, 0.0, "Cam xoàn Lai Vung", 65000.0, 1, 20000.0, 979.0, 0.0, 0.0, 0.0, "SP-TCVN-00004", 1 },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000.0, 0.0, "Chanh dây", 47000.0, 1, 20000.0, 6.0, 0.0, 0.0, 0.0, "SP-TCVN-00005", 1 },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000.0, 0.0, "Chôm chôm nhãn", 64000.0, 1, 20000.0, 311.0, 0.0, 0.0, 0.0, "SP-TCVN-00006", 1 },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000.0, 0.0, "Chôm chôm Thái", 19000.0, 1, 20000.0, 900.0, 0.0, 0.0, 0.0, "SP-TCVN-00007", 1 },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000.0, 0.0, "Chuối cau lửa", 41000.0, 1, 20000.0, 21.0, 0.0, 0.0, 0.0, "SP-TCVN-00008", 1 },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000.0, 0.0, "Chuối già hương", 15000.0, 1, 20000.0, 298.0, 0.0, 0.0, 0.0, "SP-TCVN-00009", 1 },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000.0, 0.0, "Chuối sứ", 15000.0, 1, 20000.0, 592.0, 0.0, 0.0, 0.0, "SP-TCVN-00010", 1 },
                    { 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000.0, 0.0, "Dâu tây Đà Lạt", 96000.0, 1, 20000.0, 171.0, 0.0, 0.0, 0.0, "SP-TCVN-00011", 1 },
                    { 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000.0, 0.0, "Đu đủ vàng", 27000.0, 1, 20000.0, 543.0, 0.0, 0.0, 0.0, "SP-TCVN-00012", 1 },
                    { 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000.0, 0.0, "Dưa đỏ không hạt", 15000.0, 1, 20000.0, 253.0, 0.0, 0.0, 0.0, "SP-TCVN-00013", 1 },
                    { 45, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000.0, 0.0, "Mận khủng long đỏ Mỹ", 94000.0, 2, 20000.0, 21.0, 0.0, 0.0, 0.0, "SP-TCNK-00045", 1 },
                    { 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000.0, 0.0, "Dưa lê trắng", 63000.0, 1, 20000.0, 743.0, 0.0, 0.0, 0.0, "SP-TCVN-00015", 1 },
                    { 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000.0, 0.0, "Dưa lưới giống Nhật", 345000.0, 1, 20000.0, 811.0, 0.0, 0.0, 0.0, "SP-TCVN-00016", 1 },
                    { 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000.0, 0.0, "Dưa lưới ruột đỏ", 57000.0, 1, 20000.0, 105.0, 0.0, 0.0, 0.0, "SP-TCVN-00017", 1 },
                    { 18, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000.0, 0.0, "Dưa lưới vàng", 81000.0, 1, 20000.0, 495.0, 0.0, 0.0, 0.0, "SP-TCVN-00018", 1 },
                    { 19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000.0, 0.0, "Dứa Việt Nam", 57000.0, 1, 20000.0, 322.0, 0.0, 0.0, 0.0, "SP-TCVN-00019", 1 },
                    { 20, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000.0, 0.0, "Dừa xiêm Bến Tre", 20000.0, 1, 20000.0, 759.0, 0.0, 0.0, 0.0, "SP-TCVN-00020", 1 },
                    { 22, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000.0, 0.0, "Hồng giòn Đà Lạt", 34000.0, 1, 20000.0, 728.0, 0.0, 0.0, 0.0, "SP-TCVN-00022", 1 },
                    { 46, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000.0, 0.0, "Mận khủng long Farmily Tree Mỹ", 32000.0, 2, 20000.0, 819.0, 0.0, 0.0, 0.0, "SP-TCNK-00046", 1 }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_GoodsReceivingDetails_GoodsReceivingNoteId",
                table: "GoodsReceivingDetails",
                column: "GoodsReceivingNoteId");

            migrationBuilder.CreateIndex(
                name: "IX_GoodsReceivingDetails_ProductId",
                table: "GoodsReceivingDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_GoodsReceivingNotes_PurchaseProposalFormId",
                table: "GoodsReceivingNotes",
                column: "PurchaseProposalFormId");

            migrationBuilder.CreateIndex(
                name: "IX_GoodsReceivingNotes_UserId",
                table: "GoodsReceivingNotes",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ProductCategoryId",
                table: "Products",
                column: "ProductCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductUnits_ProductId",
                table: "ProductUnits",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseProposalDetails_ProductId",
                table: "PurchaseProposalDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseProposalDetails_PurchaseProposalFormId",
                table: "PurchaseProposalDetails",
                column: "PurchaseProposalFormId");

            migrationBuilder.CreateIndex(
                name: "IX_PurchaseProposalForms_UserId",
                table: "PurchaseProposalForms",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "GoodsReceivingDetails");

            migrationBuilder.DropTable(
                name: "ProductUnits");

            migrationBuilder.DropTable(
                name: "PurchaseProposalDetails");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "GoodsReceivingNotes");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "PurchaseProposalForms");

            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
