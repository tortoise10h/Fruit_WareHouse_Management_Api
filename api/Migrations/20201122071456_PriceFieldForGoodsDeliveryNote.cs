using Microsoft.EntityFrameworkCore.Migrations;

namespace api.Migrations
{
    public partial class PriceFieldForGoodsDeliveryNote : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<double>(
                name: "TotalPrice",
                table: "GoodsDeliveryNotes",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "SinglePrice",
                table: "GoodsDeliveryDetails",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "TotalPrice",
                table: "GoodsDeliveryDetails",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "423e498c-fc67-4853-ac4f-f3cd91d32e87",
                column: "ConcurrencyStamp",
                value: "50fa4267-b169-4d11-84e0-29f140bfc452");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6665ddaa-72f9-4f90-a6b1-43eb68dea610",
                column: "ConcurrencyStamp",
                value: "28bdda18-87f2-44ec-a843-d388825814bd");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6b30cb05-12f7-46c2-b95f-8d783c1f9eb1",
                column: "ConcurrencyStamp",
                value: "df35acb8-25bc-45ff-aa73-899ece53717b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "78c5228f-f600-4545-abcd-f4cc21d18e4c",
                column: "ConcurrencyStamp",
                value: "229d0ae1-93a8-4064-a094-e526ad03160a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b979036b-d165-4bea-b6b6-16b22a3f54dd",
                column: "ConcurrencyStamp",
                value: "ca7060df-d942-475a-854e-3e3ee2941488");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c2d4b743-d9da-443c-9f5a-c2682750c805",
                column: "ConcurrencyStamp",
                value: "a65c6b89-3403-43cc-848b-5ade13d79d49");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc2a0eb3-8736-441d-9130-5b421db3ac0e",
                column: "ConcurrencyStamp",
                value: "d141a6b3-f7d7-4aca-bc58-7e53fcdde9fb");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "08b84a20-7e7d-4353-bb53-74c79732beed",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "09764f11-ebb4-4e33-8107-443c53e9b113", "AQAAAAEAACcQAAAAEE8dkO28iRV6EWRqDxybGH6v5JIqWKFNYbFhEcehfLp2NywLicyt/pI/l05BkJ5O5w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "308da0db-e863-4814-8930-de3540e5406d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "19cd51df-bc78-4d3a-b549-6d0c9660475d", "AQAAAAEAACcQAAAAECeTFJWEzFcjdzPj8cN8+Qpsjfy/4awObncVX0nllHi0PybM+KSUwVAAxur+kNU8Eg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39b465e2-c398-494f-bb62-d1eb02aa5471",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "44cbfd58-45dd-420c-805e-0ec5062cb513", "AQAAAAEAACcQAAAAEPffKOkFgAcgTEYhBf3rB/mQhXkfWzRHWJx3jkoo762Ca1LlCIF5ClyNYLlO4Q4hog==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a6a1f70-8f67-4f8a-b1f9-267e5d621edb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "342406fc-ce15-4e58-b05a-1e93cef835c0", "AQAAAAEAACcQAAAAEHWNckTsh5Ruo4C/dTzETWvqZRZ43a76LsiDwOr67Ygi17wKIvEqypKiOh+uSpBQsw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b488e0f-eb92-4994-a555-cbe4ecdf3672",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "26a64d28-2c84-4ac3-962e-b4fd602d3851", "AQAAAAEAACcQAAAAEG8H09ILSFUBRrl6DCnlO6DpemT8EJ/TTpL1qtZXIipN1ZmIsIPw3ASnQkl0GfWlkg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "52999f6b-a605-45b0-b98f-b8880fc46027",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "488593d5-4a64-4ce9-8051-732b01bddf8c", "AQAAAAEAACcQAAAAECqTthWiCevHQtaZRZBAuL3KalqLeU+LUq7Sd/FdwYjK9uAgwuE/ut/0F+/dbI2ZDQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57b2db13-1d08-48a4-adca-41d837bb8937",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c7f67878-3292-409f-b570-48fa3bc0cdd8", "AQAAAAEAACcQAAAAEKzLECbRbt7L70cxDXgo+Lzt3JAoxu39lPKTDPBqnGKcBcsCzSXqsFKaI9en+5cIwA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5ce20f05-c625-43fc-ae25-a7514e9520db",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9d7691d9-d783-4fce-9107-61cd524828c9", "AQAAAAEAACcQAAAAEDwXkKruvcdz6zloNluHfp/QdkTK0q+S0/rDot60S4qnJinnKZ4nc2ehTqDY4FdMsA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f8ce951-2f66-4a9e-a4fa-7a14f85b54c6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c4f7b0d7-236d-4aa7-9518-f16da5671a9b", "AQAAAAEAACcQAAAAEJo+3nWF1ko+slTQCR4zy+sF02DqUUTl0p6T8RZk6aEmfDrstTEqeNl+S9OEIugyNg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "927e4f6a-62ed-4e13-b002-7e133eb47bbc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "545ea8fa-2698-4e24-b396-0f6cc15020a3", "AQAAAAEAACcQAAAAEGSYDt2zOwcbO7u7VhruOitMBwG49LKpijWzbMpqsh/Sb2KHhoek3kjEV0AmmCYYcQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a0c9e67b-d593-4a56-93cd-063ec5d5d035",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0277cb9f-f0a8-4ce1-86b2-b2db5274509f", "AQAAAAEAACcQAAAAEDEyia4keL+g7xafg2YLvsJ5SUWJuENXJN/vmAb7cwjeavnfYznavIVQi6YmsUCVIQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b6256340-7bd0-4373-8549-c6a08053396b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a3a9a81b-dc9f-4f8e-a5c5-67e0ee5a84be", "AQAAAAEAACcQAAAAEMYr/VRazHgyEB9G+rZ++c3yFgD/5Z8GHnTtz1gHgt+MXuabtrXPVIiJZv3S/G/zcQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ce4b2f5c-1fb9-4fe1-945c-20eca474ce16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5431f778-4fb2-4fcf-9359-95ae1d037d91", "AQAAAAEAACcQAAAAECn0GXvaRcw06pR16XrB52CdC4QZPzziNfx8Pu4OT9RoMBmuGKMO0T+8GAL2ZO9+0Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e7610feb-110c-47d0-9a88-1bfdc12742a4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b69ec719-0917-447c-b13b-df4a663785a5", "AQAAAAEAACcQAAAAEKMVfbNBcWq2szc8L5dQryioTx+jfxOz4t2fL1bHQZ2nIcJ0uU2DTfkOKxEV2PphZg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9012ef1-cd3c-49a1-8726-7f8f8aba9f98",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1bd111bd-862e-40ae-834f-3e4d7b9c0bb2", "AQAAAAEAACcQAAAAECCuTuTnKi62GYZMKOHAfpBhu/Wm6ZHlxZ0A9yezGW3ohz5ijg2JbYVQ1G7tlFgq2A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd4fd02a-238d-4efc-a187-14d205a841f0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "582a2891-373a-4bf0-b011-6ba9bde105f2", "AQAAAAEAACcQAAAAEGSEcxtDhuFY4WD7MASX8mNaLtStRF8Ccn7ZUhMPBrLToEgzhNUlHTcMHFcuhEfwPA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd9a7449-e604-48c1-a638-c564e17c1bc0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f73bfa03-e5b4-4c0b-a8e9-1bd0501251e5", "AQAAAAEAACcQAAAAEAq5UaDfRsxY9UHQDs7oPFwgyoiYWNCOFJE//UdDH+KPMpqb0JGCTGMg+8cGXwmtpw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "GoodsDeliveryNotes");

            migrationBuilder.DropColumn(
                name: "SinglePrice",
                table: "GoodsDeliveryDetails");

            migrationBuilder.DropColumn(
                name: "TotalPrice",
                table: "GoodsDeliveryDetails");

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
    }
}
