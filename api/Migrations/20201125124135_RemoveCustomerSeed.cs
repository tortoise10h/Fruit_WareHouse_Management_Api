using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace api.Migrations
{
    public partial class RemoveCustomerSeed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "08b84a20-7e7d-4353-bb53-74c79732beed", "423e498c-fc67-4853-ac4f-f3cd91d32e87" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "6f8ce951-2f66-4a9e-a4fa-7a14f85b54c6", "423e498c-fc67-4853-ac4f-f3cd91d32e87" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a0c9e67b-d593-4a56-93cd-063ec5d5d035", "423e498c-fc67-4853-ac4f-f3cd91d32e87" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "b6256340-7bd0-4373-8549-c6a08053396b", "423e498c-fc67-4853-ac4f-f3cd91d32e87" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "fd4fd02a-238d-4efc-a187-14d205a841f0", "423e498c-fc67-4853-ac4f-f3cd91d32e87" });

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "08b84a20-7e7d-4353-bb53-74c79732beed");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f8ce951-2f66-4a9e-a4fa-7a14f85b54c6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a0c9e67b-d593-4a56-93cd-063ec5d5d035");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b6256340-7bd0-4373-8549-c6a08053396b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd4fd02a-238d-4efc-a187-14d205a841f0");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "423e498c-fc67-4853-ac4f-f3cd91d32e87",
                column: "ConcurrencyStamp",
                value: "c329c2d2-59ef-4953-95ae-66d2d02469e5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6665ddaa-72f9-4f90-a6b1-43eb68dea610",
                column: "ConcurrencyStamp",
                value: "ab5d0096-489a-4e84-a29e-8045bb4364e8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6b30cb05-12f7-46c2-b95f-8d783c1f9eb1",
                column: "ConcurrencyStamp",
                value: "dca25ffc-a555-4c97-8959-8788f67db3c9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "78c5228f-f600-4545-abcd-f4cc21d18e4c",
                column: "ConcurrencyStamp",
                value: "a7d1c484-3f0f-4801-803e-d6f10ce6bc44");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b979036b-d165-4bea-b6b6-16b22a3f54dd",
                column: "ConcurrencyStamp",
                value: "871d1173-8cdd-484e-ae4f-2137f4b0b226");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c2d4b743-d9da-443c-9f5a-c2682750c805",
                column: "ConcurrencyStamp",
                value: "085d166f-2331-467b-9389-feb5bf9dc739");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc2a0eb3-8736-441d-9130-5b421db3ac0e",
                column: "ConcurrencyStamp",
                value: "830eb623-d665-4788-ac5f-ef7ae76a7e34");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "308da0db-e863-4814-8930-de3540e5406d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d3acfd81-4750-48dc-89ef-0d0ac6b7a140", "AQAAAAEAACcQAAAAEHRM+/N6OiGba35QUFjhDC1fYIGBsUwG3/6vYFWuNVJ8V6QYXcgXaAiLhk7NiSUQUg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39b465e2-c398-494f-bb62-d1eb02aa5471",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1bb96338-5dad-400e-8dd9-6e182f051597", "AQAAAAEAACcQAAAAEOyRcHwFnHLcdwGWxdMdljtijYOBPMgbSzEXHKiMOxzbCmFBfiTHXUx8X0WSPkGQ0Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a6a1f70-8f67-4f8a-b1f9-267e5d621edb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b6ee39ba-3020-436a-90b5-cf1614091959", "AQAAAAEAACcQAAAAEJie9GWXtawnXfRSngM5disdNxPORIt1Oove+QC12PB84GoRrnPA0EUmRfpgcr2WTw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b488e0f-eb92-4994-a555-cbe4ecdf3672",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8139a825-0dcf-4453-9aaa-41fa0ae06726", "AQAAAAEAACcQAAAAEDmZWXY6vuKO230qmoBoab3b0NWyzF9gBFoOsQyD5MICMFJh8prQhBwKqFeR2iCWdw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "52999f6b-a605-45b0-b98f-b8880fc46027",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "13096716-81bd-4bc7-9e54-ea6d9f6aa640", "AQAAAAEAACcQAAAAEBLpgNOs6kOT3TAUO9vZLPtfLb8/KXJHg9Fcbir0yhT2gxj0a7BYZSukbORsH1KbzA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57b2db13-1d08-48a4-adca-41d837bb8937",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2a32692d-2d3f-4cea-8217-249c73813f37", "AQAAAAEAACcQAAAAELA5FR9ChNyBRvlkHyy+WIthkKuEct89fwZ5WEA+xwzscFqReV/amDdxZpDLm43DxA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5ce20f05-c625-43fc-ae25-a7514e9520db",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b48b84b8-47d1-44db-8ec4-3119e249949c", "AQAAAAEAACcQAAAAEOlAt8Yrp12rhhyMXCUw8SAdrksswpEni14aaWJfF4JBwbMMN0IiqFTj0T72DKxkMw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "927e4f6a-62ed-4e13-b002-7e133eb47bbc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "88cf17b8-ea7f-45eb-8bf1-b78d9e14cbba", "AQAAAAEAACcQAAAAELOlIipHqmmnRQ8W0KeYpgpv3fGsH/vRdqm8SrHR8fljr1NkzKObkI3wJE0jZE8/Zg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ce4b2f5c-1fb9-4fe1-945c-20eca474ce16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "23c4b200-c021-4ea6-9d2b-f8fa838cd659", "AQAAAAEAACcQAAAAEM9+E4IsB1w3QJYfrIhGfQKsHPiqC2/ub7G59SzLLJlLvFjEkhBjNBTzlayOovAsGA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e7610feb-110c-47d0-9a88-1bfdc12742a4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "77a5aa56-ab6b-4dd3-9863-3b747e719cca", "AQAAAAEAACcQAAAAELmhalB5ZtgXi9wvj1fh/wYrp2gdYhiBwIuulxpO8iWx1R+WE9JqzEz8KCSKJ/nuFQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9012ef1-cd3c-49a1-8726-7f8f8aba9f98",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "15704a5e-f289-46af-b126-44b4bbc07dda", "AQAAAAEAACcQAAAAEHvotqMfS+hPkG2/xcBsPAl7FuzNwB//CXV18Bc7cqxa08ZUh44tQpg3JEjQaJJuMw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd9a7449-e604-48c1-a638-c564e17c1bc0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8acc860a-088f-4d3d-bf56-d61469442457", "AQAAAAEAACcQAAAAEOT2Ye7jnxFiMNaHijAGmNBqfUOQD6EFTColWj8qvdg1NjUNkm5D6sygWz9zFO8Q2g==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "423e498c-fc67-4853-ac4f-f3cd91d32e87",
                column: "ConcurrencyStamp",
                value: "0b59daaf-228f-4199-9a05-3d414bb311e4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6665ddaa-72f9-4f90-a6b1-43eb68dea610",
                column: "ConcurrencyStamp",
                value: "ef423b2b-e9c0-4398-808f-d1363b325108");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6b30cb05-12f7-46c2-b95f-8d783c1f9eb1",
                column: "ConcurrencyStamp",
                value: "c3be2c80-0bf3-4e58-b3bc-f4f60da1f659");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "78c5228f-f600-4545-abcd-f4cc21d18e4c",
                column: "ConcurrencyStamp",
                value: "412bbd14-8d8a-49e4-99e0-4a19adb2862d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b979036b-d165-4bea-b6b6-16b22a3f54dd",
                column: "ConcurrencyStamp",
                value: "f20fb135-d8bd-4b64-b430-b3ae1ccbc19a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c2d4b743-d9da-443c-9f5a-c2682750c805",
                column: "ConcurrencyStamp",
                value: "693434e9-0571-4322-b9e0-f6eafe42a14f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc2a0eb3-8736-441d-9130-5b421db3ac0e",
                column: "ConcurrencyStamp",
                value: "98b9279c-e939-4491-ae77-daa7945174c0");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "308da0db-e863-4814-8930-de3540e5406d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a5b1c77d-a173-40b6-9b6b-1bba6d2296a6", "AQAAAAEAACcQAAAAEPuUi+8ldFvbFmmr9TsFqhTnrWZjy8GGgaaWyeP3I6ZL4vMKSAn+L750B1kevt/8Mg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39b465e2-c398-494f-bb62-d1eb02aa5471",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3b3dadbb-03d4-4d14-9061-34d906051fb4", "AQAAAAEAACcQAAAAECYX62CBd+INRWjpJ0MyFFn/ZbpyD6UKA7jdTEWGR7qqyqbX9f9gH0oyIwERToffig==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a6a1f70-8f67-4f8a-b1f9-267e5d621edb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cd2e4f5e-13b4-4fde-b9ed-2c56fe04c14e", "AQAAAAEAACcQAAAAEL+uvbWdVt0VJnnb8xAW0BXQRoHhsZPOZCGVo529LkdeB+DnBobMh2xjgE8p3dsRAw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b488e0f-eb92-4994-a555-cbe4ecdf3672",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d7b0fa31-c83e-4767-8f55-6b54f51df55f", "AQAAAAEAACcQAAAAEN0qtZy7UYkHtn/UJPcoqjRgw3uPhqBxhfKtODxPAXwjaBVF8Qy6QADkrO/oqvmOEQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "52999f6b-a605-45b0-b98f-b8880fc46027",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6ffa61fe-aa98-42dd-a019-fea1d26fbf86", "AQAAAAEAACcQAAAAEJ2/6ympcXoNc0ZK/tVv0swIG6HFHlEIzDA1Ip11OT7GbsUlePfCrqAIDdVMZAQuPg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57b2db13-1d08-48a4-adca-41d837bb8937",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9534c3fc-be7f-45ab-8631-af6ef0579e4b", "AQAAAAEAACcQAAAAEFpLdMMDz01QsjPAtDFLX0fwkFFJE6pf0sP5bCt6K9xT75u7fwD7mL3U1YaFwYfh0A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5ce20f05-c625-43fc-ae25-a7514e9520db",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1b896f15-e02d-40cf-be05-bb92e365f1be", "AQAAAAEAACcQAAAAEAWnxzC3IwApvpOC8B45aoP3wpA7TpzGR/qaIophP0vNjSvobkVCvRwL4J0e8LozgA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "927e4f6a-62ed-4e13-b002-7e133eb47bbc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6a51c4ed-25fe-4a7f-ab2c-006c2b7c3fbe", "AQAAAAEAACcQAAAAEKv+OYzEqF51mzeOVb7uuU8wgbvChpH4Ai16J8jGzP9/adVjUIVUQPfr09XNYydSOA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ce4b2f5c-1fb9-4fe1-945c-20eca474ce16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ed808d58-0d2a-495e-8ae0-e1683a3f2f6d", "AQAAAAEAACcQAAAAEH1AN/kpFMS1qfQPHGh9Wx2zUL6RemEGiRb+1hTIpD2ugOIdBhipM3bzWvJXZhV/mw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e7610feb-110c-47d0-9a88-1bfdc12742a4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9ee3af92-971b-4743-9f18-1caed7ab522f", "AQAAAAEAACcQAAAAEJc8YWU/8iOd/G35X11hjK53DKmtTAGnqG8YZDdXXRDaUp6NxTOurmvXmDvE72NPSw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9012ef1-cd3c-49a1-8726-7f8f8aba9f98",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f61ee6e0-ed66-4aab-b8e1-eda159332f50", "AQAAAAEAACcQAAAAEPP3EUvslEez97US5Rjx3eqmvNRJ7/GT09oW2rLXLDTqEWvEjnHcqKEHqMbPDr6Now==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd9a7449-e604-48c1-a638-c564e17c1bc0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "35320859-610d-433b-b0d6-26a7848b3e3f", "AQAAAAEAACcQAAAAENp+TvRuu2Fqb1l7mWrFXny1VUCPFSR69RYT2zNF9Wmxpj4am3wGDGfIJ9pl6ODPjQ==" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CreatedAt", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "fd4fd02a-238d-4efc-a187-14d205a841f0", 0, "ffd788b8-1041-4ddf-a281-f867616d95af", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "truongthitramanh@gmail.com", true, "Anh", "Trương Thị Trâm", false, null, "TRUONGTHITRAMANH@GMAIL.COM", "TRUONGTHITRAMANH@GMAIL.COM", "AQAAAAEAACcQAAAAECQs5YGFjm++IgD/emT+fmSuCZgx0RutvKOt8ti944GXbG447EKTuGGRCOHCKJzEag==", "0901234580", false, "", false, "truongthitramanh@gmail.com" },
                    { "a0c9e67b-d593-4a56-93cd-063ec5d5d035", 0, "8a488cbd-f60a-4a9f-8eb1-92dafa93ad8c", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "tranthaonguyen@gmail.com", true, "Nguyên", "Trần Thảo", false, null, "TRANTHAONGUYEN@GMAIL.COM", "TRANTHAONGUYEN@GMAIL.COM", "AQAAAAEAACcQAAAAEHJevxLr6nCHRKbO85KVA/3dm4b7Bc4xCjbKEzjkE9UFAsP13guWFmrpoXk41Yclvg==", "0901234582", false, "", false, "tranthaonguyen@gmail.com" },
                    { "6f8ce951-2f66-4a9e-a4fa-7a14f85b54c6", 0, "93ccde98-c834-4c4b-bac6-6dc5922c7188", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "caothivananh@gmail.com", true, "Anh", "Cao Thị Vân", false, null, "CAOTHIVANANH@GMAIL.COM", "CAOTHIVANANH@GMAIL.COM", "AQAAAAEAACcQAAAAEKCpE6YBIRG5n9cp7tFpBR0PxZGgm7E/sEG3ovM8HvGBllikj0MUeEh3rBSfLoVgFg==", "0901234584", false, "", false, "caothivananh@gmail.com" },
                    { "b6256340-7bd0-4373-8549-c6a08053396b", 0, "6b97996b-c394-4aba-9c8b-48a542ec2c37", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "nguyennhuloc@gmail.com", true, "Lộc", "Nguyễn Như", false, null, "NGUYENNHULOC@GMAIL.COM", "NGUYENNHULOC@GMAIL.COM", "AQAAAAEAACcQAAAAEGJjE3lSH4MAW7ld9hBqLAXz9puJHlmbtaeiCQIWTPDfir5iHgpfeic1K3ArOckc8A==", "0901234585", false, "", false, "nguyennhuloc@gmail.com" },
                    { "08b84a20-7e7d-4353-bb53-74c79732beed", 0, "0c1d0e2b-3e80-4dcc-8ab4-43eaba5698df", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "nguyentrunghieu@gmail.com", true, "Hiếu", "Nguyễn Trung", false, null, "NGUYENTRUNGHIEU@GMAIL.COM", "NGUYENTRUNGHIEU@GMAIL.COM", "AQAAAAEAACcQAAAAECfluSDlGgflEEoDcUNBMNXd00PDAXjwFVTQgm8YlI0HVymoOc/EuWp/Qq/N44/MXA==", "0901234566", false, "", false, "nguyentrunghieu@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "08b84a20-7e7d-4353-bb53-74c79732beed", "423e498c-fc67-4853-ac4f-f3cd91d32e87" },
                    { "b6256340-7bd0-4373-8549-c6a08053396b", "423e498c-fc67-4853-ac4f-f3cd91d32e87" },
                    { "6f8ce951-2f66-4a9e-a4fa-7a14f85b54c6", "423e498c-fc67-4853-ac4f-f3cd91d32e87" },
                    { "a0c9e67b-d593-4a56-93cd-063ec5d5d035", "423e498c-fc67-4853-ac4f-f3cd91d32e87" },
                    { "fd4fd02a-238d-4efc-a187-14d205a841f0", "423e498c-fc67-4853-ac4f-f3cd91d32e87" }
                });
        }
    }
}
