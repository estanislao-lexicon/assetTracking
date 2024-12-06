using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace assetTracking.Migrations
{
    /// <inheritdoc />
    public partial class ChangePriceToDouble : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<double>(
                name: "Price",
                table: "Assets",
                type: "float",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Price", "PurchaseDate" },
                values: new object[] { 200.0, new DateTime(2022, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Price", "PurchaseDate" },
                values: new object[] { 400.0, new DateTime(2022, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Price", "PurchaseDate" },
                values: new object[] { 400.0, new DateTime(2022, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Price", "PurchaseDate" },
                values: new object[] { 4500.0, new DateTime(2022, 6, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Price", "PurchaseDate" },
                values: new object[] { 4500.0, new DateTime(2022, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Price", "PurchaseDate" },
                values: new object[] { 3000.0, new DateTime(2022, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Price", "PurchaseDate" },
                values: new object[] { 3000.0, new DateTime(2022, 5, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Price", "PurchaseDate" },
                values: new object[] { 220.0, new DateTime(2022, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Price", "PurchaseDate" },
                values: new object[] { 100.0, new DateTime(2021, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Price", "PurchaseDate" },
                values: new object[] { 100.0, new DateTime(2021, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Price", "PurchaseDate" },
                values: new object[] { 300.0, new DateTime(2022, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Price", "PurchaseDate" },
                values: new object[] { 300.0, new DateTime(2022, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Price", "PurchaseDate" },
                values: new object[] { 500.0, new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Price", "PurchaseDate" },
                values: new object[] { 1500.0, new DateTime(2022, 7, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Price", "PurchaseDate" },
                values: new object[] { 1400.0, new DateTime(2022, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Price", "PurchaseDate" },
                values: new object[] { 1300.0, new DateTime(2022, 9, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Price", "PurchaseDate" },
                values: new object[] { 1600.0, new DateTime(2023, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Price", "PurchaseDate" },
                values: new object[] { 1200.0, new DateTime(2022, 3, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Price", "PurchaseDate" },
                values: new object[] { 1200.0, new DateTime(2022, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Price", "PurchaseDate" },
                values: new object[] { 1300.0, new DateTime(2022, 2, 5, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "Price",
                table: "Assets",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(double),
                oldType: "float");

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Price", "PurchaseDate" },
                values: new object[] { 200m, new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Price", "PurchaseDate" },
                values: new object[] { 400m, new DateTime(2020, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Price", "PurchaseDate" },
                values: new object[] { 400m, new DateTime(2020, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 4,
                columns: new[] { "Price", "PurchaseDate" },
                values: new object[] { 4500m, new DateTime(2020, 7, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 5,
                columns: new[] { "Price", "PurchaseDate" },
                values: new object[] { 4500m, new DateTime(2020, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 6,
                columns: new[] { "Price", "PurchaseDate" },
                values: new object[] { 3000m, new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 7,
                columns: new[] { "Price", "PurchaseDate" },
                values: new object[] { 3000m, new DateTime(2020, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 8,
                columns: new[] { "Price", "PurchaseDate" },
                values: new object[] { 220m, new DateTime(2021, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 9,
                columns: new[] { "Price", "PurchaseDate" },
                values: new object[] { 100m, new DateTime(2019, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "Price", "PurchaseDate" },
                values: new object[] { 100m, new DateTime(2019, 12, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "Price", "PurchaseDate" },
                values: new object[] { 300m, new DateTime(2020, 2, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "Price", "PurchaseDate" },
                values: new object[] { 300m, new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "Price", "PurchaseDate" },
                values: new object[] { 500m, new DateTime(2020, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "Price", "PurchaseDate" },
                values: new object[] { 1500m, new DateTime(2020, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "Price", "PurchaseDate" },
                values: new object[] { 1400m, new DateTime(2020, 9, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "Price", "PurchaseDate" },
                values: new object[] { 1300m, new DateTime(2020, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 17,
                columns: new[] { "Price", "PurchaseDate" },
                values: new object[] { 1600m, new DateTime(2021, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 18,
                columns: new[] { "Price", "PurchaseDate" },
                values: new object[] { 1200m, new DateTime(2020, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 19,
                columns: new[] { "Price", "PurchaseDate" },
                values: new object[] { 1200m, new DateTime(2020, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 20,
                columns: new[] { "Price", "PurchaseDate" },
                values: new object[] { 1300m, new DateTime(2020, 3, 15, 0, 0, 0, 0, DateTimeKind.Unspecified) });
        }
    }
}
