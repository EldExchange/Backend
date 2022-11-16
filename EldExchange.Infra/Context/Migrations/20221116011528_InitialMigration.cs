using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EldExchange.Infra.Context.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.EnsureSchema(
                name: "EldExchange");

            migrationBuilder.CreateTable(
                name: "Agencies",
                schema: "EldExchange",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    CNPJ = table.Column<string>(type: "char(18)", unicode: false, fixedLength: true, maxLength: 18, nullable: false),
                    IsWorking = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Agencies", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Currencies",
                schema: "EldExchange",
                columns: table => new
                {
                    Code = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Number = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Currencies", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                schema: "EldExchange",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ZipCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    StreetName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Number = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Complement = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    Country = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    City = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_Agencies_Id",
                        column: x => x.Id,
                        principalSchema: "EldExchange",
                        principalTable: "Agencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Telephones",
                schema: "EldExchange",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CountryCode = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: false),
                    RegionCode = table.Column<string>(type: "varchar(10)", unicode: false, maxLength: 10, nullable: true),
                    Number = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    Type = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    AgencyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Telephones", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Telephones_Agencies_AgencyId",
                        column: x => x.AgencyId,
                        principalSchema: "EldExchange",
                        principalTable: "Agencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Money",
                schema: "EldExchange",
                columns: table => new
                {
                    Code = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: false),
                    Value = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false, defaultValue: "Coin")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Money", x => new { x.Code, x.Value, x.Type });
                    table.ForeignKey(
                        name: "FK_Money_Currencies_Code",
                        column: x => x.Code,
                        principalSchema: "EldExchange",
                        principalTable: "Currencies",
                        principalColumn: "Code",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Safe",
                schema: "EldExchange",
                columns: table => new
                {
                    AgencyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Code = table.Column<string>(type: "char(3)", unicode: false, fixedLength: true, maxLength: 3, nullable: false),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Value = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    AgencyId1 = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Safe", x => new { x.Code, x.Value, x.Type, x.AgencyId });
                    table.ForeignKey(
                        name: "FK_Safe_Agencies_AgencyId",
                        column: x => x.AgencyId,
                        principalSchema: "EldExchange",
                        principalTable: "Agencies",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Safe_Agencies_AgencyId1",
                        column: x => x.AgencyId1,
                        principalSchema: "EldExchange",
                        principalTable: "Agencies",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Safe_Money_Code_Value_Type",
                        columns: x => new { x.Code, x.Value, x.Type },
                        principalSchema: "EldExchange",
                        principalTable: "Money",
                        principalColumns: new[] { "Code", "Value", "Type" },
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                schema: "EldExchange",
                table: "Currencies",
                columns: new[] { "Code", "Name", "Number" },
                values: new object[,]
                {
                    { "AED", "UAE Dirham", 784 },
                    { "AFN", "Afghani", 971 },
                    { "ALL", "Lek", 8 },
                    { "AMD", "Armenian Dram", 51 },
                    { "ANG", "Netherlands Antillean Guilder", 532 },
                    { "AOA", "Kwanza", 973 },
                    { "ARS", "Argentine Peso", 32 },
                    { "AUD", "Australian Dollar", 36 },
                    { "AWG", "Aruban Florin", 533 },
                    { "AZN", "Azerbaijanian Manat", 944 },
                    { "BAM", "Convertible Mark", 977 },
                    { "BBD", "Barbados Dollar", 52 },
                    { "BDT", "Taka", 50 },
                    { "BGN", "Bulgarian Lev", 975 },
                    { "BHD", "Bahraini Dinar", 48 },
                    { "BIF", "Burundi Franc", 108 },
                    { "BMD", "Bermudian Dollar", 60 },
                    { "BND", "Brunei Dollar", 96 },
                    { "BOB", "Boliviano", 68 },
                    { "BOV", "Mvdol", 984 },
                    { "BRL", "Brazilian Real", 986 },
                    { "BSD", "Bahamian Dollar", 44 },
                    { "BTN", "Ngultrum", 64 },
                    { "BWP", "Pula", 72 },
                    { "BYN", "Belarussian Ruble", 933 },
                    { "BZD", "Belize Dollar", 84 },
                    { "CAD", "Canadian Dollar", 124 },
                    { "CDF", "Congolese Franc", 976 },
                    { "CHE", "WIR Euro", 947 },
                    { "CHF", "Swiss Franc", 756 },
                    { "CHW", "WIR Franc", 948 },
                    { "CLF", "Unidad de Fomento", 990 },
                    { "CLP", "Chilean Peso", 152 },
                    { "CNY", "Yuan Renminbi", 156 },
                    { "COP", "Colombian Peso", 170 },
                    { "COU", "Unidad de Valor Real", 970 },
                    { "CRC", "Costa Rican Colon", 188 },
                    { "CUC", "Peso Convertible", 931 },
                    { "CUP", "Cuban Peso", 192 },
                    { "CVE", "Cabo Verde Escudo", 132 },
                    { "CZK", "Czech Koruna", 203 },
                    { "DJF", "Djibouti Franc", 262 }
                });

            migrationBuilder.InsertData(
                schema: "EldExchange",
                table: "Currencies",
                columns: new[] { "Code", "Name", "Number" },
                values: new object[,]
                {
                    { "DKK", "Danish Krone", 208 },
                    { "DOP", "Dominican Peso", 214 },
                    { "DZD", "Algerian Dinar", 12 },
                    { "EGP", "Egyptian Pound", 818 },
                    { "ERN", "Nakfa", 232 },
                    { "ETB", "Ethiopian Birr", 230 },
                    { "EUR", "Euro", 978 },
                    { "FJD", "Fiji Dollar", 242 },
                    { "FKP", "Falkland Islands Pound", 238 },
                    { "GBP", "Pound Sterling", 826 },
                    { "GEL", "Lari", 981 },
                    { "GHS", "Ghana Cedi", 936 },
                    { "GIP", "Gibraltar Pound", 292 },
                    { "GMD", "Dalasi", 270 },
                    { "GNF", "Guinea Franc", 324 },
                    { "GTQ", "Quetzal", 320 },
                    { "GYD", "Guyana Dollar", 328 },
                    { "HKD", "Hong Kong Dollar", 344 },
                    { "HNL", "Lempira", 340 },
                    { "HRK", "Kuna", 191 },
                    { "HTG", "Gourde", 332 },
                    { "HUF", "Forint", 348 },
                    { "IDR", "Rupiah", 360 },
                    { "ILS", "New Israeli Sheqel", 376 },
                    { "INR", "Indian Rupee", 356 },
                    { "IQD", "Iraqi Dinar", 368 },
                    { "IRR", "Iranian Rial", 364 },
                    { "ISK", "Iceland Krona", 352 },
                    { "JMD", "Jamaican Dollar", 388 },
                    { "JOD", "Jordanian Dinar", 400 },
                    { "JPY", "Yen", 392 },
                    { "KES", "Kenyan Shilling", 404 },
                    { "KGS", "Som", 417 },
                    { "KHR", "Riel", 116 },
                    { "KMF", "Comoro Franc", 174 },
                    { "KPW", "North Korean Won", 408 },
                    { "KRW", "Won", 410 },
                    { "KWD", "Kuwaiti Dinar", 414 },
                    { "KYD", "Cayman Islands Dollar", 136 },
                    { "KZT", "Tenge", 398 },
                    { "LAK", "Kip", 418 },
                    { "LBP", "Lebanese Pound", 422 }
                });

            migrationBuilder.InsertData(
                schema: "EldExchange",
                table: "Currencies",
                columns: new[] { "Code", "Name", "Number" },
                values: new object[,]
                {
                    { "LKR", "Sri Lanka Rupee", 144 },
                    { "LRD", "Liberian Dollar", 430 },
                    { "LSL", "Loti", 426 },
                    { "LYD", "Libyan Dinar", 434 },
                    { "MAD", "Moroccan Dirham", 504 },
                    { "MDL", "Moldovan Leu", 498 },
                    { "MGA", "Malagasy Ariary", 969 },
                    { "MKD", "Denar", 807 },
                    { "MMK", "Kyat", 104 },
                    { "MNT", "Tugrik", 496 },
                    { "MOP", "Pataca", 446 },
                    { "MRU", "Ouguiya", 929 },
                    { "MUR", "Mauritius Rupee", 480 },
                    { "MVR", "Rufiyaa", 462 },
                    { "MWK", "Kwacha", 454 },
                    { "MXN", "Mexican Peso", 484 },
                    { "MXV", "Mexican Unidad de Inversion (UDI)", 979 },
                    { "MYR", "Malaysian Ringgit", 458 },
                    { "MZN", "Mozambique Metical", 943 },
                    { "NAD", "Namibia Dollar", 516 },
                    { "NGN", "Naira", 566 },
                    { "NIO", "Cordoba Oro", 558 },
                    { "NOK", "Norwegian Krone", 578 },
                    { "NPR", "Nepalese Rupee", 524 },
                    { "NZD", "New Zealand Dollar", 554 },
                    { "OMR", "Rial Omani", 512 },
                    { "PAB", "Balboa", 590 },
                    { "PEN", "Nuevo Sol", 604 },
                    { "PGK", "Kina", 598 },
                    { "PHP", "Philippine Peso", 608 },
                    { "PKR", "Pakistan Rupee", 586 },
                    { "PLN", "Zloty", 985 },
                    { "PYG", "Guarani", 600 },
                    { "QAR", "Qatari Rial", 634 },
                    { "RON", "Romanian Leu", 946 },
                    { "RSD", "Serbian Dinar", 941 },
                    { "RUB", "Russian Ruble", 643 },
                    { "RWF", "Rwanda Franc", 646 },
                    { "SAR", "Saudi Riyal", 682 },
                    { "SBD", "Solomon Islands Dollar", 90 },
                    { "SCR", "Seychelles Rupee", 690 },
                    { "SDG", "Sudanese Pound", 938 }
                });

            migrationBuilder.InsertData(
                schema: "EldExchange",
                table: "Currencies",
                columns: new[] { "Code", "Name", "Number" },
                values: new object[,]
                {
                    { "SEK", "Swedish Krona", 752 },
                    { "SGD", "Singapore Dollar", 702 },
                    { "SHP", "Saint Helena Pound", 654 },
                    { "SLE", "Leone", 925 },
                    { "SOS", "Somali Shilling", 706 },
                    { "SRD", "Surinam Dollar", 968 },
                    { "SSP", "South Sudanese Pound", 728 },
                    { "STN", "Dobra", 930 },
                    { "SVC", "El Salvador Colon", 222 },
                    { "SYP", "Syrian Pound", 760 },
                    { "SZL", "Lilangeni", 748 },
                    { "THB", "Baht", 764 },
                    { "TJS", "Somoni", 972 },
                    { "TMT", "Turkmenistan New Manat", 934 },
                    { "TND", "Tunisian Dinar", 788 },
                    { "TOP", "Pa’anga", 776 },
                    { "TRY", "Turkish Lira", 949 },
                    { "TTD", "Trinidad and Tobago Dollar", 780 },
                    { "TWD", "New Taiwan Dollar", 901 },
                    { "TZS", "Tanzanian Shilling", 834 },
                    { "UAH", "Hryvnia", 980 },
                    { "UGX", "Uganda Shilling", 800 },
                    { "USD", "US Dollar", 840 },
                    { "USN", "US Dollar (Next day)", 997 },
                    { "UYI", "Uruguay Peso en Unidades Indexadas (URUIURUI)", 940 },
                    { "UYU", "Peso Uruguayo", 858 },
                    { "UZS", "Uzbekistan Sum", 860 },
                    { "VED", "Bolivar", 926 },
                    { "VEF", "Bolivar", 937 },
                    { "VND", "Dong", 704 },
                    { "VUV", "Vatu", 548 },
                    { "WST", "Tala", 882 },
                    { "XAF", "CFA Franc BEAC", 950 },
                    { "XCD", "East Caribbean Dollar", 951 },
                    { "XDR", "SDR (Special Drawing Right)", 960 },
                    { "XOF", "CFA Franc BCEAO", 952 },
                    { "XPF", "CFP Franc", 953 },
                    { "XSU", "Sucre", 994 },
                    { "XUA", "ADB Unit of Account", 965 },
                    { "YER", "Yemeni Rial", 886 },
                    { "ZAR", "Rand", 710 },
                    { "ZMW", "Zambian Kwacha", 967 }
                });

            migrationBuilder.InsertData(
                schema: "EldExchange",
                table: "Currencies",
                columns: new[] { "Code", "Name", "Number" },
                values: new object[] { "ZWL", "Zimbabwe Dollar", 932 });

            migrationBuilder.InsertData(
                schema: "EldExchange",
                table: "Money",
                columns: new[] { "Code", "Type", "Value" },
                values: new object[,]
                {
                    { "BRL", "BankNote", 1m },
                    { "BRL", "BankNote", 2m },
                    { "BRL", "BankNote", 5m },
                    { "BRL", "BankNote", 10m },
                    { "BRL", "BankNote", 20m },
                    { "BRL", "BankNote", 50m },
                    { "BRL", "BankNote", 100m },
                    { "BRL", "BankNote", 200m },
                    { "EUR", "BankNote", 5m },
                    { "EUR", "BankNote", 10m },
                    { "EUR", "BankNote", 20m },
                    { "EUR", "BankNote", 50m },
                    { "EUR", "BankNote", 100m },
                    { "EUR", "BankNote", 200m },
                    { "EUR", "BankNote", 500m },
                    { "USD", "BankNote", 1m },
                    { "USD", "BankNote", 2m },
                    { "USD", "BankNote", 5m },
                    { "USD", "BankNote", 10m },
                    { "USD", "BankNote", 20m },
                    { "USD", "BankNote", 50m },
                    { "USD", "BankNote", 100m },
                    { "BRL", "Coin", 0.01m },
                    { "BRL", "Coin", 0.05m },
                    { "BRL", "Coin", 0.1m },
                    { "BRL", "Coin", 0.25m },
                    { "BRL", "Coin", 0.5m },
                    { "BRL", "Coin", 1m },
                    { "EUR", "Coin", 0.01m },
                    { "EUR", "Coin", 0.02m },
                    { "EUR", "Coin", 0.05m },
                    { "EUR", "Coin", 0.1m },
                    { "EUR", "Coin", 0.2m },
                    { "EUR", "Coin", 0.5m },
                    { "EUR", "Coin", 1m },
                    { "EUR", "Coin", 2m },
                    { "USD", "Coin", 0.01m },
                    { "USD", "Coin", 0.05m },
                    { "USD", "Coin", 0.1m },
                    { "USD", "Coin", 0.25m },
                    { "USD", "Coin", 0.5m },
                    { "USD", "Coin", 1m }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Safe_AgencyId",
                schema: "EldExchange",
                table: "Safe",
                column: "AgencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Safe_AgencyId1",
                schema: "EldExchange",
                table: "Safe",
                column: "AgencyId1");

            migrationBuilder.CreateIndex(
                name: "IX_Telephones_AgencyId",
                schema: "EldExchange",
                table: "Telephones",
                column: "AgencyId");

            migrationBuilder.CreateIndex(
                name: "IX_Telephones_Number_RegionCode_CountryCode",
                schema: "EldExchange",
                table: "Telephones",
                columns: new[] { "Number", "RegionCode", "CountryCode" },
                unique: true,
                filter: "[RegionCode] IS NOT NULL");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Addresses",
                schema: "EldExchange");

            migrationBuilder.DropTable(
                name: "Safe",
                schema: "EldExchange");

            migrationBuilder.DropTable(
                name: "Telephones",
                schema: "EldExchange");

            migrationBuilder.DropTable(
                name: "Money",
                schema: "EldExchange");

            migrationBuilder.DropTable(
                name: "Agencies",
                schema: "EldExchange");

            migrationBuilder.DropTable(
                name: "Currencies",
                schema: "EldExchange");
        }
    }
}
