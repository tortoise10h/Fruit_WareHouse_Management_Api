using Microsoft.EntityFrameworkCore.Migrations;

namespace api.Migrations
{
    public partial class GoodsDeliveryNoteAndGoodsDeliveryDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GoodsDeliveryDetail_GoodsDeliveryNote_GoodsDeliveryNoteId",
                table: "GoodsDeliveryDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_GoodsDeliveryDetail_Products_ProductId",
                table: "GoodsDeliveryDetail");

            migrationBuilder.DropForeignKey(
                name: "FK_GoodsDeliveryNote_Orders_OrderId",
                table: "GoodsDeliveryNote");

            migrationBuilder.DropForeignKey(
                name: "FK_GoodsDeliveryNote_AspNetUsers_UserId",
                table: "GoodsDeliveryNote");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GoodsDeliveryNote",
                table: "GoodsDeliveryNote");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GoodsDeliveryDetail",
                table: "GoodsDeliveryDetail");

            migrationBuilder.RenameTable(
                name: "GoodsDeliveryNote",
                newName: "GoodsDeliveryNotes");

            migrationBuilder.RenameTable(
                name: "GoodsDeliveryDetail",
                newName: "GoodsDeliveryDetails");

            migrationBuilder.RenameIndex(
                name: "IX_GoodsDeliveryNote_UserId",
                table: "GoodsDeliveryNotes",
                newName: "IX_GoodsDeliveryNotes_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_GoodsDeliveryNote_OrderId",
                table: "GoodsDeliveryNotes",
                newName: "IX_GoodsDeliveryNotes_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_GoodsDeliveryDetail_ProductId",
                table: "GoodsDeliveryDetails",
                newName: "IX_GoodsDeliveryDetails_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_GoodsDeliveryDetail_GoodsDeliveryNoteId",
                table: "GoodsDeliveryDetails",
                newName: "IX_GoodsDeliveryDetails_GoodsDeliveryNoteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GoodsDeliveryNotes",
                table: "GoodsDeliveryNotes",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GoodsDeliveryDetails",
                table: "GoodsDeliveryDetails",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "423e498c-fc67-4853-ac4f-f3cd91d32e87",
                column: "ConcurrencyStamp",
                value: "085d579f-7d03-408c-a0c0-7cccefae57e3");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6665ddaa-72f9-4f90-a6b1-43eb68dea610",
                column: "ConcurrencyStamp",
                value: "f7676e9c-e928-48f3-9cca-e443ce6b4e5c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6b30cb05-12f7-46c2-b95f-8d783c1f9eb1",
                column: "ConcurrencyStamp",
                value: "61d63258-72cf-4770-9b9e-a6ba2967730d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "78c5228f-f600-4545-abcd-f4cc21d18e4c",
                column: "ConcurrencyStamp",
                value: "7ed28bb8-f2fd-4270-9651-3dabb024e030");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b979036b-d165-4bea-b6b6-16b22a3f54dd",
                column: "ConcurrencyStamp",
                value: "64294af0-75a9-45e2-9d13-3f541a20c725");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c2d4b743-d9da-443c-9f5a-c2682750c805",
                column: "ConcurrencyStamp",
                value: "fd977d94-29e9-4505-8cb4-e1cd7b8ec613");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc2a0eb3-8736-441d-9130-5b421db3ac0e",
                column: "ConcurrencyStamp",
                value: "5fb8ceb7-3854-4ff8-a269-545c0d65c29a");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "08b84a20-7e7d-4353-bb53-74c79732beed",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "04343acf-ee1c-4350-9051-7b8cf995ab74", "AQAAAAEAACcQAAAAEMu4f1fVGB8MAu+vcNW3SCwjYjXsTpeEBUQ9Go67SsXIirLH+E3r9aPfTHr54BNkbQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "308da0db-e863-4814-8930-de3540e5406d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "921e38f5-b236-4126-a7fc-ffce46cf46f2", "AQAAAAEAACcQAAAAEIaFPDKu6e+YZcvb1dnlsiWe3mn+XTRbQFmBP7Z2BlmO+JDh784e0gMbunhkNsPMAA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39b465e2-c398-494f-bb62-d1eb02aa5471",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d6c5db3b-58c7-4dce-bc83-480f4a121cb0", "AQAAAAEAACcQAAAAEN4VJFhur+En7lmkbUubsxyoj5Q2k+ac49NBylI0zYJAKkoQCEF5MNOMk9EPotWSqg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a6a1f70-8f67-4f8a-b1f9-267e5d621edb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5652de70-8f39-4799-bfc4-c9f767078034", "AQAAAAEAACcQAAAAEDctM3akAc9VmvWpLMrj6aPuU3GBZsxERXBhaidpkLpO2NQV+yEzcielFUkwAn3uew==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b488e0f-eb92-4994-a555-cbe4ecdf3672",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6a3615c5-2176-47b2-afcc-ac8bdaeffb2e", "AQAAAAEAACcQAAAAEKC4mzI1N+L66h2ThDrt9NGHd/xddwLAQFARxiy8fHVWh9pv+VHx7zDzjlcyPAyXdQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "52999f6b-a605-45b0-b98f-b8880fc46027",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e6eaad57-8c3b-4031-9ecb-3cdfe2f426dd", "AQAAAAEAACcQAAAAEDtWjLDa6gdhDBWvUKy6uxLMkVAxsvyMtPttQr+9hQGWeNMqQmRo2ink8gp6RJwS4w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57b2db13-1d08-48a4-adca-41d837bb8937",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "24f8b22a-c131-4406-a645-f9237cedda73", "AQAAAAEAACcQAAAAEJ4zCM9CkXw8Exhn7oKduEuTLltBRT/KTx3RE59KQLU3xp932FPw8dPdx3BQoC4bPw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5ce20f05-c625-43fc-ae25-a7514e9520db",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0d75e098-7b79-4ba8-bd72-48e50244527c", "AQAAAAEAACcQAAAAEGEqygLYfOgY+IXxd4I+vDZJvGShSqetL/np1V9P9xdjd0Tgm+VwPegFyxck5ZO4lA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f8ce951-2f66-4a9e-a4fa-7a14f85b54c6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "f39fecf6-e69e-4afc-9dfd-de245cc54edb", "AQAAAAEAACcQAAAAEMY3+gKw9yM9jLk+LZGlPMq3q47eBmHPGfUuVk3iAME703K0ZfO4uCKBDBDxIfPkWg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "927e4f6a-62ed-4e13-b002-7e133eb47bbc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "90f74e60-68ed-4101-803a-568fe69ea19f", "AQAAAAEAACcQAAAAEKMSjH6iOXj6Rs1Vhdw9qs1w50PiPuAYvgvtpZnC3zvYG+pHdbjch+u8xn+0Ibu82w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a0c9e67b-d593-4a56-93cd-063ec5d5d035",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8bfbfe1d-55a7-4c2d-a735-c7768899b56e", "AQAAAAEAACcQAAAAEHMUFkR9o7JYh8z1Bsmc9lEIsKI4VRoOaxDHYjm81w88zLGODtLaBcqzRhYCqgfi5A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b6256340-7bd0-4373-8549-c6a08053396b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3dec63bd-7020-4296-94ac-74194346f1b4", "AQAAAAEAACcQAAAAELTaOZtZVpJEA/Cg2bwZIgW/7C35vEe4IQAN0RyEXbBnHbjq9YMhI7samLZDuqZeWQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ce4b2f5c-1fb9-4fe1-945c-20eca474ce16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1c234380-f6a7-48c4-bf16-6372a61c0833", "AQAAAAEAACcQAAAAEB/agzZrybDdBdQ6dH0dXNaFLnlYmmTMmfHxuPQCltVIhlEY8Ki/N5Bb295KgJlj9w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e7610feb-110c-47d0-9a88-1bfdc12742a4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bc5470e7-5829-4d28-8b57-30793bf57e02", "AQAAAAEAACcQAAAAECeKYtNPKp0AOxiEfYlUaMT3MXiX2pkwhh3++I0wSm58JYLrEtopMiymbVO8TtCCmQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9012ef1-cd3c-49a1-8726-7f8f8aba9f98",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "746a9abb-9b06-4013-91d4-1192315a879c", "AQAAAAEAACcQAAAAEKRrdc4INcShRt1pchKtxRP6aF0DmQSzX1ZdUewBai+Ntvzv6cB9Lk2b8XjK5chzeA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd4fd02a-238d-4efc-a187-14d205a841f0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7f2af424-471b-4731-ab59-35296abc6897", "AQAAAAEAACcQAAAAEOwlp5Cl/BhSq8vwC3ZLB5V1y37WwVNrO97vcj9YhAPiIA1iSezrc9ydUwa48eIoNQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd9a7449-e604-48c1-a638-c564e17c1bc0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d441f6d6-7ded-421d-8294-958381ffbdbf", "AQAAAAEAACcQAAAAELxoCsZJmSC+tbwT5FT4M7cQhQS1uTsI5+O71bgkB5trVpEcwV0SfZsttJub8Upv2g==" });

            migrationBuilder.AddForeignKey(
                name: "FK_GoodsDeliveryDetails_GoodsDeliveryNotes_GoodsDeliveryNoteId",
                table: "GoodsDeliveryDetails",
                column: "GoodsDeliveryNoteId",
                principalTable: "GoodsDeliveryNotes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GoodsDeliveryDetails_Products_ProductId",
                table: "GoodsDeliveryDetails",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GoodsDeliveryNotes_Orders_OrderId",
                table: "GoodsDeliveryNotes",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GoodsDeliveryNotes_AspNetUsers_UserId",
                table: "GoodsDeliveryNotes",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GoodsDeliveryDetails_GoodsDeliveryNotes_GoodsDeliveryNoteId",
                table: "GoodsDeliveryDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_GoodsDeliveryDetails_Products_ProductId",
                table: "GoodsDeliveryDetails");

            migrationBuilder.DropForeignKey(
                name: "FK_GoodsDeliveryNotes_Orders_OrderId",
                table: "GoodsDeliveryNotes");

            migrationBuilder.DropForeignKey(
                name: "FK_GoodsDeliveryNotes_AspNetUsers_UserId",
                table: "GoodsDeliveryNotes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GoodsDeliveryNotes",
                table: "GoodsDeliveryNotes");

            migrationBuilder.DropPrimaryKey(
                name: "PK_GoodsDeliveryDetails",
                table: "GoodsDeliveryDetails");

            migrationBuilder.RenameTable(
                name: "GoodsDeliveryNotes",
                newName: "GoodsDeliveryNote");

            migrationBuilder.RenameTable(
                name: "GoodsDeliveryDetails",
                newName: "GoodsDeliveryDetail");

            migrationBuilder.RenameIndex(
                name: "IX_GoodsDeliveryNotes_UserId",
                table: "GoodsDeliveryNote",
                newName: "IX_GoodsDeliveryNote_UserId");

            migrationBuilder.RenameIndex(
                name: "IX_GoodsDeliveryNotes_OrderId",
                table: "GoodsDeliveryNote",
                newName: "IX_GoodsDeliveryNote_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_GoodsDeliveryDetails_ProductId",
                table: "GoodsDeliveryDetail",
                newName: "IX_GoodsDeliveryDetail_ProductId");

            migrationBuilder.RenameIndex(
                name: "IX_GoodsDeliveryDetails_GoodsDeliveryNoteId",
                table: "GoodsDeliveryDetail",
                newName: "IX_GoodsDeliveryDetail_GoodsDeliveryNoteId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GoodsDeliveryNote",
                table: "GoodsDeliveryNote",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_GoodsDeliveryDetail",
                table: "GoodsDeliveryDetail",
                column: "Id");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "423e498c-fc67-4853-ac4f-f3cd91d32e87",
                column: "ConcurrencyStamp",
                value: "4ba0d223-aa35-41ff-a22e-7d92a9dfd144");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6665ddaa-72f9-4f90-a6b1-43eb68dea610",
                column: "ConcurrencyStamp",
                value: "512abb65-0bcf-4015-a097-117c4646be24");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6b30cb05-12f7-46c2-b95f-8d783c1f9eb1",
                column: "ConcurrencyStamp",
                value: "ba784644-216d-43b3-a47a-1c8ccae885f6");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "78c5228f-f600-4545-abcd-f4cc21d18e4c",
                column: "ConcurrencyStamp",
                value: "ee78a2f2-5ee7-486b-adfe-5311b8d9b20a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b979036b-d165-4bea-b6b6-16b22a3f54dd",
                column: "ConcurrencyStamp",
                value: "c25f3395-f7ea-4ef5-b578-aa4767ae4d6b");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c2d4b743-d9da-443c-9f5a-c2682750c805",
                column: "ConcurrencyStamp",
                value: "234b7c5b-27fe-40ae-b288-a663ed3e44f7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc2a0eb3-8736-441d-9130-5b421db3ac0e",
                column: "ConcurrencyStamp",
                value: "a6a5fdfa-42c6-4e79-9386-4e944c3f27f5");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "08b84a20-7e7d-4353-bb53-74c79732beed",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5201817c-ae26-45d5-8c69-e4f41408f90c", "AQAAAAEAACcQAAAAEMBI46keoMpPekCi+qShmnEQH71qG0jH3jX8XDWUbvdWSerlbiQT6wwZ4sCrauC+IQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "308da0db-e863-4814-8930-de3540e5406d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b35cb02d-862c-490b-b2ec-1348adc1058e", "AQAAAAEAACcQAAAAEPZVj53bracGzvrfqpa1EhxIfQKXH42OQ5tYWDtFoXVH9gtVurfjrEA/TfZUKtIS7A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39b465e2-c398-494f-bb62-d1eb02aa5471",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b8186844-5938-4881-a1d2-df2245c757e4", "AQAAAAEAACcQAAAAEBYfxwQEOcSNYblGxMSpXmHhCXL/eRLR/Oq6tBcrsKYcfWIr5bevuxk58YNcbCzmNw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a6a1f70-8f67-4f8a-b1f9-267e5d621edb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "da522c54-31e9-4b9b-bc24-9880d1b41146", "AQAAAAEAACcQAAAAEPbUtjgfxGk9EM3RRjb7ikOhbr6Gz5gdkbQwaOsnC5RQBwtLCH/kThXG7MHolYJ/lg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b488e0f-eb92-4994-a555-cbe4ecdf3672",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "088b3b24-e91b-435a-b931-e48988510cdf", "AQAAAAEAACcQAAAAEOG/XHzaRgrzDrPE//h0FPa/0EXLDyui/C62W+ostJqfcOlNBDsFKbIVX/1RhR6JMg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "52999f6b-a605-45b0-b98f-b8880fc46027",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b8df0cec-823a-46a0-9e4b-767f07a690bd", "AQAAAAEAACcQAAAAEOtaNbVVc5zUKZti7tKZUzWvFurcFumlaHLy/1T3T1SVst81YrWBjUG19QZn0vlUAg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57b2db13-1d08-48a4-adca-41d837bb8937",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ba8998f7-f77e-431c-9a23-b4402cde8a3b", "AQAAAAEAACcQAAAAEBKkVDFuljR8BKziKcwVi0wgEY9PbzxL94dZowINL5FpQsrvsO5PWsJgubAVUe7WTw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5ce20f05-c625-43fc-ae25-a7514e9520db",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "19adf92b-13c6-4f3d-a287-40b09439d755", "AQAAAAEAACcQAAAAELCja2Vq86nrcgzY1uoU3NRTwMsJ+/CKhqedFyg+Cd+b6RusHlkGAx2w8Spaj0KBBQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f8ce951-2f66-4a9e-a4fa-7a14f85b54c6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "29e586b6-3ad5-41fa-a03f-43ffeb344afa", "AQAAAAEAACcQAAAAEMBruoS49FaPn/Qu73pUWN0QdujU2ULemiqdy4eFYzkc20Q3TqF7rHaP0PNDpTxvcg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "927e4f6a-62ed-4e13-b002-7e133eb47bbc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "31b882a7-47a1-4de3-b508-91f5c861f7b8", "AQAAAAEAACcQAAAAEFycXWPdRIhn56AERhViOzums1F+M59ioG3VfQnQ0WqneoM0RgiLKnIJz3bub9LA+w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a0c9e67b-d593-4a56-93cd-063ec5d5d035",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1f44eeab-0d04-4816-920b-fbd5150291d4", "AQAAAAEAACcQAAAAEBGyqKt/eOd9ZpRlWgiCZqdTC+1sqsz5u2viH+5JKDaxW6NG4mqbb8B2gA3Ms8zKsg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b6256340-7bd0-4373-8549-c6a08053396b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "818cac7f-b252-4e79-834a-cb850ded2e95", "AQAAAAEAACcQAAAAEEkVfSa+qTOIeRK1EhW/wT1rRQiqxsRENw8jqtQRUjEUR5GI9OZtp+Botnr1Kh74Aw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ce4b2f5c-1fb9-4fe1-945c-20eca474ce16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ffdb5e70-19ac-401a-8e41-77921078525f", "AQAAAAEAACcQAAAAED6HxtSRy5Iop4lvsP6yJn4LxRGi99YpIT/g5QQ8sr1y95AfFALWsq1cuW0ROI9jRA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e7610feb-110c-47d0-9a88-1bfdc12742a4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "701a0f5e-1904-4c34-a17a-f186dd951f83", "AQAAAAEAACcQAAAAEERH+k68RXA2DqtLeKn6w3iNPX6ptjZje6lCcAAcQyJn1ZtrpVUmb3ZuWRQaczzZCQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9012ef1-cd3c-49a1-8726-7f8f8aba9f98",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7352c4a6-3881-4c73-a07b-92114fd366d3", "AQAAAAEAACcQAAAAEKanw/c2BIb+7alImlzhBfK3CqPgsKad1aALg6oWrVUMF6BuR1Wn0r1nusZoU0RCQA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd4fd02a-238d-4efc-a187-14d205a841f0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6d84c3e0-e661-4861-bd7e-6630308426e2", "AQAAAAEAACcQAAAAEFUR6d6auU5CivIfXtwERlA1WrSEIbOwCs8BPR7IitM2JBrKH6CBznGejKtJS1PlEQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd9a7449-e604-48c1-a638-c564e17c1bc0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "84c48df6-7358-4c74-a6ce-8557442fc520", "AQAAAAEAACcQAAAAEMBvqSPxBHtHPGNoBS+GZqy0uqZZ/Qqp4nn2Z/CPNYwISkTaV1sOR6GL0F/Mfsr6vA==" });

            migrationBuilder.AddForeignKey(
                name: "FK_GoodsDeliveryDetail_GoodsDeliveryNote_GoodsDeliveryNoteId",
                table: "GoodsDeliveryDetail",
                column: "GoodsDeliveryNoteId",
                principalTable: "GoodsDeliveryNote",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GoodsDeliveryDetail_Products_ProductId",
                table: "GoodsDeliveryDetail",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GoodsDeliveryNote_Orders_OrderId",
                table: "GoodsDeliveryNote",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_GoodsDeliveryNote_AspNetUsers_UserId",
                table: "GoodsDeliveryNote",
                column: "UserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
