IF SCHEMA_ID(N'EldExchange') IS NULL EXEC(N'CREATE SCHEMA [EldExchange];');
GO


CREATE TABLE [EldExchange].[Agencies] (
    [Id] uniqueidentifier NOT NULL,
    [Name] nvarchar(250) NOT NULL,
    [CNPJ] char(18) NOT NULL,
    [IsWorking] bit NOT NULL,
    CONSTRAINT [PK_Agencies] PRIMARY KEY ([Id])
);
GO


CREATE TABLE [EldExchange].[Currencies] (
    [Code] char(3) NOT NULL,
    [Country] nvarchar(100) NOT NULL,
    [Name] nvarchar(100) NOT NULL,
    [Number] int NULL,
    CONSTRAINT [PK_Currencies] PRIMARY KEY ([Code])
);
GO


CREATE TABLE [EldExchange].[Addresses] (
    [Id] uniqueidentifier NOT NULL,
    [ZipCode] nvarchar(max) NOT NULL,
    [StreetName] nvarchar(150) NOT NULL,
    [Number] nvarchar(50) NOT NULL,
    [Complement] nvarchar(150) NULL,
    [Country] nvarchar(150) NOT NULL,
    [City] nvarchar(150) NULL,
    CONSTRAINT [PK_Addresses] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Addresses_Agencies_Id] FOREIGN KEY ([Id]) REFERENCES [EldExchange].[Agencies] ([Id]) ON DELETE CASCADE
);
GO


CREATE TABLE [EldExchange].[Telephones] (
    [Id] uniqueidentifier NOT NULL,
    [CountryCode] varchar(10) NOT NULL,
    [RegionCode] varchar(10) NULL,
    [Number] varchar(20) NOT NULL,
    [Type] varchar(50) NULL,
    [AgencyId] uniqueidentifier NOT NULL,
    CONSTRAINT [PK_Telephones] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Telephones_Agencies_AgencyId] FOREIGN KEY ([AgencyId]) REFERENCES [EldExchange].[Agencies] ([Id]) ON DELETE CASCADE
);
GO


CREATE TABLE [EldExchange].[Money] (
    [Code] char(3) NOT NULL,
    [Value] decimal(18,2) NOT NULL,
    [Type] nvarchar(50) NOT NULL DEFAULT N'Coin',
    CONSTRAINT [PK_Money] PRIMARY KEY ([Code], [Value], [Type]),
    CONSTRAINT [FK_Money_Currencies_Code] FOREIGN KEY ([Code]) REFERENCES [EldExchange].[Currencies] ([Code]) ON DELETE CASCADE
);
GO


IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Code', N'Country', N'Name', N'Number') AND [object_id] = OBJECT_ID(N'[EldExchange].[Currencies]'))
    SET IDENTITY_INSERT [EldExchange].[Currencies] ON;
