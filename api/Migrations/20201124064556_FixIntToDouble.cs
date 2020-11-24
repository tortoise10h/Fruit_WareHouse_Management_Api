using Microsoft.EntityFrameworkCore.Migrations;

namespace api.Migrations
{
    public partial class FixIntToDouble : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "QuantityReturned",
                table: "MerchandiseReturnDetails",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "Quantity",
                table: "MerchandiseReturnDetails",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

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
                keyValue: "08b84a20-7e7d-4353-bb53-74c79732beed",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0c1d0e2b-3e80-4dcc-8ab4-43eaba5698df", "AQAAAAEAACcQAAAAECfluSDlGgflEEoDcUNBMNXd00PDAXjwFVTQgm8YlI0HVymoOc/EuWp/Qq/N44/MXA==" });

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
                keyValue: "6f8ce951-2f66-4a9e-a4fa-7a14f85b54c6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "93ccde98-c834-4c4b-bac6-6dc5922c7188", "AQAAAAEAACcQAAAAEKCpE6YBIRG5n9cp7tFpBR0PxZGgm7E/sEG3ovM8HvGBllikj0MUeEh3rBSfLoVgFg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "927e4f6a-62ed-4e13-b002-7e133eb47bbc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6a51c4ed-25fe-4a7f-ab2c-006c2b7c3fbe", "AQAAAAEAACcQAAAAEKv+OYzEqF51mzeOVb7uuU8wgbvChpH4Ai16J8jGzP9/adVjUIVUQPfr09XNYydSOA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a0c9e67b-d593-4a56-93cd-063ec5d5d035",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "8a488cbd-f60a-4a9f-8eb1-92dafa93ad8c", "AQAAAAEAACcQAAAAEHJevxLr6nCHRKbO85KVA/3dm4b7Bc4xCjbKEzjkE9UFAsP13guWFmrpoXk41Yclvg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b6256340-7bd0-4373-8549-c6a08053396b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6b97996b-c394-4aba-9c8b-48a542ec2c37", "AQAAAAEAACcQAAAAEGJjE3lSH4MAW7ld9hBqLAXz9puJHlmbtaeiCQIWTPDfir5iHgpfeic1K3ArOckc8A==" });

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
                keyValue: "fd4fd02a-238d-4efc-a187-14d205a841f0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ffd788b8-1041-4ddf-a281-f867616d95af", "AQAAAAEAACcQAAAAECQs5YGFjm++IgD/emT+fmSuCZgx0RutvKOt8ti944GXbG447EKTuGGRCOHCKJzEag==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd9a7449-e604-48c1-a638-c564e17c1bc0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "35320859-610d-433b-b0d6-26a7848b3e3f", "AQAAAAEAACcQAAAAENp+TvRuu2Fqb1l7mWrFXny1VUCPFSR69RYT2zNF9Wmxpj4am3wGDGfIJ9pl6ODPjQ==" });

            migrationBuilder.CreateIndex(
                name: "IX_GoodsReceivingOfReturns_MerchandiseReturnProposalId",
                table: "GoodsReceivingOfReturns",
                column: "MerchandiseReturnProposalId");

            migrationBuilder.AddForeignKey(
                name: "FK_GoodsReceivingOfReturns_MerchandiseReturnProposals_MerchandiseReturnProposalId",
                table: "GoodsReceivingOfReturns",
                column: "MerchandiseReturnProposalId",
                principalTable: "MerchandiseReturnProposals",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_GoodsReceivingOfReturns_MerchandiseReturnProposals_MerchandiseReturnProposalId",
                table: "GoodsReceivingOfReturns");

            migrationBuilder.DropIndex(
                name: "IX_GoodsReceivingOfReturns_MerchandiseReturnProposalId",
                table: "GoodsReceivingOfReturns");

            migrationBuilder.AlterColumn<int>(
                name: "QuantityReturned",
                table: "MerchandiseReturnDetails",
                type: "int",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<int>(
                name: "Quantity",
                table: "MerchandiseReturnDetails",
                type: "int",
                nullable: false,
                oldClrType: typeof(double));

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ec4dc9a8-bb6f-402e-bb74-b3fc5822ced6", "AQAAAAEAACcQAAAAEMdvov6zK7qVoTDThk8+MkSWlhjmXUO5HEgH4ILYZlPBBG7z6bmG/4kpFrt7KFtxpg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "308da0db-e863-4814-8930-de3540e5406d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0d97aaef-4a5c-4580-9ab1-76aae7e68c19", "AQAAAAEAACcQAAAAEGuf/QdrB7d2Bq9u9IgZyADy/U8FA5fS3+RE0ESWmHQAnnWl7aRdA9ytb3Ha31tB3w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39b465e2-c398-494f-bb62-d1eb02aa5471",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "18d34199-7eff-4229-95c0-7fc27ec2a11c", "AQAAAAEAACcQAAAAEHFD7hKfuF/Mi00Dad+RMv2ANc+OXdlX6Mn9BSx2E0ebRk+KEzgLcaBUhIRukSat8g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a6a1f70-8f67-4f8a-b1f9-267e5d621edb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b8273ef1-d52b-45ac-93ac-5331b81b702e", "AQAAAAEAACcQAAAAEOIDEjsw6vnOo4nxp41NpGAyx0lrTTViC0We10tiC9LmohhFjvEFLy59Xh11PWobyQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b488e0f-eb92-4994-a555-cbe4ecdf3672",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "61d1a31b-3617-4510-b431-274327b233cd", "AQAAAAEAACcQAAAAEJ3Xy2+KXDr2fdbg+xGp0FTmkTQWcNP6CPdHIveu4maiohwcqRN5GYvrnpawbL1nig==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "52999f6b-a605-45b0-b98f-b8880fc46027",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7fecf561-b30a-49b9-903e-71adf87e960b", "AQAAAAEAACcQAAAAEFcxKFVs9pzd2kY87TjQrPDOMxk7wulsNSOWYHc8zpJze3MAsmbbN8SrRf9x6rqMJg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57b2db13-1d08-48a4-adca-41d837bb8937",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3dc4d6d7-8782-403c-a50e-6382e6cb3ef4", "AQAAAAEAACcQAAAAELDhEOxA7hWeaPkh269A4iNLruDMDiWb0ZdJ8p64ahEDJAeRjTBYEZqSvyxZ3EbXMQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5ce20f05-c625-43fc-ae25-a7514e9520db",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2a40bf9f-a29b-4e29-b6cb-90200561fd55", "AQAAAAEAACcQAAAAEKDtmYiele+E1UVSP4XCy4xtS+MsACoFUMRzvRDBb5V1NX0pTqgXrRCTzml8lS7pMA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f8ce951-2f66-4a9e-a4fa-7a14f85b54c6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d124850f-ea07-48d9-b52a-e311ac533868", "AQAAAAEAACcQAAAAEBrK9uvo8GAfMFjOF5Tq3gWd2nte724fpzmmDr/JAQI6t+mDrhs30nu/cYDlElAp2g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "927e4f6a-62ed-4e13-b002-7e133eb47bbc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a7a40740-b0b7-44c5-9045-ac501293eec3", "AQAAAAEAACcQAAAAEK64jyIYQufQiIy3kIoZwyW2iaN708RwuVjjEA6az5NAX8Ltph/HHTnhi80vYkQWEQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a0c9e67b-d593-4a56-93cd-063ec5d5d035",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d4d2f9c3-e2e6-4ba6-92fd-9f2ffa118cda", "AQAAAAEAACcQAAAAEDUNlnfpiTlmrS6ibVORGjoHX1HCJG11+02ffGcukLPTfDtRV8ov1FtuH92xH6e8EA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b6256340-7bd0-4373-8549-c6a08053396b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "af8b42f7-f7e9-4955-a3b9-ba02f468208b", "AQAAAAEAACcQAAAAEOPDaE8Uq1aTWt3GwgQJKSohPyOcpd1thAnOo/6Y30tk0mENmLERMjisFNdTF1s04Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ce4b2f5c-1fb9-4fe1-945c-20eca474ce16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "23d54677-ccee-47c2-93d3-549e3989fe5d", "AQAAAAEAACcQAAAAEL8nXmfeqQz9oAQiyWnYVFj6ujVjToU7AkUaIC9z9ReQhY07cCpMZtB9QAQEXqGeKg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e7610feb-110c-47d0-9a88-1bfdc12742a4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d5523440-d0ff-401f-a674-9e50884ad3dc", "AQAAAAEAACcQAAAAEJxQx0O2Xy5VSeaAxZNqq6SfwOqXEHjk2CbbZDX9CJh3XQ0fd3qAmuK+XSmULUp+Pw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9012ef1-cd3c-49a1-8726-7f8f8aba9f98",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "d1ef33eb-e611-4b40-baee-e4dd41b1bad2", "AQAAAAEAACcQAAAAENwcaUCjN7gCV3SjbBn8x6L9kuJmY92qRW8AZyRH2OjwJK5LC3QymS7eWA7YZJcZQw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd4fd02a-238d-4efc-a187-14d205a841f0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9ae9784d-82e2-49a6-8c8c-a3411f2ff6df", "AQAAAAEAACcQAAAAEJD0c4Yn5t5MJPVb+GOBa3mvSwl0Du2pLztTgTbUDI4PXDxssn/0ptNmPpmakmoNXw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd9a7449-e604-48c1-a638-c564e17c1bc0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "077ab957-18ee-47fe-a3c7-8c978a85ba3e", "AQAAAAEAACcQAAAAED5Zv+oCEjkkvCM3Dtw9ac82XiHQ4Ve3SWTsnTxS/++mJzT3yPC17bMR3vmCxd0asw==" });
        }
    }
}
