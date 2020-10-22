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
                name: "ProductUnit",
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
                    table.PrimaryKey("PK_ProductUnit", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductUnit_Products_ProductId",
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
                    { "c834b8e1-0007-484a-9130-4a2da17b7751", "a2584fd1-5b34-4aa7-8d2f-8429febacbab", "Admin", "admin" },
                    { "b76626a7-1386-42c3-a168-5e494c3afdcf", "e1172a33-84db-4d4d-a0ab-36acafe52244", "Sale", "sale" },
                    { "189b958a-daba-486d-afeb-b66faf815f3d", "d0828e75-02ad-4cf5-b7ff-a06c61a0e68f", "SuperAdmin", "superadmin" },
                    { "96bec076-866e-4f01-8490-1ee3490f34aa", "06241a3a-d551-46a0-abce-b0f939b21168", "WarehouseKeeperManager", "warehousekeepermanager" },
                    { "b9f09031-e8e0-4d91-bbe5-41b29b3e2f86", "8c5d59b2-d612-41ef-942e-b6dc51a9c016", "WarehouseKeeper", "warehousekeeper" },
                    { "a08d8517-1f01-45b9-9700-0609323e2334", "5aa98588-072e-44c1-959f-86b720e84f0d", "Customer", "customer" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "f604ba7b-d6e7-4c15-9067-4e6171bd60bc", 0, "3f7f0989-a1e9-427b-bd03-aeee4d50eb60", "truongtuantu@gmail.com", true, "Tú", "Trương Tuấn", false, null, "TRUONGTUANTU@GMAIL.COM", "TRUONGTUANTU@GMAIL.COM", "AQAAAAEAACcQAAAAECdCkHomqV6RXpfYAqGwd/62gN6SYzra1Oj39ssLqDJ1UBEA44fQwxp62bh5can7xQ==", null, false, "", false, "truongtuantu@gmail.com" },
                    { "55627df7-d2e9-483f-8293-ddaef8f65cc2", 0, "24a62e3b-6736-4a97-ad2d-b57199302f40", "phantantrung@gmail.com", true, "Trung", "Phan Tấn", false, null, "PHANTANTRUNG@GMAIL.COM", "PHANTANTRUNG@GMAIL.COM", "AQAAAAEAACcQAAAAEPOp1ckjtBmGCaY1mim2bQhnT3LrwCgdICrlSCT/iwZHN41jfFYD8HzaaMeYwjEH+A==", null, false, "", false, "phantantrung@gmail.com" },
                    { "29c4d224-9ce6-4555-b58c-ddc5269f1e73", 0, "d5086605-79c4-4a5a-b337-d84d0c746975", "phungthanhdo@gmail.com", true, "Độ", "Phùng Thanh", false, null, "PHUNGTHANHDO@GMAIL.COM", "PHUNGTHANHDO@GMAIL.COM", "AQAAAAEAACcQAAAAEIpRNugXlWDI+kvUJmlkHAy16b84eIJE7fxSgiiwp8tNPy0oABk3HnzgmOG5xOvPaw==", null, false, "", false, "phungthanhdo@gmail.com" },
                    { "1dc4f675-c3e2-4418-8841-aef023c7e628", 0, "23a06ec3-53bc-4bb6-8c6c-3243e2dc43d8", "nguyenhue@gmail.com", true, "Huệ", "Nguyễn", false, null, "NGUYENHUE@GMAIL.COM", "NGUYENHUE@GMAIL.COM", "AQAAAAEAACcQAAAAEPm9E7cldDSoZcutuhwPEg/khYNjNRXnT+eQvda6Ygxmou9vah8+sH7O+/gDKqF+HA==", null, false, "", false, "nguyenhue@gmail.com" },
                    { "de40550f-5a2d-43dd-bb6e-74f0d9555d16", 0, "403823ac-3e7a-468d-9408-fbe67c778942", "hoxuanhuong@gmail.com", true, "Hương", "Hồ Xuân", false, null, "HOXUANHUONG@GMAIL.COM", "HOXUANHUONG@GMAIL.COM", "AQAAAAEAACcQAAAAEIWB0cuxtT8T7cL9uR9dqKPqqNeteHDlNKIiEJIP/1jnfBcaS5On4wevuSAijcWA2Q==", null, false, "", false, "hoxuanhuong@gmail.com" },
                    { "96b91bae-5bae-40b9-a240-c8bb3cf7ebef", 0, "7266c960-7e94-484b-b669-e6a5d268cfaf", "nguyenthanhlong@gmail.com", true, "Long", "Nguyễn Thành", false, null, "NGUYENTHANHLONG@GMAIL.COM", "NGUYENTHANHLONG@GMAIL.COM", "AQAAAAEAACcQAAAAEMNzXUYXbcVDdt/rrRENydqugcWOxYpYzaEowxIJucwOmH+5c8o3tgPAShP/jD7y0A==", null, false, "", false, "nguyenthanhlong@gmail.com" },
                    { "c7a5d61e-bbf8-41d9-ac02-56fb9d58fb45", 0, "10b67fe1-175b-406e-8e5d-1cffc62ba337", "huynhtranthanh@gmail.com", true, "Thành", "Huỳnh Trấn", false, null, "HUYNHTRANTHANH@GMAIL.COM", "HUYNHTRANTHANH@GMAIL.COM", "AQAAAAEAACcQAAAAECdoGXoKakMDINFud1q6wO+i1jibnWpV26eHbbcb2BNfjArLkLAGHTEFqpA6S7hLGQ==", null, false, "", false, "huynhtranthanh@gmail.com" },
                    { "5d185e71-9081-4f7d-a791-7481c5fec01f", 0, "ae76deb1-61e2-4f86-bd3c-f11338d6b294", "caobaquat@gmail.com", true, "Quát", "Cao Bá", false, null, "CAOBAQUAT@GMAIL.COM", "CAOBAQUAT@GMAIL.COM", "AQAAAAEAACcQAAAAEC5mbmkmos5ddtUr4TownhMeN78XMGW3YA1KhidydElr3FB51LH4AbzIPgRyxyNDdg==", null, false, "", false, "caobaquat@gmail.com" },
                    { "b8b33a02-ef0f-4e29-84b8-7ac86bf1785a", 0, "133fc9ef-569b-47c9-9466-62004c8d6126", "caothivananh@gmail.com", true, "Anh", "Cao Thị Vân", false, null, "CAOTHIVANANH@GMAIL.COM", "CAOTHIVANANH@GMAIL.COM", "AQAAAAEAACcQAAAAECWR/4Knf+8ORHBZoB03N0LAVJ0dKaAyBCCHLdIoE2nAvTwwHAhTM0GckSpHZaoO8g==", null, false, "", false, "caothivananh@gmail.com" },
                    { "2e04737e-9968-40a7-ad41-eccbc74217e2", 0, "58314498-c983-464b-b361-c984854d2eb9", "tranthaonguyen@gmail.com", true, "Nguyên", "Trần Thảo", false, null, "TRANTHAONGUYEN@GMAIL.COM", "TRANTHAONGUYEN@GMAIL.COM", "AQAAAAEAACcQAAAAEHSu8fwB1VjJMMNPERwYS0shKxPcbl3ZLQh/7RWwp17RdfxwdLxoBLPw0cOliElsxQ==", null, false, "", false, "tranthaonguyen@gmail.com" },
                    { "75d00dc7-5651-4453-93f7-d0ca11550a17", 0, "0647c871-fccc-48f9-8ce4-b9a0adc48c70", "nguyennhuloc@gmail.com", true, "Lộc", "Nguyễn Như", false, null, "NGUYENNHULOC@GMAIL.COM", "NGUYENNHULOC@GMAIL.COM", "AQAAAAEAACcQAAAAEO6iQl0jUtSO3yIQptCLMtcNFHhc4iXgKdOky4ERyqAV/IUyAxxi7b+v9P0iV97xLQ==", null, false, "", false, "nguyennhuloc@gmail.com" },
                    { "4d86e23d-b493-4fac-92d0-b9855debc4e9", 0, "7c31b0ef-87b8-42c8-b885-30fec09202f6", "nguyentrunghieu@gmail.com", true, "Hiếu", "Nguyễn Trung", false, null, "NGUYENTRUNGHIEU@GMAIL.COM", "NGUYENTRUNGHIEU@GMAIL.COM", "AQAAAAEAACcQAAAAEAXeD+Eacm3/Y7zrArsqq5Xwqoi1GgyPOeO9F+AS1/7UH2r8RiskSjVxY8DziML1xQ==", null, false, "", false, "nguyentrunghieu@gmail.com" },
                    { "fed18e67-86c2-4c7f-8cb9-13aeb2da490b", 0, "669faf52-db9b-4585-99ac-cf026bcb0390", "phamvinhson@gmail.com", true, "Sơn", "Phạm Vĩnh", false, null, "PHAMVINHSON@GMAIL.COM", "PHAMVINHSON@GMAIL.COM", "AQAAAAEAACcQAAAAEDGDLEf8sgua8sDRISqMla1iUtlF2VhN3UOP7y4RkBAG50ZXa4QT5f2qp4j7n4wcGA==", null, false, "", false, "phamvinhson@gmail.com" },
                    { "acdc5a84-7426-4109-abe8-488ed3d7e250", 0, "d1ebca70-4986-424a-a507-2aba6bfc8323", "trankieuloan@gmail.com", true, "Loan", "Trần Kiều", false, null, "TRANKIEULOAN@GMAIL.COM", "TRANKIEULOAN@GMAIL.COM", "AQAAAAEAACcQAAAAEGHL+z4eW6iX3Ah4bde6s9djam+r2KEnD8mTAFekjNMnk5UQAikeCUo6y+8DtkVn4w==", null, false, "", false, "trankieuloan@gmail.com" },
                    { "8e84c837-3c26-402e-8aa1-58e356640cdc", 0, "d525f962-814c-41ae-877f-7bfb911a6e92", "yungadmin@gmail.com", true, "Admin", "Yung", false, null, "YUNGADMIN@GMAIL.COM", "YUNGADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEO5oyf+kKU9igLC2ImbjmJSDUZoys1IAjDVsF7yKf56Eb7BAbIZplXlndjEc0zL35g==", null, false, "", false, "yungadmin@gmail.com" },
                    { "e26529e9-980a-431f-823b-f77996f574f9", 0, "b2204c66-186b-4b7a-8c49-183a3ad01fe7", "lilsuperadmin@gmail.com", true, "Super Admin", "Lil", false, null, "LILSUPERADMIN@GMAIL.COM", "LILSUPERADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAECiwxjZ36WCEvqZCw+0N/mjaDpeMdVcrzGLBpWbEsBGmY7tSwrxWdUYWR5E8r8uNlg==", null, false, "", false, "lilsuperadmin@gmail.com" },
                    { "c3ed21d3-4ca4-4375-9fd6-6de885e4fc8c", 0, "d79425d4-d3db-41ba-8e78-e9ccf9fa82c8", "truongthitramanh@gmail.com", true, "Anh", "Trương Thị Trâm", false, null, "TRUONGTHITRAMANH@GMAIL.COM", "TRUONGTHITRAMANH@GMAIL.COM", "AQAAAAEAACcQAAAAEFFwZPpQSPZiTvVkL+5P+Srgq2TCmMvc62VK0PA/jkhRAeZK+FCqSn8TOPx51YlnfA==", null, false, "", false, "truongthitramanh@gmail.com" }
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
                    { "e26529e9-980a-431f-823b-f77996f574f9", "189b958a-daba-486d-afeb-b66faf815f3d" },
                    { "f604ba7b-d6e7-4c15-9067-4e6171bd60bc", "b76626a7-1386-42c3-a168-5e494c3afdcf" },
                    { "55627df7-d2e9-483f-8293-ddaef8f65cc2", "b76626a7-1386-42c3-a168-5e494c3afdcf" },
                    { "29c4d224-9ce6-4555-b58c-ddc5269f1e73", "b76626a7-1386-42c3-a168-5e494c3afdcf" },
                    { "de40550f-5a2d-43dd-bb6e-74f0d9555d16", "b9f09031-e8e0-4d91-bbe5-41b29b3e2f86" },
                    { "96b91bae-5bae-40b9-a240-c8bb3cf7ebef", "b9f09031-e8e0-4d91-bbe5-41b29b3e2f86" },
                    { "c7a5d61e-bbf8-41d9-ac02-56fb9d58fb45", "96bec076-866e-4f01-8490-1ee3490f34aa" },
                    { "5d185e71-9081-4f7d-a791-7481c5fec01f", "96bec076-866e-4f01-8490-1ee3490f34aa" },
                    { "1dc4f675-c3e2-4418-8841-aef023c7e628", "b9f09031-e8e0-4d91-bbe5-41b29b3e2f86" },
                    { "2e04737e-9968-40a7-ad41-eccbc74217e2", "a08d8517-1f01-45b9-9700-0609323e2334" },
                    { "b8b33a02-ef0f-4e29-84b8-7ac86bf1785a", "a08d8517-1f01-45b9-9700-0609323e2334" },
                    { "75d00dc7-5651-4453-93f7-d0ca11550a17", "a08d8517-1f01-45b9-9700-0609323e2334" },
                    { "4d86e23d-b493-4fac-92d0-b9855debc4e9", "a08d8517-1f01-45b9-9700-0609323e2334" },
                    { "fed18e67-86c2-4c7f-8cb9-13aeb2da490b", "a08d8517-1f01-45b9-9700-0609323e2334" },
                    { "acdc5a84-7426-4109-abe8-488ed3d7e250", "a08d8517-1f01-45b9-9700-0609323e2334" },
                    { "8e84c837-3c26-402e-8aa1-58e356640cdc", "c834b8e1-0007-484a-9130-4a2da17b7751" },
                    { "c3ed21d3-4ca4-4375-9fd6-6de885e4fc8c", "a08d8517-1f01-45b9-9700-0609323e2334" }
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
                name: "IX_ProductUnit_ProductId",
                table: "ProductUnit",
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
                name: "ProductUnit");

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
