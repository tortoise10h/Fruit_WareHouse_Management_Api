using Microsoft.EntityFrameworkCore.Migrations;

namespace api.Migrations
{
    public partial class AddSomeEssentilQuantityFieldForProductAndFixQuantityToDouble : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "13b00890-d1f9-45b0-a2db-79c8e58f927f", "d0cdb3a2-0198-422e-8386-2f832f0a0670" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "18f6f8d1-93fd-4f05-9ecb-6e807dda4115", "3e3b009c-799c-4a4c-86a5-d90daf8563ce" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "1df6771c-1fb8-4bbe-bfc3-92f703859b90", "3e3b009c-799c-4a4c-86a5-d90daf8563ce" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "387216d3-d69c-4802-be9a-f876ae42f5df", "32e3b759-f48e-403a-9b16-a7050fadcbc8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "405bfeac-8e9a-4037-9706-0ede0504ee6b", "3e3b009c-799c-4a4c-86a5-d90daf8563ce" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "5b250552-61d2-45e2-902b-70cdf6b58e7a", "32e3b759-f48e-403a-9b16-a7050fadcbc8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "7780aea3-27e8-4a8c-a633-48cb266126df", "08458f61-e622-4753-aca8-cf0a87608a19" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "8d0a4d6d-2ecc-4f0d-a5c6-d9ab6198a861", "d21ec932-48b1-45ff-a4ae-f282b6fecaeb" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "947b2125-a09e-4122-b0b2-19d154019a61", "68fc8a61-7c39-4dd9-9b71-69e7b3828deb" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "97a944c9-6591-41d8-b0c5-231ba340e323", "68fc8a61-7c39-4dd9-9b71-69e7b3828deb" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "996cb637-0c0d-4449-b20a-f845e967968f", "3e3b009c-799c-4a4c-86a5-d90daf8563ce" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "aab88e65-ea84-41d1-8c29-66a269795ee5", "3e3b009c-799c-4a4c-86a5-d90daf8563ce" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "b2b480b1-49df-4b5a-a077-b85f3c400d13", "287041ab-c9cb-4f96-ae2f-b5fd44349683" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "c95c6655-ca3f-4971-ad8f-74b43918f4f4", "287041ab-c9cb-4f96-ae2f-b5fd44349683" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "d66d3245-a3cd-489c-9d3e-e515a4a25f67", "32e3b759-f48e-403a-9b16-a7050fadcbc8" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "e28aba9e-fe53-460e-bb34-c2027eb5004d", "08458f61-e622-4753-aca8-cf0a87608a19" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "e4348093-1864-44c5-90fa-32a35a2073ec", "287041ab-c9cb-4f96-ae2f-b5fd44349683" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "08458f61-e622-4753-aca8-cf0a87608a19");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "287041ab-c9cb-4f96-ae2f-b5fd44349683");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32e3b759-f48e-403a-9b16-a7050fadcbc8");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3e3b009c-799c-4a4c-86a5-d90daf8563ce");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "68fc8a61-7c39-4dd9-9b71-69e7b3828deb");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d0cdb3a2-0198-422e-8386-2f832f0a0670");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d21ec932-48b1-45ff-a4ae-f282b6fecaeb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "13b00890-d1f9-45b0-a2db-79c8e58f927f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "18f6f8d1-93fd-4f05-9ecb-6e807dda4115");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1df6771c-1fb8-4bbe-bfc3-92f703859b90");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "387216d3-d69c-4802-be9a-f876ae42f5df");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "405bfeac-8e9a-4037-9706-0ede0504ee6b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5b250552-61d2-45e2-902b-70cdf6b58e7a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7780aea3-27e8-4a8c-a633-48cb266126df");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8d0a4d6d-2ecc-4f0d-a5c6-d9ab6198a861");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "947b2125-a09e-4122-b0b2-19d154019a61");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "97a944c9-6591-41d8-b0c5-231ba340e323");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "996cb637-0c0d-4449-b20a-f845e967968f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "aab88e65-ea84-41d1-8c29-66a269795ee5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b2b480b1-49df-4b5a-a077-b85f3c400d13");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c95c6655-ca3f-4971-ad8f-74b43918f4f4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d66d3245-a3cd-489c-9d3e-e515a4a25f67");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e28aba9e-fe53-460e-bb34-c2027eb5004d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e4348093-1864-44c5-90fa-32a35a2073ec");

            migrationBuilder.AlterColumn<double>(
                name: "Quantity",
                table: "PurchaseProposalDetails",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<double>(
                name: "QuantityPurchased",
                table: "PurchaseProposalDetails",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AlterColumn<double>(
                name: "Quantity",
                table: "Products",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AlterColumn<double>(
                name: "MinQuantity",
                table: "Products",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<double>(
                name: "MaxQuantity",
                table: "Products",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddColumn<double>(
                name: "QuantityForSale",
                table: "Products",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "QuantityOrdered",
                table: "Products",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.AddColumn<double>(
                name: "QuantityReturned",
                table: "Products",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "2b864b94-804d-4ee7-868c-976268cd8c19", "751f72a7-084b-4a6a-b6a1-153fed577774", "Admin", "admin" },
                    { "5079e708-33e5-4419-8ff5-9901304ae134", "22d9bd21-2e29-4c5e-82f3-73b5a5e3f65d", "Sale", "sale" },
                    { "523d34bb-4034-4752-9e72-2412e97d7617", "ac7822f8-c9bf-44d4-8275-f60eafcd3376", "SuperAdmin", "superadmin" },
                    { "3ee11948-4c99-4fbd-8e61-ef3601bce794", "0cc903ea-2312-4e74-ac04-90dc22612180", "WarehouseKeeperManager", "warehousekeepermanager" },
                    { "a2c3f740-cb6e-494b-93f7-1105ee89996d", "8834a9f7-9c93-4179-8a6f-2010008c267f", "WarehouseKeeper", "warehousekeeper" },
                    { "375da43b-81b4-4977-9158-7f44988fd3e4", "ff918693-6eb6-4564-85d0-327744c54a84", "Customer", "customer" },
                    { "26aceecc-20b9-4934-82d1-7ff18eb3da23", "29357050-7c3a-4676-83d3-152373ec90b3", "Boss", "boss" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "e88e0cbd-3988-40f7-8991-dfa33282a6f5", 0, "303055fe-c2e3-4f82-b631-67603edd3a0b", "truongtuantu@gmail.com", true, "Tú", "Trương Tuấn", false, null, "TRUONGTUANTU@GMAIL.COM", "TRUONGTUANTU@GMAIL.COM", "AQAAAAEAACcQAAAAEDdirr+iMrwUdz3d4axS8jg0NoZ7GxP/X0k8UxtNnScxK25RRPTWTQ7dPGGWmRHi2w==", null, false, "", false, "truongtuantu@gmail.com" },
                    { "0a27c5af-06f0-464b-80b9-bbefcd963730", 0, "a6566cfd-5ab1-4fa8-8f96-b965d653c55b", "phantantrung@gmail.com", true, "Trung", "Phan Tấn", false, null, "PHANTANTRUNG@GMAIL.COM", "PHANTANTRUNG@GMAIL.COM", "AQAAAAEAACcQAAAAEFUp+yK/2Bg0bdtY7Eowd0fQ48IVgGiWOo/Bt5TWYZZ2R+f3NR9sFZoUNz48/9Y5BA==", null, false, "", false, "phantantrung@gmail.com" },
                    { "f1bee162-1c5a-4890-acb0-d2cdaf55a8c8", 0, "1bf64a7e-2e94-4745-988d-b8ae98864a0f", "phungthanhdo@gmail.com", true, "Độ", "Phùng Thanh", false, null, "PHUNGTHANHDO@GMAIL.COM", "PHUNGTHANHDO@GMAIL.COM", "AQAAAAEAACcQAAAAEOBh2rfQTzJ/tCAxwSIHTDNCumioTFohO8tDkPXo0yv4vlV8BipaxTFUtOaRgIRLPA==", null, false, "", false, "phungthanhdo@gmail.com" },
                    { "d0fec2f3-fcbf-4fcc-bc2a-f14d31065dc7", 0, "746625e1-07c1-4238-bdbc-f8101aad5805", "nguyenhue@gmail.com", true, "Huệ", "Nguyễn", false, null, "NGUYENHUE@GMAIL.COM", "NGUYENHUE@GMAIL.COM", "AQAAAAEAACcQAAAAEOGT1qw7Hnep8Hc00uwSALdSmq8rNlYM80ZvY7guajSIxZpnOAXPi2+h6vwRCEOZaA==", null, false, "", false, "nguyenhue@gmail.com" },
                    { "9dcd0027-cae0-4af6-b9e8-1f1a6a96efe2", 0, "c151f167-496e-4770-aa26-b4b8b2554d14", "hoxuanhuong@gmail.com", true, "Hương", "Hồ Xuân", false, null, "HOXUANHUONG@GMAIL.COM", "HOXUANHUONG@GMAIL.COM", "AQAAAAEAACcQAAAAEObeDnLOkIILDkhq+L4bPFrnTdU9xoOg2pTnRq+vhdfgZzujjvGXYo57HVDA3s1X/A==", null, false, "", false, "hoxuanhuong@gmail.com" },
                    { "85ce5c89-56dd-4fbf-b2ad-0ccfe069679e", 0, "7550bd7a-7571-467f-9687-8be743196213", "nguyenthanhlong@gmail.com", true, "Long", "Nguyễn Thành", false, null, "NGUYENTHANHLONG@GMAIL.COM", "NGUYENTHANHLONG@GMAIL.COM", "AQAAAAEAACcQAAAAECUEhpn6O+dwpqRHUmCvkgtIyDroHSvZvvB7cHJvVJmRE4GR9NMFj0RV4dIgZQQ08Q==", null, false, "", false, "nguyenthanhlong@gmail.com" },
                    { "04c1916f-eb52-46db-981c-762b9957e25c", 0, "4e4366c5-1f5a-4727-9040-e989aa469594", "huynhtranthanh@gmail.com", true, "Thành", "Huỳnh Trấn", false, null, "HUYNHTRANTHANH@GMAIL.COM", "HUYNHTRANTHANH@GMAIL.COM", "AQAAAAEAACcQAAAAEH4B+g21wHFD+bpTxmXVS7hu9ZoalVFbTNWGxkSH5aO82aMJJ6LgI7CrICYadrc9Ow==", null, false, "", false, "huynhtranthanh@gmail.com" },
                    { "7f689288-ce66-4c15-b5e8-2782dc8559bd", 0, "d3952326-6a6a-418c-8af9-98c37ebf20c0", "truongthitramanh@gmail.com", true, "Anh", "Trương Thị Trâm", false, null, "TRUONGTHITRAMANH@GMAIL.COM", "TRUONGTHITRAMANH@GMAIL.COM", "AQAAAAEAACcQAAAAEEKLreT/hE1q7w96W6HZ+/uiMIYUU/GZoBvv475X4P0IEE+K+NeHsleRX+sdhzWnKA==", null, false, "", false, "truongthitramanh@gmail.com" },
                    { "b4f1c462-acce-49b4-895a-7d1d989ad264", 0, "8e041071-6834-4857-b177-ac90032adf73", "caobaquat@gmail.com", true, "Quát", "Cao Bá", false, null, "CAOBAQUAT@GMAIL.COM", "CAOBAQUAT@GMAIL.COM", "AQAAAAEAACcQAAAAEBEEWtFKdYRbCrp9oxCu7DGCsIoqwm8mhKdZ3trI7iSdonmlVTjgAhHTFRi2Jcipfw==", null, false, "", false, "caobaquat@gmail.com" },
                    { "f4191ce9-fca7-4f54-bfef-e918192984c0", 0, "c1c330be-0330-4d11-b686-059cc339d7f0", "caothivananh@gmail.com", true, "Anh", "Cao Thị Vân", false, null, "CAOTHIVANANH@GMAIL.COM", "CAOTHIVANANH@GMAIL.COM", "AQAAAAEAACcQAAAAEF5a5Pj+0TGoh7MK2yRlCWS7HbDXVVNKdNr5WbgrUiGHq5a/sU1e8ybG2uVh6mpGIw==", null, false, "", false, "caothivananh@gmail.com" },
                    { "d475f04e-6f9a-4f13-b8ea-b099b5aa84db", 0, "7b613ea6-3d25-4403-8ed6-cf3a72779bd6", "nguyennhuloc@gmail.com", true, "Lộc", "Nguyễn Như", false, null, "NGUYENNHULOC@GMAIL.COM", "NGUYENNHULOC@GMAIL.COM", "AQAAAAEAACcQAAAAEGkQ30O32QpBHvVVMkels7iwCIJoDE98xbhgpcKo57t67+dQ2BhBo3/Zz3Q7l/SOMg==", null, false, "", false, "nguyennhuloc@gmail.com" },
                    { "380e17cb-fe13-4107-9621-d257e6ba6dba", 0, "386a20e0-51ac-47d3-9e01-c467b506d985", "nguyentrunghieu@gmail.com", true, "Hiếu", "Nguyễn Trung", false, null, "NGUYENTRUNGHIEU@GMAIL.COM", "NGUYENTRUNGHIEU@GMAIL.COM", "AQAAAAEAACcQAAAAEByvUvbx27rH4DInYePyKqse8xB0p6dCBe5DBewAP+5GuJAtzzfZR0FJoUl+4K3j1w==", null, false, "", false, "nguyentrunghieu@gmail.com" },
                    { "6ad07f1d-4c95-4532-a831-e4cc80543fc0", 0, "24450a34-2cac-4af0-a94e-4ec53b7e6439", "phamvinhson@gmail.com", true, "Sơn", "Phạm Vĩnh", false, null, "PHAMVINHSON@GMAIL.COM", "PHAMVINHSON@GMAIL.COM", "AQAAAAEAACcQAAAAEEICaidCntH1Nh0XF8r+qjV26FHFdd8TClrwbS3OL1jtMRzT9RvRQtOe2W9+iYtegw==", null, false, "", false, "phamvinhson@gmail.com" },
                    { "21ba26ca-04ab-4ef9-8667-b7ea9a908d46", 0, "8d818f3a-c124-48a6-b0f4-0cb28a90309a", "trankieuloan@gmail.com", true, "Loan", "Trần Kiều", false, null, "TRANKIEULOAN@GMAIL.COM", "TRANKIEULOAN@GMAIL.COM", "AQAAAAEAACcQAAAAEDqkPAzE3rlfBDTyqxduLOeps+OtjHwLNfb7T9B1Lbe24XqHTu3iULjQ8dv6m/4VVw==", null, false, "", false, "trankieuloan@gmail.com" },
                    { "d9dceed0-3978-4136-ba4d-89feee4a0445", 0, "04fe1263-6eb8-4b0e-a9b9-9fb278be97ee", "yungadmin@gmail.com", true, "Admin", "Yung", false, null, "YUNGADMIN@GMAIL.COM", "YUNGADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEPGW3n6sbZTfXfIB5sIQIAMAljNXN1YIg1BbBi3W7fGIjI2sQmvgYLs8+YRxPOs/zg==", null, false, "", false, "yungadmin@gmail.com" },
                    { "d65c44d7-3f3a-41e5-b42d-1e60fb7fe90a", 0, "1952fd19-3a3f-498b-8f7e-e7bfb631346f", "lilsuperadmin@gmail.com", true, "Super Admin", "Lil", false, null, "LILSUPERADMIN@GMAIL.COM", "LILSUPERADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEONIPpdvwcIhTjwkhMBxYBuEag8Qg+eulMQ25GHdRBPUT5xOhesbxqnY+89bENiM+w==", null, false, "", false, "lilsuperadmin@gmail.com" },
                    { "84f8b688-c9d7-4084-8cf0-1ae773a303ea", 0, "37cd7c90-fc68-4ebd-a2b5-2d46ebf50ad9", "tranthaonguyen@gmail.com", true, "Nguyên", "Trần Thảo", false, null, "TRANTHAONGUYEN@GMAIL.COM", "TRANTHAONGUYEN@GMAIL.COM", "AQAAAAEAACcQAAAAEJ4wiszqPLRD2p8Ztch3tQc8rpCIVPKJxo9sYR6ZwBCAtdN3AZU0T7CAVo6KosuTiw==", null, false, "", false, "tranthaonguyen@gmail.com" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000.0, 0.0, 896.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000.0, 0.0, 259.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000.0, 0.0, 251.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000.0, 0.0, 979.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000.0, 0.0, 6.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000.0, 0.0, 311.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000.0, 0.0, 900.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000.0, 0.0, 21.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000.0, 0.0, 298.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000.0, 0.0, 592.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000.0, 0.0, 171.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000.0, 0.0, 543.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000.0, 0.0, 253.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000.0, 0.0, 324.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000.0, 0.0, 743.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000.0, 0.0, 811.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000.0, 0.0, 105.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000.0, 0.0, 495.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000.0, 0.0, 322.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000.0, 0.0, 759.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000.0, 0.0, 42.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000.0, 0.0, 728.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000.0, 0.0, 420.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000.0, 0.0, 369.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000.0, 0.0, 969.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000.0, 0.0, 818.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000.0, 0.0, 655.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000.0, 0.0, 852.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000.0, 0.0, 509.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000.0, 0.0, 904.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000.0, 0.0, 29.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000.0, 0.0, 306.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000.0, 0.0, 976.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000.0, 0.0, 726.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000.0, 0.0, 998.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000.0, 0.0, 675.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000.0, 0.0, 389.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000.0, 0.0, 813.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000.0, 0.0, 885.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000.0, 0.0, 672.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000.0, 0.0, 485.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000.0, 0.0, 802.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000.0, 0.0, 764.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000.0, 0.0, 439.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000.0, 0.0, 21.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000.0, 0.0, 819.0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000.0, 0.0, 262.0 });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "d65c44d7-3f3a-41e5-b42d-1e60fb7fe90a", "523d34bb-4034-4752-9e72-2412e97d7617" },
                    { "f1bee162-1c5a-4890-acb0-d2cdaf55a8c8", "5079e708-33e5-4419-8ff5-9901304ae134" },
                    { "d0fec2f3-fcbf-4fcc-bc2a-f14d31065dc7", "a2c3f740-cb6e-494b-93f7-1105ee89996d" },
                    { "9dcd0027-cae0-4af6-b9e8-1f1a6a96efe2", "a2c3f740-cb6e-494b-93f7-1105ee89996d" },
                    { "85ce5c89-56dd-4fbf-b2ad-0ccfe069679e", "a2c3f740-cb6e-494b-93f7-1105ee89996d" },
                    { "04c1916f-eb52-46db-981c-762b9957e25c", "3ee11948-4c99-4fbd-8e61-ef3601bce794" },
                    { "b4f1c462-acce-49b4-895a-7d1d989ad264", "3ee11948-4c99-4fbd-8e61-ef3601bce794" },
                    { "0a27c5af-06f0-464b-80b9-bbefcd963730", "5079e708-33e5-4419-8ff5-9901304ae134" },
                    { "7f689288-ce66-4c15-b5e8-2782dc8559bd", "375da43b-81b4-4977-9158-7f44988fd3e4" },
                    { "f4191ce9-fca7-4f54-bfef-e918192984c0", "375da43b-81b4-4977-9158-7f44988fd3e4" },
                    { "d475f04e-6f9a-4f13-b8ea-b099b5aa84db", "375da43b-81b4-4977-9158-7f44988fd3e4" },
                    { "380e17cb-fe13-4107-9621-d257e6ba6dba", "375da43b-81b4-4977-9158-7f44988fd3e4" },
                    { "6ad07f1d-4c95-4532-a831-e4cc80543fc0", "26aceecc-20b9-4934-82d1-7ff18eb3da23" },
                    { "21ba26ca-04ab-4ef9-8667-b7ea9a908d46", "26aceecc-20b9-4934-82d1-7ff18eb3da23" },
                    { "d9dceed0-3978-4136-ba4d-89feee4a0445", "2b864b94-804d-4ee7-868c-976268cd8c19" },
                    { "84f8b688-c9d7-4084-8cf0-1ae773a303ea", "375da43b-81b4-4977-9158-7f44988fd3e4" },
                    { "e88e0cbd-3988-40f7-8991-dfa33282a6f5", "5079e708-33e5-4419-8ff5-9901304ae134" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "04c1916f-eb52-46db-981c-762b9957e25c", "3ee11948-4c99-4fbd-8e61-ef3601bce794" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "0a27c5af-06f0-464b-80b9-bbefcd963730", "5079e708-33e5-4419-8ff5-9901304ae134" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "21ba26ca-04ab-4ef9-8667-b7ea9a908d46", "26aceecc-20b9-4934-82d1-7ff18eb3da23" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "380e17cb-fe13-4107-9621-d257e6ba6dba", "375da43b-81b4-4977-9158-7f44988fd3e4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "6ad07f1d-4c95-4532-a831-e4cc80543fc0", "26aceecc-20b9-4934-82d1-7ff18eb3da23" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "7f689288-ce66-4c15-b5e8-2782dc8559bd", "375da43b-81b4-4977-9158-7f44988fd3e4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "84f8b688-c9d7-4084-8cf0-1ae773a303ea", "375da43b-81b4-4977-9158-7f44988fd3e4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "85ce5c89-56dd-4fbf-b2ad-0ccfe069679e", "a2c3f740-cb6e-494b-93f7-1105ee89996d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "9dcd0027-cae0-4af6-b9e8-1f1a6a96efe2", "a2c3f740-cb6e-494b-93f7-1105ee89996d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "b4f1c462-acce-49b4-895a-7d1d989ad264", "3ee11948-4c99-4fbd-8e61-ef3601bce794" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "d0fec2f3-fcbf-4fcc-bc2a-f14d31065dc7", "a2c3f740-cb6e-494b-93f7-1105ee89996d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "d475f04e-6f9a-4f13-b8ea-b099b5aa84db", "375da43b-81b4-4977-9158-7f44988fd3e4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "d65c44d7-3f3a-41e5-b42d-1e60fb7fe90a", "523d34bb-4034-4752-9e72-2412e97d7617" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "d9dceed0-3978-4136-ba4d-89feee4a0445", "2b864b94-804d-4ee7-868c-976268cd8c19" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "e88e0cbd-3988-40f7-8991-dfa33282a6f5", "5079e708-33e5-4419-8ff5-9901304ae134" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "f1bee162-1c5a-4890-acb0-d2cdaf55a8c8", "5079e708-33e5-4419-8ff5-9901304ae134" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "f4191ce9-fca7-4f54-bfef-e918192984c0", "375da43b-81b4-4977-9158-7f44988fd3e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "26aceecc-20b9-4934-82d1-7ff18eb3da23");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2b864b94-804d-4ee7-868c-976268cd8c19");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "375da43b-81b4-4977-9158-7f44988fd3e4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3ee11948-4c99-4fbd-8e61-ef3601bce794");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5079e708-33e5-4419-8ff5-9901304ae134");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "523d34bb-4034-4752-9e72-2412e97d7617");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a2c3f740-cb6e-494b-93f7-1105ee89996d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "04c1916f-eb52-46db-981c-762b9957e25c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0a27c5af-06f0-464b-80b9-bbefcd963730");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "21ba26ca-04ab-4ef9-8667-b7ea9a908d46");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "380e17cb-fe13-4107-9621-d257e6ba6dba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6ad07f1d-4c95-4532-a831-e4cc80543fc0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7f689288-ce66-4c15-b5e8-2782dc8559bd");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "84f8b688-c9d7-4084-8cf0-1ae773a303ea");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "85ce5c89-56dd-4fbf-b2ad-0ccfe069679e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9dcd0027-cae0-4af6-b9e8-1f1a6a96efe2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b4f1c462-acce-49b4-895a-7d1d989ad264");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d0fec2f3-fcbf-4fcc-bc2a-f14d31065dc7");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d475f04e-6f9a-4f13-b8ea-b099b5aa84db");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d65c44d7-3f3a-41e5-b42d-1e60fb7fe90a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d9dceed0-3978-4136-ba4d-89feee4a0445");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e88e0cbd-3988-40f7-8991-dfa33282a6f5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f1bee162-1c5a-4890-acb0-d2cdaf55a8c8");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f4191ce9-fca7-4f54-bfef-e918192984c0");

            migrationBuilder.DropColumn(
                name: "QuantityPurchased",
                table: "PurchaseProposalDetails");

            migrationBuilder.DropColumn(
                name: "QuantityForSale",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "QuantityOrdered",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "QuantityReturned",
                table: "Products");

            migrationBuilder.AlterColumn<int>(
                name: "Quantity",
                table: "PurchaseProposalDetails",
                type: "int",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<int>(
                name: "Quantity",
                table: "Products",
                type: "int",
                nullable: false,
                oldClrType: typeof(double));

            migrationBuilder.AlterColumn<int>(
                name: "MinQuantity",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "MaxQuantity",
                table: "Products",
                type: "int",
                nullable: true,
                oldClrType: typeof(double),
                oldNullable: true);

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "d0cdb3a2-0198-422e-8386-2f832f0a0670", "0f34f98f-1218-47ff-be7d-57b39140febf", "Admin", "admin" },
                    { "287041ab-c9cb-4f96-ae2f-b5fd44349683", "57747f1b-f18c-4e3d-928c-4a046a244163", "Sale", "sale" },
                    { "d21ec932-48b1-45ff-a4ae-f282b6fecaeb", "4de91b0d-d7d6-4feb-8a65-6855eb12baf0", "SuperAdmin", "superadmin" },
                    { "68fc8a61-7c39-4dd9-9b71-69e7b3828deb", "323f8d07-cc45-4536-a8fc-1f6ee21a877a", "WarehouseKeeperManager", "warehousekeepermanager" },
                    { "32e3b759-f48e-403a-9b16-a7050fadcbc8", "f53463fd-6780-4fa6-87ae-74c247a099ef", "WarehouseKeeper", "warehousekeeper" },
                    { "3e3b009c-799c-4a4c-86a5-d90daf8563ce", "05715d08-65a8-4a68-8b5f-ac3b208b6b8b", "Customer", "customer" },
                    { "08458f61-e622-4753-aca8-cf0a87608a19", "b564c7bd-eaa8-4baa-8d09-79f4488b8fac", "Boss", "boss" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "b2b480b1-49df-4b5a-a077-b85f3c400d13", 0, "d480cead-e4cf-4db5-a553-19ddb2ac7d2d", "truongtuantu@gmail.com", true, "Tú", "Trương Tuấn", false, null, "TRUONGTUANTU@GMAIL.COM", "TRUONGTUANTU@GMAIL.COM", "AQAAAAEAACcQAAAAEHrAr9xtZ7osCTV9wCzX8WNzyAjvwwc5PwG5dpZrpXmNWU0NsgApMuBHWlDiF1oMew==", null, false, "", false, "truongtuantu@gmail.com" },
                    { "c95c6655-ca3f-4971-ad8f-74b43918f4f4", 0, "c7fe0814-7f80-4239-983d-b24e1bf4d6e6", "phantantrung@gmail.com", true, "Trung", "Phan Tấn", false, null, "PHANTANTRUNG@GMAIL.COM", "PHANTANTRUNG@GMAIL.COM", "AQAAAAEAACcQAAAAEL0AokTTqeXPp0E8k1jhpiwXoqHN7iEWa5/j8Lx9MmKdfBXdCLv0CrZKWNu+5C2wyw==", null, false, "", false, "phantantrung@gmail.com" },
                    { "e4348093-1864-44c5-90fa-32a35a2073ec", 0, "5d4a0fb8-47f6-4cda-8df1-226665a3b854", "phungthanhdo@gmail.com", true, "Độ", "Phùng Thanh", false, null, "PHUNGTHANHDO@GMAIL.COM", "PHUNGTHANHDO@GMAIL.COM", "AQAAAAEAACcQAAAAEL/uX4zwT5UwBcRL5l0bZg/nU/TS56ikI7fsGBmcE3GZvKZziEFvQnTVQ6qiF30pqg==", null, false, "", false, "phungthanhdo@gmail.com" },
                    { "5b250552-61d2-45e2-902b-70cdf6b58e7a", 0, "4d00678d-0557-43a2-8703-36962e0e0864", "nguyenhue@gmail.com", true, "Huệ", "Nguyễn", false, null, "NGUYENHUE@GMAIL.COM", "NGUYENHUE@GMAIL.COM", "AQAAAAEAACcQAAAAEFp87XccXA+N4jc3zZV3P/AG2Mo0RK2C5b5Notm0kJB9lawhlnuOSipRGEBXME1BPA==", null, false, "", false, "nguyenhue@gmail.com" },
                    { "387216d3-d69c-4802-be9a-f876ae42f5df", 0, "37140ad3-4ce6-4316-95b9-4758a225779c", "hoxuanhuong@gmail.com", true, "Hương", "Hồ Xuân", false, null, "HOXUANHUONG@GMAIL.COM", "HOXUANHUONG@GMAIL.COM", "AQAAAAEAACcQAAAAEEJXTRUqbRA55j+edw+G/jK9EkilB1d3VHdjydDUZ3P1C2cUeE6d/icTm9FGGP3kBg==", null, false, "", false, "hoxuanhuong@gmail.com" },
                    { "d66d3245-a3cd-489c-9d3e-e515a4a25f67", 0, "381649df-2e79-48bf-b183-86cef1bf2292", "nguyenthanhlong@gmail.com", true, "Long", "Nguyễn Thành", false, null, "NGUYENTHANHLONG@GMAIL.COM", "NGUYENTHANHLONG@GMAIL.COM", "AQAAAAEAACcQAAAAEBzpKCCCeDVrCGwgA6J5ItRF+1WfELsilS0Ibzzp95oOLcilsAcxqa/Ghs4fJXKcVw==", null, false, "", false, "nguyenthanhlong@gmail.com" },
                    { "947b2125-a09e-4122-b0b2-19d154019a61", 0, "310924e1-02ac-4dc6-9ecc-0949dd528036", "huynhtranthanh@gmail.com", true, "Thành", "Huỳnh Trấn", false, null, "HUYNHTRANTHANH@GMAIL.COM", "HUYNHTRANTHANH@GMAIL.COM", "AQAAAAEAACcQAAAAENjvtoNMMYmygflYVrA/91k9PRfOVl/5U3U/lCles7ZhiyVLBNaYGWLgQFVShp6Rig==", null, false, "", false, "huynhtranthanh@gmail.com" },
                    { "996cb637-0c0d-4449-b20a-f845e967968f", 0, "357858e3-c71a-44ae-ab6c-4d7a5d73af91", "truongthitramanh@gmail.com", true, "Anh", "Trương Thị Trâm", false, null, "TRUONGTHITRAMANH@GMAIL.COM", "TRUONGTHITRAMANH@GMAIL.COM", "AQAAAAEAACcQAAAAEOUpy57sZQTtzC1mFSyUGBos9tGXWdvtZXOxFotwlMa7JXOfiRf4Tc3lGZ1Cd29umQ==", null, false, "", false, "truongthitramanh@gmail.com" },
                    { "97a944c9-6591-41d8-b0c5-231ba340e323", 0, "1b59cf32-1dc5-4cbd-a1b2-8ced1ba78a24", "caobaquat@gmail.com", true, "Quát", "Cao Bá", false, null, "CAOBAQUAT@GMAIL.COM", "CAOBAQUAT@GMAIL.COM", "AQAAAAEAACcQAAAAEHpTcWSIKIggPP1h+eTSJBi5a8byB5r0k6o9jIQPSS6cXakJz7fE3j3CEfXiHb/WNA==", null, false, "", false, "caobaquat@gmail.com" },
                    { "aab88e65-ea84-41d1-8c29-66a269795ee5", 0, "1af7f3a2-0017-4435-83f5-44e47f405af4", "caothivananh@gmail.com", true, "Anh", "Cao Thị Vân", false, null, "CAOTHIVANANH@GMAIL.COM", "CAOTHIVANANH@GMAIL.COM", "AQAAAAEAACcQAAAAEJT75Crezs+ySw3WFGhVmIg+OukGjScBiTaswesRsY9uHZeng/EmiZSoXJrVAvFQOA==", null, false, "", false, "caothivananh@gmail.com" },
                    { "1df6771c-1fb8-4bbe-bfc3-92f703859b90", 0, "833d346d-dfb9-4343-912b-c4b15e2c6be1", "nguyennhuloc@gmail.com", true, "Lộc", "Nguyễn Như", false, null, "NGUYENNHULOC@GMAIL.COM", "NGUYENNHULOC@GMAIL.COM", "AQAAAAEAACcQAAAAEHyCVBHLxzKmbk2NEUk8EFBevaGLuOIkN9xO4NFkGd51ydLeocyUsqvyVs/fqTKMIQ==", null, false, "", false, "nguyennhuloc@gmail.com" },
                    { "18f6f8d1-93fd-4f05-9ecb-6e807dda4115", 0, "25701c60-a460-49c7-89ab-e833175f3a37", "nguyentrunghieu@gmail.com", true, "Hiếu", "Nguyễn Trung", false, null, "NGUYENTRUNGHIEU@GMAIL.COM", "NGUYENTRUNGHIEU@GMAIL.COM", "AQAAAAEAACcQAAAAEF1CfgXV+nyjLfuIwAR+D0vwY27fAuFN+n7/DMuSbrcy8bWviFfzQ0LvImoOntajoA==", null, false, "", false, "nguyentrunghieu@gmail.com" },
                    { "7780aea3-27e8-4a8c-a633-48cb266126df", 0, "5c78c5e7-f7b6-40c8-8d6a-df53813b1612", "phamvinhson@gmail.com", true, "Sơn", "Phạm Vĩnh", false, null, "PHAMVINHSON@GMAIL.COM", "PHAMVINHSON@GMAIL.COM", "AQAAAAEAACcQAAAAEB3G0gLD81i3fvljNHRtVh5MTkv8GEFfaX58XkshSEAxjbqEMxbu1S9BgqDzxkgKnQ==", null, false, "", false, "phamvinhson@gmail.com" },
                    { "e28aba9e-fe53-460e-bb34-c2027eb5004d", 0, "a0bc2677-df68-492b-9459-1bf6ba5109d0", "trankieuloan@gmail.com", true, "Loan", "Trần Kiều", false, null, "TRANKIEULOAN@GMAIL.COM", "TRANKIEULOAN@GMAIL.COM", "AQAAAAEAACcQAAAAECUJDhHpT1605eN12nHNfZECyEwAq53pHJSsRFAdSM3wbIqyzC2Oy1vbRNF9hZKjVw==", null, false, "", false, "trankieuloan@gmail.com" },
                    { "13b00890-d1f9-45b0-a2db-79c8e58f927f", 0, "e26c5854-6740-44a1-b5a9-6a6c31c84d2e", "yungadmin@gmail.com", true, "Admin", "Yung", false, null, "YUNGADMIN@GMAIL.COM", "YUNGADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEGZvZ62Ax0CA20skFAqmBBONPg/gQ15aNm6/uKrYgni0mHVSzZX9Lnyoc1Z75eMl0Q==", null, false, "", false, "yungadmin@gmail.com" },
                    { "8d0a4d6d-2ecc-4f0d-a5c6-d9ab6198a861", 0, "f8fa39b6-2f41-499e-80ed-dfe7378e2029", "lilsuperadmin@gmail.com", true, "Super Admin", "Lil", false, null, "LILSUPERADMIN@GMAIL.COM", "LILSUPERADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEJRfpdHzXlPC3gUlCHAlFjwVqcYmFGxPTKq9oiHx91C4NReMKpoootfFCdfGk1hD0w==", null, false, "", false, "lilsuperadmin@gmail.com" },
                    { "405bfeac-8e9a-4037-9706-0ede0504ee6b", 0, "5b36ff5c-3798-4825-8971-be349a457f23", "tranthaonguyen@gmail.com", true, "Nguyên", "Trần Thảo", false, null, "TRANTHAONGUYEN@GMAIL.COM", "TRANTHAONGUYEN@GMAIL.COM", "AQAAAAEAACcQAAAAEDHM+JT2w3XzLb/CpL23C7q1idyAghsoCsGhmapG34oCRJYRU8fo9TFD7FRjWYLQkg==", null, false, "", false, "tranthaonguyen@gmail.com" }
                });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000, 0, 896 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000, 0, 259 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000, 0, 251 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000, 0, 979 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000, 0, 6 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000, 0, 311 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000, 0, 900 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000, 0, 21 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000, 0, 298 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000, 0, 592 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000, 0, 171 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000, 0, 543 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000, 0, 253 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000, 0, 324 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000, 0, 743 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000, 0, 811 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000, 0, 105 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000, 0, 495 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000, 0, 322 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000, 0, 759 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 21,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000, 0, 42 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 22,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000, 0, 728 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 23,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000, 0, 420 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 24,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000, 0, 369 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 25,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000, 0, 969 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 26,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000, 0, 818 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 27,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000, 0, 655 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 28,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000, 0, 852 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 29,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000, 0, 509 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 30,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000, 0, 904 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 31,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000, 0, 29 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 32,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000, 0, 306 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 33,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000, 0, 976 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 34,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000, 0, 726 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 35,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000, 0, 998 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 36,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000, 0, 675 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 37,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000, 0, 389 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 38,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000, 0, 813 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 39,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000, 0, 885 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 40,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000, 0, 672 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 41,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000, 0, 485 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 42,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000, 0, 802 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 43,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000, 0, 764 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 44,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000, 0, 439 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 45,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000, 0, 21 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 46,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000, 0, 819 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 48,
                columns: new[] { "MaxQuantity", "MinQuantity", "Quantity" },
                values: new object[] { 1000, 0, 262 });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "8d0a4d6d-2ecc-4f0d-a5c6-d9ab6198a861", "d21ec932-48b1-45ff-a4ae-f282b6fecaeb" },
                    { "e4348093-1864-44c5-90fa-32a35a2073ec", "287041ab-c9cb-4f96-ae2f-b5fd44349683" },
                    { "5b250552-61d2-45e2-902b-70cdf6b58e7a", "32e3b759-f48e-403a-9b16-a7050fadcbc8" },
                    { "387216d3-d69c-4802-be9a-f876ae42f5df", "32e3b759-f48e-403a-9b16-a7050fadcbc8" },
                    { "d66d3245-a3cd-489c-9d3e-e515a4a25f67", "32e3b759-f48e-403a-9b16-a7050fadcbc8" },
                    { "947b2125-a09e-4122-b0b2-19d154019a61", "68fc8a61-7c39-4dd9-9b71-69e7b3828deb" },
                    { "97a944c9-6591-41d8-b0c5-231ba340e323", "68fc8a61-7c39-4dd9-9b71-69e7b3828deb" },
                    { "c95c6655-ca3f-4971-ad8f-74b43918f4f4", "287041ab-c9cb-4f96-ae2f-b5fd44349683" },
                    { "996cb637-0c0d-4449-b20a-f845e967968f", "3e3b009c-799c-4a4c-86a5-d90daf8563ce" },
                    { "aab88e65-ea84-41d1-8c29-66a269795ee5", "3e3b009c-799c-4a4c-86a5-d90daf8563ce" },
                    { "1df6771c-1fb8-4bbe-bfc3-92f703859b90", "3e3b009c-799c-4a4c-86a5-d90daf8563ce" },
                    { "18f6f8d1-93fd-4f05-9ecb-6e807dda4115", "3e3b009c-799c-4a4c-86a5-d90daf8563ce" },
                    { "7780aea3-27e8-4a8c-a633-48cb266126df", "08458f61-e622-4753-aca8-cf0a87608a19" },
                    { "e28aba9e-fe53-460e-bb34-c2027eb5004d", "08458f61-e622-4753-aca8-cf0a87608a19" },
                    { "13b00890-d1f9-45b0-a2db-79c8e58f927f", "d0cdb3a2-0198-422e-8386-2f832f0a0670" },
                    { "405bfeac-8e9a-4037-9706-0ede0504ee6b", "3e3b009c-799c-4a4c-86a5-d90daf8563ce" },
                    { "b2b480b1-49df-4b5a-a077-b85f3c400d13", "287041ab-c9cb-4f96-ae2f-b5fd44349683" }
                });
        }
    }
}
