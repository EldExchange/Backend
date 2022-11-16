using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EldExchange.Infra.Context.Migrations
{
    public partial class InitialMigration2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Country",
                schema: "EldExchange",
                table: "Currencies");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Country",
                schema: "EldExchange",
                table: "Currencies",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "AED",
                column: "Country",
                value: "UNITED ARAB EMIRATES (THE)");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "AFN",
                column: "Country",
                value: "AFGHANISTAN");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "ALL",
                column: "Country",
                value: "ALBANIA");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "AMD",
                column: "Country",
                value: "ARMENIA");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "ANG",
                column: "Country",
                value: "CURAÇAO");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "AOA",
                column: "Country",
                value: "ANGOLA");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "ARS",
                column: "Country",
                value: "ARGENTINA");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "AUD",
                column: "Country",
                value: "AUSTRALIA");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "AWG",
                column: "Country",
                value: "ARUBA");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "AZN",
                column: "Country",
                value: "AZERBAIJAN");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "BAM",
                column: "Country",
                value: "BOSNIA AND HERZEGOVINA");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "BBD",
                column: "Country",
                value: "BARBADOS");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "BDT",
                column: "Country",
                value: "BANGLADESH");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "BGN",
                column: "Country",
                value: "BULGARIA");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "BHD",
                column: "Country",
                value: "BAHRAIN");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "BIF",
                column: "Country",
                value: "BURUNDI");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "BMD",
                column: "Country",
                value: "BERMUDA");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "BND",
                column: "Country",
                value: "BRUNEI DARUSSALAM");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "BOB",
                column: "Country",
                value: "BOLIVIA (PLURINATIONAL STATE    OF)");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "BOV",
                column: "Country",
                value: "BOLIVIA (PLURINATIONAL STATE    OF)");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "BRL",
                column: "Country",
                value: "BRAZIL");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "BSD",
                column: "Country",
                value: "BAHAMAS (THE)");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "BTN",
                column: "Country",
                value: "BHUTAN");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "BWP",
                column: "Country",
                value: "BOTSWANA");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "BYN",
                column: "Country",
                value: "BELARUS");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "BZD",
                column: "Country",
                value: "BELIZE");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "CAD",
                column: "Country",
                value: "CANADA");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "CDF",
                column: "Country",
                value: "CONGO (THE DEMOCRATIC    REPUBLIC OF THE)");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "CHE",
                column: "Country",
                value: "SWITZERLAND");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "CHF",
                column: "Country",
                value: "LIECHTENSTEIN");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "CHW",
                column: "Country",
                value: "SWITZERLAND");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "CLF",
                column: "Country",
                value: "CHILE");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "CLP",
                column: "Country",
                value: "CHILE");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "CNY",
                column: "Country",
                value: "CHINA");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "COP",
                column: "Country",
                value: "COLOMBIA");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "COU",
                column: "Country",
                value: "COLOMBIA");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "CRC",
                column: "Country",
                value: "COSTA RICA");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "CUC",
                column: "Country",
                value: "CUBA");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "CUP",
                column: "Country",
                value: "CUBA");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "CVE",
                column: "Country",
                value: "CABO VERDE");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "CZK",
                column: "Country",
                value: "CZECH REPUBLIC (THE)");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "DJF",
                column: "Country",
                value: "DJIBOUTI");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "DKK",
                column: "Country",
                value: "DENMARK");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "DOP",
                column: "Country",
                value: "DOMINICAN REPUBLIC (THE)");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "DZD",
                column: "Country",
                value: "ALGERIA");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "EGP",
                column: "Country",
                value: "EGYPT");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "ERN",
                column: "Country",
                value: "ERITREA");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "ETB",
                column: "Country",
                value: "ETHIOPIA");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "EUR",
                column: "Country",
                value: "ÅLAND ISLANDS");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "FJD",
                column: "Country",
                value: "FIJI");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "FKP",
                column: "Country",
                value: "FALKLAND ISLANDS (THE)    [MALVINAS]");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "GBP",
                column: "Country",
                value: "GUERNSEY");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "GEL",
                column: "Country",
                value: "GEORGIA");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "GHS",
                column: "Country",
                value: "GHANA");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "GIP",
                column: "Country",
                value: "GIBRALTAR");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "GMD",
                column: "Country",
                value: "GAMBIA (THE)");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "GNF",
                column: "Country",
                value: "GUINEA");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "GTQ",
                column: "Country",
                value: "GUATEMALA");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "GYD",
                column: "Country",
                value: "GUYANA");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "HKD",
                column: "Country",
                value: "HONG KONG");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "HNL",
                column: "Country",
                value: "HONDURAS");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "HRK",
                column: "Country",
                value: "CROATIA");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "HTG",
                column: "Country",
                value: "HAITI");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "HUF",
                column: "Country",
                value: "HUNGARY");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "IDR",
                column: "Country",
                value: "INDONESIA");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "ILS",
                column: "Country",
                value: "ISRAEL");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "INR",
                column: "Country",
                value: "BHUTAN");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "IQD",
                column: "Country",
                value: "IRAQ");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "IRR",
                column: "Country",
                value: "IRAN (ISLAMIC REPUBLIC OF)");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "ISK",
                column: "Country",
                value: "ICELAND");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "JMD",
                column: "Country",
                value: "JAMAICA");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "JOD",
                column: "Country",
                value: "JORDAN");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "JPY",
                column: "Country",
                value: "JAPAN");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "KES",
                column: "Country",
                value: "KENYA");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "KGS",
                column: "Country",
                value: "KYRGYZSTAN");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "KHR",
                column: "Country",
                value: "CAMBODIA");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "KMF",
                column: "Country",
                value: "COMOROS (THE)");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "KPW",
                column: "Country",
                value: "KOREA (THE DEMOCRATIC    PEOPLE’S REPUBLIC OF)");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "KRW",
                column: "Country",
                value: "KOREA (THE REPUBLIC OF)");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "KWD",
                column: "Country",
                value: "KUWAIT");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "KYD",
                column: "Country",
                value: "CAYMAN ISLANDS (THE)");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "KZT",
                column: "Country",
                value: "KAZAKHSTAN");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "LAK",
                column: "Country",
                value: "LAO PEOPLE’S DEMOCRATIC    REPUBLIC (THE)");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "LBP",
                column: "Country",
                value: "LEBANON");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "LKR",
                column: "Country",
                value: "SRI LANKA");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "LRD",
                column: "Country",
                value: "LIBERIA");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "LSL",
                column: "Country",
                value: "LESOTHO");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "LYD",
                column: "Country",
                value: "LIBYA");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "MAD",
                column: "Country",
                value: "MOROCCO");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "MDL",
                column: "Country",
                value: "MOLDOVA (THE REPUBLIC OF)");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "MGA",
                column: "Country",
                value: "MADAGASCAR");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "MKD",
                column: "Country",
                value: "REPUBLIC OF NORTH MACEDONIA");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "MMK",
                column: "Country",
                value: "MYANMAR");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "MNT",
                column: "Country",
                value: "MONGOLIA");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "MOP",
                column: "Country",
                value: "MACAO");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "MRU",
                column: "Country",
                value: "MAURITANIA");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "MUR",
                column: "Country",
                value: "MAURITIUS");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "MVR",
                column: "Country",
                value: "MALDIVES");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "MWK",
                column: "Country",
                value: "MALAWI");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "MXN",
                column: "Country",
                value: "MEXICO");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "MXV",
                column: "Country",
                value: "MEXICO");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "MYR",
                column: "Country",
                value: "MALAYSIA");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "MZN",
                column: "Country",
                value: "MOZAMBIQUE");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "NAD",
                column: "Country",
                value: "NAMIBIA");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "NGN",
                column: "Country",
                value: "NIGERIA");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "NIO",
                column: "Country",
                value: "NICARAGUA");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "NOK",
                column: "Country",
                value: "BOUVET ISLAND");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "NPR",
                column: "Country",
                value: "NEPAL");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "NZD",
                column: "Country",
                value: "COOK ISLANDS (THE)");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "OMR",
                column: "Country",
                value: "OMAN");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "PAB",
                column: "Country",
                value: "PANAMA");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "PEN",
                column: "Country",
                value: "PERU");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "PGK",
                column: "Country",
                value: "PAPUA NEW GUINEA");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "PHP",
                column: "Country",
                value: "PHILIPPINES (THE)");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "PKR",
                column: "Country",
                value: "PAKISTAN");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "PLN",
                column: "Country",
                value: "POLAND");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "PYG",
                column: "Country",
                value: "PARAGUAY");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "QAR",
                column: "Country",
                value: "QATAR");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "RON",
                column: "Country",
                value: "ROMANIA");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "RSD",
                column: "Country",
                value: "SERBIA");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "RUB",
                column: "Country",
                value: "RUSSIAN FEDERATION (THE)");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "RWF",
                column: "Country",
                value: "RWANDA");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "SAR",
                column: "Country",
                value: "SAUDI ARABIA");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "SBD",
                column: "Country",
                value: "SOLOMON ISLANDS");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "SCR",
                column: "Country",
                value: "SEYCHELLES");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "SDG",
                column: "Country",
                value: "SUDAN (THE)");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "SEK",
                column: "Country",
                value: "SWEDEN");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "SGD",
                column: "Country",
                value: "SINGAPORE");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "SHP",
                column: "Country",
                value: "SAINT HELENA, ASCENSION AND    TRISTAN DA CUNHA");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "SLE",
                column: "Country",
                value: "SIERRA LEONE");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "SOS",
                column: "Country",
                value: "SOMALIA");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "SRD",
                column: "Country",
                value: "SURINAME");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "SSP",
                column: "Country",
                value: "SOUTH SUDAN");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "STN",
                column: "Country",
                value: "SAO TOME AND PRINCIPE");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "SVC",
                column: "Country",
                value: "EL SALVADOR");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "SYP",
                column: "Country",
                value: "SYRIAN ARAB REPUBLIC");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "SZL",
                column: "Country",
                value: "SWAZILAND");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "THB",
                column: "Country",
                value: "THAILAND");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "TJS",
                column: "Country",
                value: "TAJIKISTAN");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "TMT",
                column: "Country",
                value: "TURKMENISTAN");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "TND",
                column: "Country",
                value: "TUNISIA");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "TOP",
                column: "Country",
                value: "TONGA");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "TRY",
                column: "Country",
                value: "TURKEY");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "TTD",
                column: "Country",
                value: "TRINIDAD AND TOBAGO");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "TWD",
                column: "Country",
                value: "TAIWAN (PROVINCE OF CHINA)");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "TZS",
                column: "Country",
                value: "TANZANIA, UNITED REPUBLIC OF");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "UAH",
                column: "Country",
                value: "UKRAINE");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "UGX",
                column: "Country",
                value: "UGANDA");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "USD",
                column: "Country",
                value: "AMERICAN SAMOA");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "USN",
                column: "Country",
                value: "UNITED STATES OF AMERICA    (THE)");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "UYI",
                column: "Country",
                value: "URUGUAY");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "UYU",
                column: "Country",
                value: "URUGUAY");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "UZS",
                column: "Country",
                value: "UZBEKISTAN");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "VED",
                column: "Country",
                value: "VENEZUELA (BOLIVARIAN REPUBLIC OF)");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "VEF",
                column: "Country",
                value: "VENEZUELA (BOLIVARIAN REPUBLIC OF)");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "VND",
                column: "Country",
                value: "VIET NAM");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "VUV",
                column: "Country",
                value: "VANUATU");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "WST",
                column: "Country",
                value: "SAMOA");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "XAF",
                column: "Country",
                value: "CAMEROON");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "XCD",
                column: "Country",
                value: "ANGUILLA");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "XDR",
                column: "Country",
                value: "INTERNATIONAL MONETARY FUND    (IMF)");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "XOF",
                column: "Country",
                value: "BENIN");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "XPF",
                column: "Country",
                value: "FRENCH POLYNESIA");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "XSU",
                column: "Country",
                value: "SISTEMA UNITARIO DE    COMPENSACION REGIONAL DE PAGOS \"SUCRE\"");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "XUA",
                column: "Country",
                value: "MEMBER COUNTRIES OF THE    AFRICAN DEVELOPMENT BANK GROUP");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "YER",
                column: "Country",
                value: "YEMEN");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "ZAR",
                column: "Country",
                value: "LESOTHO");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "ZMW",
                column: "Country",
                value: "ZAMBIA");

            migrationBuilder.UpdateData(
                schema: "EldExchange",
                table: "Currencies",
                keyColumn: "Code",
                keyValue: "ZWL",
                column: "Country",
                value: "ZIMBABWE");
        }
    }
}
