using Microsoft.EntityFrameworkCore.Migrations;

namespace CFPP_WebAPI.Migrations
{
    public partial class MakeRelationshipOptional : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Case_Customer_CustomerId",
                table: "Case");

            migrationBuilder.DropColumn(
                name: "OverdueBallance",
                table: "Case");

            migrationBuilder.DropColumn(
                name: "TotalBallance",
                table: "Case");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Case",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_Case_Customer_CustomerId",
                table: "Case",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Case_Customer_CustomerId",
                table: "Case");

            migrationBuilder.AlterColumn<int>(
                name: "CustomerId",
                table: "Case",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "OverdueBallance",
                table: "Case",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddColumn<decimal>(
                name: "TotalBallance",
                table: "Case",
                type: "decimal(18,2)",
                nullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Case_Customer_CustomerId",
                table: "Case",
                column: "CustomerId",
                principalTable: "Customer",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
