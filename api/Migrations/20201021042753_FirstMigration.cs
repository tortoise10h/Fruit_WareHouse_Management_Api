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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "55c87258-7dd4-4457-b19e-cdc2610a614d", "447aee1e-c05f-41b1-ab6e-cc0344007660", "Admin", "admin" },
                    { "09f73ec7-0087-439b-9483-e357547a024b", "329f6dd7-4a71-441f-a0ab-8722275632ed", "SuperAdmin", "superadmin" },
                    { "bbfa21f7-30dd-4229-8a32-bcc5edb1e094", "bbe3d4cd-8704-4a2c-8195-4279cbe7a219", "Customer", "customer" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "2fc4a62b-72e0-4ce1-aa38-c30cb15821bc", 0, "44b2c900-cfe5-4c7f-9280-b6b51031ab06", "phungthanhdo@gmail.com", true, "Độ", "Phùng Thanh", false, null, "PHUNGTHANHDO@GMAIL.COM", "PHUNGTHANHDO@GMAIL.COM", "AQAAAAEAACcQAAAAEEIGFXUQM2+MT5OVWsPPEOC2CIjMIcZGG+zO+IGFJKcqJPcTtvh0eZ4K3/nKjozF2w==", null, false, "", false, "phungthanhdo@gmail.com" },
                    { "766f6481-df4d-432c-a832-5f47ead81296", 0, "49a06f44-c410-4ae9-aafe-bf0915698261", "nguyenhue@gmail.com", true, "Huệ", "Nguyễn", false, null, "NGUYENHUE@GMAIL.COM", "NGUYENHUE@GMAIL.COM", "AQAAAAEAACcQAAAAEPZSNx5eUP8JqLKTZFKcMrA92mz7o6B1CJaXAuH22fM/aZDj4POrFVVyNCHwusHoyQ==", null, false, "", false, "nguyenhue@gmail.com" },
                    { "7efe4f15-45fc-4aa8-b2d2-6858eebe34b1", 0, "b2cc6a73-831a-4c27-aba1-2dff0ba63185", "hoxuanhuong@gmail.com", true, "Hương", "Hồ Xuân", false, null, "HOXUANHUONG@GMAIL.COM", "HOXUANHUONG@GMAIL.COM", "AQAAAAEAACcQAAAAEI7fhAulxJsnVWvkN2sGtuUvWXLUU3qV05bi58qCYfaoAagoMXbGIVEQWyd7IiqC+w==", null, false, "", false, "hoxuanhuong@gmail.com" },
                    { "4c62ad2f-63f7-4a85-963f-3c06ab5fff3f", 0, "932fc424-cdc8-4b25-acfe-f7c454acd364", "nguyenthanhlong@gmail.com", true, "Long", "Nguyễn Thành", false, null, "NGUYENTHANHLONG@GMAIL.COM", "NGUYENTHANHLONG@GMAIL.COM", "AQAAAAEAACcQAAAAEMw5XQvoRSMHq0LG77r+QFmqO11LcTlpTL/8dMPzeXBFfVoOcJ0ig/FjYzWfkXhadw==", null, false, "", false, "nguyenthanhlong@gmail.com" },
                    { "49c41914-24e5-4b1b-8751-91b2b1ee88d4", 0, "bc975bce-a9bd-49f2-ba0f-ad106c046750", "huynhtranthanh@gmail.com", true, "Thành", "Huỳnh Trấn", false, null, "HUYNHTRANTHANH@GMAIL.COM", "HUYNHTRANTHANH@GMAIL.COM", "AQAAAAEAACcQAAAAEHNgqw+3l8q2C/ObKRM4CbWePw/W5s5Paa71iCqnQbmDvjrl4f2Zl+0mJt7Z4EWdNQ==", null, false, "", false, "huynhtranthanh@gmail.com" },
                    { "37865622-4310-44ba-902e-a4a82ffb07ac", 0, "732baa51-49cc-4d01-8eaf-21c8e9a00ac0", "caobaquat@gmail.com", true, "Quát", "Cao Bá", false, null, "CAOBAQUAT@GMAIL.COM", "CAOBAQUAT@GMAIL.COM", "AQAAAAEAACcQAAAAEMj0MYYje3+fzJdLJkliYarH/vIDOEth89l3Pd0/OshaJz2vM4XHFq9jN5nlEnA8IQ==", null, false, "", false, "caobaquat@gmail.com" },
                    { "163a9a16-cdf6-428b-aa1d-a9fa2cc054c2", 0, "2d0dc967-1325-4ae6-8412-6e2621b4fb6a", "truongthitramanh@gmail.com", true, "Anh", "Trương Thị Trâm", false, null, "TRUONGTHITRAMANH@GMAIL.COM", "TRUONGTHITRAMANH@GMAIL.COM", "AQAAAAEAACcQAAAAEHbuZaHPx4dYieA16VQ2E4Pu3oTREvUyuX6s5zhHPHMRRaYZpmFM4r0js0w4u+cJhw==", null, false, "", false, "truongthitramanh@gmail.com" },
                    { "01cd768b-b548-48d8-8ba1-95d4136ca85a", 0, "9149953d-3b88-4b55-8d56-0fa5bd337438", "caothivananh@gmail.com", true, "Anh", "Cao Thị Vân", false, null, "CAOTHIVANANH@GMAIL.COM", "CAOTHIVANANH@GMAIL.COM", "AQAAAAEAACcQAAAAEBHbcaH83n2MeNXRJl13C4AaAvh6UoLvqk8T9TpsOi/9x4COkWsHBSlIG7VQUCMApw==", null, false, "", false, "caothivananh@gmail.com" },
                    { "75e69b67-2484-4a03-bb2a-cfb654467e74", 0, "efd7f02f-b18f-4935-8daf-c9c0507e9f61", "phantantrung@gmail.com", true, "Trung", "Phan Tấn", false, null, "PHANTANTRUNG@GMAIL.COM", "PHANTANTRUNG@GMAIL.COM", "AQAAAAEAACcQAAAAEH1GG2GC3ZgAHWn+kNTBiC3rFtJLZjcOQ/I86wWsA1PcqHuNT+bOSU4aXCPViHirog==", null, false, "", false, "phantantrung@gmail.com" },
                    { "3fbde490-eefc-48ed-90bc-c359f670b93e", 0, "f7635bb4-88d7-4117-a085-1bcb74d0fbd2", "nguyennhuloc@gmail.com", true, "Lộc", "Nguyễn Như", false, null, "NGUYENNHULOC@GMAIL.COM", "NGUYENNHULOC@GMAIL.COM", "AQAAAAEAACcQAAAAEMg5yyClndfEpGaEcEs+JorW4jufz+0KDMy3dwVjwKujIaQMzLJIjZwu4/vfLzoPCw==", null, false, "", false, "nguyennhuloc@gmail.com" },
                    { "c27b5e8e-8cd2-4297-a7c7-dc5a1facec1c", 0, "14ba0abc-e942-4ecd-894d-9ebcc5235458", "nguyentrunghieu@gmail.com", true, "Hiếu", "Nguyễn Trung", false, null, "NGUYENTRUNGHIEU@GMAIL.COM", "NGUYENTRUNGHIEU@GMAIL.COM", "AQAAAAEAACcQAAAAEKVdLTVBGRoG5COSwvlsE3I+v4MQ/qfPaH9Mc/obVONWHqa8p2tBXZojEg4Hi81sQQ==", null, false, "", false, "nguyentrunghieu@gmail.com" },
                    { "e9c6e7de-70a5-48ce-81ce-f64ed14d3453", 0, "7d20f333-11ae-46dc-afce-9c9ab4917272", "phamvinhson@gmail.com", true, "Sơn", "Phạm Vĩnh", false, null, "PHAMVINHSON@GMAIL.COM", "PHAMVINHSON@GMAIL.COM", "AQAAAAEAACcQAAAAEDUsTdLDyg9D8n6MMei0m5UD1Ka5nc+zHT0QeJnB9StY63sYO+yLU1Uz/Q1WPX5bvw==", null, false, "", false, "phamvinhson@gmail.com" },
                    { "ffa51c62-1729-48ea-a1be-44090dd809b5", 0, "3337c29d-a195-4a40-97f1-d52e8fead64f", "trankieuloan@gmail.com", true, "Loan", "Trần Kiều", false, null, "TRANKIEULOAN@GMAIL.COM", "TRANKIEULOAN@GMAIL.COM", "AQAAAAEAACcQAAAAELajcXMnQ2/ennjtT8CK4nUBJ38GyHf64vSFEI5L43x9NpE5jl/eMyvJZCcaeE06nQ==", null, false, "", false, "trankieuloan@gmail.com" },
                    { "f6b6f34d-9b82-451c-95c3-c3508c91e81b", 0, "77bad35e-ae42-4179-b7fb-42f0f57eca3d", "yungadmin@gmail.com", true, "Admin", "Yung", false, null, "YUNGADMIN@GMAIL.COM", "YUNGADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEDWKRGW2D9tAAqspoicKclOtviL3bBoUJ4JwacGf+W5hfj0hL9+v8tD0xWX8k3H8KQ==", null, false, "", false, "yungadmin@gmail.com" },
                    { "21e2a2ba-79b6-48d5-b734-b5eb07aa1348", 0, "e3c6342a-4bbf-4ccc-9367-00c4818fd026", "lilsuperadmin@gmail.com", true, "Super Admin", "Lil", false, null, "LILSUPERADMIN@GMAIL.COM", "LILSUPERADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEGvLtM5JWo9s5FI5ttZI3itblrQytqrZhw4Y0IkG/Eidl/JqnU71hZBR33BU8bobVg==", null, false, "", false, "lilsuperadmin@gmail.com" },
                    { "c1f16337-45eb-41a6-8563-eb35a4da746b", 0, "6afcd8df-003d-470d-ae27-ef80044643db", "tranthaonguyen@gmail.com", true, "Nguyên", "Trần Thảo", false, null, "TRANTHAONGUYEN@GMAIL.COM", "TRANTHAONGUYEN@GMAIL.COM", "AQAAAAEAACcQAAAAELxwfAQfwH8iwmou4xHBQSN1VafF37kgYEWxsl0UnhipPg/VuO8DtCMCnp6ckgEeiQ==", null, false, "", false, "tranthaonguyen@gmail.com" },
                    { "ce79ae28-4cff-4817-ba0e-6958afc9cbe2", 0, "a7604bc5-aa84-46ca-9e60-e316c0c7dbc8", "truongtuantu@gmail.com", true, "Tú", "Trương Tuấn", false, null, "TRUONGTUANTU@GMAIL.COM", "TRUONGTUANTU@GMAIL.COM", "AQAAAAEAACcQAAAAEPGJfMJEvrcKKNpUNAY5Kt/g9+UtyWokgp9W10xs9MAJajF7VOOggG/hukGN9S+HvQ==", null, false, "", false, "truongtuantu@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "21e2a2ba-79b6-48d5-b734-b5eb07aa1348", "09f73ec7-0087-439b-9483-e357547a024b" },
                    { "2fc4a62b-72e0-4ce1-aa38-c30cb15821bc", "bbfa21f7-30dd-4229-8a32-bcc5edb1e094" },
                    { "766f6481-df4d-432c-a832-5f47ead81296", "bbfa21f7-30dd-4229-8a32-bcc5edb1e094" },
                    { "7efe4f15-45fc-4aa8-b2d2-6858eebe34b1", "bbfa21f7-30dd-4229-8a32-bcc5edb1e094" },
                    { "4c62ad2f-63f7-4a85-963f-3c06ab5fff3f", "bbfa21f7-30dd-4229-8a32-bcc5edb1e094" },
                    { "49c41914-24e5-4b1b-8751-91b2b1ee88d4", "bbfa21f7-30dd-4229-8a32-bcc5edb1e094" },
                    { "37865622-4310-44ba-902e-a4a82ffb07ac", "bbfa21f7-30dd-4229-8a32-bcc5edb1e094" },
                    { "75e69b67-2484-4a03-bb2a-cfb654467e74", "bbfa21f7-30dd-4229-8a32-bcc5edb1e094" },
                    { "163a9a16-cdf6-428b-aa1d-a9fa2cc054c2", "bbfa21f7-30dd-4229-8a32-bcc5edb1e094" },
                    { "01cd768b-b548-48d8-8ba1-95d4136ca85a", "bbfa21f7-30dd-4229-8a32-bcc5edb1e094" },
                    { "3fbde490-eefc-48ed-90bc-c359f670b93e", "bbfa21f7-30dd-4229-8a32-bcc5edb1e094" },
                    { "c27b5e8e-8cd2-4297-a7c7-dc5a1facec1c", "bbfa21f7-30dd-4229-8a32-bcc5edb1e094" },
                    { "e9c6e7de-70a5-48ce-81ce-f64ed14d3453", "bbfa21f7-30dd-4229-8a32-bcc5edb1e094" },
                    { "ffa51c62-1729-48ea-a1be-44090dd809b5", "bbfa21f7-30dd-4229-8a32-bcc5edb1e094" },
                    { "f6b6f34d-9b82-451c-95c3-c3508c91e81b", "55c87258-7dd4-4457-b19e-cdc2610a614d" },
                    { "c1f16337-45eb-41a6-8563-eb35a4da746b", "bbfa21f7-30dd-4229-8a32-bcc5edb1e094" },
                    { "ce79ae28-4cff-4817-ba0e-6958afc9cbe2", "bbfa21f7-30dd-4229-8a32-bcc5edb1e094" }
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
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");
        }
    }
}
