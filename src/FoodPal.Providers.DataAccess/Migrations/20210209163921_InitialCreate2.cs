using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodPal.Providers.DataAccess.Migrations
{
    public partial class InitialCreate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CatalogueItemCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 2, 9, 18, 39, 19, 963, DateTimeKind.Local).AddTicks(7724));

            migrationBuilder.UpdateData(
                table: "CatalogueItemCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 2, 9, 18, 39, 19, 963, DateTimeKind.Local).AddTicks(8437));

            migrationBuilder.UpdateData(
                table: "CatalogueItemCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 2, 9, 18, 39, 19, 963, DateTimeKind.Local).AddTicks(8456));

            migrationBuilder.UpdateData(
                table: "CatalogueItemCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 2, 9, 18, 39, 19, 963, DateTimeKind.Local).AddTicks(8462));

            migrationBuilder.UpdateData(
                table: "ProviderCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 2, 9, 18, 39, 19, 951, DateTimeKind.Local).AddTicks(7367));

            migrationBuilder.UpdateData(
                table: "ProviderCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 2, 9, 18, 39, 19, 961, DateTimeKind.Local).AddTicks(5941));

            migrationBuilder.UpdateData(
                table: "ProviderCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 2, 9, 18, 39, 19, 961, DateTimeKind.Local).AddTicks(6015));

            migrationBuilder.UpdateData(
                table: "ProviderCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 2, 9, 18, 39, 19, 961, DateTimeKind.Local).AddTicks(6026));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CatalogueItemCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 2, 9, 16, 22, 13, 515, DateTimeKind.Local).AddTicks(1254));

            migrationBuilder.UpdateData(
                table: "CatalogueItemCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 2, 9, 16, 22, 13, 515, DateTimeKind.Local).AddTicks(1988));

            migrationBuilder.UpdateData(
                table: "CatalogueItemCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 2, 9, 16, 22, 13, 515, DateTimeKind.Local).AddTicks(2000));

            migrationBuilder.UpdateData(
                table: "CatalogueItemCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 2, 9, 16, 22, 13, 515, DateTimeKind.Local).AddTicks(2004));

            migrationBuilder.UpdateData(
                table: "ProviderCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 2, 9, 16, 22, 13, 505, DateTimeKind.Local).AddTicks(3679));

            migrationBuilder.UpdateData(
                table: "ProviderCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 2, 9, 16, 22, 13, 513, DateTimeKind.Local).AddTicks(4137));

            migrationBuilder.UpdateData(
                table: "ProviderCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 2, 9, 16, 22, 13, 513, DateTimeKind.Local).AddTicks(4218));

            migrationBuilder.UpdateData(
                table: "ProviderCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 2, 9, 16, 22, 13, 513, DateTimeKind.Local).AddTicks(4226));
        }
    }
}
