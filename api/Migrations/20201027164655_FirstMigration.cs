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
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PurchaseProposalForms", x => x.Id);
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
                    Quantity = table.Column<int>(nullable: false),
                    ProductCategoryId = table.Column<int>(nullable: false),
                    MinQuantity = table.Column<int>(nullable: true),
                    MaxQuantity = table.Column<int>(nullable: true),
                    LastSaledDate = table.Column<DateTime>(nullable: true)
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
                    Quantity = table.Column<int>(nullable: false),
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "471a0c38-1d21-4588-8d55-b5071ba23799", "1676308d-10f5-42ae-8786-59b133a23b40", "Admin", "admin" },
                    { "a77929bb-fccd-454e-bc71-c3e7e5fb4d23", "f97cccad-19f5-4104-882e-b502bcae5761", "Sale", "sale" },
                    { "927518db-7e30-4b3c-a69c-ca831da4a44c", "8b19a9c2-913d-4027-9167-94207a711c1d", "SuperAdmin", "superadmin" },
                    { "32eee7ee-ffde-4da4-a5cc-4eb65e011e3b", "f0687843-455c-4830-b189-fda3da1554be", "WarehouseKeeperManager", "warehousekeepermanager" },
                    { "57acb4c0-2745-47de-ab24-1e62f7f955eb", "546e9c07-65b0-488c-8185-6d30ed94c1c5", "WarehouseKeeper", "warehousekeeper" },
                    { "55d703b9-4f99-423e-8053-cb12f61e9c8c", "cc56e846-9b7f-455c-aa54-fa1101f96f0f", "Customer", "customer" },
                    { "76349c70-224d-4f19-9be4-4357252b81c4", "96a2a1d8-0200-46d7-ad96-36a42b09b564", "Boss", "boss" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "536eaf27-caa7-4a73-8170-f28faecf4579", 0, "115353bc-cf9f-4d40-ab39-3ebd57fc2c05", "truongtuantu@gmail.com", true, "Tú", "Trương Tuấn", false, null, "TRUONGTUANTU@GMAIL.COM", "TRUONGTUANTU@GMAIL.COM", "AQAAAAEAACcQAAAAENTTogaNOKOEZzqqb8wq6WTK0/hLrN9tYKufXJRrBBHbegQciIvcxoZ3kkT6JRVNBw==", null, false, "", false, "truongtuantu@gmail.com" },
                    { "c0959756-87f0-4251-a4c0-63b6f1bda6ab", 0, "860e7376-8f9a-4f64-94aa-15c58c75b52a", "phantantrung@gmail.com", true, "Trung", "Phan Tấn", false, null, "PHANTANTRUNG@GMAIL.COM", "PHANTANTRUNG@GMAIL.COM", "AQAAAAEAACcQAAAAEHIYrK6zEX4EuUJOrV6Uy45+fNks4wH9UbYJm5DEl4BuVvONVVQ05H33WaZI5dgj7g==", null, false, "", false, "phantantrung@gmail.com" },
                    { "272007cb-66bc-406d-9339-fe82f9b5da4f", 0, "5a3ee482-93b7-40b2-859a-b07cfaeaef28", "phungthanhdo@gmail.com", true, "Độ", "Phùng Thanh", false, null, "PHUNGTHANHDO@GMAIL.COM", "PHUNGTHANHDO@GMAIL.COM", "AQAAAAEAACcQAAAAEIu80Z+GG4uLnxr/v1p1dS746q06QhKQlfMykAKwX/rjfsF3M6aQnnd2wFO1tw6N8g==", null, false, "", false, "phungthanhdo@gmail.com" },
                    { "88c143f9-bf5a-44a2-b113-e3a1e6364221", 0, "87f1ad61-bfca-4565-8f79-26217479737b", "nguyenhue@gmail.com", true, "Huệ", "Nguyễn", false, null, "NGUYENHUE@GMAIL.COM", "NGUYENHUE@GMAIL.COM", "AQAAAAEAACcQAAAAEJ/jSpAA10uWb6nZ8y7nBl741uLWN3wvZk+QSxZ9P3uEa/AByS6dowikkhOEiWrucg==", null, false, "", false, "nguyenhue@gmail.com" },
                    { "e393cfe0-555a-4c3a-9a04-9046964c1090", 0, "b040d427-c745-496d-9b1e-b4d85c3417a5", "hoxuanhuong@gmail.com", true, "Hương", "Hồ Xuân", false, null, "HOXUANHUONG@GMAIL.COM", "HOXUANHUONG@GMAIL.COM", "AQAAAAEAACcQAAAAEMUzo7+UjpeHByh5Hozmm2BR8AaknjoKXaVZvzGcle0kiPvdLBZ56Kut6o31sEQ15Q==", null, false, "", false, "hoxuanhuong@gmail.com" },
                    { "41d15516-7e1d-4003-a35b-69489c166615", 0, "5c744bc1-4127-4613-b582-f462244434e7", "nguyenthanhlong@gmail.com", true, "Long", "Nguyễn Thành", false, null, "NGUYENTHANHLONG@GMAIL.COM", "NGUYENTHANHLONG@GMAIL.COM", "AQAAAAEAACcQAAAAEFvjVYGSVKKIv3wcaMpRiX83UGqFKyHe6+nR0sFfW7Yts1eqRPgc2o/NS4KZw7ne0A==", null, false, "", false, "nguyenthanhlong@gmail.com" },
                    { "fb354fc5-c347-49d2-bc2b-e489b3f317cb", 0, "96e6e732-eac3-4eec-a42e-63a93ef5039a", "huynhtranthanh@gmail.com", true, "Thành", "Huỳnh Trấn", false, null, "HUYNHTRANTHANH@GMAIL.COM", "HUYNHTRANTHANH@GMAIL.COM", "AQAAAAEAACcQAAAAEKnUZvXmP9NnSOE+SteXhuhoKAAwTys/PM5p5sTj7lino9A59js9kNeV5I4gJBTyPw==", null, false, "", false, "huynhtranthanh@gmail.com" },
                    { "9b8445ef-8e53-4f25-9513-44c311ce6303", 0, "8b3c0144-46cc-4190-a043-c64c0258b3dc", "caobaquat@gmail.com", true, "Quát", "Cao Bá", false, null, "CAOBAQUAT@GMAIL.COM", "CAOBAQUAT@GMAIL.COM", "AQAAAAEAACcQAAAAEH9rCvN1dtURwp6cL9BpIYzbLshvd2UZqUt49s54cEGC0y56skP2bl5ATJnWVrXcKA==", null, false, "", false, "caobaquat@gmail.com" },
                    { "0227cf58-be5b-42f1-b34f-1a2566a24b6d", 0, "ea4a002d-96d4-4669-88ec-0880e116c466", "nguyennhuloc@gmail.com", true, "Lộc", "Nguyễn Như", false, null, "NGUYENNHULOC@GMAIL.COM", "NGUYENNHULOC@GMAIL.COM", "AQAAAAEAACcQAAAAEBtS157HILNOcXK8VoqwMNo7kk5lNlOfnxH5NceECdRIQasSU6hdPiIB3xZJyECZQQ==", null, false, "", false, "nguyennhuloc@gmail.com" },
                    { "1e157ee8-30aa-449b-8df6-09389a397104", 0, "3fb90dd8-38d0-42f1-bf89-0df54e7a7a50", "tranthaonguyen@gmail.com", true, "Nguyên", "Trần Thảo", false, null, "TRANTHAONGUYEN@GMAIL.COM", "TRANTHAONGUYEN@GMAIL.COM", "AQAAAAEAACcQAAAAEGze8dfnSvtwDxPu6pJGfhw1cDT2X5xYyzxYnXNZBsuivN2htmyI2RKlpp7Hx8h5xA==", null, false, "", false, "tranthaonguyen@gmail.com" },
                    { "85c40bdf-9969-4b44-a00a-37c8bbae645a", 0, "90dec32c-b767-4175-9098-36b2b45e392e", "caothivananh@gmail.com", true, "Anh", "Cao Thị Vân", false, null, "CAOTHIVANANH@GMAIL.COM", "CAOTHIVANANH@GMAIL.COM", "AQAAAAEAACcQAAAAEJEYHHGfsANwBsQEQbXWnhMnF2vf+XCdUjlYwMDomx7JIsteFXWpFelF9d5olRbyKA==", null, false, "", false, "caothivananh@gmail.com" },
                    { "ea502dbb-5b2c-4be9-93f3-34c401043381", 0, "fa96fb74-2d93-4fb7-a03f-f72113a98128", "nguyentrunghieu@gmail.com", true, "Hiếu", "Nguyễn Trung", false, null, "NGUYENTRUNGHIEU@GMAIL.COM", "NGUYENTRUNGHIEU@GMAIL.COM", "AQAAAAEAACcQAAAAECDvvPQMsFgl9DcQjEgOK8BwPsrvhHh3UhufbfjdN8aZEBMQvoRoTSeaJvNRXT2Oyw==", null, false, "", false, "nguyentrunghieu@gmail.com" },
                    { "48f9bbdf-3345-497a-ab98-c17f69875de5", 0, "30c7b11c-0d66-47ac-97e5-a0056cf3a981", "phamvinhson@gmail.com", true, "Sơn", "Phạm Vĩnh", false, null, "PHAMVINHSON@GMAIL.COM", "PHAMVINHSON@GMAIL.COM", "AQAAAAEAACcQAAAAELNYevLSt8Hauu/0XnUlipbFqE6tWdxA4Xjz4E+Qy2GCK4BtM91DAyQ1/R5tVJKsCA==", null, false, "", false, "phamvinhson@gmail.com" },
                    { "1ad81d0f-1e59-4f1f-b464-0978b4d06750", 0, "104073a8-536c-4309-bfb5-21ad89a94c4f", "trankieuloan@gmail.com", true, "Loan", "Trần Kiều", false, null, "TRANKIEULOAN@GMAIL.COM", "TRANKIEULOAN@GMAIL.COM", "AQAAAAEAACcQAAAAECIpz0pkjlQzy4n2WCBbi/Wpckr613epqCUjJDonmhF1qxRR7L88OqYXIfeWoyxmtA==", null, false, "", false, "trankieuloan@gmail.com" },
                    { "7069f213-b9d9-4035-87ad-1607bbf81d54", 0, "4cc68f73-d97b-405f-a6f7-9ef4e5fbd5ec", "yungadmin@gmail.com", true, "Admin", "Yung", false, null, "YUNGADMIN@GMAIL.COM", "YUNGADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEPQ5E1GKXrOx4tb5sK7I4Z8EhVwyFiVexWF9oH/pGlD4GlaSrRwYptprO+tWWIMg2g==", null, false, "", false, "yungadmin@gmail.com" },
                    { "206cfe97-6e08-43f3-a1c9-7e1f6e51562b", 0, "7052977f-714d-4229-a7cc-57c6e61ef054", "lilsuperadmin@gmail.com", true, "Super Admin", "Lil", false, null, "LILSUPERADMIN@GMAIL.COM", "LILSUPERADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEErfmFrresCg0lCdYf5jXwLxO3sbiokU+YF46zQmivSrEIUmzrigrg2fNpf1mrZ48g==", null, false, "", false, "lilsuperadmin@gmail.com" },
                    { "42f8ec39-80dc-44e8-b181-90528cd297e8", 0, "236c1017-3c03-4d5d-94cc-58e9fcda1e0f", "truongthitramanh@gmail.com", true, "Anh", "Trương Thị Trâm", false, null, "TRUONGTHITRAMANH@GMAIL.COM", "TRUONGTHITRAMANH@GMAIL.COM", "AQAAAAEAACcQAAAAED7/R1aj+MFj1sF0Xfx8mOar+jMvsl9TbAaAx/y4lc76+Y8+W1jpVY1cePuLzNdJjA==", null, false, "", false, "truongthitramanh@gmail.com" }
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
                    { "206cfe97-6e08-43f3-a1c9-7e1f6e51562b", "927518db-7e30-4b3c-a69c-ca831da4a44c" },
                    { "536eaf27-caa7-4a73-8170-f28faecf4579", "a77929bb-fccd-454e-bc71-c3e7e5fb4d23" },
                    { "c0959756-87f0-4251-a4c0-63b6f1bda6ab", "a77929bb-fccd-454e-bc71-c3e7e5fb4d23" },
                    { "272007cb-66bc-406d-9339-fe82f9b5da4f", "a77929bb-fccd-454e-bc71-c3e7e5fb4d23" },
                    { "e393cfe0-555a-4c3a-9a04-9046964c1090", "57acb4c0-2745-47de-ab24-1e62f7f955eb" },
                    { "41d15516-7e1d-4003-a35b-69489c166615", "57acb4c0-2745-47de-ab24-1e62f7f955eb" },
                    { "fb354fc5-c347-49d2-bc2b-e489b3f317cb", "32eee7ee-ffde-4da4-a5cc-4eb65e011e3b" },
                    { "9b8445ef-8e53-4f25-9513-44c311ce6303", "32eee7ee-ffde-4da4-a5cc-4eb65e011e3b" },
                    { "88c143f9-bf5a-44a2-b113-e3a1e6364221", "57acb4c0-2745-47de-ab24-1e62f7f955eb" },
                    { "1e157ee8-30aa-449b-8df6-09389a397104", "55d703b9-4f99-423e-8053-cb12f61e9c8c" },
                    { "85c40bdf-9969-4b44-a00a-37c8bbae645a", "55d703b9-4f99-423e-8053-cb12f61e9c8c" },
                    { "0227cf58-be5b-42f1-b34f-1a2566a24b6d", "55d703b9-4f99-423e-8053-cb12f61e9c8c" },
                    { "ea502dbb-5b2c-4be9-93f3-34c401043381", "55d703b9-4f99-423e-8053-cb12f61e9c8c" },
                    { "48f9bbdf-3345-497a-ab98-c17f69875de5", "76349c70-224d-4f19-9be4-4357252b81c4" },
                    { "1ad81d0f-1e59-4f1f-b464-0978b4d06750", "76349c70-224d-4f19-9be4-4357252b81c4" },
                    { "7069f213-b9d9-4035-87ad-1607bbf81d54", "471a0c38-1d21-4588-8d55-b5071ba23799" },
                    { "42f8ec39-80dc-44e8-b181-90528cd297e8", "55d703b9-4f99-423e-8053-cb12f61e9c8c" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedAt", "CreatedBy", "DefaultUnit", "Description", "IsDeleted", "LastModifiedAt", "LastModifiedBy", "LastSaledDate", "MaxQuantity", "MinQuantity", "Name", "Price", "ProductCategoryId", "PurchasePrice", "Quantity", "SKU", "Status" },
                values: new object[,]
                {
                    { 32, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000, 0, "Táo Rockit Newzealand", 155000.0, 2, 20000.0, 306, "SP-TCNK-00032", 1 },
                    { 31, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000, 0, "Táo Kiku (Size lớn) - Táo Newzealand", 119000.0, 2, 20000.0, 29, "SP-TCNK-00031", 1 },
                    { 30, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000, 0, "Táo Jazz New Zealand", 110000.0, 2, 20000.0, 904, "SP-TCNK-00030", 1 },
                    { 29, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000, 0, "Táo Envy New Zealand", 235000.0, 2, 20000.0, 509, "SP-TCNK-00029", 1 },
                    { 25, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000, 0, "Kiwi ruột đỏ NewZealand", 66000.0, 2, 20000.0, 969, "SP-TCNK-00025", 1 },
                    { 27, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000, 0, "Kiwi Xanh New Zealand", 135000.0, 2, 20000.0, 655, "SP-TCNK-00027", 1 },
                    { 26, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000, 0, "Kiwi Vàng New Zealand", 235000.0, 2, 20000.0, 818, "SP-TCNK-00026", 1 },
                    { 33, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000, 0, "Táo Royal Gala Newzealand", 99000.0, 2, 20000.0, 976, "SP-TCNK-00033", 1 },
                    { 28, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000, 0, "Táo Breeze NewZealand", 83000.0, 2, 20000.0, 852, "SP-TCNK-00028", 1 },
                    { 34, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000, 0, "Táo xanh Newzealand", 110000.0, 2, 20000.0, 726, "SP-TCNK-00034", 1 },
                    { 42, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000, 0, "Mận khủng long (tím) Mỹ", 46000.0, 2, 20000.0, 802, "SP-TCNK-00042", 1 },
                    { 36, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000, 0, "Cherry đỏ Canada", 519000.0, 2, 20000.0, 675, "SP-TCNK-00036", 1 },
                    { 37, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000, 0, "Cherry Đỏ Mỹ", 490000.0, 2, 20000.0, 389, "SP-TCNK-00037", 1 },
                    { 38, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000, 0, "Hồng giòn Mỹ", 409000.0, 2, 20000.0, 813, "SP-TCNK-00038", 1 },
                    { 39, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000, 0, "Lựu Mỹ", 399000.0, 2, 20000.0, 885, "SP-TCNK-00039", 1 },
                    { 40, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000, 0, "Mận đen Mỹ", 410000.0, 2, 20000.0, 672, "SP-TCNK-00040", 1 },
                    { 41, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000, 0, "Mận đỏ Red Plum Mỹ", 420000.0, 2, 20000.0, 485, "SP-TCNK-00041", 1 },
                    { 24, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000, 0, "Cherry New Zealand Gift Box 2kg", 1600000.0, 2, 20000.0, 369, "SP-TCNK-00024", 1 },
                    { 43, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000, 0, "Mận khủng long (xanh) Mỹ", 420000.0, 2, 20000.0, 764, "SP-TCNK-00043", 1 },
                    { 44, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000, 0, "Mận khủng long đen Mỹ", 109000.0, 2, 20000.0, 439, "SP-TCNK-00044", 1 },
                    { 35, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000, 0, "Chanh vàng Sunkist Mỹ", 51250.0, 2, 20000.0, 998, "SP-TCNK-00035", 1 },
                    { 23, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000, 0, "Hồng xiêm Tiền Giang", 42000.0, 1, 20000.0, 420, "SP-TCVN-00023", 1 },
                    { 14, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000, 0, "Dưa hấu hắc mỹ nhân", 35000.0, 1, 20000.0, 324, "SP-TCVN-00014", 1 },
                    { 21, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000, 0, "Hồng chín Đà Lạt", 86000.0, 1, 20000.0, 42, "SP-TCVN-00021", 1 },
                    { 48, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000, 0, "Bơ Đăk Lăk", 90000.0, 1, 20000.0, 262, "SP-TCVN-00048", 1 },
                    { 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000, 0, "Bòn Bon Thái", 25000.0, 1, 20000.0, 896, "SP-TCVN-00001", 1 },
                    { 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000, 0, "Bưởi Đoan Hùng", 60000.0, 1, 20000.0, 259, "SP-TCVN-00002", 1 },
                    { 3, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000, 0, "Cam Xã Đoài (Vinh, Nghệ An)", 85000.0, 1, 20000.0, 251, "SP-TCVN-00003", 1 },
                    { 4, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000, 0, "Cam xoàn Lai Vung", 65000.0, 1, 20000.0, 979, "SP-TCVN-00004", 1 },
                    { 5, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000, 0, "Chanh dây", 47000.0, 1, 20000.0, 6, "SP-TCVN-00005", 1 },
                    { 6, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000, 0, "Chôm chôm nhãn", 64000.0, 1, 20000.0, 311, "SP-TCVN-00006", 1 },
                    { 7, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000, 0, "Chôm chôm Thái", 19000.0, 1, 20000.0, 900, "SP-TCVN-00007", 1 },
                    { 8, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000, 0, "Chuối cau lửa", 41000.0, 1, 20000.0, 21, "SP-TCVN-00008", 1 },
                    { 9, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000, 0, "Chuối già hương", 15000.0, 1, 20000.0, 298, "SP-TCVN-00009", 1 },
                    { 10, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000, 0, "Chuối sứ", 15000.0, 1, 20000.0, 592, "SP-TCVN-00010", 1 },
                    { 11, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000, 0, "Dâu tây Đà Lạt", 96000.0, 1, 20000.0, 171, "SP-TCVN-00011", 1 },
                    { 12, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000, 0, "Đu đủ vàng", 27000.0, 1, 20000.0, 543, "SP-TCVN-00012", 1 },
                    { 13, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000, 0, "Dưa đỏ không hạt", 15000.0, 1, 20000.0, 253, "SP-TCVN-00013", 1 },
                    { 45, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000, 0, "Mận khủng long đỏ Mỹ", 94000.0, 2, 20000.0, 21, "SP-TCNK-00045", 1 },
                    { 15, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000, 0, "Dưa lê trắng", 63000.0, 1, 20000.0, 743, "SP-TCVN-00015", 1 },
                    { 16, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000, 0, "Dưa lưới giống Nhật", 345000.0, 1, 20000.0, 811, "SP-TCVN-00016", 1 },
                    { 17, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000, 0, "Dưa lưới ruột đỏ", 57000.0, 1, 20000.0, 105, "SP-TCVN-00017", 1 },
                    { 18, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000, 0, "Dưa lưới vàng", 81000.0, 1, 20000.0, 495, "SP-TCVN-00018", 1 },
                    { 19, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000, 0, "Dứa Việt Nam", 57000.0, 1, 20000.0, 322, "SP-TCVN-00019", 1 },
                    { 20, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000, 0, "Dừa xiêm Bến Tre", 20000.0, 1, 20000.0, 759, "SP-TCVN-00020", 1 },
                    { 22, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000, 0, "Hồng giòn Đà Lạt", 34000.0, 1, 20000.0, 728, "SP-TCVN-00022", 1 },
                    { 46, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, "Kg", null, false, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), null, null, 1000, 0, "Mận khủng long Farmily Tree Mỹ", 32000.0, 2, 20000.0, 819, "SP-TCNK-00046", 1 }
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
                name: "ProductUnits");

            migrationBuilder.DropTable(
                name: "PurchaseProposalDetails");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "PurchaseProposalForms");

            migrationBuilder.DropTable(
                name: "ProductCategories");
        }
    }
}