INSERT INTO [EldExchange].[Currencies] ([Code], [Country], [Name], [Number])
VALUES ('AED', N'UNITED ARAB EMIRATES (THE)', N'UAE Dirham', 784),
('AFN', N'AFGHANISTAN', N'Afghani', 971),
('ALL', N'ALBANIA', N'Lek', 8),
('AMD', N'ARMENIA', N'Armenian Dram', 51),
('ANG', N'CURAÇAO', N'Netherlands Antillean Guilder', 532),
('AOA', N'ANGOLA', N'Kwanza', 973),
('ARS', N'ARGENTINA', N'Argentine Peso', 32),
('AUD', N'AUSTRALIA', N'Australian Dollar', 36),
('AWG', N'ARUBA', N'Aruban Florin', 533),
('AZN', N'AZERBAIJAN', N'Azerbaijanian Manat', 944),
('BAM', N'BOSNIA AND HERZEGOVINA', N'Convertible Mark', 977),
('BBD', N'BARBADOS', N'Barbados Dollar', 52),
('BDT', N'BANGLADESH', N'Taka', 50),
('BGN', N'BULGARIA', N'Bulgarian Lev', 975),
('BHD', N'BAHRAIN', N'Bahraini Dinar', 48),
('BIF', N'BURUNDI', N'Burundi Franc', 108),
('BMD', N'BERMUDA', N'Bermudian Dollar', 60),
('BND', N'BRUNEI DARUSSALAM', N'Brunei Dollar', 96),
('BOB', N'BOLIVIA (PLURINATIONAL STATE    OF)', N'Boliviano', 68),
('BOV', N'BOLIVIA (PLURINATIONAL STATE    OF)', N'Mvdol', 984),
('BRL', N'BRAZIL', N'Brazilian Real', 986),
('BSD', N'BAHAMAS (THE)', N'Bahamian Dollar', 44),
('BTN', N'BHUTAN', N'Ngultrum', 64),
('BWP', N'BOTSWANA', N'Pula', 72),
('BYN', N'BELARUS', N'Belarussian Ruble', 933),
('BZD', N'BELIZE', N'Belize Dollar', 84),
('CAD', N'CANADA', N'Canadian Dollar', 124),
('CDF', N'CONGO (THE DEMOCRATIC    REPUBLIC OF THE)', N'Congolese Franc', 976),
('CHE', N'SWITZERLAND', N'WIR Euro', 947),
('CHF', N'LIECHTENSTEIN', N'Swiss Franc', 756),
('CHW', N'SWITZERLAND', N'WIR Franc', 948),
('CLF', N'CHILE', N'Unidad de Fomento', 990),
('CLP', N'CHILE', N'Chilean Peso', 152),
('CNY', N'CHINA', N'Yuan Renminbi', 156),
('COP', N'COLOMBIA', N'Colombian Peso', 170),
('COU', N'COLOMBIA', N'Unidad de Valor Real', 970),
('CRC', N'COSTA RICA', N'Costa Rican Colon', 188),
('CUC', N'CUBA', N'Peso Convertible', 931),
('CUP', N'CUBA', N'Cuban Peso', 192),
('CVE', N'CABO VERDE', N'Cabo Verde Escudo', 132),
('CZK', N'CZECH REPUBLIC (THE)', N'Czech Koruna', 203),
('DJF', N'DJIBOUTI', N'Djibouti Franc', 262);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Code', N'Country', N'Name', N'Number') AND [object_id] = OBJECT_ID(N'[EldExchange].[Currencies]'))
    SET IDENTITY_INSERT [EldExchange].[Currencies] OFF;
GO


IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Code', N'Country', N'Name', N'Number') AND [object_id] = OBJECT_ID(N'[EldExchange].[Currencies]'))
    SET IDENTITY_INSERT [EldExchange].[Currencies] ON;
