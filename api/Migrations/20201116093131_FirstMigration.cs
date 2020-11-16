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
                name: "Suppliers",
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
                    Address = table.Column<string>(nullable: true),
                    PhoneNumber = table.Column<string>(nullable: true),
                    Email = table.Column<string>(nullable: true),
                    Representative = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Id);
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
                name: "Orders",
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
                    Description = table.Column<string>(nullable: true),
                    ExceptionReason = table.Column<string>(nullable: true),
                    TotalPrice = table.Column<double>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Orders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Orders_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
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
                name: "OrderDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedAt = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    OrderId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    Quantity = table.Column<double>(nullable: false),
                    QuantityNeed = table.Column<double>(nullable: false),
                    QuantitySaled = table.Column<double>(nullable: false),
                    QuantityReturned = table.Column<double>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    SinglePrice = table.Column<double>(nullable: false),
                    TotalPrice = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
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
                name: "SupplierProducts",
                columns: table => new
                {
                    SupplierId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    Price = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SupplierProducts", x => new { x.SupplierId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_SupplierProducts_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_SupplierProducts_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
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
                    { "b979036b-d165-4bea-b6b6-16b22a3f54dd", "13c34189-5eec-45f0-a0df-b4778274f273", "Admin", "admin" },
                    { "78c5228f-f600-4545-abcd-f4cc21d18e4c", "55ae6458-d265-4897-b732-d78794ccfa07", "Sale", "sale" },
                    { "cc2a0eb3-8736-441d-9130-5b421db3ac0e", "28d7957c-9404-426e-81c9-0447e8b2e26f", "SuperAdmin", "superadmin" },
                    { "6b30cb05-12f7-46c2-b95f-8d783c1f9eb1", "2e6789f2-8d53-4045-9361-1454b9e8e723", "WarehouseKeeperManager", "warehousekeepermanager" },
                    { "6665ddaa-72f9-4f90-a6b1-43eb68dea610", "b3d2bccd-be02-4975-af8a-adfbb245c311", "WarehouseKeeper", "warehousekeeper" },
                    { "423e498c-fc67-4853-ac4f-f3cd91d32e87", "be9cd960-8e24-4af9-be0f-31f8ccbd2849", "Customer", "customer" },
                    { "c2d4b743-d9da-443c-9f5a-c2682750c805", "904c533e-a442-42f9-a75f-b10699599894", "Boss", "boss" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5ce20f05-c625-43fc-ae25-a7514e9520db", 0, "3a9b1d48-7d19-40f0-bb4a-a988a1a0937d", "truongtuantu@gmail.com", true, "Tú", "Trương Tuấn", false, null, "TRUONGTUANTU@GMAIL.COM", "TRUONGTUANTU@GMAIL.COM", "AQAAAAEAACcQAAAAEBnfypzIDAhKfo8n9O1CP70lf2Nm3tDlgsKtIqr7CWuyRVqh9o8K8PdSV5OPi5YrUQ==", null, false, "", false, "truongtuantu@gmail.com" },
                    { "3a6a1f70-8f67-4f8a-b1f9-267e5d621edb", 0, "4c16662a-ea58-4b1d-803b-f81b2e097824", "phantantrung@gmail.com", true, "Trung", "Phan Tấn", false, null, "PHANTANTRUNG@GMAIL.COM", "PHANTANTRUNG@GMAIL.COM", "AQAAAAEAACcQAAAAEHTgTsaUyjyXcAHcuSsN2ykg958QRWnjr2I+b5pWoVtLorXR2L1zXboXr1zIkEvDUg==", null, false, "", false, "phantantrung@gmail.com" },
                    { "57b2db13-1d08-48a4-adca-41d837bb8937", 0, "ad70dbba-4a70-487d-826d-9ebf4c2690b6", "phungthanhdo@gmail.com", true, "Độ", "Phùng Thanh", false, null, "PHUNGTHANHDO@GMAIL.COM", "PHUNGTHANHDO@GMAIL.COM", "AQAAAAEAACcQAAAAEB74GAbfbNnJeeZ6IlquomQZql3b2FQvoVeJYRhG9rLwBG5PwzFs/qpG752Rbmp22A==", null, false, "", false, "phungthanhdo@gmail.com" },
                    { "fd9a7449-e604-48c1-a638-c564e17c1bc0", 0, "0eae5ebc-552a-4f05-aa74-4822045d4372", "nguyenhue@gmail.com", true, "Huệ", "Nguyễn", false, null, "NGUYENHUE@GMAIL.COM", "NGUYENHUE@GMAIL.COM", "AQAAAAEAACcQAAAAELMhVKuj++RTKq/PIPxrH/UrPh/HEx6UE7GO5Ps8KbNW7fSaz1laeO77f48znkuCXg==", null, false, "", false, "nguyenhue@gmail.com" },
                    { "ce4b2f5c-1fb9-4fe1-945c-20eca474ce16", 0, "9f8599b6-282d-412e-93a1-84d0b87b304a", "hoxuanhuong@gmail.com", true, "Hương", "Hồ Xuân", false, null, "HOXUANHUONG@GMAIL.COM", "HOXUANHUONG@GMAIL.COM", "AQAAAAEAACcQAAAAEAQW4IXBinarLIAfzyI8X+hrwP55TPsOkjL3JuPfEzmG9nwuApVFsSqChfZzhsE+1w==", null, false, "", false, "hoxuanhuong@gmail.com" },
                    { "39b465e2-c398-494f-bb62-d1eb02aa5471", 0, "b147e10d-6081-4a1a-af28-de0ac5d21491", "nguyenthanhlong@gmail.com", true, "Long", "Nguyễn Thành", false, null, "NGUYENTHANHLONG@GMAIL.COM", "NGUYENTHANHLONG@GMAIL.COM", "AQAAAAEAACcQAAAAEB5MALUDXmnVlK28FIiZYBlBGLCGTc7u5Gt8R2uRjZGKYThQk+7NYKuPEr1AzJy6Gw==", null, false, "", false, "nguyenthanhlong@gmail.com" },
                    { "52999f6b-a605-45b0-b98f-b8880fc46027", 0, "ed9153d4-d806-4404-9336-dbdeab8605f4", "huynhtranthanh@gmail.com", true, "Thành", "Huỳnh Trấn", false, null, "HUYNHTRANTHANH@GMAIL.COM", "HUYNHTRANTHANH@GMAIL.COM", "AQAAAAEAACcQAAAAEH21AKjAjoO1nVitdCFlLzDhrzBUH45J5JRFMwt0Jb2clXNlIPqLLpyCU+augunsOQ==", null, false, "", false, "huynhtranthanh@gmail.com" },
                    { "3b488e0f-eb92-4994-a555-cbe4ecdf3672", 0, "a7e13e99-186f-4446-beb3-c07f0d2250c7", "caobaquat@gmail.com", true, "Quát", "Cao Bá", false, null, "CAOBAQUAT@GMAIL.COM", "CAOBAQUAT@GMAIL.COM", "AQAAAAEAACcQAAAAEK0iVbt8BM5A6CtTPDPme5HqHRak4Os1r2vKg8sx2msTsRT8TiGgif4JAzpZ1bap6g==", null, false, "", false, "caobaquat@gmail.com" },
                    { "b6256340-7bd0-4373-8549-c6a08053396b", 0, "3474d7f7-82bd-4979-acd3-274305136a3b", "nguyennhuloc@gmail.com", true, "Lộc", "Nguyễn Như", false, null, "NGUYENNHULOC@GMAIL.COM", "NGUYENNHULOC@GMAIL.COM", "AQAAAAEAACcQAAAAEDETWmcT5uSJ6GAoOPq5LnDdLvh2eC2f+eY2ugVdGwVI5JUw8EvE8g1E4MQoORZiAg==", null, false, "", false, "nguyennhuloc@gmail.com" },
                    { "a0c9e67b-d593-4a56-93cd-063ec5d5d035", 0, "7e0290bf-650c-489c-87ed-8b9a3399d140", "tranthaonguyen@gmail.com", true, "Nguyên", "Trần Thảo", false, null, "TRANTHAONGUYEN@GMAIL.COM", "TRANTHAONGUYEN@GMAIL.COM", "AQAAAAEAACcQAAAAEAfY1Q+8DE4ApfbviOHOS2GD6c13/g+snLbDNYyxb1r++Ag3fvCfVruDNGIwq9cCLg==", null, false, "", false, "tranthaonguyen@gmail.com" },
                    { "6f8ce951-2f66-4a9e-a4fa-7a14f85b54c6", 0, "c4b2e3b7-d906-45a5-b4f9-480bedbccaf7", "caothivananh@gmail.com", true, "Anh", "Cao Thị Vân", false, null, "CAOTHIVANANH@GMAIL.COM", "CAOTHIVANANH@GMAIL.COM", "AQAAAAEAACcQAAAAEFU8SM24e2SQ+Ne+7rDLwxr7NDMOSZYRX6ndE8+D/uRMmOMDaq5+R6vQksknTsrjCA==", null, false, "", false, "caothivananh@gmail.com" },
                    { "08b84a20-7e7d-4353-bb53-74c79732beed", 0, "e3edc087-e2a7-4717-8897-6166a13ffaf0", "nguyentrunghieu@gmail.com", true, "Hiếu", "Nguyễn Trung", false, null, "NGUYENTRUNGHIEU@GMAIL.COM", "NGUYENTRUNGHIEU@GMAIL.COM", "AQAAAAEAACcQAAAAEPI8dKfMgUEZeOXMYYjqZd+k2INDNOWLTg0W3TR19PdL+o/wzOVSJkwKaleDKFZoxQ==", null, false, "", false, "nguyentrunghieu@gmail.com" },
                    { "e9012ef1-cd3c-49a1-8726-7f8f8aba9f98", 0, "dd39af78-9e17-4931-af09-9476d1a5617a", "phamvinhson@gmail.com", true, "Sơn", "Phạm Vĩnh", false, null, "PHAMVINHSON@GMAIL.COM", "PHAMVINHSON@GMAIL.COM", "AQAAAAEAACcQAAAAEBFTRjapHYleq0sVLeYaAMKPTjKlAnJfg0UaQ3qAUs+ol6Bl8x2ff2fJm3kuVBPRYA==", null, false, "", false, "phamvinhson@gmail.com" },
                    { "e7610feb-110c-47d0-9a88-1bfdc12742a4", 0, "21c84d05-3644-4a7a-816d-ff96b1381f53", "trankieuloan@gmail.com", true, "Loan", "Trần Kiều", false, null, "TRANKIEULOAN@GMAIL.COM", "TRANKIEULOAN@GMAIL.COM", "AQAAAAEAACcQAAAAEJ3WZTIeTxH3IWjwgj7E9gDlXOtd+QPaddilzwfiBtadDgzWiBTdgFmWflr0QyaDqg==", null, false, "", false, "trankieuloan@gmail.com" },
                    { "308da0db-e863-4814-8930-de3540e5406d", 0, "5a8a38cc-da40-423a-9028-8faa6885399c", "yungadmin@gmail.com", true, "Admin", "Yung", false, null, "YUNGADMIN@GMAIL.COM", "YUNGADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEGBhM76+OYrUK/BOQgtyMzOlW8URD3Yy3+q6ZdDhIR6WCqw7VPMW594xOlN43R6zWw==", null, false, "", false, "yungadmin@gmail.com" },
                    { "927e4f6a-62ed-4e13-b002-7e133eb47bbc", 0, "5c0c07fe-f461-43e1-8a1b-9a512f2c5e2d", "lilsuperadmin@gmail.com", true, "Super Admin", "Lil", false, null, "LILSUPERADMIN@GMAIL.COM", "LILSUPERADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEAN9Un9DKxbGxNYLX4pJVfI9KRbZpYQKsFzezxUZeJ3DSOcnxiV6+MNYznvMZCBlFQ==", null, false, "", false, "lilsuperadmin@gmail.com" },
                    { "fd4fd02a-238d-4efc-a187-14d205a841f0", 0, "b4dce1ae-8c9f-4846-9b6d-4d4dc0dfda80", "truongthitramanh@gmail.com", true, "Anh", "Trương Thị Trâm", false, null, "TRUONGTHITRAMANH@GMAIL.COM", "TRUONGTHITRAMANH@GMAIL.COM", "AQAAAAEAACcQAAAAEPzksovUL+hZAA6k06WKJHjIa4ckMw1pojWVR38Jhq0v0CEhMXUrqeR+ZasiQIk6iQ==", null, false, "", false, "truongthitramanh@gmail.com" }
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
                name: "IX_OrderDetails_OrderId",
                table: "OrderDetails",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetails_ProductId",
                table: "OrderDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_UserId",
                table: "Orders",
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

            migrationBuilder.CreateIndex(
                name: "IX_SupplierProducts_ProductId",
                table: "SupplierProducts",
                column: "ProductId");
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
                name: "OrderDetails");

            migrationBuilder.DropTable(
                name: "ProductUnits");

            migrationBuilder.DropTable(
                name: "PurchaseProposalDetails");

            migrationBuilder.DropTable(
                name: "SupplierProducts");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "GoodsReceivingNotes");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "PurchaseProposalForms");

            migrationBuilder.DropTable(
                name: "ProductCategories");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
