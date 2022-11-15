using EldExchange.Domain.Models.DALs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EldExchange.Infra.Context.Mapping;

internal class CurrencyMap : IEntityTypeConfiguration<Currency>
{
    public void Configure(EntityTypeBuilder<Currency> builder)
    {
        builder.HasKey(x => x.Code);

        builder.Property(x => x.Code).IsFixedLength().HasMaxLength(3).IsUnicode(false);
        builder.Property(x => x.Name).HasMaxLength(100);
        builder.Property(x=> x.Country).HasMaxLength(100);

        var currencyData = CurrencyInitializer.Initialize();

        if(currencyData != null)  builder.HasData(currencyData);
    }
}

