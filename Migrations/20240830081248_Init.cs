using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Power_BI_Extension.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Designs",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PbiUrl = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CatId = table.Column<int>(type: "int", nullable: false),
                    Thumb = table.Column<string>(type: "nvarchar(max)", maxLength: 5000, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Designs", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Designs",
                columns: new[] { "Id", "CatId", "Description", "Name", "PbiUrl", "Thumb" },
                values: new object[,]
                {
                    { 1, 1, "Reka bentuk ini menunjukkan prestasi dan data untuk Asset", "Penjagaan Asset", "https://app.powerbi.com/view?r=eyJrIjoiMjYyOTNmOGMtNjUwZC00MDAwLWE5ODUtYjY1MDI0OGUxMjRlIiwidCI6ImM2NWIxYzYzLTdjYjctNGFlNy05YzNjLTk5OWI0ZGE1MjM5NiIsImMiOjEwfQ%3D%3D", "./images/default.jpg" },
                    { 2, 2, "Reka Bentuk ini menunjukkan Data dan prestasi Data Rangkaian", "Data Rangkaian", "https://app.powerbi.com/view?r=eyJrIjoiMmI0YjcyZDUtZjNhYy00MGMxLWEzZDktNTkzZDE5ZDQzZDUxIiwidCI6ImM2NWIxYzYzLTdjYjctNGFlNy05YzNjLTk5OWI0ZGE1MjM5NiIsImMiOjEwfQ%3D%3D", "./images/default.jpg" },
                    { 3, 3, "Reka Bentuk ini menunjukkan Kadar berlakunya kemalangan dan juga kematian", "Road Accident", "https://app.powerbi.com/view?r=eyJrIjoiOTc4YmVjMGUtY2M4Ni00YTQwLWJmZTktNGQwM2I1NDE1NTZiIiwidCI6ImM2NWIxYzYzLTdjYjctNGFlNy05YzNjLTk5OWI0ZGE1MjM5NiIsImMiOjEwfQ%3D%3D", "./images/default.jpg" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Designs");
        }
    }
}
