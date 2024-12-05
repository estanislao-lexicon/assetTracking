﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace assetTracking.Migrations
{
    /// <inheritdoc />
    public partial class UpdateModelChanges : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1,
                column: "PurchaseDate",
                value: new DateTime(2022, 4, 5, 13, 51, 54, 902, DateTimeKind.Local).AddTicks(2790));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 2,
                column: "PurchaseDate",
                value: new DateTime(2022, 5, 5, 13, 51, 54, 917, DateTimeKind.Local).AddTicks(9579));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 3,
                column: "PurchaseDate",
                value: new DateTime(2022, 10, 5, 13, 51, 54, 917, DateTimeKind.Local).AddTicks(9594));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 4,
                column: "PurchaseDate",
                value: new DateTime(2022, 6, 5, 13, 51, 54, 917, DateTimeKind.Local).AddTicks(9597));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 5,
                column: "PurchaseDate",
                value: new DateTime(2022, 7, 5, 13, 51, 54, 917, DateTimeKind.Local).AddTicks(9600));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 6,
                column: "PurchaseDate",
                value: new DateTime(2022, 4, 5, 13, 51, 54, 917, DateTimeKind.Local).AddTicks(9602));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 7,
                column: "PurchaseDate",
                value: new DateTime(2022, 5, 5, 13, 51, 54, 917, DateTimeKind.Local).AddTicks(9605));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 8,
                column: "PurchaseDate",
                value: new DateTime(2022, 12, 5, 13, 51, 54, 917, DateTimeKind.Local).AddTicks(9607));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 9,
                column: "PurchaseDate",
                value: new DateTime(2021, 10, 5, 13, 51, 54, 917, DateTimeKind.Local).AddTicks(9610));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 10,
                column: "PurchaseDate",
                value: new DateTime(2021, 11, 5, 13, 51, 54, 917, DateTimeKind.Local).AddTicks(9612));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 11,
                column: "PurchaseDate",
                value: new DateTime(2022, 1, 5, 13, 51, 54, 917, DateTimeKind.Local).AddTicks(9615));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 12,
                column: "PurchaseDate",
                value: new DateTime(2022, 4, 5, 13, 51, 54, 917, DateTimeKind.Local).AddTicks(9661));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 13,
                column: "PurchaseDate",
                value: new DateTime(2022, 9, 5, 13, 51, 54, 917, DateTimeKind.Local).AddTicks(9664));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 14,
                column: "PurchaseDate",
                value: new DateTime(2022, 7, 5, 13, 51, 54, 917, DateTimeKind.Local).AddTicks(9667));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 15,
                column: "PurchaseDate",
                value: new DateTime(2022, 8, 5, 13, 51, 54, 917, DateTimeKind.Local).AddTicks(9669));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 16,
                column: "PurchaseDate",
                value: new DateTime(2022, 9, 5, 13, 51, 54, 917, DateTimeKind.Local).AddTicks(9671));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 17,
                column: "PurchaseDate",
                value: new DateTime(2023, 2, 5, 13, 51, 54, 917, DateTimeKind.Local).AddTicks(9674));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 18,
                column: "PurchaseDate",
                value: new DateTime(2022, 4, 5, 13, 51, 54, 917, DateTimeKind.Local).AddTicks(9676));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 19,
                column: "PurchaseDate",
                value: new DateTime(2022, 3, 5, 13, 51, 54, 917, DateTimeKind.Local).AddTicks(9679));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 20,
                column: "PurchaseDate",
                value: new DateTime(2022, 2, 5, 13, 51, 54, 917, DateTimeKind.Local).AddTicks(9681));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 1,
                column: "PurchaseDate",
                value: new DateTime(2022, 4, 5, 13, 45, 56, 361, DateTimeKind.Local).AddTicks(1975));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 2,
                column: "PurchaseDate",
                value: new DateTime(2022, 5, 5, 13, 45, 56, 377, DateTimeKind.Local).AddTicks(3367));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 3,
                column: "PurchaseDate",
                value: new DateTime(2022, 10, 5, 13, 45, 56, 377, DateTimeKind.Local).AddTicks(3382));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 4,
                column: "PurchaseDate",
                value: new DateTime(2022, 6, 5, 13, 45, 56, 377, DateTimeKind.Local).AddTicks(3385));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 5,
                column: "PurchaseDate",
                value: new DateTime(2022, 7, 5, 13, 45, 56, 377, DateTimeKind.Local).AddTicks(3388));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 6,
                column: "PurchaseDate",
                value: new DateTime(2022, 4, 5, 13, 45, 56, 377, DateTimeKind.Local).AddTicks(3390));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 7,
                column: "PurchaseDate",
                value: new DateTime(2022, 5, 5, 13, 45, 56, 377, DateTimeKind.Local).AddTicks(3393));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 8,
                column: "PurchaseDate",
                value: new DateTime(2022, 12, 5, 13, 45, 56, 377, DateTimeKind.Local).AddTicks(3395));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 9,
                column: "PurchaseDate",
                value: new DateTime(2021, 10, 5, 13, 45, 56, 377, DateTimeKind.Local).AddTicks(3397));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 10,
                column: "PurchaseDate",
                value: new DateTime(2021, 11, 5, 13, 45, 56, 377, DateTimeKind.Local).AddTicks(3400));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 11,
                column: "PurchaseDate",
                value: new DateTime(2022, 1, 5, 13, 45, 56, 377, DateTimeKind.Local).AddTicks(3402));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 12,
                column: "PurchaseDate",
                value: new DateTime(2022, 4, 5, 13, 45, 56, 377, DateTimeKind.Local).AddTicks(3405));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 13,
                column: "PurchaseDate",
                value: new DateTime(2022, 9, 5, 13, 45, 56, 377, DateTimeKind.Local).AddTicks(3407));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 14,
                column: "PurchaseDate",
                value: new DateTime(2022, 7, 5, 13, 45, 56, 377, DateTimeKind.Local).AddTicks(3410));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 15,
                column: "PurchaseDate",
                value: new DateTime(2022, 8, 5, 13, 45, 56, 377, DateTimeKind.Local).AddTicks(3413));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 16,
                column: "PurchaseDate",
                value: new DateTime(2022, 9, 5, 13, 45, 56, 377, DateTimeKind.Local).AddTicks(3416));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 17,
                column: "PurchaseDate",
                value: new DateTime(2023, 2, 5, 13, 45, 56, 377, DateTimeKind.Local).AddTicks(3418));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 18,
                column: "PurchaseDate",
                value: new DateTime(2022, 4, 5, 13, 45, 56, 377, DateTimeKind.Local).AddTicks(3421));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 19,
                column: "PurchaseDate",
                value: new DateTime(2022, 3, 5, 13, 45, 56, 377, DateTimeKind.Local).AddTicks(3423));

            migrationBuilder.UpdateData(
                table: "Assets",
                keyColumn: "Id",
                keyValue: 20,
                column: "PurchaseDate",
                value: new DateTime(2022, 2, 5, 13, 45, 56, 377, DateTimeKind.Local).AddTicks(3426));
        }
    }
}
