using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace assetTracking.Migrations
{
    /// <inheritdoc />
    public partial class SynchronizeDbContext : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1,
                column: "PurchaseDate",
                value: new DateTime(2022, 4, 5, 13, 57, 55, 298, DateTimeKind.Local).AddTicks(8897));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 2,
                column: "PurchaseDate",
                value: new DateTime(2022, 5, 5, 13, 57, 55, 317, DateTimeKind.Local).AddTicks(6666));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 3,
                column: "PurchaseDate",
                value: new DateTime(2022, 10, 5, 13, 57, 55, 317, DateTimeKind.Local).AddTicks(6688));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 4,
                column: "PurchaseDate",
                value: new DateTime(2022, 6, 5, 13, 57, 55, 317, DateTimeKind.Local).AddTicks(6692));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 5,
                column: "PurchaseDate",
                value: new DateTime(2022, 7, 5, 13, 57, 55, 317, DateTimeKind.Local).AddTicks(6695));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 6,
                column: "PurchaseDate",
                value: new DateTime(2022, 4, 5, 13, 57, 55, 317, DateTimeKind.Local).AddTicks(6697));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 7,
                column: "PurchaseDate",
                value: new DateTime(2022, 5, 5, 13, 57, 55, 317, DateTimeKind.Local).AddTicks(6700));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 8,
                column: "PurchaseDate",
                value: new DateTime(2022, 12, 5, 13, 57, 55, 317, DateTimeKind.Local).AddTicks(6702));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 9,
                column: "PurchaseDate",
                value: new DateTime(2021, 10, 5, 13, 57, 55, 317, DateTimeKind.Local).AddTicks(6705));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 10,
                column: "PurchaseDate",
                value: new DateTime(2021, 11, 5, 13, 57, 55, 317, DateTimeKind.Local).AddTicks(6710));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 11,
                column: "PurchaseDate",
                value: new DateTime(2022, 1, 5, 13, 57, 55, 317, DateTimeKind.Local).AddTicks(6713));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 12,
                column: "PurchaseDate",
                value: new DateTime(2022, 4, 5, 13, 57, 55, 317, DateTimeKind.Local).AddTicks(6716));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 13,
                column: "PurchaseDate",
                value: new DateTime(2022, 9, 5, 13, 57, 55, 317, DateTimeKind.Local).AddTicks(6718));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 14,
                column: "PurchaseDate",
                value: new DateTime(2022, 7, 5, 13, 57, 55, 317, DateTimeKind.Local).AddTicks(6721));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 15,
                column: "PurchaseDate",
                value: new DateTime(2022, 8, 5, 13, 57, 55, 317, DateTimeKind.Local).AddTicks(6723));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 16,
                column: "PurchaseDate",
                value: new DateTime(2022, 9, 5, 13, 57, 55, 317, DateTimeKind.Local).AddTicks(6726));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 17,
                column: "PurchaseDate",
                value: new DateTime(2023, 2, 5, 13, 57, 55, 317, DateTimeKind.Local).AddTicks(6728));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 18,
                column: "PurchaseDate",
                value: new DateTime(2022, 4, 5, 13, 57, 55, 317, DateTimeKind.Local).AddTicks(6730));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 19,
                column: "PurchaseDate",
                value: new DateTime(2022, 3, 5, 13, 57, 55, 317, DateTimeKind.Local).AddTicks(6733));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 20,
                column: "PurchaseDate",
                value: new DateTime(2022, 2, 5, 13, 57, 55, 317, DateTimeKind.Local).AddTicks(6740));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1,
                column: "PurchaseDate",
                value: new DateTime(2022, 4, 5, 13, 53, 32, 264, DateTimeKind.Local).AddTicks(2380));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 2,
                column: "PurchaseDate",
                value: new DateTime(2022, 5, 5, 13, 53, 32, 280, DateTimeKind.Local).AddTicks(6704));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 3,
                column: "PurchaseDate",
                value: new DateTime(2022, 10, 5, 13, 53, 32, 280, DateTimeKind.Local).AddTicks(6720));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 4,
                column: "PurchaseDate",
                value: new DateTime(2022, 6, 5, 13, 53, 32, 280, DateTimeKind.Local).AddTicks(6723));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 5,
                column: "PurchaseDate",
                value: new DateTime(2022, 7, 5, 13, 53, 32, 280, DateTimeKind.Local).AddTicks(6726));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 6,
                column: "PurchaseDate",
                value: new DateTime(2022, 4, 5, 13, 53, 32, 280, DateTimeKind.Local).AddTicks(6728));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 7,
                column: "PurchaseDate",
                value: new DateTime(2022, 5, 5, 13, 53, 32, 280, DateTimeKind.Local).AddTicks(6731));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 8,
                column: "PurchaseDate",
                value: new DateTime(2022, 12, 5, 13, 53, 32, 280, DateTimeKind.Local).AddTicks(6734));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 9,
                column: "PurchaseDate",
                value: new DateTime(2021, 10, 5, 13, 53, 32, 280, DateTimeKind.Local).AddTicks(6737));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 10,
                column: "PurchaseDate",
                value: new DateTime(2021, 11, 5, 13, 53, 32, 280, DateTimeKind.Local).AddTicks(6740));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 11,
                column: "PurchaseDate",
                value: new DateTime(2022, 1, 5, 13, 53, 32, 280, DateTimeKind.Local).AddTicks(6742));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 12,
                column: "PurchaseDate",
                value: new DateTime(2022, 4, 5, 13, 53, 32, 280, DateTimeKind.Local).AddTicks(6745));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 13,
                column: "PurchaseDate",
                value: new DateTime(2022, 9, 5, 13, 53, 32, 280, DateTimeKind.Local).AddTicks(6747));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 14,
                column: "PurchaseDate",
                value: new DateTime(2022, 7, 5, 13, 53, 32, 280, DateTimeKind.Local).AddTicks(6750));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 15,
                column: "PurchaseDate",
                value: new DateTime(2022, 8, 5, 13, 53, 32, 280, DateTimeKind.Local).AddTicks(6752));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 16,
                column: "PurchaseDate",
                value: new DateTime(2022, 9, 5, 13, 53, 32, 280, DateTimeKind.Local).AddTicks(6754));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 17,
                column: "PurchaseDate",
                value: new DateTime(2023, 2, 5, 13, 53, 32, 280, DateTimeKind.Local).AddTicks(6757));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 18,
                column: "PurchaseDate",
                value: new DateTime(2022, 4, 5, 13, 53, 32, 280, DateTimeKind.Local).AddTicks(6759));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 19,
                column: "PurchaseDate",
                value: new DateTime(2022, 3, 5, 13, 53, 32, 280, DateTimeKind.Local).AddTicks(6761));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 20,
                column: "PurchaseDate",
                value: new DateTime(2022, 2, 5, 13, 53, 32, 280, DateTimeKind.Local).AddTicks(6764));
        }
    }
}
