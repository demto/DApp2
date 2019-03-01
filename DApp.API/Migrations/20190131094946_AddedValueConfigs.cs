using Microsoft.EntityFrameworkCore.Migrations;

namespace DApp.API.Migrations
{
    public partial class AddedValueConfigs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Values",
                table: "Values");

            migrationBuilder.RenameTable(
                name: "Values",
                newName: "ValueTable");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "ValueTable",
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_ValueTable",
                table: "ValueTable",
                column: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ValueTable",
                table: "ValueTable");

            migrationBuilder.RenameTable(
                name: "ValueTable",
                newName: "Values");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Values",
                nullable: true,
                oldClrType: typeof(string),
                oldMaxLength: 10);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Values",
                table: "Values",
                column: "Id");
        }
    }
}
