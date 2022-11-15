using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EldExchange.Infra.Context.Migrations
{
    public partial class AddTelephone2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Telephones_agency_Id",
                table: "Telephones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Telephones",
                table: "Telephones");

            migrationBuilder.RenameTable(
                name: "Telephones",
                newName: "telephone");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "telephone",
                type: "varchar(50)",
                unicode: false,
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "RegionCode",
                table: "telephone",
                type: "varchar(10)",
                unicode: false,
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Number",
                table: "telephone",
                type: "varchar(10)",
                unicode: false,
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "CountryCode",
                table: "telephone",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_telephone",
                table: "telephone",
                columns: new[] { "Id", "Number", "RegionCode", "CountryCode" });

            migrationBuilder.CreateIndex(
                name: "IX_telephone_Number_RegionCode_CountryCode",
                table: "telephone",
                columns: new[] { "Number", "RegionCode", "CountryCode" },
                unique: true);

            migrationBuilder.AddForeignKey(
                name: "FK_telephone_agency_Id",
                table: "telephone",
                column: "Id",
                principalTable: "agency",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_telephone_agency_Id",
                table: "telephone");

            migrationBuilder.DropPrimaryKey(
                name: "PK_telephone",
                table: "telephone");

            migrationBuilder.DropIndex(
                name: "IX_telephone_Number_RegionCode_CountryCode",
                table: "telephone");

            migrationBuilder.RenameTable(
                name: "telephone",
                newName: "Telephones");

            migrationBuilder.AlterColumn<string>(
                name: "Type",
                table: "Telephones",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldUnicode: false,
                oldMaxLength: 50,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "CountryCode",
                table: "Telephones",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "RegionCode",
                table: "Telephones",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldUnicode: false,
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Number",
                table: "Telephones",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldUnicode: false,
                oldMaxLength: 10);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Telephones",
                table: "Telephones",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Telephones_agency_Id",
                table: "Telephones",
                column: "Id",
                principalTable: "agency",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
