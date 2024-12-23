using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InsurancePortalWeb.Migrations
{
    /// <inheritdoc />
    public partial class RemovedPrice23122 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Insurances",
                keyColumn: "Id",
                keyValue: 3);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Insurances",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { 1, "Comprehensive health insurance for individuals.", "https://example.com/images/health-insurance-a.jpg", "Health Insurance Plan A", 299.99m },
                    { 2, "Full coverage car insurance with roadside assistance.", "https://example.com/images/car-insurance-b.jpg", "Car Insurance Plan B", 499.99m },
                    { 3, "Protection for your home and belongings.", "https://example.com/images/home-insurance-c.jpg", "Home Insurance Plan C", 399.99m }
                });
        }
    }
}
