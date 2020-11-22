using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace api.Migrations
{
    public partial class CreateTableMerchandiseReturnProposalAndMerChandiseDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "MerchandiseReturnProposals",
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
                    GoodsDeliveryNoteId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MerchandiseReturnProposals", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MerchandiseReturnProposals_GoodsDeliveryNotes_GoodsDeliveryNoteId",
                        column: x => x.GoodsDeliveryNoteId,
                        principalTable: "GoodsDeliveryNotes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MerchandiseReturnDetails",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedAt = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    Quantity = table.Column<int>(nullable: false),
                    QuantityReturned = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    MerchandiseReturnProposalId = table.Column<int>(nullable: false),
                    ProductId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MerchandiseReturnDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_MerchandiseReturnDetails_MerchandiseReturnProposals_MerchandiseReturnProposalId",
                        column: x => x.MerchandiseReturnProposalId,
                        principalTable: "MerchandiseReturnProposals",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MerchandiseReturnDetails_Products_ProductId",
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
                value: "228bac3a-9257-4ec3-bd74-fa1b3ead4128");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6665ddaa-72f9-4f90-a6b1-43eb68dea610",
                column: "ConcurrencyStamp",
                value: "b6827032-764c-48eb-8c41-0f1b04d735e5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6b30cb05-12f7-46c2-b95f-8d783c1f9eb1",
                column: "ConcurrencyStamp",
                value: "efc0825e-6f35-470c-9560-84b0ac0f7b0d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "78c5228f-f600-4545-abcd-f4cc21d18e4c",
                column: "ConcurrencyStamp",
                value: "895febff-3079-427f-9f66-b91feac9f72e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b979036b-d165-4bea-b6b6-16b22a3f54dd",
                column: "ConcurrencyStamp",
                value: "577f1a38-7cf8-4345-ab56-a56334b2888a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c2d4b743-d9da-443c-9f5a-c2682750c805",
                column: "ConcurrencyStamp",
                value: "c0ec81ad-96d2-493d-b238-e83eb7150a42");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc2a0eb3-8736-441d-9130-5b421db3ac0e",
                column: "ConcurrencyStamp",
                value: "42620f17-af5b-4511-bb22-b205224f5a68");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "08b84a20-7e7d-4353-bb53-74c79732beed",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1a6232da-bde9-4a5b-9c4c-e34ec92732ee", "AQAAAAEAACcQAAAAEEijQYYcss1hG5MXdW+ZlnCAvvesMpzPSPOQziwxiQZhXfNajM1loX4nc+0nEIU1+w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "308da0db-e863-4814-8930-de3540e5406d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "10adb25b-10a0-4d97-aaa1-30c8efd2781e", "AQAAAAEAACcQAAAAEPwLEEYPbrc9Ycfy2yHeqKEOTEwKpihVfVt3YeLHD7GcXCnXCrcUn1amSqN/1m6k1A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39b465e2-c398-494f-bb62-d1eb02aa5471",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "29c751f2-f23e-4f91-a140-568c71559958", "AQAAAAEAACcQAAAAEDi905kyiZnE8wbcSOUAu87j2BYsLaUZ79Bauy+fwf4drxl12o+oR6LZslHbIXT4mA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a6a1f70-8f67-4f8a-b1f9-267e5d621edb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0c73922d-2693-4e3f-a25d-5341371349bb", "AQAAAAEAACcQAAAAEMgI8xR1N67sh6EFfDxAx4vX+/XIMjPKUdHOI31mOseWJBf6LWX3J4mlV2l05MzMUQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b488e0f-eb92-4994-a555-cbe4ecdf3672",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cbafcb10-934f-47db-bf2c-6a519841281d", "AQAAAAEAACcQAAAAEDcWnt1YVefRwPZL/m4qh9Jx7+GiEd+UXsHB0VgH7/Qz7Q/tMA9NyAn31xsBR7QP8A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "52999f6b-a605-45b0-b98f-b8880fc46027",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "eed382c0-adb1-49d2-a7bb-77f3bcfe6a12", "AQAAAAEAACcQAAAAENb6qljuvqH6w4EA8rkKM+oPehGjlaxMUe778l2d40eXE7C2/FmNAc8D3wH5TxJFDQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57b2db13-1d08-48a4-adca-41d837bb8937",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3c6a53fe-9110-46c6-873a-3e72ec480e1e", "AQAAAAEAACcQAAAAEF/XJG9rikYSSI54Tqz+e/ETYblBop7lYCgnHGZEryYPf2IXtwx9ytnCuQlRqTVmEQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5ce20f05-c625-43fc-ae25-a7514e9520db",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "02ec30ef-4b20-47b8-af88-031a358902c5", "AQAAAAEAACcQAAAAEFOidTYZ6gw2qO/84dHobMQ3+4sxZXnk+YmCItshkSGfF1vJC9g1RwnhQ/I3MmSP+A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f8ce951-2f66-4a9e-a4fa-7a14f85b54c6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "83effe20-7df3-4763-a45b-035c199636ff", "AQAAAAEAACcQAAAAEPbsKGnVuiGeThaqiB7f0iK3qCmU3X/yOLAZQ0EEjk0N536EYU9pN4eTwE/tSSNZsA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "927e4f6a-62ed-4e13-b002-7e133eb47bbc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9723223b-1efa-46f6-91cf-426894e247c7", "AQAAAAEAACcQAAAAEKOqxcMXIOFlHhCw5BquTMCCsqH9TGAO/NXUWcoin8L0ODSaunW8DgyWyyg7ko273w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a0c9e67b-d593-4a56-93cd-063ec5d5d035",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4cdc4f72-e07e-46d3-bfa6-715790e8f6d6", "AQAAAAEAACcQAAAAENCat4S/4cXxmbTnfTfNOY9eSSJe77mFBjDj80ibE6l7Olj0iOuC120TjNcVTND/0w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b6256340-7bd0-4373-8549-c6a08053396b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1ee198b2-0bab-43aa-bc90-5306d936c689", "AQAAAAEAACcQAAAAEE7hoiOu6DKi4yw9DhCsTQvE/zT56NpydAhiYc91kP797k3xmJNKuvpsyQp5SACBEQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ce4b2f5c-1fb9-4fe1-945c-20eca474ce16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "38355fb5-3378-4c46-8cce-34a1591ba894", "AQAAAAEAACcQAAAAEF0Oxg0CQY01Vp4owxemWUsqEQ3oiyAktVnAtZ+VBFiWxdMRE4KCqHlC9/6PACjvIA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e7610feb-110c-47d0-9a88-1bfdc12742a4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "69bbe3cb-0932-4e8d-9c5c-cbcb92f34b7b", "AQAAAAEAACcQAAAAEIZRztCt33HwY431v1PCeWyQu38AtBXltn5+VWyUw4WsfB9Wc1X7Rlr4nMd3dW35Zw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9012ef1-cd3c-49a1-8726-7f8f8aba9f98",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "16c05e2a-4a94-47de-8e69-6675bbdf634e", "AQAAAAEAACcQAAAAEJ5ZQh4hn+Ug8y4ZuUsQAjUxfYEIGX/mwJ9xC4H3i5VqXBi5zAAkjP/fTVMNbwam0g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd4fd02a-238d-4efc-a187-14d205a841f0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b11d599c-ff3c-4a88-80bf-05127f6e283a", "AQAAAAEAACcQAAAAEFdjb3fLLeegkZ7AiHt2j2W1ywH4Qgg1itH8U0WOoNcaIMH+kRrK5QmbWRi9wZ3I0A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd9a7449-e604-48c1-a638-c564e17c1bc0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7e9ce7f0-ef26-41cf-b5d2-cc54d3e37995", "AQAAAAEAACcQAAAAELJhc/yTAgL6+Qzbc/y5WP2gQvwA+uqOCearrSSyRmUIMsrIZ5CVDow3C6mzU53wmA==" });

            migrationBuilder.CreateIndex(
                name: "IX_MerchandiseReturnDetails_MerchandiseReturnProposalId",
                table: "MerchandiseReturnDetails",
                column: "MerchandiseReturnProposalId");

            migrationBuilder.CreateIndex(
                name: "IX_MerchandiseReturnDetails_ProductId",
                table: "MerchandiseReturnDetails",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_MerchandiseReturnProposals_GoodsDeliveryNoteId",
                table: "MerchandiseReturnProposals",
                column: "GoodsDeliveryNoteId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MerchandiseReturnDetails");

            migrationBuilder.DropTable(
                name: "MerchandiseReturnProposals");

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
    }
}
