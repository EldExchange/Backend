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
                    Country = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
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

            migrationBuilder.InsertData(
                schema: "EldExchange",
                table: "Currencies",
                columns: new[] { "Code", "Country", "Name", "Number" },
                values: new object[,]
                {
                    { "AED", "UNITED ARAB EMIRATES (THE)", "UAE Dirham", 784 },
                    { "AFN", "AFGHANISTAN", "Afghani", 971 },
                    { "ALL", "ALBANIA", "Lek", 8 },
                    { "AMD", "ARMENIA", "Armenian Dram", 51 },
                    { "ANG", "CURAÇAO", "Netherlands Antillean Guilder", 532 },
                    { "AOA", "ANGOLA", "Kwanza", 973 },
                    { "ARS", "ARGENTINA", "Argentine Peso", 32 },
                    { "AUD", "AUSTRALIA", "Australian Dollar", 36 },
                    { "AWG", "ARUBA", "Aruban Florin", 533 },
                    { "AZN", "AZERBAIJAN", "Azerbaijanian Manat", 944 },
                    { "BAM", "BOSNIA AND HERZEGOVINA", "Convertible Mark", 977 },
                    { "BBD", "BARBADOS", "Barbados Dollar", 52 },
                    { "BDT", "BANGLADESH", "Taka", 50 },
                    { "BGN", "BULGARIA", "Bulgarian Lev", 975 },
                    { "BHD", "BAHRAIN", "Bahraini Dinar", 48 },
                    { "BIF", "BURUNDI", "Burundi Franc", 108 },
                    { "BMD", "BERMUDA", "Bermudian Dollar", 60 },
                    { "BND", "BRUNEI DARUSSALAM", "Brunei Dollar", 96 },
                    { "BOB", "BOLIVIA (PLURINATIONAL STATE    OF)", "Boliviano", 68 },
                    { "BOV", "BOLIVIA (PLURINATIONAL STATE    OF)", "Mvdol", 984 },
                    { "BRL", "BRAZIL", "Brazilian Real", 986 },
                    { "BSD", "BAHAMAS (THE)", "Bahamian Dollar", 44 },
                    { "BTN", "BHUTAN", "Ngultrum", 64 },
                    { "BWP", "BOTSWANA", "Pula", 72 },
                    { "BYN", "BELARUS", "Belarussian Ruble", 933 },
                    { "BZD", "BELIZE", "Belize Dollar", 84 },
                    { "CAD", "CANADA", "Canadian Dollar", 124 },
                    { "CDF", "CONGO (THE DEMOCRATIC    REPUBLIC OF THE)", "Congolese Franc", 976 },
                    { "CHE", "SWITZERLAND", "WIR Euro", 947 },
                    { "CHF", "LIECHTENSTEIN", "Swiss Franc", 756 },
                    { "CHW", "SWITZERLAND", "WIR Franc", 948 },
                    { "CLF", "CHILE", "Unidad de Fomento", 990 },
                    { "CLP", "CHILE", "Chilean Peso", 152 },
                    { "CNY", "CHINA", "Yuan Renminbi", 156 },
                    { "COP", "COLOMBIA", "Colombian Peso", 170 },
                    { "COU", "COLOMBIA", "Unidad de Valor Real", 970 },
                    { "CRC", "COSTA RICA", "Costa Rican Colon", 188 },
                    { "CUC", "CUBA", "Peso Convertible", 931 },
                    { "CUP", "CUBA", "Cuban Peso", 192 },
                    { "CVE", "CABO VERDE", "Cabo Verde Escudo", 132 },
                    { "CZK", "CZECH REPUBLIC (THE)", "Czech Koruna", 203 },
                    { "DJF", "DJIBOUTI", "Djibouti Franc", 262 }
                });

            migrationBuilder.InsertData(
                schema: "EldExchange",
                table: "Currencies",
                columns: new[] { "Code", "Country", "Name", "Number" },
                values: new object[,]
                {
                    { "DKK", "DENMARK", "Danish Krone", 208 },
                    { "DOP", "DOMINICAN REPUBLIC (THE)", "Dominican Peso", 214 },
                    { "DZD", "ALGERIA", "Algerian Dinar", 12 },
                    { "EGP", "EGYPT", "Egyptian Pound", 818 },
                    { "ERN", "ERITREA", "Nakfa", 232 },
                    { "ETB", "ETHIOPIA", "Ethiopian Birr", 230 },
                    { "EUR", "ÅLAND ISLANDS", "Euro", 978 },
                    { "FJD", "FIJI", "Fiji Dollar", 242 },
                    { "FKP", "FALKLAND ISLANDS (THE)    [MALVINAS]", "Falkland Islands Pound", 238 },
                    { "GBP", "GUERNSEY", "Pound Sterling", 826 },
                    { "GEL", "GEORGIA", "Lari", 981 },
                    { "GHS", "GHANA", "Ghana Cedi", 936 },
                    { "GIP", "GIBRALTAR", "Gibraltar Pound", 292 },
                    { "GMD", "GAMBIA (THE)", "Dalasi", 270 },
                    { "GNF", "GUINEA", "Guinea Franc", 324 },
                    { "GTQ", "GUATEMALA", "Quetzal", 320 },
                    { "GYD", "GUYANA", "Guyana Dollar", 328 },
                    { "HKD", "HONG KONG", "Hong Kong Dollar", 344 },
                    { "HNL", "HONDURAS", "Lempira", 340 },
                    { "HRK", "CROATIA", "Kuna", 191 },
                    { "HTG", "HAITI", "Gourde", 332 },
                    { "HUF", "HUNGARY", "Forint", 348 },
                    { "IDR", "INDONESIA", "Rupiah", 360 },
                    { "ILS", "ISRAEL", "New Israeli Sheqel", 376 },
                    { "INR", "BHUTAN", "Indian Rupee", 356 },
                    { "IQD", "IRAQ", "Iraqi Dinar", 368 },
                    { "IRR", "IRAN (ISLAMIC REPUBLIC OF)", "Iranian Rial", 364 },
                    { "ISK", "ICELAND", "Iceland Krona", 352 },
                    { "JMD", "JAMAICA", "Jamaican Dollar", 388 },
                    { "JOD", "JORDAN", "Jordanian Dinar", 400 },
                    { "JPY", "JAPAN", "Yen", 392 },
                    { "KES", "KENYA", "Kenyan Shilling", 404 },
                    { "KGS", "KYRGYZSTAN", "Som", 417 },
                    { "KHR", "CAMBODIA", "Riel", 116 },
                    { "KMF", "COMOROS (THE)", "Comoro Franc", 174 },
                    { "KPW", "KOREA (THE DEMOCRATIC    PEOPLE’S REPUBLIC OF)", "North Korean Won", 408 },
                    { "KRW", "KOREA (THE REPUBLIC OF)", "Won", 410 },
                    { "KWD", "KUWAIT", "Kuwaiti Dinar", 414 },
                    { "KYD", "CAYMAN ISLANDS (THE)", "Cayman Islands Dollar", 136 },
                    { "KZT", "KAZAKHSTAN", "Tenge", 398 },
                    { "LAK", "LAO PEOPLE’S DEMOCRATIC    REPUBLIC (THE)", "Kip", 418 },
                    { "LBP", "LEBANON", "Lebanese Pound", 422 }
                });

            migrationBuilder.InsertData(
                schema: "EldExchange",
                table: "Currencies",
                columns: new[] { "Code", "Country", "Name", "Number" },
                values: new object[,]
                {
                    { "LKR", "SRI LANKA", "Sri Lanka Rupee", 144 },
                    { "LRD", "LIBERIA", "Liberian Dollar", 430 },
                    { "LSL", "LESOTHO", "Loti", 426 },
                    { "LYD", "LIBYA", "Libyan Dinar", 434 },
                    { "MAD", "MOROCCO", "Moroccan Dirham", 504 },
                    { "MDL", "MOLDOVA (THE REPUBLIC OF)", "Moldovan Leu", 498 },
                    { "MGA", "MADAGASCAR", "Malagasy Ariary", 969 },
                    { "MKD", "REPUBLIC OF NORTH MACEDONIA", "Denar", 807 },
                    { "MMK", "MYANMAR", "Kyat", 104 },
                    { "MNT", "MONGOLIA", "Tugrik", 496 },
                    { "MOP", "MACAO", "Pataca", 446 },
                    { "MRU", "MAURITANIA", "Ouguiya", 929 },
                    { "MUR", "MAURITIUS", "Mauritius Rupee", 480 },
                    { "MVR", "MALDIVES", "Rufiyaa", 462 },
                    { "MWK", "MALAWI", "Kwacha", 454 },
                    { "MXN", "MEXICO", "Mexican Peso", 484 },
                    { "MXV", "MEXICO", "Mexican Unidad de Inversion (UDI)", 979 },
                    { "MYR", "MALAYSIA", "Malaysian Ringgit", 458 },
                    { "MZN", "MOZAMBIQUE", "Mozambique Metical", 943 },
                    { "NAD", "NAMIBIA", "Namibia Dollar", 516 },
                    { "NGN", "NIGERIA", "Naira", 566 },
                    { "NIO", "NICARAGUA", "Cordoba Oro", 558 },
                    { "NOK", "BOUVET ISLAND", "Norwegian Krone", 578 },
                    { "NPR", "NEPAL", "Nepalese Rupee", 524 },
                    { "NZD", "COOK ISLANDS (THE)", "New Zealand Dollar", 554 },
                    { "OMR", "OMAN", "Rial Omani", 512 },
                    { "PAB", "PANAMA", "Balboa", 590 },
                    { "PEN", "PERU", "Nuevo Sol", 604 },
                    { "PGK", "PAPUA NEW GUINEA", "Kina", 598 },
                    { "PHP", "PHILIPPINES (THE)", "Philippine Peso", 608 },
                    { "PKR", "PAKISTAN", "Pakistan Rupee", 586 },
                    { "PLN", "POLAND", "Zloty", 985 },
                    { "PYG", "PARAGUAY", "Guarani", 600 },
                    { "QAR", "QATAR", "Qatari Rial", 634 },
                    { "RON", "ROMANIA", "Romanian Leu", 946 },
                    { "RSD", "SERBIA", "Serbian Dinar", 941 },
                    { "RUB", "RUSSIAN FEDERATION (THE)", "Russian Ruble", 643 },
                    { "RWF", "RWANDA", "Rwanda Franc", 646 },
                    { "SAR", "SAUDI ARABIA", "Saudi Riyal", 682 },
                    { "SBD", "SOLOMON ISLANDS", "Solomon Islands Dollar", 90 },
                    { "SCR", "SEYCHELLES", "Seychelles Rupee", 690 },
                    { "SDG", "SUDAN (THE)", "Sudanese Pound", 938 }
                });

            migrationBuilder.InsertData(
                schema: "EldExchange",
                table: "Currencies",
                columns: new[] { "Code", "Country", "Name", "Number" },
                values: new object[,]
                {
                    { "SEK", "SWEDEN", "Swedish Krona", 752 },
                    { "SGD", "SINGAPORE", "Singapore Dollar", 702 },
                    { "SHP", "SAINT HELENA, ASCENSION AND    TRISTAN DA CUNHA", "Saint Helena Pound", 654 },
                    { "SLE", "SIERRA LEONE", "Leone", 925 },
                    { "SOS", "SOMALIA", "Somali Shilling", 706 },
                    { "SRD", "SURINAME", "Surinam Dollar", 968 },
                    { "SSP", "SOUTH SUDAN", "South Sudanese Pound", 728 },
                    { "STN", "SAO TOME AND PRINCIPE", "Dobra", 930 },
                    { "SVC", "EL SALVADOR", "El Salvador Colon", 222 },
                    { "SYP", "SYRIAN ARAB REPUBLIC", "Syrian Pound", 760 },
                    { "SZL", "SWAZILAND", "Lilangeni", 748 },
                    { "THB", "THAILAND", "Baht", 764 },
                    { "TJS", "TAJIKISTAN", "Somoni", 972 },
                    { "TMT", "TURKMENISTAN", "Turkmenistan New Manat", 934 },
                    { "TND", "TUNISIA", "Tunisian Dinar", 788 },
                    { "TOP", "TONGA", "Pa’anga", 776 },
                    { "TRY", "TURKEY", "Turkish Lira", 949 },
                    { "TTD", "TRINIDAD AND TOBAGO", "Trinidad and Tobago Dollar", 780 },
                    { "TWD", "TAIWAN (PROVINCE OF CHINA)", "New Taiwan Dollar", 901 },
                    { "TZS", "TANZANIA, UNITED REPUBLIC OF", "Tanzanian Shilling", 834 },
                    { "UAH", "UKRAINE", "Hryvnia", 980 },
                    { "UGX", "UGANDA", "Uganda Shilling", 800 },
                    { "USD", "AMERICAN SAMOA", "US Dollar", 840 },
                    { "USN", "UNITED STATES OF AMERICA    (THE)", "US Dollar (Next day)", 997 },
                    { "UYI", "URUGUAY", "Uruguay Peso en Unidades Indexadas (URUIURUI)", 940 },
                    { "UYU", "URUGUAY", "Peso Uruguayo", 858 },
                    { "UZS", "UZBEKISTAN", "Uzbekistan Sum", 860 },
                    { "VED", "VENEZUELA (BOLIVARIAN REPUBLIC OF)", "Bolivar", 926 },
                    { "VEF", "VENEZUELA (BOLIVARIAN REPUBLIC OF)", "Bolivar", 937 },
                    { "VND", "VIET NAM", "Dong", 704 },
                    { "VUV", "VANUATU", "Vatu", 548 },
                    { "WST", "SAMOA", "Tala", 882 },
                    { "XAF", "CAMEROON", "CFA Franc BEAC", 950 },
                    { "XCD", "ANGUILLA", "East Caribbean Dollar", 951 },
                    { "XDR", "INTERNATIONAL MONETARY FUND    (IMF)", "SDR (Special Drawing Right)", 960 },
                    { "XOF", "BENIN", "CFA Franc BCEAO", 952 },
                    { "XPF", "FRENCH POLYNESIA", "CFP Franc", 953 },
                    { "XSU", "SISTEMA UNITARIO DE    COMPENSACION REGIONAL DE PAGOS \"SUCRE\"", "Sucre", 994 },
                    { "XUA", "MEMBER COUNTRIES OF THE    AFRICAN DEVELOPMENT BANK GROUP", "ADB Unit of Account", 965 },
                    { "YER", "YEMEN", "Yemeni Rial", 886 },
                    { "ZAR", "LESOTHO", "Rand", 710 },
                    { "ZMW", "ZAMBIA", "Zambian Kwacha", 967 }
                });

            migrationBuilder.InsertData(
                schema: "EldExchange",
                table: "Currencies",
                columns: new[] { "Code", "Country", "Name", "Number" },
                values: new object[] { "ZWL", "ZIMBABWE", "Zimbabwe Dollar", 932 });

            migrationBuilder.InsertData(
                schema: "EldExchange",
                table: "Money",
                columns: new[] { "Code", "Type", "Value" },
                values: new object[] { "USD", "BankNote", 1m });

            migrationBuilder.InsertData(
                schema: "EldExchange",
                table: "Money",
                columns: new[] { "Code", "Type", "Value" },
                values: new object[] { "USD", "Coin", 1m });

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
                name: "Money",
                schema: "EldExchange");

            migrationBuilder.DropTable(
                name: "Telephones",
                schema: "EldExchange");

            migrationBuilder.DropTable(
                name: "Currencies",
                schema: "EldExchange");

            migrationBuilder.DropTable(
                name: "Agencies",
                schema: "EldExchange");
        }
    }
}