INSERT INTO [EldExchange].[Currencies] ([Code], [Country], [Name], [Number])
VALUES ('DKK', N'DENMARK', N'Danish Krone', 208),
('DOP', N'DOMINICAN REPUBLIC (THE)', N'Dominican Peso', 214),
('DZD', N'ALGERIA', N'Algerian Dinar', 12),
('EGP', N'EGYPT', N'Egyptian Pound', 818),
('ERN', N'ERITREA', N'Nakfa', 232),
('ETB', N'ETHIOPIA', N'Ethiopian Birr', 230),
('EUR', N'ÅLAND ISLANDS', N'Euro', 978),
('FJD', N'FIJI', N'Fiji Dollar', 242),
('FKP', N'FALKLAND ISLANDS (THE)    [MALVINAS]', N'Falkland Islands Pound', 238),
('GBP', N'GUERNSEY', N'Pound Sterling', 826),
('GEL', N'GEORGIA', N'Lari', 981),
('GHS', N'GHANA', N'Ghana Cedi', 936),
('GIP', N'GIBRALTAR', N'Gibraltar Pound', 292),
('GMD', N'GAMBIA (THE)', N'Dalasi', 270),
('GNF', N'GUINEA', N'Guinea Franc', 324),
('GTQ', N'GUATEMALA', N'Quetzal', 320),
('GYD', N'GUYANA', N'Guyana Dollar', 328),
('HKD', N'HONG KONG', N'Hong Kong Dollar', 344),
('HNL', N'HONDURAS', N'Lempira', 340),
('HRK', N'CROATIA', N'Kuna', 191),
('HTG', N'HAITI', N'Gourde', 332),
('HUF', N'HUNGARY', N'Forint', 348),
('IDR', N'INDONESIA', N'Rupiah', 360),
('ILS', N'ISRAEL', N'New Israeli Sheqel', 376),
('INR', N'BHUTAN', N'Indian Rupee', 356),
('IQD', N'IRAQ', N'Iraqi Dinar', 368),
('IRR', N'IRAN (ISLAMIC REPUBLIC OF)', N'Iranian Rial', 364),
('ISK', N'ICELAND', N'Iceland Krona', 352),
('JMD', N'JAMAICA', N'Jamaican Dollar', 388),
('JOD', N'JORDAN', N'Jordanian Dinar', 400),
('JPY', N'JAPAN', N'Yen', 392),
('KES', N'KENYA', N'Kenyan Shilling', 404),
('KGS', N'KYRGYZSTAN', N'Som', 417),
('KHR', N'CAMBODIA', N'Riel', 116),
('KMF', N'COMOROS (THE)', N'Comoro Franc', 174),
('KPW', N'KOREA (THE DEMOCRATIC    PEOPLE’S REPUBLIC OF)', N'North Korean Won', 408),
('KRW', N'KOREA (THE REPUBLIC OF)', N'Won', 410),
('KWD', N'KUWAIT', N'Kuwaiti Dinar', 414),
('KYD', N'CAYMAN ISLANDS (THE)', N'Cayman Islands Dollar', 136),
('KZT', N'KAZAKHSTAN', N'Tenge', 398),
('LAK', N'LAO PEOPLE’S DEMOCRATIC    REPUBLIC (THE)', N'Kip', 418),
('LBP', N'LEBANON', N'Lebanese Pound', 422);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Code', N'Country', N'Name', N'Number') AND [object_id] = OBJECT_ID(N'[EldExchange].[Currencies]'))
    SET IDENTITY_INSERT [EldExchange].[Currencies] OFF;
GO


IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Code', N'Country', N'Name', N'Number') AND [object_id] = OBJECT_ID(N'[EldExchange].[Currencies]'))
    SET IDENTITY_INSERT [EldExchange].[Currencies] ON;
