using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace api.Migrations
{
    public partial class UserCreateField : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedAt",
                table: "AspNetUsers",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "423e498c-fc67-4853-ac4f-f3cd91d32e87",
                column: "ConcurrencyStamp",
                value: "ab6765a2-2184-4d6e-a527-803ccc5bcd11");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6665ddaa-72f9-4f90-a6b1-43eb68dea610",
                column: "ConcurrencyStamp",
                value: "4cf223c5-5e66-4b8b-9cf0-78febd92bbac");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6b30cb05-12f7-46c2-b95f-8d783c1f9eb1",
                column: "ConcurrencyStamp",
                value: "ef2709e8-76ca-443c-a5a6-69974bc1ac95");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "78c5228f-f600-4545-abcd-f4cc21d18e4c",
                column: "ConcurrencyStamp",
                value: "6dcf6cbc-01bc-4941-a888-c86b721db6ba");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b979036b-d165-4bea-b6b6-16b22a3f54dd",
                column: "ConcurrencyStamp",
                value: "d8fec1be-83df-4b1c-a5b1-540523e71c09");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c2d4b743-d9da-443c-9f5a-c2682750c805",
                column: "ConcurrencyStamp",
                value: "9f9737d5-1a4f-49be-be76-5a5f57d950ec");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc2a0eb3-8736-441d-9130-5b421db3ac0e",
                column: "ConcurrencyStamp",
                value: "59680bfb-7bc7-4812-8e83-c057d3dd6cf8");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "08b84a20-7e7d-4353-bb53-74c79732beed",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "08f01d5b-49f0-408b-a7c4-d91df00a1e47", "AQAAAAEAACcQAAAAEB2CwcF1oPoBViJg4EFgUy1TQMLDEEAH7uNKoS833JUphZnM1aKCMY93JcZbcoEMCA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "308da0db-e863-4814-8930-de3540e5406d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8af43950-b5bb-419a-8ead-1a3945afdca6", "AQAAAAEAACcQAAAAEAUiObENVptAMK82KhF4v5k5OCkYeQCp+3TwY0gklJ3Gm+it0MN2Vqx8Lwa5/TRU0A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39b465e2-c398-494f-bb62-d1eb02aa5471",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6a25d670-f40d-433d-bb65-640300317117", "AQAAAAEAACcQAAAAEAhYqeWuNiFoGBOjp1mRNRyLNlbNj9h3HXCA98qLWkkoBXcskMY+9SGF83IFwPjl1Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a6a1f70-8f67-4f8a-b1f9-267e5d621edb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "06aa0c96-8a3b-4aaf-a96a-1db5de6e3a76", "AQAAAAEAACcQAAAAEA8H9PMDjYFKP9iZft/er95lzpHK98NVlYaWQcy6DWeztuUdgKh2s6vQhMkMrlMZ4w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b488e0f-eb92-4994-a555-cbe4ecdf3672",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4d3603af-8a5f-4db1-8e0f-a2932341987d", "AQAAAAEAACcQAAAAELKPrH8zHjSA7/wcy/QGHx0STe4Ka+4oJPJ9TkgsnFfrZoMVCiWJnJgl1lNFGNCLbw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "52999f6b-a605-45b0-b98f-b8880fc46027",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "24bf3114-a3f8-4986-8b87-3477397d30c6", "AQAAAAEAACcQAAAAEH7zYhpNgmRqwWZmJm5wmY4R6V0WbGDphEa3XUZawxMK3yb6RqWaLrQfDhbWvWL5dg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57b2db13-1d08-48a4-adca-41d837bb8937",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "21bb4b10-9a8f-430c-b1c7-b3dd324e6e09", "AQAAAAEAACcQAAAAENjW/Kva+UbXooiMk544wiRJK3dvrQh3jXqlrlErjuhxcl1NzOXG14VjEObigFvaNw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5ce20f05-c625-43fc-ae25-a7514e9520db",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4bac9c29-36aa-48c3-aa79-8355183ad610", "AQAAAAEAACcQAAAAECxipJLc3UgWf9RV7K6Hp/zW0jZJuzzLUIrBASUUhtHBw/FKaAWZFlsoeLoRednzRw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f8ce951-2f66-4a9e-a4fa-7a14f85b54c6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bdd5186e-e717-415c-a29f-f9936532136b", "AQAAAAEAACcQAAAAEMcbrKpzN6bajzdjeuq2LzZA8ylWwssRXxJPcqOHEz2badS9Z89bWLaVczs6/6F1zg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "927e4f6a-62ed-4e13-b002-7e133eb47bbc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "73bb73ae-5218-4e90-8fbf-3dcadbc14ba4", "AQAAAAEAACcQAAAAEAvQS0nRoG1RiSaDsBy+7rkCinJuUACnvUgoPObw19HqTsjm0kjvbx4saEzukB2OYw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a0c9e67b-d593-4a56-93cd-063ec5d5d035",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fe70fb12-acc4-4974-ad18-01cbebe24750", "AQAAAAEAACcQAAAAEK8QfK7fiu836bKY7GXXOEhQM8NQKkwidPo0iJ7SB9qa9pb0NIrKtxQJ1kxnZx2cZA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b6256340-7bd0-4373-8549-c6a08053396b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b59bbe82-3d7f-4965-acb2-7f6e111d56d7", "AQAAAAEAACcQAAAAECqpP9Ju/axDc7ZXrl9xbrQdP7hN286hTkPjDgbkgnwzYQTyNLa08inSDDW2j+xtKQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ce4b2f5c-1fb9-4fe1-945c-20eca474ce16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b313689c-35b0-47c2-a4ad-f570cfdaf456", "AQAAAAEAACcQAAAAEGoG/rW+2NpyGg1CDphEtRzqXslJIMbJmHP1C9O5d9SAj3xTYb5t9zSmeUeYi7dttg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e7610feb-110c-47d0-9a88-1bfdc12742a4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "27cab9fa-61b0-431e-9646-321a54d5953c", "AQAAAAEAACcQAAAAEGVHVpb9E7Ov6wvhmDbcPaAKglwyimWukQLBSl7vfYtNvYFgpYhMdy1DEmN63Qo4Ag==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9012ef1-cd3c-49a1-8726-7f8f8aba9f98",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "578acda2-6da2-4ca4-b3d6-6b03d1a0fb91", "AQAAAAEAACcQAAAAEOJzKuxnrKNnFptFwuP9BwLU4ZmMoMvWCx2OljQhzymV8V+Pn90Ynrnt2BKwamQ6Uw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd4fd02a-238d-4efc-a187-14d205a841f0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8f21f75f-6cc6-4228-9b76-c7fdd643f658", "AQAAAAEAACcQAAAAECn0js0mhOoLCpNASzfInpJKowS0i0iS4cwPWaa9X38Q8tdQewwXX5LKYLKaIotBxA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd9a7449-e604-48c1-a638-c564e17c1bc0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "45f2ef3d-c6ea-4b0d-b250-528a9d129db8", "AQAAAAEAACcQAAAAEJpmwgfqy9JouGZmhGOqbU2T29kwD6qERs6wRYYlHWmKLFSxAdTH+U/QVxIMOnyKNw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatedAt",
                table: "AspNetUsers");

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
        }
    }
}
