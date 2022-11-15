using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EldExchange.Infra.Context.Migrations
{
    public partial class AddMoneyTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Money",
                schema: "EldExchange",
                columns: table => new
                {
                    Code = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: false),
                    Value = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    CurrencyCode = table.Column<string>(type: "char(3)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Money", x => new { x.Code, x.Value, x.Type });
                    table.ForeignKey(
                        name: "FK_Money_Currencies_CurrencyCode",
                        column: x => x.CurrencyCode,
                        principalSchema: "EldExchange",
                        principalTable: "Currencies",
                        principalColumn: "Code");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Money_CurrencyCode",
                schema: "EldExchange",
                table: "Money",
                column: "CurrencyCode");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Money",
                schema: "EldExchange");
        }
    }
}
