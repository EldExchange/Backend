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


CREATE TABLE [EldExchange].[Safe] (
    [AgencyId] uniqueidentifier NOT NULL,
    [Code] char(3) NOT NULL,
    [Type] nvarchar(50) NOT NULL,
    [Value] decimal(18,2) NOT NULL,
    [Quantity] int NOT NULL,
    [AgencyId1] uniqueidentifier NULL,
    CONSTRAINT [PK_Safe] PRIMARY KEY ([Code], [Value], [Type], [AgencyId]),
    CONSTRAINT [FK_Safe_Agencies_AgencyId] FOREIGN KEY ([AgencyId]) REFERENCES [EldExchange].[Agencies] ([Id]) ON DELETE CASCADE,
    CONSTRAINT [FK_Safe_Agencies_AgencyId1] FOREIGN KEY ([AgencyId1]) REFERENCES [EldExchange].[Agencies] ([Id]),
    CONSTRAINT [FK_Safe_Money_Code_Value_Type] FOREIGN KEY ([Code], [Value], [Type]) REFERENCES [EldExchange].[Money] ([Code], [Value], [Type]) ON DELETE CASCADE
);
GO


IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Code', N'Name', N'Number') AND [object_id] = OBJECT_ID(N'[EldExchange].[Currencies]'))
    SET IDENTITY_INSERT [EldExchange].[Currencies] ON;
INSERT INTO [EldExchange].[Currencies] ([Code], [Name], [Number])
VALUES ('AED', N'UAE Dirham', 784),
('AFN', N'Afghani', 971),
('ALL', N'Lek', 8),
('AMD', N'Armenian Dram', 51),
('ANG', N'Netherlands Antillean Guilder', 532),
('AOA', N'Kwanza', 973),
('ARS', N'Argentine Peso', 32),
('AUD', N'Australian Dollar', 36),
('AWG', N'Aruban Florin', 533),
('AZN', N'Azerbaijanian Manat', 944),
('BAM', N'Convertible Mark', 977),
('BBD', N'Barbados Dollar', 52),
('BDT', N'Taka', 50),
('BGN', N'Bulgarian Lev', 975),
('BHD', N'Bahraini Dinar', 48),
('BIF', N'Burundi Franc', 108),
('BMD', N'Bermudian Dollar', 60),
('BND', N'Brunei Dollar', 96),
('BOB', N'Boliviano', 68),
('BOV', N'Mvdol', 984),
('BRL', N'Brazilian Real', 986),
('BSD', N'Bahamian Dollar', 44),
('BTN', N'Ngultrum', 64),
('BWP', N'Pula', 72),
('BYN', N'Belarussian Ruble', 933),
('BZD', N'Belize Dollar', 84),
('CAD', N'Canadian Dollar', 124),
('CDF', N'Congolese Franc', 976),
('CHE', N'WIR Euro', 947),
('CHF', N'Swiss Franc', 756),
('CHW', N'WIR Franc', 948),
('CLF', N'Unidad de Fomento', 990),
('CLP', N'Chilean Peso', 152),
('CNY', N'Yuan Renminbi', 156),
('COP', N'Colombian Peso', 170),
('COU', N'Unidad de Valor Real', 970),
('CRC', N'Costa Rican Colon', 188),
('CUC', N'Peso Convertible', 931),
('CUP', N'Cuban Peso', 192),
('CVE', N'Cabo Verde Escudo', 132),
('CZK', N'Czech Koruna', 203),
('DJF', N'Djibouti Franc', 262);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Code', N'Name', N'Number') AND [object_id] = OBJECT_ID(N'[EldExchange].[Currencies]'))
    SET IDENTITY_INSERT [EldExchange].[Currencies] OFF;
GO


IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Code', N'Name', N'Number') AND [object_id] = OBJECT_ID(N'[EldExchange].[Currencies]'))
    SET IDENTITY_INSERT [EldExchange].[Currencies] ON;