INSERT INTO [EldExchange].[Currencies] ([Code], [Country], [Name], [Number])
VALUES ('LKR', N'SRI LANKA', N'Sri Lanka Rupee', 144),
('LRD', N'LIBERIA', N'Liberian Dollar', 430),
('LSL', N'LESOTHO', N'Loti', 426),
('LYD', N'LIBYA', N'Libyan Dinar', 434),
('MAD', N'MOROCCO', N'Moroccan Dirham', 504),
('MDL', N'MOLDOVA (THE REPUBLIC OF)', N'Moldovan Leu', 498),
('MGA', N'MADAGASCAR', N'Malagasy Ariary', 969),
('MKD', N'REPUBLIC OF NORTH MACEDONIA', N'Denar', 807),
('MMK', N'MYANMAR', N'Kyat', 104),
('MNT', N'MONGOLIA', N'Tugrik', 496),
('MOP', N'MACAO', N'Pataca', 446),
('MRU', N'MAURITANIA', N'Ouguiya', 929),
('MUR', N'MAURITIUS', N'Mauritius Rupee', 480),
('MVR', N'MALDIVES', N'Rufiyaa', 462),
('MWK', N'MALAWI', N'Kwacha', 454),
('MXN', N'MEXICO', N'Mexican Peso', 484),
('MXV', N'MEXICO', N'Mexican Unidad de Inversion (UDI)', 979),
('MYR', N'MALAYSIA', N'Malaysian Ringgit', 458),
('MZN', N'MOZAMBIQUE', N'Mozambique Metical', 943),
('NAD', N'NAMIBIA', N'Namibia Dollar', 516),
('NGN', N'NIGERIA', N'Naira', 566),
('NIO', N'NICARAGUA', N'Cordoba Oro', 558),
('NOK', N'BOUVET ISLAND', N'Norwegian Krone', 578),
('NPR', N'NEPAL', N'Nepalese Rupee', 524),
('NZD', N'COOK ISLANDS (THE)', N'New Zealand Dollar', 554),
('OMR', N'OMAN', N'Rial Omani', 512),
('PAB', N'PANAMA', N'Balboa', 590),
('PEN', N'PERU', N'Nuevo Sol', 604),
('PGK', N'PAPUA NEW GUINEA', N'Kina', 598),
('PHP', N'PHILIPPINES (THE)', N'Philippine Peso', 608),
('PKR', N'PAKISTAN', N'Pakistan Rupee', 586),
('PLN', N'POLAND', N'Zloty', 985),
('PYG', N'PARAGUAY', N'Guarani', 600),
('QAR', N'QATAR', N'Qatari Rial', 634),
('RON', N'ROMANIA', N'Romanian Leu', 946),
('RSD', N'SERBIA', N'Serbian Dinar', 941),
('RUB', N'RUSSIAN FEDERATION (THE)', N'Russian Ruble', 643),
('RWF', N'RWANDA', N'Rwanda Franc', 646),
('SAR', N'SAUDI ARABIA', N'Saudi Riyal', 682),
('SBD', N'SOLOMON ISLANDS', N'Solomon Islands Dollar', 90),
('SCR', N'SEYCHELLES', N'Seychelles Rupee', 690),
('SDG', N'SUDAN (THE)', N'Sudanese Pound', 938);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Code', N'Country', N'Name', N'Number') AND [object_id] = OBJECT_ID(N'[EldExchange].[Currencies]'))
    SET IDENTITY_INSERT [EldExchange].[Currencies] OFF;
GO


IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Code', N'Country', N'Name', N'Number') AND [object_id] = OBJECT_ID(N'[EldExchange].[Currencies]'))
    SET IDENTITY_INSERT [EldExchange].[Currencies] ON;
INSERT INTO [EldExchange].[Currencies] ([Code], [Country], [Name], [Number])
VALUES ('SEK', N'SWEDEN', N'Swedish Krona', 752),
('SGD', N'SINGAPORE', N'Singapore Dollar', 702),
('SHP', N'SAINT HELENA, ASCENSION AND    TRISTAN DA CUNHA', N'Saint Helena Pound', 654),
('SLE', N'SIERRA LEONE', N'Leone', 925),
('SOS', N'SOMALIA', N'Somali Shilling', 706),
('SRD', N'SURINAME', N'Surinam Dollar', 968),
('SSP', N'SOUTH SUDAN', N'South Sudanese Pound', 728),
('STN', N'SAO TOME AND PRINCIPE', N'Dobra', 930),
('SVC', N'EL SALVADOR', N'El Salvador Colon', 222),
('SYP', N'SYRIAN ARAB REPUBLIC', N'Syrian Pound', 760),
('SZL', N'SWAZILAND', N'Lilangeni', 748),
('THB', N'THAILAND', N'Baht', 764),
('TJS', N'TAJIKISTAN', N'Somoni', 972),
('TMT', N'TURKMENISTAN', N'Turkmenistan New Manat', 934),
('TND', N'TUNISIA', N'Tunisian Dinar', 788),
('TOP', N'TONGA', N'Pa’anga', 776),
('TRY', N'TURKEY', N'Turkish Lira', 949),
('TTD', N'TRINIDAD AND TOBAGO', N'Trinidad and Tobago Dollar', 780),
('TWD', N'TAIWAN (PROVINCE OF CHINA)', N'New Taiwan Dollar', 901),
('TZS', N'TANZANIA, UNITED REPUBLIC OF', N'Tanzanian Shilling', 834),
('UAH', N'UKRAINE', N'Hryvnia', 980),
('UGX', N'UGANDA', N'Uganda Shilling', 800),
('USD', N'AMERICAN SAMOA', N'US Dollar', 840),
('USN', N'UNITED STATES OF AMERICA    (THE)', N'US Dollar (Next day)', 997),
('UYI', N'URUGUAY', N'Uruguay Peso en Unidades Indexadas (URUIURUI)', 940),
('UYU', N'URUGUAY', N'Peso Uruguayo', 858),
('UZS', N'UZBEKISTAN', N'Uzbekistan Sum', 860),
('VED', N'VENEZUELA (BOLIVARIAN REPUBLIC OF)', N'Bolivar', 926),
('VEF', N'VENEZUELA (BOLIVARIAN REPUBLIC OF)', N'Bolivar', 937),
('VND', N'VIET NAM', N'Dong', 704),
('VUV', N'VANUATU', N'Vatu', 548),
('WST', N'SAMOA', N'Tala', 882),
('XAF', N'CAMEROON', N'CFA Franc BEAC', 950),
('XCD', N'ANGUILLA', N'East Caribbean Dollar', 951),
('XDR', N'INTERNATIONAL MONETARY FUND    (IMF)', N'SDR (Special Drawing Right)', 960),
('XOF', N'BENIN', N'CFA Franc BCEAO', 952),
('XPF', N'FRENCH POLYNESIA', N'CFP Franc', 953),
('XSU', N'SISTEMA UNITARIO DE    COMPENSACION REGIONAL DE PAGOS "SUCRE"', N'Sucre', 994),
('XUA', N'MEMBER COUNTRIES OF THE    AFRICAN DEVELOPMENT BANK GROUP', N'ADB Unit of Account', 965),
('YER', N'YEMEN', N'Yemeni Rial', 886),
('ZAR', N'LESOTHO', N'Rand', 710),
('ZMW', N'ZAMBIA', N'Zambian Kwacha', 967);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Code', N'Country', N'Name', N'Number') AND [object_id] = OBJECT_ID(N'[EldExchange].[Currencies]'))
    SET IDENTITY_INSERT [EldExchange].[Currencies] OFF;
