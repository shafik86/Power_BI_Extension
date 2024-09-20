using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Power_BI_Extension.Migrations
{
    /// <inheritdoc />
    public partial class Add : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Designs",
                columns: new[] { "Id", "CatId", "Description", "Name", "PbiUrl", "Thumb" },
                values: new object[] { 4, 3, "Reka Bentuk ini menunjukkan Kadar Keselamatan negara", "MKN", "https://app.powerbi.com/view?r=eyJrIjoiYTIxMjg5NzYtOWUzNC00MWE3LWFlYjctNTY0YWM5NDdjYzE3IiwidCI6ImM2NWIxYzYzLTdjYjctNGFlNy05YzNjLTk5OWI0ZGE1MjM5NiIsImMiOjEwfQ%3D%3D", "./images/default.jpg" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Designs",
                keyColumn: "Id",
                keyValue: 4);
        }
    }
}
