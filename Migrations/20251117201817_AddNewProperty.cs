using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HW20._1.Migrations
{
    /// <inheritdoc />
    public partial class AddNewProperty : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Acceleration",
                table: "Cars",
                newName: "Accelaration");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Accelaration",
                table: "Cars",
                newName: "Acceleration");
        }
    }
}
