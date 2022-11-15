using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EldExchange.Infra.Context.Migrations
{
    public partial class AddTelephone : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Addresses_agency_Id",
                table: "Addresses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses");

            migrationBuilder.RenameTable(
                name: "Addresses",
                newName: "address");

            migrationBuilder.AlterColumn<Guid>(
                name: "Id",
                table: "Telephones",
                type: "uniqueidentifier",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(450)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_address",
                table: "address",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_address_agency_Id",
                table: "address",
                column: "Id",
                principalTable: "agency",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Telephones_agency_Id",
                table: "Telephones",
                column: "Id",
                principalTable: "agency",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_address_agency_Id",
                table: "address");

            migrationBuilder.DropForeignKey(
                name: "FK_Telephones_agency_Id",
                table: "Telephones");

            migrationBuilder.DropPrimaryKey(
                name: "PK_address",
                table: "address");

            migrationBuilder.RenameTable(
                name: "address",
                newName: "Addresses");

            migrationBuilder.AlterColumn<string>(
                name: "Id",
                table: "Telephones",
                type: "nvarchar(450)",
                nullable: false,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Addresses",
                table: "Addresses",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Addresses_agency_Id",
                table: "Addresses",
                column: "Id",
                principalTable: "agency",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
