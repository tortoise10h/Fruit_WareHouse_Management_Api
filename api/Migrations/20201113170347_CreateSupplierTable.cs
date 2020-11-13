using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace api.Migrations
{
    public partial class CreateSupplierTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "423e498c-fc67-4853-ac4f-f3cd91d32e87",
                column: "ConcurrencyStamp",
                value: "5195a361-1857-40de-9e56-a8849a6342f8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6665ddaa-72f9-4f90-a6b1-43eb68dea610",
                column: "ConcurrencyStamp",
                value: "d3ec50fa-0b23-41be-bc68-c7dc680c0001");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6b30cb05-12f7-46c2-b95f-8d783c1f9eb1",
                column: "ConcurrencyStamp",
                value: "73aa6fcc-4290-44c8-ad87-a76a23be52b7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "78c5228f-f600-4545-abcd-f4cc21d18e4c",
                column: "ConcurrencyStamp",
                value: "11915968-22dd-46ab-9d0c-9627ea8bbdd2");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b979036b-d165-4bea-b6b6-16b22a3f54dd",
                column: "ConcurrencyStamp",
                value: "e056f41c-e897-4204-80f0-5852e367f8da");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c2d4b743-d9da-443c-9f5a-c2682750c805",
                column: "ConcurrencyStamp",
                value: "63156817-2caa-4f61-8ca6-e1b9b9f6da38");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc2a0eb3-8736-441d-9130-5b421db3ac0e",
                column: "ConcurrencyStamp",
                value: "311c45a9-362c-4c77-a2aa-e281c632d452");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "08b84a20-7e7d-4353-bb53-74c79732beed",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1d3f46cf-7eb9-4b6e-bc82-7ad273c4e847", "AQAAAAEAACcQAAAAEHpFCAWYR4AjpLsW+3YyyooT3u0Ksj0cT3wRgzJcIGm5L6PiJBr42DiaKZfu7Rkp5g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "308da0db-e863-4814-8930-de3540e5406d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6070c5f7-26f8-4252-a5cc-eab03837fdf9", "AQAAAAEAACcQAAAAEEGZXiK2wd28jBbPpVAnUwT4OQwbYHePjSy8Y/yhLXnO/h0yDzLyFDQCEaLWcLBoIw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39b465e2-c398-494f-bb62-d1eb02aa5471",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "87e2fb12-fa51-4c04-8ac0-60d322dea488", "AQAAAAEAACcQAAAAEJgtKAYQ1ZXxj+vDOp1gt+eWpjuQfpF8bQcaJ1Upm0VgHs2E8s2R7g9Xmefb60qEgQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a6a1f70-8f67-4f8a-b1f9-267e5d621edb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dc29a4a7-dc95-4c57-bd09-51e13977b91e", "AQAAAAEAACcQAAAAEL4Z81gqTTuRt8InlIYVQyyvRIVk0rurXoJ2+Ifv0EZV4VUPSVUEZsDicyK62qOZFw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b488e0f-eb92-4994-a555-cbe4ecdf3672",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fbba6764-9065-43e0-a420-973a2f857a6b", "AQAAAAEAACcQAAAAELKR1tIrBoZTa75KAGSEJeEsQodTr0piBsDDglBiLoaQzkDnAQZHUmj5fChtQWNDTw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "52999f6b-a605-45b0-b98f-b8880fc46027",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f515d511-3076-4af6-adcc-782f5cbcc926", "AQAAAAEAACcQAAAAELi97o8AoEpBCnMHW7N2J+dQ0nH+EX3gm/HAg7axtelp/9YZtEAOyDPd4uw124M8SQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57b2db13-1d08-48a4-adca-41d837bb8937",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3f41dc9c-6f0d-454b-a44d-422c0e124822", "AQAAAAEAACcQAAAAEGZXBmWKxT4T0NMwXmr6m8tzZyHVJ9RWAhvWWnvT1547yHD9rqcGsrI+DdrEeoj3Qg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5ce20f05-c625-43fc-ae25-a7514e9520db",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "681b29d9-8b08-47af-baa9-5de2e6bbebc2", "AQAAAAEAACcQAAAAEPe7KqMNWepkr7OsAhQ9DG/H0AlGrjSVhm5XrYRxtumFi6Ikv0FfvvRtj7w+NXHT9A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f8ce951-2f66-4a9e-a4fa-7a14f85b54c6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5ee3be30-5b01-40cd-9750-2e68fd8296df", "AQAAAAEAACcQAAAAEPiRIxySo4W9vz7hb7+cC+3rIvbfFJMj8vrmraOd+YF9gtJHRx0L2y223Yrr5V9wdQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "927e4f6a-62ed-4e13-b002-7e133eb47bbc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bad4ca73-0de6-44d6-82d0-6631be18fb8f", "AQAAAAEAACcQAAAAEGt3ESGmDD0JRAvHTfFvTJn5kDGRgFZC1EaVNf8lE5zo79gAllIbkajBuF5y8UxzPA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a0c9e67b-d593-4a56-93cd-063ec5d5d035",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5cbd0ad2-b7ec-4d8a-9754-874a34aa51a7", "AQAAAAEAACcQAAAAEHp/nM0QHpTII2hTSp3g2SbiRvN7KBL/43LPz0SG3Io2sVKjVtewvIrwB+51TNfGMA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b6256340-7bd0-4373-8549-c6a08053396b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "53879fc1-4115-4ad0-9735-3942c114e2ab", "AQAAAAEAACcQAAAAEGBLo3/V5sJeCBn7wGvo8M5wpCCCMQ8F76lKdU16oVyyeM7U7o2dkgRg/UHKZTKr+A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ce4b2f5c-1fb9-4fe1-945c-20eca474ce16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "de198364-4cd0-4823-ae7f-8352cf91e88f", "AQAAAAEAACcQAAAAEB86L3r4B5bH5LMkMK6137jnlQKr8BKv4echBxAqF4qwPLBDvMTtAF2lWMCPBf/p6A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e7610feb-110c-47d0-9a88-1bfdc12742a4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a266edca-9f27-49f6-856d-57e856aac2c8", "AQAAAAEAACcQAAAAEDUkRE64apR8a/ChiUmX4Gro+aIkbHUAYc2ir5wpVacGFjJXNhUDHsS/F0aoI+fPDw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9012ef1-cd3c-49a1-8726-7f8f8aba9f98",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b0eedba1-dc60-4968-b79f-95905f768628", "AQAAAAEAACcQAAAAEBthPGj/lJ96GPWZh2r71N3CFjmgnpg0DHwcpqQRIeNw3AUnXub6gtsHZD9pDBCEnQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd4fd02a-238d-4efc-a187-14d205a841f0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d37343aa-b7e5-47f1-a36a-a523723636bc", "AQAAAAEAACcQAAAAEA76jYE4/o389GBn3pKcxgnJxu3fUaWYo5adbmgAWyK2tmqQiZKa+i8j8j4GsqWiIQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd9a7449-e604-48c1-a638-c564e17c1bc0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "88560f8e-d24d-4d64-a630-a6eb243722d9", "AQAAAAEAACcQAAAAEP5Ddz4OG+G1cvy+uo2qkNfEGh5Y4AQOKSFnIHo9waGOPbCCcA8ovk0Zxx1ROYEjdw==" });

            migrationBuilder.CreateIndex(
                name: "IX_SupplierProducts_ProductId",
                table: "SupplierProducts",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "SupplierProducts");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "423e498c-fc67-4853-ac4f-f3cd91d32e87",
                column: "ConcurrencyStamp",
                value: "035e9991-d889-41e8-9922-f6d5d17ab72a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6665ddaa-72f9-4f90-a6b1-43eb68dea610",
                column: "ConcurrencyStamp",
                value: "0fa75002-9f39-453b-a890-dacdd612722a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6b30cb05-12f7-46c2-b95f-8d783c1f9eb1",
                column: "ConcurrencyStamp",
                value: "65499a65-f9e4-4840-8349-9ee128e8c552");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "78c5228f-f600-4545-abcd-f4cc21d18e4c",
                column: "ConcurrencyStamp",
                value: "d9ef224e-6706-4ec3-8b01-bd861f7954f4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b979036b-d165-4bea-b6b6-16b22a3f54dd",
                column: "ConcurrencyStamp",
                value: "32efc935-28a4-4eae-8f21-fbe7b7832516");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c2d4b743-d9da-443c-9f5a-c2682750c805",
                column: "ConcurrencyStamp",
                value: "147e9cd6-6a56-449b-bbb1-ed9f009e632d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc2a0eb3-8736-441d-9130-5b421db3ac0e",
                column: "ConcurrencyStamp",
                value: "4280671d-160d-4c52-9770-851bccbef2ae");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "08b84a20-7e7d-4353-bb53-74c79732beed",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "29f25be6-9fab-47fe-8e9a-5486cf90b122", "AQAAAAEAACcQAAAAEILtaPM0ciwfsGnBXjQ2dRRorK32hDwePZYdy2y4ncT8t+57uwo7q6GY6AhBOuN3dg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "308da0db-e863-4814-8930-de3540e5406d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "74ef69c6-cb50-4b45-9d74-dbfaeb0bb15f", "AQAAAAEAACcQAAAAEBSUmVyH+0PkR/0soUR58jScDPnWpBWFs+y+YHQ1TxY0WGpSi8QD8WLW8DWf/1qWew==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39b465e2-c398-494f-bb62-d1eb02aa5471",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "563ed447-b044-49a8-927e-67e857646fe5", "AQAAAAEAACcQAAAAECIRwb3YtyUfQ6AjEGy9p6UYwzfdcDCLOjjUv9/bNxOAjxmTVuVMPEDP2OXZYC1sag==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a6a1f70-8f67-4f8a-b1f9-267e5d621edb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a6d8a432-60fd-4139-a427-0a21b8803519", "AQAAAAEAACcQAAAAEG1ASImQXfmzmXC/2MjufxKOwq3SaimEjb+PMZZXF6ix9Cb958zYEgoFwXPr0GymYQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b488e0f-eb92-4994-a555-cbe4ecdf3672",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "53b47278-36c5-4c5a-8a5b-9c99916e26b2", "AQAAAAEAACcQAAAAEA4fkn3GOAcYq2mrPoOXTUOWyySRwCFupvA4/Sw/U6xqgb944//YeyTOVhDVXsOT6A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "52999f6b-a605-45b0-b98f-b8880fc46027",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b029fbf1-b701-4403-8197-07e470103f88", "AQAAAAEAACcQAAAAELk2utqX9PQBO7tEtPmCQzzeQNFm5pytwWfHFksoZPUt56MenEKKVONgao4Tee33KA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57b2db13-1d08-48a4-adca-41d837bb8937",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c6c8d176-27d0-42ee-9666-2eb04f6abdfb", "AQAAAAEAACcQAAAAED6zqkbvW7kf1MPqa4EZNQU3fVx/33SRNrw6JGg7RM1RgFntUZUNmu95umry/xMXtg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5ce20f05-c625-43fc-ae25-a7514e9520db",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "590eaef5-7905-4b8e-814a-b6bea6d24d50", "AQAAAAEAACcQAAAAEBU9g6Dh+3H0DAv5dBwRRns6WYGLhVDuLpDExjcEl2cpPP/dSWKzqS1lq1IMwXqoYw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f8ce951-2f66-4a9e-a4fa-7a14f85b54c6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b9e24b09-4ea6-4696-ae67-6db802e66f1d", "AQAAAAEAACcQAAAAEOzbv01eXnB6lHEDejokO2vxqyDmpijcSSY3TZPdeqZSzKvqd5M5CxWCu1AUfzOlvA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "927e4f6a-62ed-4e13-b002-7e133eb47bbc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3e8f78c8-e9f0-454e-a379-d2879cecf559", "AQAAAAEAACcQAAAAENTXWV+zrb8vPmogcEBNX9QwjG2vgfHEHYsrkMq5Dr5HifVa06DRZiDKPxFpplRoLw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a0c9e67b-d593-4a56-93cd-063ec5d5d035",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "420fc063-a629-4875-9693-5047cbdbacab", "AQAAAAEAACcQAAAAECJ/NIqMuoOudEfX6gdfXX0rbnJWmzfBy0/PpTkafcw1jSlAasz6cmunrHOB8RgMXw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b6256340-7bd0-4373-8549-c6a08053396b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d3156c80-0a3c-43ed-ad75-2e078104ef5b", "AQAAAAEAACcQAAAAEIxwQFDF8GxdtTwejS5Fo1B3fDhi3Q9L72xUfOGxmZoJ3a8dYv52SPDqsccyHTnmTw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ce4b2f5c-1fb9-4fe1-945c-20eca474ce16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c7840bb9-29c4-4740-9c4b-434fdeccd366", "AQAAAAEAACcQAAAAEDs7CbHF4FefQJlFQf9F7RMoM/rJrD/+67qZAq0MsO0kiYDQRFIxTSHbj2tvqm+67w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e7610feb-110c-47d0-9a88-1bfdc12742a4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9e2fe854-b82c-41f5-8082-92d15b9da72d", "AQAAAAEAACcQAAAAELM1xpkmg8osvlYsiIUFUJfXoiD9jfofItL2jZKkRgKpHIgq6IkVWCVvkwTUIqeRoQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9012ef1-cd3c-49a1-8726-7f8f8aba9f98",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ec03f7ce-4bf4-4d12-a6de-a9b28a057023", "AQAAAAEAACcQAAAAEPlpH6OlLTVcVW8pqZqfXOZSsLkyuh6PeOZgnfGhGKx66qWkAnTAaf5GIjMZryScVA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd4fd02a-238d-4efc-a187-14d205a841f0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ef2aebe7-20b2-4131-9576-5e24c20c0c06", "AQAAAAEAACcQAAAAEOLXtixKNFO60h7mjPRyHlTwSpK7toA/NMiK9WDzWpfTV08xXyeQWdKIoJ9I0wMJPQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd9a7449-e604-48c1-a638-c564e17c1bc0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a46fe729-b366-437d-8140-a6a93ccd65a8", "AQAAAAEAACcQAAAAEM3nyaTSjIcPXAkz9NWTiiO+EVuoY7fKJ9bs24boMfeiJ1zY4xfSqtM909f0zm8dvA==" });
        }
    }
}
