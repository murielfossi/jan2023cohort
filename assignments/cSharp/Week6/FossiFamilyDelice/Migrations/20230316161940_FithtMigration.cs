using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace FossiFamilyDelice.Migrations
{
    public partial class FithtMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<long>(
                name: "UserContact",
                table: "Orders",
                type: "bigint",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "longtext")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "UserContact",
                table: "Orders",
                type: "longtext",
                nullable: false,
                oldClrType: typeof(long),
                oldType: "bigint",
                oldMaxLength: 10)
                .Annotation("MySql:CharSet", "utf8mb4");
        }
    }
}
