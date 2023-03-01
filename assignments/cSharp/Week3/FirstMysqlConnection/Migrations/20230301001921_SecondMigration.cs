using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FirstMysqlConnection.Migrations
{
    public partial class SecondMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Tunes",
                newName: "TuneOwner");

            migrationBuilder.RenameColumn(
                name: "Img",
                table: "Tunes",
                newName: "TuneName");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "Squishys",
                newName: "SquishyName");

            migrationBuilder.RenameColumn(
                name: "Img",
                table: "Squishys",
                newName: "SquishyImg");

            migrationBuilder.AddColumn<string>(
                name: "TuneImg",
                table: "Tunes",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AddColumn<string>(
                name: "Owner",
                table: "Squishys",
                type: "longtext",
                nullable: false)
                .Annotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TuneImg",
                table: "Tunes");

            migrationBuilder.DropColumn(
                name: "Owner",
                table: "Squishys");

            migrationBuilder.RenameColumn(
                name: "TuneOwner",
                table: "Tunes",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "TuneName",
                table: "Tunes",
                newName: "Img");

            migrationBuilder.RenameColumn(
                name: "SquishyName",
                table: "Squishys",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "SquishyImg",
                table: "Squishys",
                newName: "Img");
        }
    }
}
