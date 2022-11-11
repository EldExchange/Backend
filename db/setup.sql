CREATE TABLE [Addresses] (
    [Id] char(36) NOT NULL,
    [ZipCode] nvarchar(max) NOT NULL,
    [StreetName] nvarchar(max) NOT NULL,
    [Number] nvarchar(max) NOT NULL,
    [Complement] nvarchar(max) NULL,
    [Country] nvarchar(max) NOT NULL,
    [City] nvarchar(max) NULL,
    CONSTRAINT [PK_Addresses] PRIMARY KEY ([Id])
);
GO


CREATE TABLE [Currencies] (
    [CurrencyCode] nvarchar(450) NOT NULL,
    [Name] nvarchar(max) NOT NULL,
    [Symbol] nvarchar(max) NOT NULL,
    CONSTRAINT [PK_Currencies] PRIMARY KEY ([CurrencyCode])
);
GO


CREATE TABLE [agency] (
    [id] char(36) NOT NULL,
    [name] nvarchar(250) NOT NULL,
    [cnpj] char(18) NOT NULL,
    [IsWorking] bit NOT NULL,
    [AddressId] nvarchar(450) NULL,
    CONSTRAINT [PK_agency] PRIMARY KEY ([id]),
    CONSTRAINT [FK_agency_Addresses_AddressId] FOREIGN KEY ([AddressId]) REFERENCES [Addresses] ([Id])
);
GO


CREATE TABLE [AgencyCurrency] (
    [AgenciesId] char(36) NOT NULL,
    [CurrenciesCurrencyCode] nvarchar(450) NOT NULL,
    CONSTRAINT [PK_AgencyCurrency] PRIMARY KEY ([AgenciesId], [CurrenciesCurrencyCode]),
    CONSTRAINT [FK_AgencyCurrency_agency_AgenciesId] FOREIGN KEY ([AgenciesId]) REFERENCES [agency] ([id]) ON DELETE CASCADE,
    CONSTRAINT [FK_AgencyCurrency_Currencies_CurrenciesCurrencyCode] FOREIGN KEY ([CurrenciesCurrencyCode]) REFERENCES [Currencies] ([CurrencyCode]) ON DELETE CASCADE
);
GO


CREATE TABLE [Telephones] (
    [Id] nvarchar(450) NOT NULL,
    [CountryCode] nvarchar(max) NOT NULL,
    [RegionCode] nvarchar(max) NULL,
    [Number] nvarchar(max) NOT NULL,
    [Type] nvarchar(max) NULL,
    [AgencyId] char(36) NULL,
    CONSTRAINT [PK_Telephones] PRIMARY KEY ([Id]),
    CONSTRAINT [FK_Telephones_agency_AgencyId] FOREIGN KEY ([AgencyId]) REFERENCES [agency] ([id])
);
GO


CREATE INDEX [IX_agency_AddressId] ON [agency] ([AddressId]);
GO


CREATE INDEX [IX_AgencyCurrency_CurrenciesCurrencyCode] ON [AgencyCurrency] ([CurrenciesCurrencyCode]);
GO


CREATE INDEX [IX_Telephones_AgencyId] ON [Telephones] ([AgencyId]);
GO