GO


IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Code', N'Country', N'Name', N'Number') AND [object_id] = OBJECT_ID(N'[EldExchange].[Currencies]'))
    SET IDENTITY_INSERT [EldExchange].[Currencies] ON;
INSERT INTO [EldExchange].[Currencies] ([Code], [Country], [Name], [Number])
VALUES ('ZWL', N'ZIMBABWE', N'Zimbabwe Dollar', 932);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Code', N'Country', N'Name', N'Number') AND [object_id] = OBJECT_ID(N'[EldExchange].[Currencies]'))
    SET IDENTITY_INSERT [EldExchange].[Currencies] OFF;
GO


IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Code', N'Type', N'Value') AND [object_id] = OBJECT_ID(N'[EldExchange].[Money]'))
    SET IDENTITY_INSERT [EldExchange].[Money] ON;
INSERT INTO [EldExchange].[Money] ([Code], [Type], [Value])
VALUES ('USD', N'BankNote', 1.0);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Code', N'Type', N'Value') AND [object_id] = OBJECT_ID(N'[EldExchange].[Money]'))
    SET IDENTITY_INSERT [EldExchange].[Money] OFF;
GO


IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Code', N'Type', N'Value') AND [object_id] = OBJECT_ID(N'[EldExchange].[Money]'))
    SET IDENTITY_INSERT [EldExchange].[Money] ON;
INSERT INTO [EldExchange].[Money] ([Code], [Type], [Value])
VALUES ('USD', N'Coin', 1.0);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Code', N'Type', N'Value') AND [object_id] = OBJECT_ID(N'[EldExchange].[Money]'))
    SET IDENTITY_INSERT [EldExchange].[Money] OFF;
GO


CREATE INDEX [IX_Telephones_AgencyId] ON [EldExchange].[Telephones] ([AgencyId]);
GO


CREATE UNIQUE INDEX [IX_Telephones_Number_RegionCode_CountryCode] ON [EldExchange].[Telephones] ([Number], [RegionCode], [CountryCode]) WHERE [RegionCode] IS NOT NULL;
GO


