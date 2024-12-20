using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CaloriesCalculator.Migrations
{
    /// <inheritdoc />
    public partial class _3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df7c92db-9dec-4483-9b0c-39836de8f44a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "476b9ac8-fcaa-46a4-ad8a-da441ea2d0da", "AQAAAAIAAYagAAAAEKaONsl/mafM0MMDLCHzIPpyKK6GMOMGEEAGiWPV9WOd0YnXT4E0Q4mnKjfOM9g46w==", "e60cc24b-15af-4a4f-ad70-74f0705c0f31" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "df7c92db-9dec-4483-9b0c-39836de8f44a",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0dcaaa45-ed43-4e3b-b6b9-5b5406743191", "AQAAAAIAAYagAAAAEFVgKsk78O3tD2/aClTC/6x4ExhD8c13sT0Ggy63IdfnEH5Dca4YJGgNEzNoz/zr/A==", "e722c7ab-28c5-409b-8a9f-ae8569ba5800" });
        }
    }
}