INSERT INTO [EldExchange].[Currencies] ([Code], [Name], [Number])
VALUES ('DKK', N'Danish Krone', 208),
('DOP', N'Dominican Peso', 214),
('DZD', N'Algerian Dinar', 12),
('EGP', N'Egyptian Pound', 818),
('ERN', N'Nakfa', 232),
('ETB', N'Ethiopian Birr', 230),
('EUR', N'Euro', 978),
('FJD', N'Fiji Dollar', 242),
('FKP', N'Falkland Islands Pound', 238),
('GBP', N'Pound Sterling', 826),
('GEL', N'Lari', 981),
('GHS', N'Ghana Cedi', 936),
('GIP', N'Gibraltar Pound', 292),
('GMD', N'Dalasi', 270),
('GNF', N'Guinea Franc', 324),
('GTQ', N'Quetzal', 320),
('GYD', N'Guyana Dollar', 328),
('HKD', N'Hong Kong Dollar', 344),
('HNL', N'Lempira', 340),
('HRK', N'Kuna', 191),
('HTG', N'Gourde', 332),
('HUF', N'Forint', 348),
('IDR', N'Rupiah', 360),
('ILS', N'New Israeli Sheqel', 376),
('INR', N'Indian Rupee', 356),
('IQD', N'Iraqi Dinar', 368),
('IRR', N'Iranian Rial', 364),
('ISK', N'Iceland Krona', 352),
('JMD', N'Jamaican Dollar', 388),
('JOD', N'Jordanian Dinar', 400),
('JPY', N'Yen', 392),
('KES', N'Kenyan Shilling', 404),
('KGS', N'Som', 417),
('KHR', N'Riel', 116),
('KMF', N'Comoro Franc', 174),
('KPW', N'North Korean Won', 408),
('KRW', N'Won', 410),
('KWD', N'Kuwaiti Dinar', 414),
('KYD', N'Cayman Islands Dollar', 136),
('KZT', N'Tenge', 398),
('LAK', N'Kip', 418),
('LBP', N'Lebanese Pound', 422);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Code', N'Name', N'Number') AND [object_id] = OBJECT_ID(N'[EldExchange].[Currencies]'))
    SET IDENTITY_INSERT [EldExchange].[Currencies] OFF;
GO


IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Code', N'Name', N'Number') AND [object_id] = OBJECT_ID(N'[EldExchange].[Currencies]'))
    SET IDENTITY_INSERT [EldExchange].[Currencies] ON;
INSERT INTO [EldExchange].[Currencies] ([Code], [Name], [Number])
VALUES ('LKR', N'Sri Lanka Rupee', 144),
('LRD', N'Liberian Dollar', 430),
('LSL', N'Loti', 426),
('LYD', N'Libyan Dinar', 434),
('MAD', N'Moroccan Dirham', 504),
('MDL', N'Moldovan Leu', 498),
('MGA', N'Malagasy Ariary', 969),
('MKD', N'Denar', 807),
('MMK', N'Kyat', 104),
('MNT', N'Tugrik', 496),
('MOP', N'Pataca', 446),
('MRU', N'Ouguiya', 929),
('MUR', N'Mauritius Rupee', 480),
('MVR', N'Rufiyaa', 462),
('MWK', N'Kwacha', 454),
('MXN', N'Mexican Peso', 484),
('MXV', N'Mexican Unidad de Inversion (UDI)', 979),
('MYR', N'Malaysian Ringgit', 458),
('MZN', N'Mozambique Metical', 943),
('NAD', N'Namibia Dollar', 516),
('NGN', N'Naira', 566),
('NIO', N'Cordoba Oro', 558),
('NOK', N'Norwegian Krone', 578),
('NPR', N'Nepalese Rupee', 524),
('NZD', N'New Zealand Dollar', 554),
('OMR', N'Rial Omani', 512),
('PAB', N'Balboa', 590),
('PEN', N'Nuevo Sol', 604),
('PGK', N'Kina', 598),
('PHP', N'Philippine Peso', 608),
('PKR', N'Pakistan Rupee', 586),
('PLN', N'Zloty', 985),
('PYG', N'Guarani', 600),
('QAR', N'Qatari Rial', 634),
('RON', N'Romanian Leu', 946),
('RSD', N'Serbian Dinar', 941),
('RUB', N'Russian Ruble', 643),
('RWF', N'Rwanda Franc', 646),
('SAR', N'Saudi Riyal', 682),
('SBD', N'Solomon Islands Dollar', 90),
('SCR', N'Seychelles Rupee', 690),
('SDG', N'Sudanese Pound', 938);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Code', N'Name', N'Number') AND [object_id] = OBJECT_ID(N'[EldExchange].[Currencies]'))
    SET IDENTITY_INSERT [EldExchange].[Currencies] OFF;
GO


IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Code', N'Name', N'Number') AND [object_id] = OBJECT_ID(N'[EldExchange].[Currencies]'))
    SET IDENTITY_INSERT [EldExchange].[Currencies] ON;
