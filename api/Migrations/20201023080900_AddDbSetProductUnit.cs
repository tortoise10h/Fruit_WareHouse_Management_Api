using Microsoft.EntityFrameworkCore.Migrations;

namespace api.Migrations
{
    public partial class AddDbSetProductUnit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductUnit_Products_ProductId",
                table: "ProductUnit");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductUnit",
                table: "ProductUnit");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "1dc4f675-c3e2-4418-8841-aef023c7e628", "b9f09031-e8e0-4d91-bbe5-41b29b3e2f86" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "29c4d224-9ce6-4555-b58c-ddc5269f1e73", "b76626a7-1386-42c3-a168-5e494c3afdcf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "2e04737e-9968-40a7-ad41-eccbc74217e2", "a08d8517-1f01-45b9-9700-0609323e2334" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "4d86e23d-b493-4fac-92d0-b9855debc4e9", "a08d8517-1f01-45b9-9700-0609323e2334" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "55627df7-d2e9-483f-8293-ddaef8f65cc2", "b76626a7-1386-42c3-a168-5e494c3afdcf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "5d185e71-9081-4f7d-a791-7481c5fec01f", "96bec076-866e-4f01-8490-1ee3490f34aa" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "75d00dc7-5651-4453-93f7-d0ca11550a17", "a08d8517-1f01-45b9-9700-0609323e2334" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "8e84c837-3c26-402e-8aa1-58e356640cdc", "c834b8e1-0007-484a-9130-4a2da17b7751" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "96b91bae-5bae-40b9-a240-c8bb3cf7ebef", "b9f09031-e8e0-4d91-bbe5-41b29b3e2f86" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "acdc5a84-7426-4109-abe8-488ed3d7e250", "a08d8517-1f01-45b9-9700-0609323e2334" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "b8b33a02-ef0f-4e29-84b8-7ac86bf1785a", "a08d8517-1f01-45b9-9700-0609323e2334" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "c3ed21d3-4ca4-4375-9fd6-6de885e4fc8c", "a08d8517-1f01-45b9-9700-0609323e2334" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "c7a5d61e-bbf8-41d9-ac02-56fb9d58fb45", "96bec076-866e-4f01-8490-1ee3490f34aa" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "de40550f-5a2d-43dd-bb6e-74f0d9555d16", "b9f09031-e8e0-4d91-bbe5-41b29b3e2f86" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "e26529e9-980a-431f-823b-f77996f574f9", "189b958a-daba-486d-afeb-b66faf815f3d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "f604ba7b-d6e7-4c15-9067-4e6171bd60bc", "b76626a7-1386-42c3-a168-5e494c3afdcf" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "fed18e67-86c2-4c7f-8cb9-13aeb2da490b", "a08d8517-1f01-45b9-9700-0609323e2334" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "189b958a-daba-486d-afeb-b66faf815f3d");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96bec076-866e-4f01-8490-1ee3490f34aa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a08d8517-1f01-45b9-9700-0609323e2334");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b76626a7-1386-42c3-a168-5e494c3afdcf");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b9f09031-e8e0-4d91-bbe5-41b29b3e2f86");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c834b8e1-0007-484a-9130-4a2da17b7751");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1dc4f675-c3e2-4418-8841-aef023c7e628");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "29c4d224-9ce6-4555-b58c-ddc5269f1e73");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2e04737e-9968-40a7-ad41-eccbc74217e2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4d86e23d-b493-4fac-92d0-b9855debc4e9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "55627df7-d2e9-483f-8293-ddaef8f65cc2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5d185e71-9081-4f7d-a791-7481c5fec01f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "75d00dc7-5651-4453-93f7-d0ca11550a17");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8e84c837-3c26-402e-8aa1-58e356640cdc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "96b91bae-5bae-40b9-a240-c8bb3cf7ebef");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "acdc5a84-7426-4109-abe8-488ed3d7e250");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b8b33a02-ef0f-4e29-84b8-7ac86bf1785a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c3ed21d3-4ca4-4375-9fd6-6de885e4fc8c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c7a5d61e-bbf8-41d9-ac02-56fb9d58fb45");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "de40550f-5a2d-43dd-bb6e-74f0d9555d16");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e26529e9-980a-431f-823b-f77996f574f9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f604ba7b-d6e7-4c15-9067-4e6171bd60bc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fed18e67-86c2-4c7f-8cb9-13aeb2da490b");

            migrationBuilder.RenameTable(
                name: "ProductUnit",
                newName: "ProductUnits");

            migrationBuilder.RenameIndex(
                name: "IX_ProductUnit_ProductId",
                table: "ProductUnits",
                newName: "IX_ProductUnits_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductUnits",
                table: "ProductUnits",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "bfcd3af8-0515-4ea6-b562-d861be26e3fa", "53b2f247-630d-4deb-81b1-1b52b78320ff", "Admin", "admin" },
                    { "b4813a18-07ab-42c2-9521-cef27f465941", "9fba423d-4ecc-47ec-8ae3-2a4b90512c5d", "Sale", "sale" },
                    { "da204e4e-bf84-4176-9ca3-58015ef566ce", "51515262-b828-4572-a1e7-43ecd96291dc", "SuperAdmin", "superadmin" },
                    { "abc073e4-7b42-4a65-874c-695e3ae8a383", "f38afda2-37a3-4f20-a2b2-42fcf94ec6fc", "WarehouseKeeperManager", "warehousekeepermanager" },
                    { "61a0235c-df7e-4dda-9447-1fe0d366ceb0", "2c4f88d5-284b-4eea-9911-5268675c3af3", "WarehouseKeeper", "warehousekeeper" },
                    { "66f013e9-b7e7-4be1-88d5-d97f06ff10c1", "0cc2e084-71dd-46b2-a414-04e459725104", "Customer", "customer" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5dc0e841-8f37-4561-8a78-d00ce2c8dfe4", 0, "c82a9c8b-8a4b-4eff-af76-c46f097950ab", "phungthanhdo@gmail.com", true, "Độ", "Phùng Thanh", false, null, "PHUNGTHANHDO@GMAIL.COM", "PHUNGTHANHDO@GMAIL.COM", "AQAAAAEAACcQAAAAEK29kvFVUUgK0kJbK2EzFRhu7UMRycyiezRyTQKOdCKljGxnB10CwvLVXZRpVHxx6w==", null, false, "", false, "phungthanhdo@gmail.com" },
                    { "d4f250f4-78b5-497c-bfb9-013daf1c7d84", 0, "1c1fc75b-dc7c-4cfe-a71f-0ff4af33d4d9", "nguyenhue@gmail.com", true, "Huệ", "Nguyễn", false, null, "NGUYENHUE@GMAIL.COM", "NGUYENHUE@GMAIL.COM", "AQAAAAEAACcQAAAAEHtGTz2t3u1EGWTo2wIdw20p1tR3hwlu6YKEs+iw+4+oFxOmUE1YtfHlYa+QCmY+qA==", null, false, "", false, "nguyenhue@gmail.com" },
                    { "a8480f97-5c0d-4f04-8699-ec0ac26b4470", 0, "6c35ee73-c62c-40d4-8e1f-f2ec0c5b6ea2", "hoxuanhuong@gmail.com", true, "Hương", "Hồ Xuân", false, null, "HOXUANHUONG@GMAIL.COM", "HOXUANHUONG@GMAIL.COM", "AQAAAAEAACcQAAAAEIO57RLyvSfTdOXXjV8yzLMi1e57UDCjMPzIdiqPSEGz2oh1tTSblvApkDHfwSVE+w==", null, false, "", false, "hoxuanhuong@gmail.com" },
                    { "e1f79184-5fed-4732-bc70-176ea8c73aba", 0, "58797204-1e62-4cf7-892f-69c82a50ab50", "nguyenthanhlong@gmail.com", true, "Long", "Nguyễn Thành", false, null, "NGUYENTHANHLONG@GMAIL.COM", "NGUYENTHANHLONG@GMAIL.COM", "AQAAAAEAACcQAAAAEB5ql3HcF+C4sAQngDFsAEC/hbszIwYXS2CMVZgcz4OVEfD25dwpLXH6ikFEMwBoQA==", null, false, "", false, "nguyenthanhlong@gmail.com" },
                    { "03dfe6af-b601-4130-9b2f-9aa4ee45b884", 0, "4c001aa7-f8b4-446f-a53f-151279c02238", "huynhtranthanh@gmail.com", true, "Thành", "Huỳnh Trấn", false, null, "HUYNHTRANTHANH@GMAIL.COM", "HUYNHTRANTHANH@GMAIL.COM", "AQAAAAEAACcQAAAAEEqOJEaxDk4p0lDXE/zpCh4l3f3c0U6drhegQu6kd0uRI0NaauoJY0UjVS66vGP1VQ==", null, false, "", false, "huynhtranthanh@gmail.com" },
                    { "08c9dfab-ffd8-495c-b248-63751f0128f0", 0, "8dcddce1-3f27-426c-b204-ab2810eab3b1", "caobaquat@gmail.com", true, "Quát", "Cao Bá", false, null, "CAOBAQUAT@GMAIL.COM", "CAOBAQUAT@GMAIL.COM", "AQAAAAEAACcQAAAAECZZqZNn1iaDyRE5aEXBSro2kGGh8FAP7Gl9K/d6Q00TT80aZjFbdcK9Kz97Pm1lFQ==", null, false, "", false, "caobaquat@gmail.com" },
                    { "ed3290c0-fc5c-4a29-a5e1-18ab332bfd13", 0, "abbe1c69-4134-4302-9778-5c2ea253602d", "truongthitramanh@gmail.com", true, "Anh", "Trương Thị Trâm", false, null, "TRUONGTHITRAMANH@GMAIL.COM", "TRUONGTHITRAMANH@GMAIL.COM", "AQAAAAEAACcQAAAAEJherbXtNXIuT1uhMXSS5PLpWyW4SMWrA03iUrvQMOKUKXDlRjwxU1yMxRFMAYX3hg==", null, false, "", false, "truongthitramanh@gmail.com" },
                    { "6de7fe1f-bdf7-41d4-8ab4-8bf336f985bb", 0, "9233f7a5-f0d5-4630-8639-035ac5b67828", "nguyennhuloc@gmail.com", true, "Lộc", "Nguyễn Như", false, null, "NGUYENNHULOC@GMAIL.COM", "NGUYENNHULOC@GMAIL.COM", "AQAAAAEAACcQAAAAEA/2o5lw0VqZzOWclmWxBoBIBn6uyqU2dFbFQXfQv4RcjN/eZJ54C3tBccuBcqD3dQ==", null, false, "", false, "nguyennhuloc@gmail.com" },
                    { "31bfaf48-4924-4784-b06c-99ae785b4862", 0, "fb1c1ca8-8326-4d8c-9741-fa8d8df58dd5", "caothivananh@gmail.com", true, "Anh", "Cao Thị Vân", false, null, "CAOTHIVANANH@GMAIL.COM", "CAOTHIVANANH@GMAIL.COM", "AQAAAAEAACcQAAAAEEF5vgdCJQEwt83CEGUCzuxExLsmP1+4+j5XmjEtEA3h4egIyrGswSCpdc+LYhEG/Q==", null, false, "", false, "caothivananh@gmail.com" },
                    { "7208c6e1-30db-4540-87e3-0a8831011180", 0, "f159b3b0-afc9-4bb3-8f87-e9fc9ccc86fc", "phantantrung@gmail.com", true, "Trung", "Phan Tấn", false, null, "PHANTANTRUNG@GMAIL.COM", "PHANTANTRUNG@GMAIL.COM", "AQAAAAEAACcQAAAAELWKOpePTNhIi6SUQ6RQBQoGJrUC6IPOV3Si8dkJlyiFpyp3BstgL846uZY4NFfq4A==", null, false, "", false, "phantantrung@gmail.com" },
                    { "1b7a4c8b-c242-4fa3-9e7c-3b102442c1fb", 0, "68d12151-553d-425d-965b-93910676f444", "nguyentrunghieu@gmail.com", true, "Hiếu", "Nguyễn Trung", false, null, "NGUYENTRUNGHIEU@GMAIL.COM", "NGUYENTRUNGHIEU@GMAIL.COM", "AQAAAAEAACcQAAAAEEjn7QxJiKn5guFniPCBhstIJ1H0byJpEFlZZ+EdbP36ri3551xPhMgveL2l11Np/A==", null, false, "", false, "nguyentrunghieu@gmail.com" },
                    { "e5df56c3-7b66-469d-a4a4-035c4b0de3f2", 0, "a802f32f-9176-484e-a3a7-5ce5034725d1", "phamvinhson@gmail.com", true, "Sơn", "Phạm Vĩnh", false, null, "PHAMVINHSON@GMAIL.COM", "PHAMVINHSON@GMAIL.COM", "AQAAAAEAACcQAAAAEPoZWsHJMGYtlqoZ5js5aes8n9gOwNGkGpHGAqHkric999YXXzKVxfyTSUb37TV4xg==", null, false, "", false, "phamvinhson@gmail.com" },
                    { "4eed3b27-b9a4-4662-81fd-af2a2d92114c", 0, "c9c76030-5767-408f-bcb8-d87657853743", "trankieuloan@gmail.com", true, "Loan", "Trần Kiều", false, null, "TRANKIEULOAN@GMAIL.COM", "TRANKIEULOAN@GMAIL.COM", "AQAAAAEAACcQAAAAEK3MEIeheVTJYfdXqtpjPT7+jZHc0k576+14tY5D6dExGa/pFK+uubqeT2gy9z/7ow==", null, false, "", false, "trankieuloan@gmail.com" },
                    { "eba7cfc6-17b5-4ca4-b6f7-db6156bc8b1b", 0, "5de90713-53b4-407d-8206-f538343609dd", "yungadmin@gmail.com", true, "Admin", "Yung", false, null, "YUNGADMIN@GMAIL.COM", "YUNGADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEGcuVvm1YFRiBD14OdIp3pz88PP8sLafBx8tXoBlOiAiCNai04HpKAJIwzaAr37bMw==", null, false, "", false, "yungadmin@gmail.com" },
                    { "23239ef2-32da-4ffc-832c-82c0f69a1de5", 0, "26427f76-ff80-49f8-b30e-445585ef293b", "lilsuperadmin@gmail.com", true, "Super Admin", "Lil", false, null, "LILSUPERADMIN@GMAIL.COM", "LILSUPERADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEGKvn43RJ9mchLqpkVrNpEJnGUICXoCKkJQC6Hjbu+U9hmGtHnBIyXmtr1DnKkTZuQ==", null, false, "", false, "lilsuperadmin@gmail.com" },
                    { "415c76aa-9183-4cda-b658-41159171e49a", 0, "2a197e37-4bb9-456b-9421-0b0852bace2c", "tranthaonguyen@gmail.com", true, "Nguyên", "Trần Thảo", false, null, "TRANTHAONGUYEN@GMAIL.COM", "TRANTHAONGUYEN@GMAIL.COM", "AQAAAAEAACcQAAAAEGF76eYtCTPZa4dI2d2jOBd/G3kN82McB5y7hJCPtOXCPxRLhQScLwgdVH5gfBV5bg==", null, false, "", false, "tranthaonguyen@gmail.com" },
                    { "42400983-91ac-4abe-8f71-ca46a84971f6", 0, "c563332c-5b2b-4ef8-a7e6-5baea4463957", "truongtuantu@gmail.com", true, "Tú", "Trương Tuấn", false, null, "TRUONGTUANTU@GMAIL.COM", "TRUONGTUANTU@GMAIL.COM", "AQAAAAEAACcQAAAAEKLjKmBNBqVqV1sX8bQC1B3jgI71/+wIWQZB2XPBHXJ9k1wqRvcTz9p8aaF7Boi6+w==", null, false, "", false, "truongtuantu@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "23239ef2-32da-4ffc-832c-82c0f69a1de5", "da204e4e-bf84-4176-9ca3-58015ef566ce" },
                    { "5dc0e841-8f37-4561-8a78-d00ce2c8dfe4", "b4813a18-07ab-42c2-9521-cef27f465941" },
                    { "d4f250f4-78b5-497c-bfb9-013daf1c7d84", "61a0235c-df7e-4dda-9447-1fe0d366ceb0" },
                    { "a8480f97-5c0d-4f04-8699-ec0ac26b4470", "61a0235c-df7e-4dda-9447-1fe0d366ceb0" },
                    { "e1f79184-5fed-4732-bc70-176ea8c73aba", "61a0235c-df7e-4dda-9447-1fe0d366ceb0" },
                    { "03dfe6af-b601-4130-9b2f-9aa4ee45b884", "abc073e4-7b42-4a65-874c-695e3ae8a383" },
                    { "08c9dfab-ffd8-495c-b248-63751f0128f0", "abc073e4-7b42-4a65-874c-695e3ae8a383" },
                    { "7208c6e1-30db-4540-87e3-0a8831011180", "b4813a18-07ab-42c2-9521-cef27f465941" },
                    { "ed3290c0-fc5c-4a29-a5e1-18ab332bfd13", "66f013e9-b7e7-4be1-88d5-d97f06ff10c1" },
                    { "31bfaf48-4924-4784-b06c-99ae785b4862", "66f013e9-b7e7-4be1-88d5-d97f06ff10c1" },
                    { "6de7fe1f-bdf7-41d4-8ab4-8bf336f985bb", "66f013e9-b7e7-4be1-88d5-d97f06ff10c1" },
                    { "1b7a4c8b-c242-4fa3-9e7c-3b102442c1fb", "66f013e9-b7e7-4be1-88d5-d97f06ff10c1" },
                    { "e5df56c3-7b66-469d-a4a4-035c4b0de3f2", "66f013e9-b7e7-4be1-88d5-d97f06ff10c1" },
                    { "4eed3b27-b9a4-4662-81fd-af2a2d92114c", "66f013e9-b7e7-4be1-88d5-d97f06ff10c1" },
                    { "eba7cfc6-17b5-4ca4-b6f7-db6156bc8b1b", "bfcd3af8-0515-4ea6-b562-d861be26e3fa" },
                    { "415c76aa-9183-4cda-b658-41159171e49a", "66f013e9-b7e7-4be1-88d5-d97f06ff10c1" },
                    { "42400983-91ac-4abe-8f71-ca46a84971f6", "b4813a18-07ab-42c2-9521-cef27f465941" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ProductUnits_Products_ProductId",
                table: "ProductUnits",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ProductUnits_Products_ProductId",
                table: "ProductUnits");

            migrationBuilder.DropPrimaryKey(
                name: "PK_ProductUnits",
                table: "ProductUnits");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "03dfe6af-b601-4130-9b2f-9aa4ee45b884", "abc073e4-7b42-4a65-874c-695e3ae8a383" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "08c9dfab-ffd8-495c-b248-63751f0128f0", "abc073e4-7b42-4a65-874c-695e3ae8a383" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "1b7a4c8b-c242-4fa3-9e7c-3b102442c1fb", "66f013e9-b7e7-4be1-88d5-d97f06ff10c1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "23239ef2-32da-4ffc-832c-82c0f69a1de5", "da204e4e-bf84-4176-9ca3-58015ef566ce" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "31bfaf48-4924-4784-b06c-99ae785b4862", "66f013e9-b7e7-4be1-88d5-d97f06ff10c1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "415c76aa-9183-4cda-b658-41159171e49a", "66f013e9-b7e7-4be1-88d5-d97f06ff10c1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "42400983-91ac-4abe-8f71-ca46a84971f6", "b4813a18-07ab-42c2-9521-cef27f465941" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "4eed3b27-b9a4-4662-81fd-af2a2d92114c", "66f013e9-b7e7-4be1-88d5-d97f06ff10c1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "5dc0e841-8f37-4561-8a78-d00ce2c8dfe4", "b4813a18-07ab-42c2-9521-cef27f465941" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "6de7fe1f-bdf7-41d4-8ab4-8bf336f985bb", "66f013e9-b7e7-4be1-88d5-d97f06ff10c1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "7208c6e1-30db-4540-87e3-0a8831011180", "b4813a18-07ab-42c2-9521-cef27f465941" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "a8480f97-5c0d-4f04-8699-ec0ac26b4470", "61a0235c-df7e-4dda-9447-1fe0d366ceb0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "d4f250f4-78b5-497c-bfb9-013daf1c7d84", "61a0235c-df7e-4dda-9447-1fe0d366ceb0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "e1f79184-5fed-4732-bc70-176ea8c73aba", "61a0235c-df7e-4dda-9447-1fe0d366ceb0" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "e5df56c3-7b66-469d-a4a4-035c4b0de3f2", "66f013e9-b7e7-4be1-88d5-d97f06ff10c1" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "eba7cfc6-17b5-4ca4-b6f7-db6156bc8b1b", "bfcd3af8-0515-4ea6-b562-d861be26e3fa" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "UserId", "RoleId" },
                keyValues: new object[] { "ed3290c0-fc5c-4a29-a5e1-18ab332bfd13", "66f013e9-b7e7-4be1-88d5-d97f06ff10c1" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "61a0235c-df7e-4dda-9447-1fe0d366ceb0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "66f013e9-b7e7-4be1-88d5-d97f06ff10c1");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "abc073e4-7b42-4a65-874c-695e3ae8a383");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b4813a18-07ab-42c2-9521-cef27f465941");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bfcd3af8-0515-4ea6-b562-d861be26e3fa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "da204e4e-bf84-4176-9ca3-58015ef566ce");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "03dfe6af-b601-4130-9b2f-9aa4ee45b884");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "08c9dfab-ffd8-495c-b248-63751f0128f0");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1b7a4c8b-c242-4fa3-9e7c-3b102442c1fb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "23239ef2-32da-4ffc-832c-82c0f69a1de5");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31bfaf48-4924-4784-b06c-99ae785b4862");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "415c76aa-9183-4cda-b658-41159171e49a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "42400983-91ac-4abe-8f71-ca46a84971f6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4eed3b27-b9a4-4662-81fd-af2a2d92114c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5dc0e841-8f37-4561-8a78-d00ce2c8dfe4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6de7fe1f-bdf7-41d4-8ab4-8bf336f985bb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "7208c6e1-30db-4540-87e3-0a8831011180");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a8480f97-5c0d-4f04-8699-ec0ac26b4470");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d4f250f4-78b5-497c-bfb9-013daf1c7d84");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e1f79184-5fed-4732-bc70-176ea8c73aba");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e5df56c3-7b66-469d-a4a4-035c4b0de3f2");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "eba7cfc6-17b5-4ca4-b6f7-db6156bc8b1b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ed3290c0-fc5c-4a29-a5e1-18ab332bfd13");

            migrationBuilder.RenameTable(
                name: "ProductUnits",
                newName: "ProductUnit");

            migrationBuilder.RenameIndex(
                name: "IX_ProductUnits_ProductId",
                table: "ProductUnit",
                newName: "IX_ProductUnit_ProductId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ProductUnit",
                table: "ProductUnit",
                column: "Id");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "c834b8e1-0007-484a-9130-4a2da17b7751", "a2584fd1-5b34-4aa7-8d2f-8429febacbab", "Admin", "admin" },
                    { "b76626a7-1386-42c3-a168-5e494c3afdcf", "e1172a33-84db-4d4d-a0ab-36acafe52244", "Sale", "sale" },
                    { "189b958a-daba-486d-afeb-b66faf815f3d", "d0828e75-02ad-4cf5-b7ff-a06c61a0e68f", "SuperAdmin", "superadmin" },
                    { "96bec076-866e-4f01-8490-1ee3490f34aa", "06241a3a-d551-46a0-abce-b0f939b21168", "WarehouseKeeperManager", "warehousekeepermanager" },
                    { "b9f09031-e8e0-4d91-bbe5-41b29b3e2f86", "8c5d59b2-d612-41ef-942e-b6dc51a9c016", "WarehouseKeeper", "warehousekeeper" },
                    { "a08d8517-1f01-45b9-9700-0609323e2334", "5aa98588-072e-44c1-959f-86b720e84f0d", "Customer", "customer" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "29c4d224-9ce6-4555-b58c-ddc5269f1e73", 0, "d5086605-79c4-4a5a-b337-d84d0c746975", "phungthanhdo@gmail.com", true, "Độ", "Phùng Thanh", false, null, "PHUNGTHANHDO@GMAIL.COM", "PHUNGTHANHDO@GMAIL.COM", "AQAAAAEAACcQAAAAEIpRNugXlWDI+kvUJmlkHAy16b84eIJE7fxSgiiwp8tNPy0oABk3HnzgmOG5xOvPaw==", null, false, "", false, "phungthanhdo@gmail.com" },
                    { "1dc4f675-c3e2-4418-8841-aef023c7e628", 0, "23a06ec3-53bc-4bb6-8c6c-3243e2dc43d8", "nguyenhue@gmail.com", true, "Huệ", "Nguyễn", false, null, "NGUYENHUE@GMAIL.COM", "NGUYENHUE@GMAIL.COM", "AQAAAAEAACcQAAAAEPm9E7cldDSoZcutuhwPEg/khYNjNRXnT+eQvda6Ygxmou9vah8+sH7O+/gDKqF+HA==", null, false, "", false, "nguyenhue@gmail.com" },
                    { "de40550f-5a2d-43dd-bb6e-74f0d9555d16", 0, "403823ac-3e7a-468d-9408-fbe67c778942", "hoxuanhuong@gmail.com", true, "Hương", "Hồ Xuân", false, null, "HOXUANHUONG@GMAIL.COM", "HOXUANHUONG@GMAIL.COM", "AQAAAAEAACcQAAAAEIWB0cuxtT8T7cL9uR9dqKPqqNeteHDlNKIiEJIP/1jnfBcaS5On4wevuSAijcWA2Q==", null, false, "", false, "hoxuanhuong@gmail.com" },
                    { "96b91bae-5bae-40b9-a240-c8bb3cf7ebef", 0, "7266c960-7e94-484b-b669-e6a5d268cfaf", "nguyenthanhlong@gmail.com", true, "Long", "Nguyễn Thành", false, null, "NGUYENTHANHLONG@GMAIL.COM", "NGUYENTHANHLONG@GMAIL.COM", "AQAAAAEAACcQAAAAEMNzXUYXbcVDdt/rrRENydqugcWOxYpYzaEowxIJucwOmH+5c8o3tgPAShP/jD7y0A==", null, false, "", false, "nguyenthanhlong@gmail.com" },
                    { "c7a5d61e-bbf8-41d9-ac02-56fb9d58fb45", 0, "10b67fe1-175b-406e-8e5d-1cffc62ba337", "huynhtranthanh@gmail.com", true, "Thành", "Huỳnh Trấn", false, null, "HUYNHTRANTHANH@GMAIL.COM", "HUYNHTRANTHANH@GMAIL.COM", "AQAAAAEAACcQAAAAECdoGXoKakMDINFud1q6wO+i1jibnWpV26eHbbcb2BNfjArLkLAGHTEFqpA6S7hLGQ==", null, false, "", false, "huynhtranthanh@gmail.com" },
                    { "5d185e71-9081-4f7d-a791-7481c5fec01f", 0, "ae76deb1-61e2-4f86-bd3c-f11338d6b294", "caobaquat@gmail.com", true, "Quát", "Cao Bá", false, null, "CAOBAQUAT@GMAIL.COM", "CAOBAQUAT@GMAIL.COM", "AQAAAAEAACcQAAAAEC5mbmkmos5ddtUr4TownhMeN78XMGW3YA1KhidydElr3FB51LH4AbzIPgRyxyNDdg==", null, false, "", false, "caobaquat@gmail.com" },
                    { "c3ed21d3-4ca4-4375-9fd6-6de885e4fc8c", 0, "d79425d4-d3db-41ba-8e78-e9ccf9fa82c8", "truongthitramanh@gmail.com", true, "Anh", "Trương Thị Trâm", false, null, "TRUONGTHITRAMANH@GMAIL.COM", "TRUONGTHITRAMANH@GMAIL.COM", "AQAAAAEAACcQAAAAEFFwZPpQSPZiTvVkL+5P+Srgq2TCmMvc62VK0PA/jkhRAeZK+FCqSn8TOPx51YlnfA==", null, false, "", false, "truongthitramanh@gmail.com" },
                    { "75d00dc7-5651-4453-93f7-d0ca11550a17", 0, "0647c871-fccc-48f9-8ce4-b9a0adc48c70", "nguyennhuloc@gmail.com", true, "Lộc", "Nguyễn Như", false, null, "NGUYENNHULOC@GMAIL.COM", "NGUYENNHULOC@GMAIL.COM", "AQAAAAEAACcQAAAAEO6iQl0jUtSO3yIQptCLMtcNFHhc4iXgKdOky4ERyqAV/IUyAxxi7b+v9P0iV97xLQ==", null, false, "", false, "nguyennhuloc@gmail.com" },
                    { "b8b33a02-ef0f-4e29-84b8-7ac86bf1785a", 0, "133fc9ef-569b-47c9-9466-62004c8d6126", "caothivananh@gmail.com", true, "Anh", "Cao Thị Vân", false, null, "CAOTHIVANANH@GMAIL.COM", "CAOTHIVANANH@GMAIL.COM", "AQAAAAEAACcQAAAAECWR/4Knf+8ORHBZoB03N0LAVJ0dKaAyBCCHLdIoE2nAvTwwHAhTM0GckSpHZaoO8g==", null, false, "", false, "caothivananh@gmail.com" },
                    { "55627df7-d2e9-483f-8293-ddaef8f65cc2", 0, "24a62e3b-6736-4a97-ad2d-b57199302f40", "phantantrung@gmail.com", true, "Trung", "Phan Tấn", false, null, "PHANTANTRUNG@GMAIL.COM", "PHANTANTRUNG@GMAIL.COM", "AQAAAAEAACcQAAAAEPOp1ckjtBmGCaY1mim2bQhnT3LrwCgdICrlSCT/iwZHN41jfFYD8HzaaMeYwjEH+A==", null, false, "", false, "phantantrung@gmail.com" },
                    { "4d86e23d-b493-4fac-92d0-b9855debc4e9", 0, "7c31b0ef-87b8-42c8-b885-30fec09202f6", "nguyentrunghieu@gmail.com", true, "Hiếu", "Nguyễn Trung", false, null, "NGUYENTRUNGHIEU@GMAIL.COM", "NGUYENTRUNGHIEU@GMAIL.COM", "AQAAAAEAACcQAAAAEAXeD+Eacm3/Y7zrArsqq5Xwqoi1GgyPOeO9F+AS1/7UH2r8RiskSjVxY8DziML1xQ==", null, false, "", false, "nguyentrunghieu@gmail.com" },
                    { "fed18e67-86c2-4c7f-8cb9-13aeb2da490b", 0, "669faf52-db9b-4585-99ac-cf026bcb0390", "phamvinhson@gmail.com", true, "Sơn", "Phạm Vĩnh", false, null, "PHAMVINHSON@GMAIL.COM", "PHAMVINHSON@GMAIL.COM", "AQAAAAEAACcQAAAAEDGDLEf8sgua8sDRISqMla1iUtlF2VhN3UOP7y4RkBAG50ZXa4QT5f2qp4j7n4wcGA==", null, false, "", false, "phamvinhson@gmail.com" },
                    { "acdc5a84-7426-4109-abe8-488ed3d7e250", 0, "d1ebca70-4986-424a-a507-2aba6bfc8323", "trankieuloan@gmail.com", true, "Loan", "Trần Kiều", false, null, "TRANKIEULOAN@GMAIL.COM", "TRANKIEULOAN@GMAIL.COM", "AQAAAAEAACcQAAAAEGHL+z4eW6iX3Ah4bde6s9djam+r2KEnD8mTAFekjNMnk5UQAikeCUo6y+8DtkVn4w==", null, false, "", false, "trankieuloan@gmail.com" },
                    { "8e84c837-3c26-402e-8aa1-58e356640cdc", 0, "d525f962-814c-41ae-877f-7bfb911a6e92", "yungadmin@gmail.com", true, "Admin", "Yung", false, null, "YUNGADMIN@GMAIL.COM", "YUNGADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEO5oyf+kKU9igLC2ImbjmJSDUZoys1IAjDVsF7yKf56Eb7BAbIZplXlndjEc0zL35g==", null, false, "", false, "yungadmin@gmail.com" },
                    { "e26529e9-980a-431f-823b-f77996f574f9", 0, "b2204c66-186b-4b7a-8c49-183a3ad01fe7", "lilsuperadmin@gmail.com", true, "Super Admin", "Lil", false, null, "LILSUPERADMIN@GMAIL.COM", "LILSUPERADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAECiwxjZ36WCEvqZCw+0N/mjaDpeMdVcrzGLBpWbEsBGmY7tSwrxWdUYWR5E8r8uNlg==", null, false, "", false, "lilsuperadmin@gmail.com" },
                    { "2e04737e-9968-40a7-ad41-eccbc74217e2", 0, "58314498-c983-464b-b361-c984854d2eb9", "tranthaonguyen@gmail.com", true, "Nguyên", "Trần Thảo", false, null, "TRANTHAONGUYEN@GMAIL.COM", "TRANTHAONGUYEN@GMAIL.COM", "AQAAAAEAACcQAAAAEHSu8fwB1VjJMMNPERwYS0shKxPcbl3ZLQh/7RWwp17RdfxwdLxoBLPw0cOliElsxQ==", null, false, "", false, "tranthaonguyen@gmail.com" },
                    { "f604ba7b-d6e7-4c15-9067-4e6171bd60bc", 0, "3f7f0989-a1e9-427b-bd03-aeee4d50eb60", "truongtuantu@gmail.com", true, "Tú", "Trương Tuấn", false, null, "TRUONGTUANTU@GMAIL.COM", "TRUONGTUANTU@GMAIL.COM", "AQAAAAEAACcQAAAAECdCkHomqV6RXpfYAqGwd/62gN6SYzra1Oj39ssLqDJ1UBEA44fQwxp62bh5can7xQ==", null, false, "", false, "truongtuantu@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "UserId", "RoleId" },
                values: new object[,]
                {
                    { "e26529e9-980a-431f-823b-f77996f574f9", "189b958a-daba-486d-afeb-b66faf815f3d" },
                    { "29c4d224-9ce6-4555-b58c-ddc5269f1e73", "b76626a7-1386-42c3-a168-5e494c3afdcf" },
                    { "1dc4f675-c3e2-4418-8841-aef023c7e628", "b9f09031-e8e0-4d91-bbe5-41b29b3e2f86" },
                    { "de40550f-5a2d-43dd-bb6e-74f0d9555d16", "b9f09031-e8e0-4d91-bbe5-41b29b3e2f86" },
                    { "96b91bae-5bae-40b9-a240-c8bb3cf7ebef", "b9f09031-e8e0-4d91-bbe5-41b29b3e2f86" },
                    { "c7a5d61e-bbf8-41d9-ac02-56fb9d58fb45", "96bec076-866e-4f01-8490-1ee3490f34aa" },
                    { "5d185e71-9081-4f7d-a791-7481c5fec01f", "96bec076-866e-4f01-8490-1ee3490f34aa" },
                    { "55627df7-d2e9-483f-8293-ddaef8f65cc2", "b76626a7-1386-42c3-a168-5e494c3afdcf" },
                    { "c3ed21d3-4ca4-4375-9fd6-6de885e4fc8c", "a08d8517-1f01-45b9-9700-0609323e2334" },
                    { "b8b33a02-ef0f-4e29-84b8-7ac86bf1785a", "a08d8517-1f01-45b9-9700-0609323e2334" },
                    { "75d00dc7-5651-4453-93f7-d0ca11550a17", "a08d8517-1f01-45b9-9700-0609323e2334" },
                    { "4d86e23d-b493-4fac-92d0-b9855debc4e9", "a08d8517-1f01-45b9-9700-0609323e2334" },
                    { "fed18e67-86c2-4c7f-8cb9-13aeb2da490b", "a08d8517-1f01-45b9-9700-0609323e2334" },
                    { "acdc5a84-7426-4109-abe8-488ed3d7e250", "a08d8517-1f01-45b9-9700-0609323e2334" },
                    { "8e84c837-3c26-402e-8aa1-58e356640cdc", "c834b8e1-0007-484a-9130-4a2da17b7751" },
                    { "2e04737e-9968-40a7-ad41-eccbc74217e2", "a08d8517-1f01-45b9-9700-0609323e2334" },
                    { "f604ba7b-d6e7-4c15-9067-4e6171bd60bc", "b76626a7-1386-42c3-a168-5e494c3afdcf" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_ProductUnit_Products_ProductId",
                table: "ProductUnit",
                column: "ProductId",
                principalTable: "Products",
                principalColumn: "Id");
        }
    }
}
