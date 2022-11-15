CREATE TABLE [agency] (
    [Id] uniqueidentifier NOT NULL,
    [Name] nvarchar(250) NOT NULL,
    [CNPJ] char(18) NOT NULL,
    [IsWorking] bit NOT NULL,
    CONSTRAINT [PK_agency] PRIMARY KEY ([Id])
);
GO


CREATE TABLE [Currencies] (
    [CurrencyCode] nvarchar(450) NOT NULL,
    [Name] nvarchar(max) NOT NULL,
    [Symbol] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Currencies] PRIMARY KEY ([CurrencyCode])
);
GO


CREATE TABLE [address] (
    [Id] uniqueidentifier NOT NULL,
    [ZipCode] nvarchar(max) NOT NULL,
    [StreetName] nvarchar(150) NOT NULL,
    [Number] nvarchar(50) NOT NULL,
    [Complement] nvarchar(150) NULL,
    [Country] nvarchar(150) NOT NULL,
    [City] nvarchar(150) NULL,
    CONSTRAINT [PK_address] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_address_agency_Id] FOREIGN KEY ([Id]) REFERENCES [agency] ([Id]) ON DELETE CASCADE
);
GO


CREATE TABLE [telephone] (
    [Id] uniqueidentifier NOT NULL,
    [CountryCode] varchar(10) NOT NULL,
    [RegionCode] varchar(10) NULL,
    [Number] varchar(20) NOT NULL,
    [Type] varchar(50) NULL,
    [AgencyId] uniqueidentifier NOT NULL,
    CONSTRAINT [PK_telephone] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_telephone_agency_AgencyId] FOREIGN KEY ([AgencyId]) REFERENCES [agency] ([Id]) ON DELETE CASCADE
);
GO


CREATE INDEX [IX_telephone_AgencyId] ON [telephone] ([AgencyId]);
GO


CREATE UNIQUE INDEX [IX_telephone_Number_RegionCode_CountryCode] ON [telephone] ([Number], [RegionCode], [CountryCode]) WHERE [RegionCode] IS NOT NULL;
GO


