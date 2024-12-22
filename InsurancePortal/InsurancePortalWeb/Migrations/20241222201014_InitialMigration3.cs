using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace InsurancePortalWeb.Migrations
{
    /// <inheritdoc />
    public partial class InitialMigration3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Insurances",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Insurances", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Insurances",
                columns: new[] { "Id", "Description", "ImageUrl", "Name", "Price" },
                values: new object[,]
                {
                    { new Guid("6fa1b91f-f84d-4c0c-8815-d6c62251cc3b"), "Protection for your home and belongings.", "https://example.com/images/home-insurance-c.jpg", "Home Insurance Plan C", 399.99m },
                    { new Guid("b849b20c-2d79-48c2-82a7-631d21357e67"), "Full coverage car insurance with roadside assistance.", "https://example.com/images/car-insurance-b.jpg", "Car Insurance Plan B", 499.99m },
                    { new Guid("d7997d4d-4d56-4c6a-a684-41c6c2329ef1"), "Comprehensive health insurance for individuals.", "https://example.com/images/health-insurance-a.jpg", "Health Insurance Plan A", 299.99m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Insurances");
        }
    }
}
