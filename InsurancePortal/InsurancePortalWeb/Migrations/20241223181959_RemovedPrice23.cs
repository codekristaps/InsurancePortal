using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InsurancePortalWeb.Migrations
{
    /// <inheritdoc />
    public partial class RemovedPrice23 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DropColumn(
                name: "Description",
                table: "Insurances");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Insurances");

            migrationBuilder.InsertData(
                table: "Insurances",
                columns: new[] { "Id", "Name" },
                values: new object[] { 3, "Home Insurance Plan C" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.AddColumn<string>(
                name: "Description",
                table: "Insurances",
                type: "nvarchar(500)",
                maxLength: 500,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImageUrl",
                table: "Insurances",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Insurances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Comprehensive health insurance for individuals.", "https://example.com/images/health-insurance-a.jpg" });

            migrationBuilder.UpdateData(
                table: "Insurances",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ImageUrl" },
                values: new object[] { "Full coverage car insurance with roadside assistance.", "https://example.com/images/car-insurance-b.jpg" });

            migrationBuilder.InsertData(
                table: "Insurances",
                columns: new[] { "Id", "Description", "ImageUrl", "Name" },
                values: new object[] { 4, "Protection for your home and belongings.", "https://example.com/images/home-insurance-c.jpg", "Home Insurance Plan C" });
        }
    }
}
