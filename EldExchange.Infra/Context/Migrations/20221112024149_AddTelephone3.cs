using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EldExchange.Infra.Context.Migrations
{
    public partial class AddTelephone3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.AlterColumn<string>(
                name: "CountryCode",
                table: "telephone",
                type: "varchar(10)",
                unicode: false,
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AlterColumn<string>(
                name: "RegionCode",
                table: "telephone",
                type: "varchar(10)",
                unicode: false,
                maxLength: 10,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldUnicode: false,
                oldMaxLength: 10);

            migrationBuilder.AlterColumn<string>(
                name: "Number",
                table: "telephone",
                type: "varchar(20)",
                unicode: false,
                maxLength: 20,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldUnicode: false,
                oldMaxLength: 10);

            migrationBuilder.AddColumn<Guid>(
                name: "AgencyId",
                table: "telephone",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddPrimaryKey(
                name: "PK_telephone",
                table: "telephone",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_telephone_AgencyId",
                table: "telephone",
                column: "AgencyId");

            migrationBuilder.CreateIndex(
                name: "IX_telephone_Number_RegionCode_CountryCode",
                table: "telephone",
                columns: new[] { "Number", "RegionCode", "CountryCode" },
                unique: true,
                filter: "[RegionCode] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_telephone_agency_AgencyId",
                table: "telephone",
                column: "AgencyId",
                principalTable: "agency",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_telephone_agency_AgencyId",
                table: "telephone");

            migrationBuilder.DropPrimaryKey(
                name: "PK_telephone",
                table: "telephone");

            migrationBuilder.DropIndex(
                name: "IX_telephone_AgencyId",
                table: "telephone");

            migrationBuilder.DropIndex(
                name: "IX_telephone_Number_RegionCode_CountryCode",
                table: "telephone");

            migrationBuilder.DropColumn(
                name: "AgencyId",
                table: "telephone");

            migrationBuilder.AlterColumn<string>(
                name: "RegionCode",
                table: "telephone",
                type: "varchar(10)",
                unicode: false,
                maxLength: 10,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldUnicode: false,
                oldMaxLength: 10,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Number",
                table: "telephone",
                type: "varchar(10)",
                unicode: false,
                maxLength: 10,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldUnicode: false,
                oldMaxLength: 20);

            migrationBuilder.AlterColumn<string>(
                name: "CountryCode",
                table: "telephone",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(10)",
                oldUnicode: false,
                oldMaxLength: 10);

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
    }
}
