using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace api.Migrations
{
    public partial class GoodsDeliveryAndGoodsDeliveryDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GoodsDeliveryNote",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedAt = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ExceptionReason = table.Column<string>(nullable: true),
                    OrderId = table.Column<int>(nullable: false),
                    UserId = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoodsDeliveryNote", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GoodsDeliveryNote_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GoodsDeliveryNote_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GoodsDeliveryDetail",
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
                    GoodsDeliveryNoteId = table.Column<int>(nullable: false),
                    Quantity = table.Column<double>(nullable: false),
                    QuantityReturned = table.Column<double>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoodsDeliveryDetail", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GoodsDeliveryDetail_GoodsDeliveryNote_GoodsDeliveryNoteId",
                        column: x => x.GoodsDeliveryNoteId,
                        principalTable: "GoodsDeliveryNote",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GoodsDeliveryDetail_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

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

            migrationBuilder.CreateIndex(
                name: "IX_GoodsDeliveryDetail_GoodsDeliveryNoteId",
                table: "GoodsDeliveryDetail",
                column: "GoodsDeliveryNoteId");

            migrationBuilder.CreateIndex(
                name: "IX_GoodsDeliveryDetail_ProductId",
                table: "GoodsDeliveryDetail",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_GoodsDeliveryNote_OrderId",
                table: "GoodsDeliveryNote",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_GoodsDeliveryNote_UserId",
                table: "GoodsDeliveryNote",
                column: "UserId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GoodsDeliveryDetail");

            migrationBuilder.DropTable(
                name: "GoodsDeliveryNote");

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
