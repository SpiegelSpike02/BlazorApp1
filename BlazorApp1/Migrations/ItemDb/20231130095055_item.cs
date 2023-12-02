using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp1.Migrations.ItemDb
{
    /// <inheritdoc />
    public partial class item : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ProductCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Specs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProducerName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Unit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BatchCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ValidityDate = table.Column<DateTime>(type: "date", nullable: false),
                    ProductionDate = table.Column<DateTime>(type: "date", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Items", x => x.ProductCode);
                });

            migrationBuilder.CreateTable(
                name: "Records",
                columns: table => new
                {
                    OperationCode = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    OperationName = table.Column<int>(type: "int", nullable: false),
                    OperationDate = table.Column<DateTime>(type: "date", nullable: false),
                    OperationNumber = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Summary = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OperationItemProductCode = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Records", x => x.OperationCode);
                    table.ForeignKey(
                        name: "FK_Records_Items_OperationItemProductCode",
                        column: x => x.OperationItemProductCode,
                        principalTable: "Items",
                        principalColumn: "ProductCode");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Records_OperationItemProductCode",
                table: "Records",
                column: "OperationItemProductCode");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Records");

            migrationBuilder.DropTable(
                name: "Items");
        }
    }
}
