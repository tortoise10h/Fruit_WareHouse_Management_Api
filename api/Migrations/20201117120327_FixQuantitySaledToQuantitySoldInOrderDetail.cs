using Microsoft.EntityFrameworkCore.Migrations;

namespace api.Migrations
{
    public partial class FixQuantitySaledToQuantitySoldInOrderDetail : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuantitySaled",
                table: "OrderDetails");

            migrationBuilder.AddColumn<double>(
                name: "QuantitySold",
                table: "OrderDetails",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "423e498c-fc67-4853-ac4f-f3cd91d32e87",
                column: "ConcurrencyStamp",
                value: "3c129be8-107a-4cd1-8f22-e9c5ad2cc6c5");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6665ddaa-72f9-4f90-a6b1-43eb68dea610",
                column: "ConcurrencyStamp",
                value: "e7f96006-0ebc-43f4-99bd-726527606c0c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6b30cb05-12f7-46c2-b95f-8d783c1f9eb1",
                column: "ConcurrencyStamp",
                value: "e5736ffc-7a8f-4d30-882b-86fc151e4260");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "78c5228f-f600-4545-abcd-f4cc21d18e4c",
                column: "ConcurrencyStamp",
                value: "e277a285-925d-43b9-8189-03e073d4eed7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b979036b-d165-4bea-b6b6-16b22a3f54dd",
                column: "ConcurrencyStamp",
                value: "ee0d6eb0-00f0-4be2-8cc3-e5de08a7929d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c2d4b743-d9da-443c-9f5a-c2682750c805",
                column: "ConcurrencyStamp",
                value: "0ff646fa-bfab-4edb-b3b7-8f3046814039");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc2a0eb3-8736-441d-9130-5b421db3ac0e",
                column: "ConcurrencyStamp",
                value: "0409507a-f945-42e4-afed-8dada644a5b7");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "08b84a20-7e7d-4353-bb53-74c79732beed",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5b54ba0b-178e-43bf-9b20-5131ada53ae8", "AQAAAAEAACcQAAAAEJlFMKRmq2sKgQu7CpU6k3HMxER+HeOZQcAt7gQQ+fGIRCHAeX3l1RE/7UHyZTwWwg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "308da0db-e863-4814-8930-de3540e5406d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "49ae2c97-2bad-4456-b0b8-387fb5e452e8", "AQAAAAEAACcQAAAAEEMxm36i0snqQKWbOLL7uKAuutjz3F2DfhkgKEnhpmuyCp6Uj2BCPN0YWWU8nbmw4Q==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39b465e2-c398-494f-bb62-d1eb02aa5471",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "01b83258-93f7-407d-8256-d4aa79d1c748", "AQAAAAEAACcQAAAAEAJm6KR7LfB8LtTsq+YixUmE3qVmfYiU3Uj5FlhwDN/BpyRoThaLs+pLmdZGnHyrYw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a6a1f70-8f67-4f8a-b1f9-267e5d621edb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2595e0a9-3cc8-46a2-b0f0-8ba3aab81be7", "AQAAAAEAACcQAAAAEF38c5Y/sI/TyIx5ar5XbrHQHfv1EXHmKULUy0NMmVATsZl/4iHu5Cf9rILPxWcHdg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b488e0f-eb92-4994-a555-cbe4ecdf3672",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1959955b-5507-44c9-933b-b89406caf9fa", "AQAAAAEAACcQAAAAEHKnfjJSAQooZLECIcVx9N9di/WKPsbKdwaQsdB9VKxq002pJkjpbyyxP28sTl/zLw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "52999f6b-a605-45b0-b98f-b8880fc46027",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7a034757-46e4-426b-8bae-94a0587d17d5", "AQAAAAEAACcQAAAAEDnpesYzKeKQI0iyza18vxxC2e1LlJgdk82zmRzBRQMwMz5KlSTCOY0s0xzA21w62A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57b2db13-1d08-48a4-adca-41d837bb8937",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2c0c3fab-1b43-478c-8461-a9ab682137e3", "AQAAAAEAACcQAAAAELNLdTzSTPF2IKhk9ARzmb2rjsJmMQysGAYjon48d8MtPgtVcYIwcXK2bIg3IjnEOA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5ce20f05-c625-43fc-ae25-a7514e9520db",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "bb133673-af10-4fa1-9514-e59b42ff9917", "AQAAAAEAACcQAAAAEKdQ1OvB3l064X4t+24gESuIOu53Exql5+Ha5BvO15fYvo/flIHqo7D59NB+gwY2Jw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f8ce951-2f66-4a9e-a4fa-7a14f85b54c6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e7842739-0206-4ca7-9f94-90b0a957bf28", "AQAAAAEAACcQAAAAEDPmvBNa5sNJvqHQm9GURTVMAQtBGX0HleO3ISG7Wd50V3AGO7nJyzFjIR+Q2lN2Wg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "927e4f6a-62ed-4e13-b002-7e133eb47bbc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "cb5301c2-bf22-48b2-b276-b93abc82d03a", "AQAAAAEAACcQAAAAEFv5juw77Ahi8DGhVMZcKomuqd2DEs+kk1nFWnCV5tK7uSXElNLIdwde8K0o0fT9Sg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a0c9e67b-d593-4a56-93cd-063ec5d5d035",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "2dc70567-6b2f-4a14-9fb7-316b7636c087", "AQAAAAEAACcQAAAAEGb0jpmF21hZ6tWAdWw+pPb0YZOxKOs3eQjeV4ANigpA+N4ALyOzLuGYmZIYlgB5pw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b6256340-7bd0-4373-8549-c6a08053396b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b9b4157a-eedb-4f7a-9ea1-2b3848420a9d", "AQAAAAEAACcQAAAAEKfOKCJXVeAcOQrNybxT2O2ftcVaHm73rRCiCcZGabeQsIu0J3Z8VSI2JYnsRFR4yA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ce4b2f5c-1fb9-4fe1-945c-20eca474ce16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "45988cd7-dfbc-4d5b-8e6f-020df254fc9a", "AQAAAAEAACcQAAAAEPjKJXqr6vvAmkK3nRed+3zEggzojKSNm8CV6uzDbQUPaVi6a1HcUg6C7hrq52YtRw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e7610feb-110c-47d0-9a88-1bfdc12742a4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b5f048b9-b537-4890-ac1d-bf9025c93cba", "AQAAAAEAACcQAAAAEOcSViQrF1izNbX30MHdY0/eB2vmPM/TP/Q5RXMzWcbDrticsW/eiEGNkSYAl+uurg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9012ef1-cd3c-49a1-8726-7f8f8aba9f98",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "84920ef5-74eb-4bfe-affd-2b80b8ee85d0", "AQAAAAEAACcQAAAAEI3w6Dlbi8zWZANSlA8RF+nABHmpYrko4ihttxnzFoL0Ak+7Ufo8vUw7583RhSK3Jg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd4fd02a-238d-4efc-a187-14d205a841f0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7a36df5c-688c-4e56-abe7-b1adf58cf18d", "AQAAAAEAACcQAAAAEPIuVuYlaiQCD4zot612CIipLEzSpC5K1P7YbfDIfFSSjjjC3aLf/4GTipEf/zx1kg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd9a7449-e604-48c1-a638-c564e17c1bc0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "966eb701-cfd3-4d9b-8ace-20e0f208518f", "AQAAAAEAACcQAAAAEAPcuiZ7hOjZyN7X+vwlprKPhkRDFW8tgnABVF/mOFR8Ch50ztTisaUjklObPSnbzw==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuantitySold",
                table: "OrderDetails");

            migrationBuilder.AddColumn<double>(
                name: "QuantitySaled",
                table: "OrderDetails",
                type: "float",
                nullable: false,
                defaultValue: 0.0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "423e498c-fc67-4853-ac4f-f3cd91d32e87",
                column: "ConcurrencyStamp",
                value: "be9cd960-8e24-4af9-be0f-31f8ccbd2849");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6665ddaa-72f9-4f90-a6b1-43eb68dea610",
                column: "ConcurrencyStamp",
                value: "b3d2bccd-be02-4975-af8a-adfbb245c311");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6b30cb05-12f7-46c2-b95f-8d783c1f9eb1",
                column: "ConcurrencyStamp",
                value: "2e6789f2-8d53-4045-9361-1454b9e8e723");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "78c5228f-f600-4545-abcd-f4cc21d18e4c",
                column: "ConcurrencyStamp",
                value: "55ae6458-d265-4897-b732-d78794ccfa07");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b979036b-d165-4bea-b6b6-16b22a3f54dd",
                column: "ConcurrencyStamp",
                value: "13c34189-5eec-45f0-a0df-b4778274f273");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c2d4b743-d9da-443c-9f5a-c2682750c805",
                column: "ConcurrencyStamp",
                value: "904c533e-a442-42f9-a75f-b10699599894");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "cc2a0eb3-8736-441d-9130-5b421db3ac0e",
                column: "ConcurrencyStamp",
                value: "28d7957c-9404-426e-81c9-0447e8b2e26f");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "08b84a20-7e7d-4353-bb53-74c79732beed",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e3edc087-e2a7-4717-8897-6166a13ffaf0", "AQAAAAEAACcQAAAAEPI8dKfMgUEZeOXMYYjqZd+k2INDNOWLTg0W3TR19PdL+o/wzOVSJkwKaleDKFZoxQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "308da0db-e863-4814-8930-de3540e5406d",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5a8a38cc-da40-423a-9028-8faa6885399c", "AQAAAAEAACcQAAAAEGBhM76+OYrUK/BOQgtyMzOlW8URD3Yy3+q6ZdDhIR6WCqw7VPMW594xOlN43R6zWw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39b465e2-c398-494f-bb62-d1eb02aa5471",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b147e10d-6081-4a1a-af28-de0ac5d21491", "AQAAAAEAACcQAAAAEB5MALUDXmnVlK28FIiZYBlBGLCGTc7u5Gt8R2uRjZGKYThQk+7NYKuPEr1AzJy6Gw==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3a6a1f70-8f67-4f8a-b1f9-267e5d621edb",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "4c16662a-ea58-4b1d-803b-f81b2e097824", "AQAAAAEAACcQAAAAEHTgTsaUyjyXcAHcuSsN2ykg958QRWnjr2I+b5pWoVtLorXR2L1zXboXr1zIkEvDUg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3b488e0f-eb92-4994-a555-cbe4ecdf3672",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "a7e13e99-186f-4446-beb3-c07f0d2250c7", "AQAAAAEAACcQAAAAEK0iVbt8BM5A6CtTPDPme5HqHRak4Os1r2vKg8sx2msTsRT8TiGgif4JAzpZ1bap6g==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "52999f6b-a605-45b0-b98f-b8880fc46027",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ed9153d4-d806-4404-9336-dbdeab8605f4", "AQAAAAEAACcQAAAAEH21AKjAjoO1nVitdCFlLzDhrzBUH45J5JRFMwt0Jb2clXNlIPqLLpyCU+augunsOQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "57b2db13-1d08-48a4-adca-41d837bb8937",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ad70dbba-4a70-487d-826d-9ebf4c2690b6", "AQAAAAEAACcQAAAAEB74GAbfbNnJeeZ6IlquomQZql3b2FQvoVeJYRhG9rLwBG5PwzFs/qpG752Rbmp22A==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5ce20f05-c625-43fc-ae25-a7514e9520db",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3a9b1d48-7d19-40f0-bb4a-a988a1a0937d", "AQAAAAEAACcQAAAAEBnfypzIDAhKfo8n9O1CP70lf2Nm3tDlgsKtIqr7CWuyRVqh9o8K8PdSV5OPi5YrUQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6f8ce951-2f66-4a9e-a4fa-7a14f85b54c6",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c4b2e3b7-d906-45a5-b4f9-480bedbccaf7", "AQAAAAEAACcQAAAAEFU8SM24e2SQ+Ne+7rDLwxr7NDMOSZYRX6ndE8+D/uRMmOMDaq5+R6vQksknTsrjCA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "927e4f6a-62ed-4e13-b002-7e133eb47bbc",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "5c0c07fe-f461-43e1-8a1b-9a512f2c5e2d", "AQAAAAEAACcQAAAAEAN9Un9DKxbGxNYLX4pJVfI9KRbZpYQKsFzezxUZeJ3DSOcnxiV6+MNYznvMZCBlFQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a0c9e67b-d593-4a56-93cd-063ec5d5d035",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7e0290bf-650c-489c-87ed-8b9a3399d140", "AQAAAAEAACcQAAAAEAfY1Q+8DE4ApfbviOHOS2GD6c13/g+snLbDNYyxb1r++Ag3fvCfVruDNGIwq9cCLg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b6256340-7bd0-4373-8549-c6a08053396b",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3474d7f7-82bd-4979-acd3-274305136a3b", "AQAAAAEAACcQAAAAEDETWmcT5uSJ6GAoOPq5LnDdLvh2eC2f+eY2ugVdGwVI5JUw8EvE8g1E4MQoORZiAg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ce4b2f5c-1fb9-4fe1-945c-20eca474ce16",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "9f8599b6-282d-412e-93a1-84d0b87b304a", "AQAAAAEAACcQAAAAEAQW4IXBinarLIAfzyI8X+hrwP55TPsOkjL3JuPfEzmG9nwuApVFsSqChfZzhsE+1w==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e7610feb-110c-47d0-9a88-1bfdc12742a4",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "21c84d05-3644-4a7a-816d-ff96b1381f53", "AQAAAAEAACcQAAAAEJ3WZTIeTxH3IWjwgj7E9gDlXOtd+QPaddilzwfiBtadDgzWiBTdgFmWflr0QyaDqg==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e9012ef1-cd3c-49a1-8726-7f8f8aba9f98",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "dd39af78-9e17-4931-af09-9476d1a5617a", "AQAAAAEAACcQAAAAEBFTRjapHYleq0sVLeYaAMKPTjKlAnJfg0UaQ3qAUs+ol6Bl8x2ff2fJm3kuVBPRYA==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd4fd02a-238d-4efc-a187-14d205a841f0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b4dce1ae-8c9f-4846-9b6d-4d4dc0dfda80", "AQAAAAEAACcQAAAAEPzksovUL+hZAA6k06WKJHjIa4ckMw1pojWVR38Jhq0v0CEhMXUrqeR+ZasiQIk6iQ==" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "fd9a7449-e604-48c1-a638-c564e17c1bc0",
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0eae5ebc-552a-4f05-aa74-4822045d4372", "AQAAAAEAACcQAAAAELMhVKuj++RTKq/PIPxrH/UrPh/HEx6UE7GO5Ps8KbNW7fSaz1laeO77f48znkuCXg==" });
        }
    }
}
