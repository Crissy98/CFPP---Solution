using Microsoft.EntityFrameworkCore.Migrations;

namespace CFPP_WebAPI.Migrations
{
    public partial class UpdateModelAddedCaseTBL : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Case",
                columns: table => new
                {
                    CustomerCode = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CaseTitle = table.Column<string>(nullable: true),
                    TotalBallance = table.Column<decimal>(nullable: true),
                    OverdueBallance = table.Column<decimal>(nullable: true),
                    DPD = table.Column<int>(nullable: true),
                    CustomerId = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Case", x => x.CustomerCode);
                    table.ForeignKey(
                        name: "FK_Case_Customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Customer",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Case_CustomerId",
                table: "Case",
                column: "CustomerId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Case");
        }
    }
}
