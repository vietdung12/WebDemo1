using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebDemo.Data.Migrations
{
    public partial class SeedData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "926c5203-fee6-4c81-951b-30c0f6003099");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("bea0fa40-f9c9-4f04-85f7-165e527fbde5"),
                column: "ConcurrencyStamp",
                value: "f335e3fe-f4fe-42b2-b1fa-1684d1d97ec0");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("391f352a-c96e-4813-8220-e68c36f5a587"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6574048c-774e-460f-a482-a380c8329d3b", "AQAAAAEAACcQAAAAENQiOXT2hjUaYnpgJ1zgXTLamXCjymcbAO8Ki6fwHqVS+txfiXC7Ueky7YVYm0+0VA==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1cd6372f-7c3f-4a14-b533-44caef4ecab1", "AQAAAAEAACcQAAAAEJ+jWMYQJa9iRhgmcWmQhmw+93rvN+md9aABGQUXcKADGEUzCJjA+MWjvXiiBRu2xA==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Status",
                value: 1);

            migrationBuilder.InsertData(
                table: "Contacts",
                columns: new[] { "Id", "Email", "Name", "PhoneNumber", "Position", "Status" },
                values: new object[] { 1, "luongvietdung1212@gmail.com", "Dũng", 123456789, "Web Admin", 1 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "OrdersCount", "ViewCount" },
                values: new object[] { new DateTime(2020, 5, 20, 10, 57, 31, 105, DateTimeKind.Local).AddTicks(6394), 0, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "OrdersCount", "ViewCount" },
                values: new object[] { new DateTime(2020, 5, 20, 10, 57, 31, 106, DateTimeKind.Local).AddTicks(4486), 0, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "OrdersCount", "ViewCount" },
                values: new object[] { new DateTime(2020, 5, 20, 10, 57, 31, 106, DateTimeKind.Local).AddTicks(4513), 0, 0 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Contacts",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "47e6d25a-d787-43df-867a-a4f27e9aeda1");

            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("bea0fa40-f9c9-4f04-85f7-165e527fbde5"),
                column: "ConcurrencyStamp",
                value: "86b78518-6c0b-4a24-9121-595fe75eafbb");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("391f352a-c96e-4813-8220-e68c36f5a587"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "ca59d0ef-e155-4c7c-8f69-45cb0473d352", "AQAAAAEAACcQAAAAEGKoQ510iYXDdE9zEqPvFXd2bl1fZt/hQzFPnlFCnzslhoVZLP4H84dbxIQq0f37uQ==" });

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c4db9aae-2989-4b38-ad36-14d2b68e3c89", "AQAAAAEAACcQAAAAEG7j6xs7zOx2vPosRA0cu2EvHzbCG/+CZZmGut0VbtKoYI2vuFM8l+55Y2SU/n95xw==" });

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 1,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 2,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Categories",
                keyColumn: "Id",
                keyValue: 3,
                column: "Status",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "DateCreated", "OrdersCount", "ViewCount" },
                values: new object[] { new DateTime(2020, 5, 20, 10, 47, 17, 634, DateTimeKind.Local).AddTicks(4192), 0, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "DateCreated", "OrdersCount", "ViewCount" },
                values: new object[] { new DateTime(2020, 5, 20, 10, 47, 17, 635, DateTimeKind.Local).AddTicks(2658), 0, 0 });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "DateCreated", "OrdersCount", "ViewCount" },
                values: new object[] { new DateTime(2020, 5, 20, 10, 47, 17, 635, DateTimeKind.Local).AddTicks(2704), 0, 0 });
        }
    }
}
