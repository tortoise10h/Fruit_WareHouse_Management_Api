using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace api.Migrations
{
    public partial class ProductRemvoveForm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ProductRemoveForms",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedAt = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ExceptionReason = table.Column<string>(nullable: true),
                    Status = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductRemoveForms", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductRemoveForms_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ProductRemoveDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedAt = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ProductRemoveFormId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false),
                    RemovedQuantity = table.Column<double>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductRemoveDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductRemoveDetails_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductRemoveDetails_ProductRemoveForms_ProductRemoveFormId",
                        column: x => x.ProductRemoveFormId,
                        principalTable: "ProductRemoveForms",
                        principalColumn: "Id");
                });

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "423e498c-fc67-4853-ac4f-f3cd91d32e87",
                column: "ConcurrencyStamp",
                value: "deb74fd2-d528-4a91-b1ff-746e5a6fd45a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6665ddaa-72f9-4f90-a6b1-43eb68dea610",
                column: "ConcurrencyStamp",
                value: "9595ac20-7590-47fe-9fe6-9eb04a326784");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6b30cb05-12f7-46c2-b95f-8d783c1f9eb1",
                column: "ConcurrencyStamp",
                value: "3630b754-9a29-486a-8c51-1c8f4a155dc2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "78c5228f-f600-4545-abcd-f4cc21d18e4c",
                column: "ConcurrencyStamp",
                value: "b2ced65c-1a5e-46ee-800f-9461bd1a40e7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b979036b-d165-4bea-b6b6-16b22a3f54dd",
                column: "ConcurrencyStamp",
                value: "0ece2477-cd2f-4ee1-9843-a74c4927c5b8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c2d4b743-d9da-443c-9f5a-c2682750c805",
                column: "ConcurrencyStamp",
                value: "6a333b52-01f1-4bef-91e4-d5e839a67e1f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc2a0eb3-8736-441d-9130-5b421db3ac0e",
                column: "ConcurrencyStamp",
                value: "ad9260cf-fa18-45bb-8bd6-00334e9bb01a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "08b84a20-7e7d-4353-bb53-74c79732beed",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "da07c98f-770d-47ab-bc2d-bbf2298b08bf", "AQAAAAEAACcQAAAAEM557aZBOV94TEuZNbE0AQgIM2n2jYOn4h3/Si09BNVLffaTDJFLeGez4yrsY4tijg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "308da0db-e863-4814-8930-de3540e5406d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5b5c81b4-3c21-4350-94a6-729ccb850e24", "AQAAAAEAACcQAAAAEAUTJ73/aQcYQNLklopsiUMCpC7e31nB0EB9FOQUHM/dgvvmJquVwJUBMI/dJKTyvw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39b465e2-c398-494f-bb62-d1eb02aa5471",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7107f1b9-fbd2-4fd4-93f0-7bb36619fa3e", "AQAAAAEAACcQAAAAELjoNqVVz3gRwNuUckfcR5Vlp81LDec2RI2IMrIWRzEX2w3oGzS9cJYufNfrOzdnHA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a6a1f70-8f67-4f8a-b1f9-267e5d621edb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d63080ea-16b7-4450-8bd1-ba37f0864c1f", "AQAAAAEAACcQAAAAEFFiWVccMkrZn/3tP5AYHDVV+hc2KLGHrQN5Lt4FNE+S9GywUfUhN1zurFy4pjO4BA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b488e0f-eb92-4994-a555-cbe4ecdf3672",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5bb50221-702d-4125-a2c2-74a78e21b4ad", "AQAAAAEAACcQAAAAEG9kLtwJnG0SXIJGd0ykSL+4WNtulZc6Rs+KysOIEPG9Sy2xBCQ0vIO8bal2bTRiSQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "52999f6b-a605-45b0-b98f-b8880fc46027",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2b965dc3-e1b5-4755-b026-0e7118987042", "AQAAAAEAACcQAAAAEFOqUaV5VnOHY2Mdt/X1XVZkpYT+BM6eDFsQzHRJcLEEXtALzzs1UGGZBzKlA/f7xQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57b2db13-1d08-48a4-adca-41d837bb8937",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "38997bdf-e8c3-45a4-90d5-1a2afb9bf8fa", "AQAAAAEAACcQAAAAEMtvxNQDxQQriZy6qC1p8+oynrbRfoiq9ih71pA87v4FD5S/kwo9ViaVKC5V6WrFoA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5ce20f05-c625-43fc-ae25-a7514e9520db",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5f2b6d1e-4276-4711-9a25-d9f0962cd20f", "AQAAAAEAACcQAAAAEITP0akXirRYE/8aAhfoXONdGjYoUtRiQ8zvtIwdPnahBDpTzrBgvO6jMc4ob6T/AQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f8ce951-2f66-4a9e-a4fa-7a14f85b54c6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "040fbd8d-0a00-48c9-803a-2552e4c8232a", "AQAAAAEAACcQAAAAEJzXGIO6lCsq2Uusf6dQt+B8VWEh3elfngNgW6ip11R3nMjiJArYi8Oz0JSbbf0eqA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "927e4f6a-62ed-4e13-b002-7e133eb47bbc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6bff4154-43ab-46a4-b373-044688dd560d", "AQAAAAEAACcQAAAAEGrzvDltNKlduH5p0wcdfZjCdYuNfC7lNauBmBWbSTnVo9WlaUBgX0bdoYXpfAhF8A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a0c9e67b-d593-4a56-93cd-063ec5d5d035",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4e8c9fb5-faf8-4dc0-9011-1f1280cc37f8", "AQAAAAEAACcQAAAAECrAE22kv6VD5efqabm4GY3zcloyZyz3vpdfnTkoaJ5iDX1OfxEixBRsJsQdDzBp7A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b6256340-7bd0-4373-8549-c6a08053396b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "812f1690-85b7-42d0-8dd7-9d357cbe3572", "AQAAAAEAACcQAAAAEHd+0BhVwcLiAGPt76v5c5dPZ5VmrtbSU4q3PTO3WSGzilkOeg9gkq6iB2NY0ELMUA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ce4b2f5c-1fb9-4fe1-945c-20eca474ce16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "82664ee3-e664-4bbd-8f11-3ad196f038d8", "AQAAAAEAACcQAAAAEJPYrpRTOyykSoWenwO2SjjeXlhzdyaQd+iOY3zZIj+CIwxOc5e+XdxWMmhV2HqybQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e7610feb-110c-47d0-9a88-1bfdc12742a4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ce2f08b5-0439-4937-a7b4-cd9a7316b1e1", "AQAAAAEAACcQAAAAEAHZxw4rTZHUy+zv7/yZ2UcJBA1lc+zG693QptsdoaHY6erHCJxYJvvLgHFTLT7UWw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9012ef1-cd3c-49a1-8726-7f8f8aba9f98",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "87384d38-97bf-48ce-9cdc-ddbf15e2cd2f", "AQAAAAEAACcQAAAAEPV+dFAqZy/MJgTa9fkbbUQZTWcMZ/WRlO86XZIcXdTCo1d0DxyUgJCshpbNFhdvmw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd4fd02a-238d-4efc-a187-14d205a841f0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "438107df-4f8a-4a97-ba28-7a7eef46a8e2", "AQAAAAEAACcQAAAAELxfkJYAGzHg+N1Ep8cXL51GH3W5g0dOwTaYynsOJWgBQHFQAoeS/E21rcWs1ZUulg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd9a7449-e604-48c1-a638-c564e17c1bc0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9d360c4d-7eed-4cbd-a36b-2e7eee671385", "AQAAAAEAACcQAAAAEJjhPBH2NWWEtbHe3eu+yWO/t9daiAZNTdIvcRNlY3BTSeM8BYZIsC4QAVTsQrYZog==" });

            migrationBuilder.CreateIndex(
                name: "IX_ProductRemoveDetails_ProductId",
                table: "ProductRemoveDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductRemoveDetails_ProductRemoveFormId",
                table: "ProductRemoveDetails",
                column: "ProductRemoveFormId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductRemoveForms_UserId",
                table: "ProductRemoveForms",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ProductRemoveDetails");

            migrationBuilder.DropTable(
                name: "ProductRemoveForms");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "423e498c-fc67-4853-ac4f-f3cd91d32e87",
                column: "ConcurrencyStamp",
                value: "55574bbe-255e-4366-8d03-d9d0c0189018");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6665ddaa-72f9-4f90-a6b1-43eb68dea610",
                column: "ConcurrencyStamp",
                value: "036a442d-a883-4fcf-b9dc-71ad9ec9fd35");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6b30cb05-12f7-46c2-b95f-8d783c1f9eb1",
                column: "ConcurrencyStamp",
                value: "556ba956-3e46-468f-8aa0-2d34a37398d2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "78c5228f-f600-4545-abcd-f4cc21d18e4c",
                column: "ConcurrencyStamp",
                value: "8b7b4f77-382b-4231-b669-d005302aee72");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b979036b-d165-4bea-b6b6-16b22a3f54dd",
                column: "ConcurrencyStamp",
                value: "8a2fe063-4487-45e5-a33e-6b78e6673ed0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c2d4b743-d9da-443c-9f5a-c2682750c805",
                column: "ConcurrencyStamp",
                value: "4c81d4e6-f1d3-475c-9544-042be4c6ad4b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc2a0eb3-8736-441d-9130-5b421db3ac0e",
                column: "ConcurrencyStamp",
                value: "07626c74-0539-4c33-9d8e-64f4fc6b5600");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "08b84a20-7e7d-4353-bb53-74c79732beed",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "484a4d94-9e10-4745-8f5b-256bf0dc2ecc", "AQAAAAEAACcQAAAAEIxYGI+Kph8SjXKQbF2VV/nMthRP4B8hIaf4j6eMKAtDGzyEZPyyGqI3UxkWIGe3zQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "308da0db-e863-4814-8930-de3540e5406d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4ece60e5-03b2-443e-821a-a2afd883d72f", "AQAAAAEAACcQAAAAENWBZts7xTHiXmxLJYqHmqM11f5/zc+ppMOfbvBBOoUeb2LvuerwB1pgT06omx/SnQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39b465e2-c398-494f-bb62-d1eb02aa5471",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "98fe09bb-a92f-4ade-9683-33065b965c87", "AQAAAAEAACcQAAAAEBJ/ERO35+Jg+mB3S1J7leLm5AP7pUy0ZpHOVO/rvtYL15+yYviwSn0IctVSNDEHtA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a6a1f70-8f67-4f8a-b1f9-267e5d621edb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bf0c7d88-d7ad-478d-ac66-a519313f0078", "AQAAAAEAACcQAAAAEHWDdi+/3wEejuG5NqnEmgjLFR9KN/yiY9HL2ZZtbEeQY3rwL8tGgaLQS4p5WvnmxA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b488e0f-eb92-4994-a555-cbe4ecdf3672",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cd205014-4251-44f6-8c64-49e69cb12f8b", "AQAAAAEAACcQAAAAEGutgkSwQ41RxtlLt7GUqPhNTCQSL9lupdqeXXVZyEGYkbRVZhk/5LN9SBxl4TrA5w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "52999f6b-a605-45b0-b98f-b8880fc46027",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e82cc074-8fe2-461f-bb5f-4f9d22b6e9b2", "AQAAAAEAACcQAAAAEBs4xN//UpgbgxKyIAsyQFvzuzafTwqx60XVEp2y364V/Gmjx/HZXcJbkiMDdwxqhg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57b2db13-1d08-48a4-adca-41d837bb8937",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e455e595-0369-42b8-b015-0297d4e0c95f", "AQAAAAEAACcQAAAAEJOtSmWpCmrjZLlkvYisxO43dNdLKQVgp3EvcW9w2d2BI8hLq0/i8Qw1zYWopEQYIg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5ce20f05-c625-43fc-ae25-a7514e9520db",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7fa4a8dc-672a-4303-90e6-3923a9194c79", "AQAAAAEAACcQAAAAEEHodcfVIChgFBj47pPKh4VE54Cz6bPClA2DXccS1L63CuAawwYZPcZlsL2lLiV3Sw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f8ce951-2f66-4a9e-a4fa-7a14f85b54c6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f67f8f5e-22ed-4224-920e-052e497426da", "AQAAAAEAACcQAAAAENQzb7jijgQPqLFrZ/YkIfBRwNgBQPt6Q/gC9gX7/phjvSzTCZ7cXZnE9xCLdvys3g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "927e4f6a-62ed-4e13-b002-7e133eb47bbc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7af7a299-7a45-4501-bc4b-7bd7277e0d13", "AQAAAAEAACcQAAAAEFSjHSJFg9gIeYaFLSXLs4PXGvQQRLFJ5PVVUD07Pwfa88h6veMfQ20HYpFa0m1QQw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a0c9e67b-d593-4a56-93cd-063ec5d5d035",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "99edc0c8-6d5b-4f61-8af2-4ae43e8fbf79", "AQAAAAEAACcQAAAAEH9x6q94qdQPurL47dm7NpIINuQr6Jgw+8L6UhaZr3NSdLt+3r0nlvKqZR92nIBdAA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b6256340-7bd0-4373-8549-c6a08053396b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f469ae61-5323-4fe7-a676-c40f363ef833", "AQAAAAEAACcQAAAAEA6XYRLgZNpe7iFZbgptGJOs0knVX1Q0BvtA89WENf732PXIztfZI6XWvUCKQg5S/A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ce4b2f5c-1fb9-4fe1-945c-20eca474ce16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "095607aa-75c6-407e-bd20-106b62440032", "AQAAAAEAACcQAAAAEKBAPJhdAsnRhiB6VtC/cIRvHgeVKHXyD1NK5In1vqXCcAdquVdBxkGJV3kzFurN6A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e7610feb-110c-47d0-9a88-1bfdc12742a4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d9344b21-3f6d-4e21-9f1e-6b003429ccaf", "AQAAAAEAACcQAAAAEF08Pv+/gcz9EnMnpVf/Zi9W9SXgVZTNdEs9T5Aa3dcIgfw7FWPmO/heWmrGuyiWDg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9012ef1-cd3c-49a1-8726-7f8f8aba9f98",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b28cf63b-410f-4485-a937-506477c45228", "AQAAAAEAACcQAAAAEBLbNAsxw1NVHDIyUSpqXWJpgByyMifMDF4R0wyUPidRNwqgM2UgVkgdnIM79isiLw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd4fd02a-238d-4efc-a187-14d205a841f0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ae158058-a4ac-4b8b-98c0-9e3e73222f38", "AQAAAAEAACcQAAAAENtcXM41F70MpJRAa1CcUUCZmn/vMogl1s5Fmxqj9SwBmnfu4vQiudGSayUBmFXe8Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd9a7449-e604-48c1-a638-c564e17c1bc0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a9c55cf4-aae8-4db3-98f5-bb9fe101c18d", "AQAAAAEAACcQAAAAEGaB3AQfELG3BwO6OcrRfpwAxSd3ceXuYTJaI5RMNFv6BvpwL05t4gJgdhh1ySA1kw==" });
        }
    }
}
