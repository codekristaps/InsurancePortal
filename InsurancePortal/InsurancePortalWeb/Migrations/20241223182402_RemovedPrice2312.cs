using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace InsurancePortalWeb.Migrations
{
    /// <inheritdoc />
    public partial class RemovedPrice2312 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.AddColumn<decimal>(
                name: "Price",
                table: "Insurances",
                type: "decimal(18,2)",
                precision: 18,
                scale: 2,
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.UpdateData(
                table: "Insurances",
                keyColumn: "Id",
                keyValue: 1,
                columns: new[] { "Description", "ImageUrl", "Price" },
                values: new object[] { "Comprehensive health insurance for individuals.", "https://example.com/images/health-insurance-a.jpg", 299.99m });

            migrationBuilder.UpdateData(
                table: "Insurances",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "Description", "ImageUrl", "Price" },
                values: new object[] { "Full coverage car insurance with roadside assistance.", "https://example.com/images/car-insurance-b.jpg", 499.99m });

            migrationBuilder.UpdateData(
                table: "Insurances",
                keyColumn: "Id",
                keyValue: 3,
                columns: new[] { "Description", "ImageUrl", "Price" },
                values: new object[] { "Protection for your home and belongings.", "https://example.com/images/home-insurance-c.jpg", 399.99m });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Description",
                table: "Insurances");

            migrationBuilder.DropColumn(
                name: "ImageUrl",
                table: "Insurances");

            migrationBuilder.DropColumn(
                name: "Price",
                table: "Insurances");
        }
    }
}
