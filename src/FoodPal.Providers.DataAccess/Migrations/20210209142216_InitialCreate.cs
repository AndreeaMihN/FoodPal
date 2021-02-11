using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodPal.Providers.DataAccess.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "CatalogueItemCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 2, 8, 21, 40, 46, 408, DateTimeKind.Local).AddTicks(7566));

            migrationBuilder.UpdateData(
                table: "CatalogueItemCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 2, 8, 21, 40, 46, 408, DateTimeKind.Local).AddTicks(8457));

            migrationBuilder.UpdateData(
                table: "CatalogueItemCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 2, 8, 21, 40, 46, 408, DateTimeKind.Local).AddTicks(8481));

            migrationBuilder.UpdateData(
                table: "CatalogueItemCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 2, 8, 21, 40, 46, 408, DateTimeKind.Local).AddTicks(8486));

            migrationBuilder.UpdateData(
                table: "ProviderCategory",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedOn",
                value: new DateTime(2021, 2, 8, 21, 40, 46, 400, DateTimeKind.Local).AddTicks(9824));

            migrationBuilder.UpdateData(
                table: "ProviderCategory",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedOn",
                value: new DateTime(2021, 2, 8, 21, 40, 46, 406, DateTimeKind.Local).AddTicks(6954));

            migrationBuilder.UpdateData(
                table: "ProviderCategory",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedOn",
                value: new DateTime(2021, 2, 8, 21, 40, 46, 406, DateTimeKind.Local).AddTicks(7044));

            migrationBuilder.UpdateData(
                table: "ProviderCategory",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedOn",
                value: new DateTime(2021, 2, 8, 21, 40, 46, 406, DateTimeKind.Local).AddTicks(7054));
        }
    }
}
