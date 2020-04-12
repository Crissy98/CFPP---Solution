using Microsoft.EntityFrameworkCore.Migrations;

namespace CFPP_WebAPI.Migrations
{
    public partial class DataSeedingTest : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customer",
                columns: new[] { "CustomerId", "CustomerName", "Email", "PhoneNo", "VATCode" },
                values: new object[] { 4, "John Doe", "JohnDoe@email.com", "0769 291 837", "JD232456" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Customer",
                keyColumn: "CustomerId",
                keyValue: 4);
        }
    }
}
