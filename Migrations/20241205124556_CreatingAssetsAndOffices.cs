using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace assetTracking.Migrations
{
    /// <inheritdoc />
    public partial class CreatingAssetsAndOffices : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Offices",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LocalCurrency = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Offices", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Assets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Brand = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Model = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PurchaseDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OfficeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Assets", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Assets_Offices_OfficeId",
                        column: x => x.OfficeId,
                        principalTable: "Offices",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Offices",
                columns: new[] { "Id", "LocalCurrency", "Name" },
                values: new object[,]
                {
                    { 1, "usd", "USA" },
                    { 2, "sek", "Sweden" },
                    { 3, "eur", "Germany" }
                });

            migrationBuilder.InsertData(
                table: "Assets",
                columns: new[] { "Id", "Brand", "Model", "OfficeId", "Price", "PurchaseDate", "Type" },
                values: new object[,]
                {
                    { 1, "Motorola", "X3", 1, 200m, new DateTime(2022, 4, 5, 13, 45, 56, 361, DateTimeKind.Local).AddTicks(1975), "Smartphone" },
                    { 2, "Motorola", "X3", 1, 400m, new DateTime(2022, 5, 5, 13, 45, 56, 377, DateTimeKind.Local).AddTicks(3367), "Smartphone" },
                    { 3, "Motorola", "X2", 1, 400m, new DateTime(2022, 10, 5, 13, 45, 56, 377, DateTimeKind.Local).AddTicks(3382), "Smartphone" },
                    { 4, "Samsung", "Galaxy 10", 2, 4500m, new DateTime(2022, 6, 5, 13, 45, 56, 377, DateTimeKind.Local).AddTicks(3385), "Smartphone" },
                    { 5, "Samsung", "Galaxy 10", 2, 4500m, new DateTime(2022, 7, 5, 13, 45, 56, 377, DateTimeKind.Local).AddTicks(3388), "Smartphone" },
                    { 6, "Sony", "XPeria 7", 2, 3000m, new DateTime(2022, 4, 5, 13, 45, 56, 377, DateTimeKind.Local).AddTicks(3390), "Smartphone" },
                    { 7, "Sony", "XPeria 7", 2, 3000m, new DateTime(2022, 5, 5, 13, 45, 56, 377, DateTimeKind.Local).AddTicks(3393), "Smartphone" },
                    { 8, "Siemens", "Brick", 3, 220m, new DateTime(2022, 12, 5, 13, 45, 56, 377, DateTimeKind.Local).AddTicks(3395), "Smartphone" },
                    { 9, "Dell", "Desktop 900", 1, 100m, new DateTime(2021, 10, 5, 13, 45, 56, 377, DateTimeKind.Local).AddTicks(3397), "Computer" },
                    { 10, "Dell", "Desktop 900", 1, 100m, new DateTime(2021, 11, 5, 13, 45, 56, 377, DateTimeKind.Local).AddTicks(3400), "Computer" },
                    { 11, "Lenovo", "X100", 1, 300m, new DateTime(2022, 1, 5, 13, 45, 56, 377, DateTimeKind.Local).AddTicks(3402), "Computer" },
                    { 12, "Lenovo", "X200", 1, 300m, new DateTime(2022, 4, 5, 13, 45, 56, 377, DateTimeKind.Local).AddTicks(3405), "Computer" },
                    { 13, "Lenovo", "X300", 1, 500m, new DateTime(2022, 9, 5, 13, 45, 56, 377, DateTimeKind.Local).AddTicks(3407), "Computer" },
                    { 14, "Dell", "Optiplex 100", 2, 1500m, new DateTime(2022, 7, 5, 13, 45, 56, 377, DateTimeKind.Local).AddTicks(3410), "Computer" },
                    { 15, "Dell", "Optiplex 200", 2, 1400m, new DateTime(2022, 8, 5, 13, 45, 56, 377, DateTimeKind.Local).AddTicks(3413), "Computer" },
                    { 16, "Dell", "Optiplex 300", 2, 1300m, new DateTime(2022, 9, 5, 13, 45, 56, 377, DateTimeKind.Local).AddTicks(3416), "Computer" },
                    { 17, "Asus", "ROG 600", 3, 1600m, new DateTime(2023, 2, 5, 13, 45, 56, 377, DateTimeKind.Local).AddTicks(3418), "Computer" },
                    { 18, "Asus", "ROG 500", 3, 1200m, new DateTime(2022, 4, 5, 13, 45, 56, 377, DateTimeKind.Local).AddTicks(3421), "Computer" },
                    { 19, "Asus", "ROG 500", 3, 1200m, new DateTime(2022, 3, 5, 13, 45, 56, 377, DateTimeKind.Local).AddTicks(3423), "Computer" },
                    { 20, "Asus", "ROG 500", 3, 1300m, new DateTime(2022, 2, 5, 13, 45, 56, 377, DateTimeKind.Local).AddTicks(3426), "Computer" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Assets_OfficeId",
                table: "Assets",
                column: "OfficeId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Assets");

            migrationBuilder.DropTable(
                name: "Offices");
        }
    }
}
