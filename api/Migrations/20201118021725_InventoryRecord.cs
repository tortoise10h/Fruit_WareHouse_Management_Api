using Microsoft.EntityFrameworkCore.Migrations;

namespace api.Migrations
{
    public partial class InventoryRecord : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "UserId",
                table: "InventoryRecordForms",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "423e498c-fc67-4853-ac4f-f3cd91d32e87",
                column: "ConcurrencyStamp",
                value: "188c5395-7e67-413c-a702-fe7296ab1def");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6665ddaa-72f9-4f90-a6b1-43eb68dea610",
                column: "ConcurrencyStamp",
                value: "c4455bd2-dfc9-4842-8794-f499ba9e7cff");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6b30cb05-12f7-46c2-b95f-8d783c1f9eb1",
                column: "ConcurrencyStamp",
                value: "41285db6-d7c4-43f3-b20d-952acf72e469");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "78c5228f-f600-4545-abcd-f4cc21d18e4c",
                column: "ConcurrencyStamp",
                value: "9c19cbad-3991-497f-9f02-fabacaa002f8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b979036b-d165-4bea-b6b6-16b22a3f54dd",
                column: "ConcurrencyStamp",
                value: "e44694ab-eca3-47bf-97f8-ccf763b14de4");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c2d4b743-d9da-443c-9f5a-c2682750c805",
                column: "ConcurrencyStamp",
                value: "24e875d5-6c2c-4d1e-b33a-0cb6d834470e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc2a0eb3-8736-441d-9130-5b421db3ac0e",
                column: "ConcurrencyStamp",
                value: "8271ff6f-cd6c-4a4b-8eb7-efb3f6746ec1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "08b84a20-7e7d-4353-bb53-74c79732beed",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "458568a5-4cbb-48bc-b091-847cee861a54", "AQAAAAEAACcQAAAAELQK9gAIYB/W6Nqu4NDB5W9X2UuNyaR180e8DWqZ3peEMFl2DAtSvwKX2TSFQkk1+w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "308da0db-e863-4814-8930-de3540e5406d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "31d0b67a-fb36-4814-847d-3fb1d2982435", "AQAAAAEAACcQAAAAEL6M+cUqUmGikAV9DuY7/HK1g/YSCBRtqNml8vngVcOkDkHXg8b+MhxfySSOrkHuVg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39b465e2-c398-494f-bb62-d1eb02aa5471",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bc92730a-437b-4a2e-b51c-fea61cde5d3e", "AQAAAAEAACcQAAAAEDXfTZP8LReLk+JuxegAzCSah1f0xb+IfAXDexWpyAGF32cJvPqXUKh6w3FMt7a8Cg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a6a1f70-8f67-4f8a-b1f9-267e5d621edb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "25108bed-41dc-48dc-9da0-1052c3786dee", "AQAAAAEAACcQAAAAEOA7MjZPo4DWLGpRrYAq3/LmI1cKwOMQVQF7hKya6Jv3Q4NEb/48O01/ngcFW8UN5w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b488e0f-eb92-4994-a555-cbe4ecdf3672",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ecef957f-0aec-48ec-a532-7ffb3b7a9fa3", "AQAAAAEAACcQAAAAEJwxadyN8GUuIyoBb8XoXrX9AOfU87TWV8UHztmau1SzdoqCqUJDEfrR3OQC68nI9A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "52999f6b-a605-45b0-b98f-b8880fc46027",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e85461d6-787c-4ec0-a291-3d9f62df5695", "AQAAAAEAACcQAAAAEEx1YjoWMs58sJFz27AMbvv4TaeyvxiilerlUO5alUxLUCvMY+SHXQoNGh0Tr/EyoA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57b2db13-1d08-48a4-adca-41d837bb8937",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "171565f3-e8e0-47d6-b4c8-e80883c25686", "AQAAAAEAACcQAAAAEEtn9UeTasvPpxmICRE9GmI8Q51jbe0fXDsWZuT7O5gSPeJZk5qDlmqH5tgMQJoEEw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5ce20f05-c625-43fc-ae25-a7514e9520db",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5ab2b12a-02a0-470e-8c26-151be7050444", "AQAAAAEAACcQAAAAEPKlmuP2TagMmmGgAzCDIG5evQ18UZjh6axIPGMq5M2J4NMk6x405ntMGozu5vrHHg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f8ce951-2f66-4a9e-a4fa-7a14f85b54c6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9b344fe5-26fe-44dd-a65b-9be3db307b9c", "AQAAAAEAACcQAAAAENdENrJ8bVzb35wxIhesAzwd44UhvKR21kRgsoHh1YwxmCzJropWon00Wdidez8PuQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "927e4f6a-62ed-4e13-b002-7e133eb47bbc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7b948e7b-0faf-4084-8a24-162b924c6c95", "AQAAAAEAACcQAAAAENjk8gg42RNIsRf3ktykm0qKGUKOxfQmvkUksEaP2ginZyz0Flg10xu7HUMDsLZFQg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a0c9e67b-d593-4a56-93cd-063ec5d5d035",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1c74ad03-c82e-4452-85e3-08520318fae3", "AQAAAAEAACcQAAAAEO82vgvkOJZUX21eKMHLyiiLO0N53eCV1SB0u/orM5WhKSWGIQyzaj3q84edkZcAyw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b6256340-7bd0-4373-8549-c6a08053396b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5381fa44-1a6e-41c3-a953-c985c7f63510", "AQAAAAEAACcQAAAAEKJEX5yyosUuySSmbuXWkG0+a7k1CSPMxEk4j0SO5lBxQvHdeRT6UduQ1aVfxrRuKg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ce4b2f5c-1fb9-4fe1-945c-20eca474ce16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "68a4bd80-0163-41f4-a022-77939dfc67a2", "AQAAAAEAACcQAAAAEGO5l9Wv2kwgo/zoBYBI/mDdSawmSA9M3EvfLwhnd6lBvjzyaV/Wv7muuHv7qMPCpA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e7610feb-110c-47d0-9a88-1bfdc12742a4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0498ebba-b72a-4396-a396-561efbfad0cf", "AQAAAAEAACcQAAAAEIn+/4Sz9FCz+eQWn2k8UXzi57WDmB2jzCXZ/B8nk/n0Ax9Pz/vbI6XIjjLla5h0ag==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9012ef1-cd3c-49a1-8726-7f8f8aba9f98",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0f5cc710-99a8-48e7-8fa6-f49319c7dd06", "AQAAAAEAACcQAAAAELhb+mSOQ6lUiiG7ERYECunt5MATKjJi/W7AVxhRCnyOLxRraqVWXEG99yihxikjEg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd4fd02a-238d-4efc-a187-14d205a841f0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "14c50638-f6f0-4ae1-a036-8b55b4ada197", "AQAAAAEAACcQAAAAECurl/IvMl8/9G3ICByN9i4OI/otTbXPL4l6SGW9z2VsCuE+L9t8FL+oONjzOZUIog==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd9a7449-e604-48c1-a638-c564e17c1bc0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "02ea282c-3a71-4d1b-8461-72502380a443", "AQAAAAEAACcQAAAAEIdJzb8KRhrnzHXM5pN31o1wEuK5oSf2/qBv+JVTuBmCwDl+eZHqNxZ3qPuDE7Wx1Q==" });

            migrationBuilder.CreateIndex(
                name: "IX_InventoryRecordForms_UserId",
                table: "InventoryRecordForms",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_InventoryRecordForms_AspNetUsers_UserId",
                table: "InventoryRecordForms",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InventoryRecordForms_AspNetUsers_UserId",
                table: "InventoryRecordForms");

            migrationBuilder.DropIndex(
                name: "IX_InventoryRecordForms_UserId",
                table: "InventoryRecordForms");

            migrationBuilder.DropColumn(
                name: "UserId",
                table: "InventoryRecordForms");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "423e498c-fc67-4853-ac4f-f3cd91d32e87",
                column: "ConcurrencyStamp",
                value: "e2175e5b-c4fa-4d9d-be0c-8642c1933e72");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6665ddaa-72f9-4f90-a6b1-43eb68dea610",
                column: "ConcurrencyStamp",
                value: "b161a21b-3f28-42ed-b8fd-b14dcd5270c8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6b30cb05-12f7-46c2-b95f-8d783c1f9eb1",
                column: "ConcurrencyStamp",
                value: "5fc1d5b2-2bcb-472f-ac95-967fd0dab98f");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "78c5228f-f600-4545-abcd-f4cc21d18e4c",
                column: "ConcurrencyStamp",
                value: "70ed58a0-5e91-43c9-a01f-c919100d4a3c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b979036b-d165-4bea-b6b6-16b22a3f54dd",
                column: "ConcurrencyStamp",
                value: "4615fd58-df6d-41ce-8f8d-95fbe206df6c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c2d4b743-d9da-443c-9f5a-c2682750c805",
                column: "ConcurrencyStamp",
                value: "0e12bc3c-2c12-4c6c-a62b-a19b1cf96e9d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc2a0eb3-8736-441d-9130-5b421db3ac0e",
                column: "ConcurrencyStamp",
                value: "086b3a71-33e1-4d0e-bee0-61a293b48259");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "08b84a20-7e7d-4353-bb53-74c79732beed",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c96d4832-790a-468a-9d91-a9b5b3e6c7ab", "AQAAAAEAACcQAAAAEKcO8RWMJqmO4mKG/HI7b4T/y/ItlVywemVxfMelBeRt3b1fYeOF9jIKICuGBy1d2w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "308da0db-e863-4814-8930-de3540e5406d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c7e74978-3e37-453a-b822-00eccbb2d341", "AQAAAAEAACcQAAAAEFqbvsIAj/sRNbtm/TGPthjIAcrYZWpPI5hYz2XU00jLlIzG/nnnjuUu033Y4AWG+A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39b465e2-c398-494f-bb62-d1eb02aa5471",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "eb18ad83-5d36-489e-bb4b-9c1595b6ce82", "AQAAAAEAACcQAAAAEFXiDbV512gfJ/GDAxYOpsUmaWnxgrY1nnI7AkPl+V3+EztLuKzBEblV9W5JZe4s0A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a6a1f70-8f67-4f8a-b1f9-267e5d621edb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0386c258-74f8-4dae-ba51-98bd45d4f7f8", "AQAAAAEAACcQAAAAEFIMaMgZYBMKt16c3l5ty/0t0tmTX1q156AygNvjJSS192VX2BfQLmecxC1SpqbZ+Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b488e0f-eb92-4994-a555-cbe4ecdf3672",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e8551879-a933-4086-b583-8fd56048c48e", "AQAAAAEAACcQAAAAEKIUp7MlV54SBS0vOpepCcK42Vo8nT0wyhi61b06tMX+pntD/qtKpqgXA/bJCewDjA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "52999f6b-a605-45b0-b98f-b8880fc46027",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e7ee499a-6b13-4035-955a-56b3d5215b3a", "AQAAAAEAACcQAAAAEEoYGK4KrvuqptchOtz6RE6xq5whOKXvbW25wfnIPD1uxbhH18rBgsWRcyhUCx+WOw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57b2db13-1d08-48a4-adca-41d837bb8937",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "795ca5df-0cb5-45bf-ba60-4bd66002aaa6", "AQAAAAEAACcQAAAAEHKC9W/YM1l9oj/k/WnUnflYJSi/eJyHX05VYeS4gIOdGRZa0X0TMg/nNaW5WpFmZA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5ce20f05-c625-43fc-ae25-a7514e9520db",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5c4cccd2-d6ff-47f7-94e3-99e51227926e", "AQAAAAEAACcQAAAAEEZbWqZgICtzT9GujUdVrnLkCk5mAXCyTYe/PpfX+mwXG2aFCK/2kZ2F3DDeUIdTGg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f8ce951-2f66-4a9e-a4fa-7a14f85b54c6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "37350da4-26b4-4955-a54a-5088539b8751", "AQAAAAEAACcQAAAAEN29biKVdMH/PPZa18ag1XkHD+gNbpBl8KeK7tAQn8Y/IGoRxHvmv1c9kuZHtC0uvA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "927e4f6a-62ed-4e13-b002-7e133eb47bbc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fb05624b-ee17-4b9a-bf4a-36db34798dc5", "AQAAAAEAACcQAAAAEAeIxdAMT8DQM+xAJweQ4PZG/OgPh0Rd2308SrVC6OVyRpn68Yqpqh8F/iwvjsSAkQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a0c9e67b-d593-4a56-93cd-063ec5d5d035",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2ceb63f0-1f83-4950-8b79-7a68acfe88bc", "AQAAAAEAACcQAAAAEGqlO/N/epSgul1UOd+9CyNrBzaNgHFkM4SokGCms3PtIXub4dGafGxi5he1PM0t0w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b6256340-7bd0-4373-8549-c6a08053396b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "edfba1a9-bb4c-4f40-980d-5d8aa5e388eb", "AQAAAAEAACcQAAAAEKzQmozBlii07fsvVUjMqaRL8YMIqZx1GcXfAgTiRf4oCBBXOa4/3z4l0py3koNG4A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ce4b2f5c-1fb9-4fe1-945c-20eca474ce16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1a109376-2571-4263-a12c-69f0537e5728", "AQAAAAEAACcQAAAAEE7FhxBGrMvhOG4xRLJjUCZDRlg9mbtlD4doG5kXhzGJ9YFKqIMt7JyWSuQd+74Xpw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e7610feb-110c-47d0-9a88-1bfdc12742a4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "af439b6f-e7de-41b8-93b5-53b8ca7e48ff", "AQAAAAEAACcQAAAAEMje7pqx6XlE0H3Mz2P5wBGdrQPCwJccWjYqXs5ZkJJb5BIKo1HyYHKwYU5mKP01dA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9012ef1-cd3c-49a1-8726-7f8f8aba9f98",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4e1558d7-074e-4f71-9e3b-8af78cc8c278", "AQAAAAEAACcQAAAAELTHRJSnkM+I4BtrqYZGTn8R42d7rm7yOVglQa21+FpMgLlMpH6KNt19feYS1Y/yKA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd4fd02a-238d-4efc-a187-14d205a841f0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c6b0c4f8-a951-4bbe-9f02-ba90043c0f32", "AQAAAAEAACcQAAAAEElymGBDlcMUmOwzjHJK2dz/XUaVCDfbVsNYMDqSnhPukKB7YEFwxHyLe8Jd6+6lYg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd9a7449-e604-48c1-a638-c564e17c1bc0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ec7a2836-9dad-43fc-a3c5-ff4d83786fdc", "AQAAAAEAACcQAAAAEGDWxbgQsXGBVxyue0tncwA57Za7XREaRxPMBW59BNNbdr743hzo2UPpFI+ba+bNog==" });
        }
    }
}
