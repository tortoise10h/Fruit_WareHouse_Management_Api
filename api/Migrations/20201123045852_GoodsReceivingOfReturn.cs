using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace api.Migrations
{
    public partial class GoodsReceivingOfReturn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "GoodsReceivingOfReturns",
                columns: table => new
                {
                    Id = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CreatedAt = table.Column<DateTime>(nullable: false),
                    CreatedBy = table.Column<string>(nullable: true),
                    LastModifiedAt = table.Column<DateTime>(nullable: false),
                    LastModifiedBy = table.Column<string>(nullable: true),
                    IsDeleted = table.Column<bool>(nullable: false),
                    MerchandiseReturnProposalId = table.Column<int>(nullable: false),
                    Status = table.Column<int>(nullable: false),
                    Description = table.Column<string>(nullable: true),
                    ExceptionReason = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoodsReceivingOfReturns", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "GoodsReceivingOfReturnDetails",
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
                    GoodsReceivingOfReturnId = table.Column<int>(nullable: false),
                    Quantity = table.Column<double>(nullable: false),
                    Description = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoodsReceivingOfReturnDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_GoodsReceivingOfReturnDetails_GoodsReceivingOfReturns_GoodsReceivingOfReturnId",
                        column: x => x.GoodsReceivingOfReturnId,
                        principalTable: "GoodsReceivingOfReturns",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_GoodsReceivingOfReturnDetails_Products_ProductId",
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
                value: "1aedcf32-de17-489a-9906-0f71b26ee0bf");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6665ddaa-72f9-4f90-a6b1-43eb68dea610",
                column: "ConcurrencyStamp",
                value: "bfebc074-d69c-45a3-bd87-f01839d82a8e");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6b30cb05-12f7-46c2-b95f-8d783c1f9eb1",
                column: "ConcurrencyStamp",
                value: "75fc5514-638b-44b0-b7d9-3888d686f626");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "78c5228f-f600-4545-abcd-f4cc21d18e4c",
                column: "ConcurrencyStamp",
                value: "5fb40ae3-ab36-4579-9199-309d605956ec");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b979036b-d165-4bea-b6b6-16b22a3f54dd",
                column: "ConcurrencyStamp",
                value: "cbd39b94-4775-463a-a9cb-9a2ef981608a");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c2d4b743-d9da-443c-9f5a-c2682750c805",
                column: "ConcurrencyStamp",
                value: "976d5d0f-c8f8-4241-a5db-b595fbdc3b17");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc2a0eb3-8736-441d-9130-5b421db3ac0e",
                column: "ConcurrencyStamp",
                value: "556c67ef-e0f1-4afb-9986-36ae4de772d2");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "08b84a20-7e7d-4353-bb53-74c79732beed",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "PhoneNumber" },
                values: new object[] { "ec4dc9a8-bb6f-402e-bb74-b3fc5822ced6", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAEAACcQAAAAEMdvov6zK7qVoTDThk8+MkSWlhjmXUO5HEgH4ILYZlPBBG7z6bmG/4kpFrt7KFtxpg==", "0901234566" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "308da0db-e863-4814-8930-de3540e5406d",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "PhoneNumber" },
                values: new object[] { "0d97aaef-4a5c-4580-9ab1-76aae7e68c19", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAEAACcQAAAAEGuf/QdrB7d2Bq9u9IgZyADy/U8FA5fS3+RE0ESWmHQAnnWl7aRdA9ytb3Ha31tB3w==", "0901234576" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39b465e2-c398-494f-bb62-d1eb02aa5471",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "PhoneNumber" },
                values: new object[] { "18d34199-7eff-4229-95c0-7fc27ec2a11c", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAEAACcQAAAAEHFD7hKfuF/Mi00Dad+RMv2ANc+OXdlX6Mn9BSx2E0ebRk+KEzgLcaBUhIRukSat8g==", "0901234568" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a6a1f70-8f67-4f8a-b1f9-267e5d621edb",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "PhoneNumber" },
                values: new object[] { "b8273ef1-d52b-45ac-93ac-5331b81b702e", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAEAACcQAAAAEOIDEjsw6vnOo4nxp41NpGAyx0lrTTViC0We10tiC9LmohhFjvEFLy59Xh11PWobyQ==", "0901234561" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b488e0f-eb92-4994-a555-cbe4ecdf3672",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "PhoneNumber" },
                values: new object[] { "61d1a31b-3617-4510-b431-274327b233cd", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAEAACcQAAAAEJ3Xy2+KXDr2fdbg+xGp0FTmkTQWcNP6CPdHIveu4maiohwcqRN5GYvrnpawbL1nig==", "0901234570" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "52999f6b-a605-45b0-b98f-b8880fc46027",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "PhoneNumber" },
                values: new object[] { "7fecf561-b30a-49b9-903e-71adf87e960b", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAEAACcQAAAAEFcxKFVs9pzd2kY87TjQrPDOMxk7wulsNSOWYHc8zpJze3MAsmbbN8SrRf9x6rqMJg==", "0901234571" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57b2db13-1d08-48a4-adca-41d837bb8937",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "PhoneNumber" },
                values: new object[] { "3dc4d6d7-8782-403c-a50e-6382e6cb3ef4", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAEAACcQAAAAELDhEOxA7hWeaPkh269A4iNLruDMDiWb0ZdJ8p64ahEDJAeRjTBYEZqSvyxZ3EbXMQ==", "0901234572" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5ce20f05-c625-43fc-ae25-a7514e9520db",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "PhoneNumber" },
                values: new object[] { "2a40bf9f-a29b-4e29-b6cb-90200561fd55", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAEAACcQAAAAEKDtmYiele+E1UVSP4XCy4xtS+MsACoFUMRzvRDBb5V1NX0pTqgXrRCTzml8lS7pMA==", "0901234578" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f8ce951-2f66-4a9e-a4fa-7a14f85b54c6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "PhoneNumber" },
                values: new object[] { "d124850f-ea07-48d9-b52a-e311ac533868", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAEAACcQAAAAEBrK9uvo8GAfMFjOF5Tq3gWd2nte724fpzmmDr/JAQI6t+mDrhs30nu/cYDlElAp2g==", "0901234584" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "927e4f6a-62ed-4e13-b002-7e133eb47bbc",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "PhoneNumber" },
                values: new object[] { "a7a40740-b0b7-44c5-9045-ac501293eec3", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAEAACcQAAAAEK64jyIYQufQiIy3kIoZwyW2iaN708RwuVjjEA6az5NAX8Ltph/HHTnhi80vYkQWEQ==", "0901234573" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a0c9e67b-d593-4a56-93cd-063ec5d5d035",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "PhoneNumber" },
                values: new object[] { "d4d2f9c3-e2e6-4ba6-92fd-9f2ffa118cda", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAEAACcQAAAAEDUNlnfpiTlmrS6ibVORGjoHX1HCJG11+02ffGcukLPTfDtRV8ov1FtuH92xH6e8EA==", "0901234582" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b6256340-7bd0-4373-8549-c6a08053396b",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "PhoneNumber" },
                values: new object[] { "af8b42f7-f7e9-4955-a3b9-ba02f468208b", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAEAACcQAAAAEOPDaE8Uq1aTWt3GwgQJKSohPyOcpd1thAnOo/6Y30tk0mENmLERMjisFNdTF1s04Q==", "0901234585" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ce4b2f5c-1fb9-4fe1-945c-20eca474ce16",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "PhoneNumber" },
                values: new object[] { "23d54677-ccee-47c2-93d3-549e3989fe5d", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAEAACcQAAAAEL8nXmfeqQz9oAQiyWnYVFj6ujVjToU7AkUaIC9z9ReQhY07cCpMZtB9QAQEXqGeKg==", "0901234583" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e7610feb-110c-47d0-9a88-1bfdc12742a4",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "PhoneNumber" },
                values: new object[] { "d5523440-d0ff-401f-a674-9e50884ad3dc", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAEAACcQAAAAEJxQx0O2Xy5VSeaAxZNqq6SfwOqXEHjk2CbbZDX9CJh3XQ0fd3qAmuK+XSmULUp+Pw==", "0901234581" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9012ef1-cd3c-49a1-8726-7f8f8aba9f98",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "PhoneNumber" },
                values: new object[] { "d1ef33eb-e611-4b40-baee-e4dd41b1bad2", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAEAACcQAAAAENwcaUCjN7gCV3SjbBn8x6L9kuJmY92qRW8AZyRH2OjwJK5LC3QymS7eWA7YZJcZQw==", "0901234586" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd4fd02a-238d-4efc-a187-14d205a841f0",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "PhoneNumber" },
                values: new object[] { "9ae9784d-82e2-49a6-8c8c-a3411f2ff6df", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAEAACcQAAAAEJD0c4Yn5t5MJPVb+GOBa3mvSwl0Du2pLztTgTbUDI4PXDxssn/0ptNmPpmakmoNXw==", "0901234580" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd9a7449-e604-48c1-a638-c564e17c1bc0",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "PhoneNumber" },
                values: new object[] { "077ab957-18ee-47fe-a3c7-8c978a85ba3e", new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAEAACcQAAAAED5Zv+oCEjkkvCM3Dtw9ac82XiHQ4Ve3SWTsnTxS/++mJzT3yPC17bMR3vmCxd0asw==", "0901234564" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(2020, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateIndex(
                name: "IX_GoodsReceivingOfReturnDetails_GoodsReceivingOfReturnId",
                table: "GoodsReceivingOfReturnDetails",
                column: "GoodsReceivingOfReturnId");

            migrationBuilder.CreateIndex(
                name: "IX_GoodsReceivingOfReturnDetails_ProductId",
                table: "GoodsReceivingOfReturnDetails",
                column: "ProductId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "GoodsReceivingOfReturnDetails");

            migrationBuilder.DropTable(
                name: "GoodsReceivingOfReturns");

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
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "PhoneNumber" },
                values: new object[] { "1a6232da-bde9-4a5b-9c4c-e34ec92732ee", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAEAACcQAAAAEEijQYYcss1hG5MXdW+ZlnCAvvesMpzPSPOQziwxiQZhXfNajM1loX4nc+0nEIU1+w==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "308da0db-e863-4814-8930-de3540e5406d",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "PhoneNumber" },
                values: new object[] { "10adb25b-10a0-4d97-aaa1-30c8efd2781e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAEAACcQAAAAEPwLEEYPbrc9Ycfy2yHeqKEOTEwKpihVfVt3YeLHD7GcXCnXCrcUn1amSqN/1m6k1A==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39b465e2-c398-494f-bb62-d1eb02aa5471",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "PhoneNumber" },
                values: new object[] { "29c751f2-f23e-4f91-a140-568c71559958", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAEAACcQAAAAEDi905kyiZnE8wbcSOUAu87j2BYsLaUZ79Bauy+fwf4drxl12o+oR6LZslHbIXT4mA==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a6a1f70-8f67-4f8a-b1f9-267e5d621edb",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "PhoneNumber" },
                values: new object[] { "0c73922d-2693-4e3f-a25d-5341371349bb", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAEAACcQAAAAEMgI8xR1N67sh6EFfDxAx4vX+/XIMjPKUdHOI31mOseWJBf6LWX3J4mlV2l05MzMUQ==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b488e0f-eb92-4994-a555-cbe4ecdf3672",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "PhoneNumber" },
                values: new object[] { "cbafcb10-934f-47db-bf2c-6a519841281d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAEAACcQAAAAEDcWnt1YVefRwPZL/m4qh9Jx7+GiEd+UXsHB0VgH7/Qz7Q/tMA9NyAn31xsBR7QP8A==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "52999f6b-a605-45b0-b98f-b8880fc46027",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "PhoneNumber" },
                values: new object[] { "eed382c0-adb1-49d2-a7bb-77f3bcfe6a12", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAEAACcQAAAAENb6qljuvqH6w4EA8rkKM+oPehGjlaxMUe778l2d40eXE7C2/FmNAc8D3wH5TxJFDQ==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57b2db13-1d08-48a4-adca-41d837bb8937",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "PhoneNumber" },
                values: new object[] { "3c6a53fe-9110-46c6-873a-3e72ec480e1e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAEAACcQAAAAEF/XJG9rikYSSI54Tqz+e/ETYblBop7lYCgnHGZEryYPf2IXtwx9ytnCuQlRqTVmEQ==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5ce20f05-c625-43fc-ae25-a7514e9520db",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "PhoneNumber" },
                values: new object[] { "02ec30ef-4b20-47b8-af88-031a358902c5", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAEAACcQAAAAEFOidTYZ6gw2qO/84dHobMQ3+4sxZXnk+YmCItshkSGfF1vJC9g1RwnhQ/I3MmSP+A==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f8ce951-2f66-4a9e-a4fa-7a14f85b54c6",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "PhoneNumber" },
                values: new object[] { "83effe20-7df3-4763-a45b-035c199636ff", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAEAACcQAAAAEPbsKGnVuiGeThaqiB7f0iK3qCmU3X/yOLAZQ0EEjk0N536EYU9pN4eTwE/tSSNZsA==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "927e4f6a-62ed-4e13-b002-7e133eb47bbc",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "PhoneNumber" },
                values: new object[] { "9723223b-1efa-46f6-91cf-426894e247c7", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAEAACcQAAAAEKOqxcMXIOFlHhCw5BquTMCCsqH9TGAO/NXUWcoin8L0ODSaunW8DgyWyyg7ko273w==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a0c9e67b-d593-4a56-93cd-063ec5d5d035",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "PhoneNumber" },
                values: new object[] { "4cdc4f72-e07e-46d3-bfa6-715790e8f6d6", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAEAACcQAAAAENCat4S/4cXxmbTnfTfNOY9eSSJe77mFBjDj80ibE6l7Olj0iOuC120TjNcVTND/0w==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b6256340-7bd0-4373-8549-c6a08053396b",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "PhoneNumber" },
                values: new object[] { "1ee198b2-0bab-43aa-bc90-5306d936c689", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAEAACcQAAAAEE7hoiOu6DKi4yw9DhCsTQvE/zT56NpydAhiYc91kP797k3xmJNKuvpsyQp5SACBEQ==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ce4b2f5c-1fb9-4fe1-945c-20eca474ce16",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "PhoneNumber" },
                values: new object[] { "38355fb5-3378-4c46-8cce-34a1591ba894", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAEAACcQAAAAEF0Oxg0CQY01Vp4owxemWUsqEQ3oiyAktVnAtZ+VBFiWxdMRE4KCqHlC9/6PACjvIA==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e7610feb-110c-47d0-9a88-1bfdc12742a4",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "PhoneNumber" },
                values: new object[] { "69bbe3cb-0932-4e8d-9c5c-cbcb92f34b7b", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAEAACcQAAAAEIZRztCt33HwY431v1PCeWyQu38AtBXltn5+VWyUw4WsfB9Wc1X7Rlr4nMd3dW35Zw==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9012ef1-cd3c-49a1-8726-7f8f8aba9f98",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "PhoneNumber" },
                values: new object[] { "16c05e2a-4a94-47de-8e69-6675bbdf634e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAEAACcQAAAAEJ5ZQh4hn+Ug8y4ZuUsQAjUxfYEIGX/mwJ9xC4H3i5VqXBi5zAAkjP/fTVMNbwam0g==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd4fd02a-238d-4efc-a187-14d205a841f0",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "PhoneNumber" },
                values: new object[] { "b11d599c-ff3c-4a88-80bf-05127f6e283a", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAEAACcQAAAAEFdjb3fLLeegkZ7AiHt2j2W1ywH4Qgg1itH8U0WOoNcaIMH+kRrK5QmbWRi9wZ3I0A==", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd9a7449-e604-48c1-a638-c564e17c1bc0",
                columns: new[] { "ConcurrencyStamp", "CreatedAt", "PasswordHash", "PhoneNumber" },
                values: new object[] { "7e9ce7f0-ef26-41cf-b5d2-cc54d3e37995", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "AQAAAAEAACcQAAAAELJhc/yTAgL6+Qzbc/y5WP2gQvwA+uqOCearrSSyRmUIMsrIZ5CVDow3C6mzU53wmA==", null });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                column: "CreatedAt",
                value: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));
        }
    }
}
