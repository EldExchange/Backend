using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EldExchange.Infra.Context.Migrations
{
    public partial class fixAgencyMapping : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Agencies_Addresses_AddressId",
                table: "Agencies");

            migrationBuilder.DropForeignKey(
                name: "FK_AgencyCurrency_Agencies_AgenciesId",
                table: "AgencyCurrency");

            migrationBuilder.DropForeignKey(
                name: "FK_Telephones_Agencies_AgencyId",
                table: "Telephones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Agencies",
                table: "Agencies");

            migrationBuilder.RenameTable(
                name: "Agencies",
                newName: "agency");

            migrationBuilder.RenameColumn(
                name: "Name",
                table: "agency",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "CNPJ",
                table: "agency",
                newName: "cnpj");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "agency",
                newName: "id");

            migrationBuilder.RenameIndex(
                name: "IX_Agencies_AddressId",
                table: "agency",
                newName: "IX_agency_AddressId");

            migrationBuilder.AlterColumn<string>(
                name: "AgencyId",
                table: "Telephones",
                type: "char(36)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AgenciesId",
                table: "AgencyCurrency",
                type: "char(36)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "name",
                table: "agency",
                type: "nvarchar(250)",
                maxLength: 250,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "cnpj",
                table: "agency",
                type: "char(18)",
                unicode: false,
                fixedLength: true,
                maxLength: 18,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "id",
                table: "agency",
                type: "char(36)",
                unicode: false,
                fixedLength: true,
                maxLength: 36,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_agency",
                table: "agency",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_agency_Addresses_AddressId",
                table: "agency",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AgencyCurrency_agency_AgenciesId",
                table: "AgencyCurrency",
                column: "AgenciesId",
                principalTable: "agency",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Telephones_agency_AgencyId",
                table: "Telephones",
                column: "AgencyId",
                principalTable: "agency",
                principalColumn: "id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_agency_Addresses_AddressId",
                table: "agency");

            migrationBuilder.DropForeignKey(
                name: "FK_AgencyCurrency_agency_AgenciesId",
                table: "AgencyCurrency");

            migrationBuilder.DropForeignKey(
                name: "FK_Telephones_agency_AgencyId",
                table: "Telephones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_agency",
                table: "agency");

            migrationBuilder.RenameTable(
                name: "agency",
                newName: "Agencies");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Agencies",
                newName: "Name");

            migrationBuilder.RenameColumn(
                name: "cnpj",
                table: "Agencies",
                newName: "CNPJ");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Agencies",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_agency_AddressId",
                table: "Agencies",
                newName: "IX_Agencies_AddressId");

            migrationBuilder.AlterColumn<string>(
                name: "AgencyId",
                table: "Telephones",
                type: "nvarchar(450)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "char(36)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "AgenciesId",
                table: "AgencyCurrency",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(36)");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Agencies",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(250)",
                oldMaxLength: 250);

            migrationBuilder.AlterColumn<string>(
                name: "CNPJ",
                table: "Agencies",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(18)",
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 18);

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Agencies",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "char(36)",
                oldUnicode: false,
                oldFixedLength: true,
                oldMaxLength: 36);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Agencies",
                table: "Agencies",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Agencies_Addresses_AddressId",
                table: "Agencies",
                column: "AddressId",
                principalTable: "Addresses",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AgencyCurrency_Agencies_AgenciesId",
                table: "AgencyCurrency",
                column: "AgenciesId",
                principalTable: "Agencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Telephones_Agencies_AgencyId",
                table: "Telephones",
                column: "AgencyId",
                principalTable: "Agencies",
                principalColumn: "Id");
        }
    }
}
