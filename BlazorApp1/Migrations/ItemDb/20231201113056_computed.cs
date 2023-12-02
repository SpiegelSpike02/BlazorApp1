using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp1.Migrations.ItemDb
{
    /// <inheritdoc />
    public partial class computed : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Records_Items_OperationItemProductCode",
                table: "Records");

            migrationBuilder.AlterColumn<string>(
                name: "OperationItemProductCode",
                table: "Records",
                type: "nvarchar(450)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Number",
                table: "Items",
                type: "int",
                nullable: false,
                computedColumnSql: "dbo.CalculateNumberFunction([ProductCode])",
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Records_Items_OperationItemProductCode",
                table: "Records",
                column: "OperationItemProductCode",
                principalTable: "Items",
                principalColumn: "ProductCode",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Records_Items_OperationItemProductCode",
                table: "Records");

            migrationBuilder.AlterColumn<string>(
                name: "OperationItemProductCode",
                table: "Records",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<int>(
                name: "Number",
                table: "Items",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldComputedColumnSql: "dbo.CalculateNumberFunction([ProductCode])");

            migrationBuilder.AddForeignKey(
                name: "FK_Records_Items_OperationItemProductCode",
                table: "Records",
                column: "OperationItemProductCode",
                principalTable: "Items",
                principalColumn: "ProductCode");
        }
    }
}
