# Infraestructure - Entity Framework 6 - Code First

## packages intalled

* Microsoft.EntityFrameworkCore
* Microsoft.EntityFrameworkCore.Tools
* Microsoft.EntityFrameworkCore.Design
* Microsoft.EntityFrameworkCore.Relational
* Microsoft.EntityFrameworkCore.SqlServer - according to the database used

### Entity Framework 6 Providers

The Entity Framework is now being developed under an open-source license and EF6 and above will not be shipped as part of the .NET Framework. This has many advantages but also requires that EF providers be rebuilt against the EF6 assemblies. This means that EF providers for EF5 and below will not work with EF6 until they have been rebuilt.

[Entity Framework 6 Providers](https://docs.microsoft.com/en-us/ef/ef6/fundamentals/providers/)

* [Microsoft SQL Server provider](https://www.nuget.org/packages/EntityFramework)

* [Microsoft SQL Server Compact Edition provider](https://nuget.org/packages/EntityFramework.SqlServerCompact)
* [Devart dotConnect Data Providers](https://www.devart.com/dotconnect/)
* [CData Software providers](https://www.cdata.com/ado/)
* [Firebird provider](https://www.nuget.org/packages/EntityFramework.Firebird/)
* [Visual Fox Pro provider](https://www.nuget.org/packages/VFPEntityFrameworkProvider2/)
* [MySQL Connector/NET for Entity Framework](https://dev.mysql.com/doc/connector-net/en/connector-net-entityframework60.html)
* [PostgreSQL](https://www.nuget.org/packages/EntityFramework6.Npgsql/)
* [Oracle](https://www.nuget.org/packages/Oracle.ManagedDataAccess.EntityFramework/)
* [SQLite](https://www.nuget.org/packages/System.Data.SQLite/)

## Migration

* [Entity Framework Tools](https://docs.microsoft.com/en-us/ef/core/cli/powershell)

### Migration Commands used (Package Manager Console Tool)

* Install Microsoft.EntityFrameworkCore.Tools 
```
        Install-Package Microsoft.EntityFrameworkCore.Tools
```
  
* Update Microsoft.EntityFrameworkCore.Tools 
```
        Update-Package Microsoft.EntityFrameworkCore.Tools
```
  
* Get help about Microsoft.EntityFrameworkCore.Tools 
```
        Get-Help about_EntityFrameworkCore
```

* Add a new migration => Add-Migration `<Migration Name>` -Context `<Context Name>` -Output `<output path>`
```Example
        Add-Migration InitialMigration -Context EldDbContext -Output Context/Migrations
```

* Update the data base => Update-Database -Context `<Context Name>`
```Example
        Update-Database -Context EldDbContext
```

* Remove a migration => Remove-Migration -Context `<Context Name>`
```
        Remove-Migration -Context EldDbContext
```

* Create Script sql to create the database =>  Script-DbContext -Context `<Context Name>` -Output  `<output path>`
```
        Script-DbContext -Context EldDbContext -Output  db/setup.sql
```

* Drop the database =>  Drop-Database -Context `<Context Name>`
```
         Drop-Database -Context EldDbContext
```

### Migration Commands used (Entity Framework Core tools reference - .NET Core CLI)

* Installing the tool
```
        dotnet tool install --global dotnet-ef
```

* Updating the tool
```
        dotnet tool update --global dotnet-ef
```

* Before you can use the tools on a specific project, you'll need to add the Microsoft.EntityFrameworkCore.Design package to it.
```
        dotnet add package Microsoft.EntityFrameworkCore.Design
```

* verify instalation
  ```
        dotnet ef
  ```

* Create the database sql script =>  dotnet ef `<context name>` script --output `<output path>`
  ```
        dotnet ef migrations script --no-transactions --output db/scripts/create_database.sql --project  .\TemplateApi\TemplateApi.csproj -- --environment Production
  ```