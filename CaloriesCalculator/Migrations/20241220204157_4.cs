using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CaloriesCalculator.Migrations
{
    /// <inheritdoc />
    public partial class _4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df7c92db-9dec-4483-9b0c-39836de8f44a",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "a92c54be-e60e-4f1e-8d28-0b5b8d070f86", "ADMIN@DOMAIN.COM", "AQAAAAIAAYagAAAAEL0udlhvfHjZawbGKgUHB0E3Uq8i/7e0MeSSo6Jq48WmXcb36OsAlzfLEJFxWcgWRg==", "e11500ce-752d-4a96-b82b-54f7a538f3ef", "admin@domain.com" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df7c92db-9dec-4483-9b0c-39836de8f44a",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "476b9ac8-fcaa-46a4-ad8a-da441ea2d0da", "ADMIN", "AQAAAAIAAYagAAAAEKaONsl/mafM0MMDLCHzIPpyKK6GMOMGEEAGiWPV9WOd0YnXT4E0Q4mnKjfOM9g46w==", "e60cc24b-15af-4a4f-ad70-74f0705c0f31", "admin" });
        }
    }
}
