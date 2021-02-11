using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace FoodPal.Providers.DataAccess.Migrations
{
    public partial class SeedingDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "CatalogueItemCategory",
                columns: new[] { "Id", "CreatedOn", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 2, 8, 21, 40, 46, 408, DateTimeKind.Local).AddTicks(7566), "Dessert" },
                    { 2, new DateTime(2021, 2, 8, 21, 40, 46, 408, DateTimeKind.Local).AddTicks(8457), "Main Course" },
                    { 3, new DateTime(2021, 2, 8, 21, 40, 46, 408, DateTimeKind.Local).AddTicks(8481), "Soups" },
                    { 4, new DateTime(2021, 2, 8, 21, 40, 46, 408, DateTimeKind.Local).AddTicks(8486), "Apperitives" }
                });

            migrationBuilder.InsertData(
                table: "ProviderCategory",
                columns: new[] { "Id", "CreatedOn", "Name" },
                values: new object[,]
                {
                    { 1, new DateTime(2021, 2, 8, 21, 40, 46, 400, DateTimeKind.Local).AddTicks(9824), "Mediteranean Cousine" },
                    { 2, new DateTime(2021, 2, 8, 21, 40, 46, 406, DateTimeKind.Local).AddTicks(6954), "Tradinional Romanian Cousine" },
                    { 3, new DateTime(2021, 2, 8, 21, 40, 46, 406, DateTimeKind.Local).AddTicks(7044), "Japonese Cousine" },
                    { 4, new DateTime(2021, 2, 8, 21, 40, 46, 406, DateTimeKind.Local).AddTicks(7054), "Thai Cousine" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "CatalogueItemCategory",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "CatalogueItemCategory",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "CatalogueItemCategory",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "CatalogueItemCategory",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProviderCategory",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProviderCategory",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProviderCategory",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProviderCategory",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