INSERT INTO [EldExchange].[Currencies] ([Code], [Name], [Number])
VALUES ('SEK', N'Swedish Krona', 752),
('SGD', N'Singapore Dollar', 702),
('SHP', N'Saint Helena Pound', 654),
('SLE', N'Leone', 925),
('SOS', N'Somali Shilling', 706),
('SRD', N'Surinam Dollar', 968),
('SSP', N'South Sudanese Pound', 728),
('STN', N'Dobra', 930),
('SVC', N'El Salvador Colon', 222),
('SYP', N'Syrian Pound', 760),
('SZL', N'Lilangeni', 748),
('THB', N'Baht', 764),
('TJS', N'Somoni', 972),
('TMT', N'Turkmenistan New Manat', 934),
('TND', N'Tunisian Dinar', 788),
('TOP', N'Pa’anga', 776),
('TRY', N'Turkish Lira', 949),
('TTD', N'Trinidad and Tobago Dollar', 780),
('TWD', N'New Taiwan Dollar', 901),
('TZS', N'Tanzanian Shilling', 834),
('UAH', N'Hryvnia', 980),
('UGX', N'Uganda Shilling', 800),
('USD', N'US Dollar', 840),
('USN', N'US Dollar (Next day)', 997),
('UYI', N'Uruguay Peso en Unidades Indexadas (URUIURUI)', 940),
('UYU', N'Peso Uruguayo', 858),
('UZS', N'Uzbekistan Sum', 860),
('VED', N'Bolivar', 926),
('VEF', N'Bolivar', 937),
('VND', N'Dong', 704),
('VUV', N'Vatu', 548),
('WST', N'Tala', 882),
('XAF', N'CFA Franc BEAC', 950),
('XCD', N'East Caribbean Dollar', 951),
('XDR', N'SDR (Special Drawing Right)', 960),
('XOF', N'CFA Franc BCEAO', 952),
('XPF', N'CFP Franc', 953),
('XSU', N'Sucre', 994),
('XUA', N'ADB Unit of Account', 965),
('YER', N'Yemeni Rial', 886),
('ZAR', N'Rand', 710),
('ZMW', N'Zambian Kwacha', 967);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Code', N'Name', N'Number') AND [object_id] = OBJECT_ID(N'[EldExchange].[Currencies]'))
    SET IDENTITY_INSERT [EldExchange].[Currencies] OFF;
GO


IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Code', N'Name', N'Number') AND [object_id] = OBJECT_ID(N'[EldExchange].[Currencies]'))
    SET IDENTITY_INSERT [EldExchange].[Currencies] ON;
INSERT INTO [EldExchange].[Currencies] ([Code], [Name], [Number])
VALUES ('ZWL', N'Zimbabwe Dollar', 932);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Code', N'Name', N'Number') AND [object_id] = OBJECT_ID(N'[EldExchange].[Currencies]'))
    SET IDENTITY_INSERT [EldExchange].[Currencies] OFF;
GO


IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Code', N'Type', N'Value') AND [object_id] = OBJECT_ID(N'[EldExchange].[Money]'))
    SET IDENTITY_INSERT [EldExchange].[Money] ON;
INSERT INTO [EldExchange].[Money] ([Code], [Type], [Value])
VALUES ('BRL', N'BankNote', 1.0),
('BRL', N'BankNote', 2.0),
('BRL', N'BankNote', 5.0),
('BRL', N'BankNote', 10.0),
('BRL', N'BankNote', 20.0),
('BRL', N'BankNote', 50.0),
('BRL', N'BankNote', 100.0),
('BRL', N'BankNote', 200.0),
('EUR', N'BankNote', 5.0),
('EUR', N'BankNote', 10.0),
('EUR', N'BankNote', 20.0),
('EUR', N'BankNote', 50.0),
('EUR', N'BankNote', 100.0),
('EUR', N'BankNote', 200.0),
('EUR', N'BankNote', 500.0),
('USD', N'BankNote', 1.0),
('USD', N'BankNote', 2.0),
('USD', N'BankNote', 5.0),
('USD', N'BankNote', 10.0),
('USD', N'BankNote', 20.0),
('USD', N'BankNote', 50.0),
('USD', N'BankNote', 100.0),
('BRL', N'Coin', 0.01),
('BRL', N'Coin', 0.05),
('BRL', N'Coin', 0.1),
('BRL', N'Coin', 0.25),
('BRL', N'Coin', 0.5),
('BRL', N'Coin', 1.0),
('EUR', N'Coin', 0.01),
('EUR', N'Coin', 0.02),
('EUR', N'Coin', 0.05),
('EUR', N'Coin', 0.1),
('EUR', N'Coin', 0.2),
('EUR', N'Coin', 0.5),
('EUR', N'Coin', 1.0),
('EUR', N'Coin', 2.0),
('USD', N'Coin', 0.01),
('USD', N'Coin', 0.05),
('USD', N'Coin', 0.1),
('USD', N'Coin', 0.25),
('USD', N'Coin', 0.5),
('USD', N'Coin', 1.0);
IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'Code', N'Type', N'Value') AND [object_id] = OBJECT_ID(N'[EldExchange].[Money]'))
    SET IDENTITY_INSERT [EldExchange].[Money] OFF;
GO


CREATE INDEX [IX_Safe_AgencyId] ON [EldExchange].[Safe] ([AgencyId]);
GO


CREATE INDEX [IX_Safe_AgencyId1] ON [EldExchange].[Safe] ([AgencyId1]);
GO


CREATE INDEX [IX_Telephones_AgencyId] ON [EldExchange].[Telephones] ([AgencyId]);
GO


CREATE UNIQUE INDEX [IX_Telephones_Number_RegionCode_CountryCode] ON [EldExchange].[Telephones] ([Number], [RegionCode], [CountryCode]) WHERE [RegionCode] IS NOT NULL;
GO


