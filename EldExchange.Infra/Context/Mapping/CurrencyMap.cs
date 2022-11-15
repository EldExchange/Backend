using EldExchange.Domain.Models.DALs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Metadata.Conventions.Infrastructure;

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

internal class MoneyMap : IEntityTypeConfiguration<Money>
{
    public void Configure(EntityTypeBuilder<Money> builder)
    {
        builder.HasKey(x => new { x.Code, x.Value, x.Type });

        builder.HasOne(x=> x.Currency).WithMany().HasForeignKey(x => x.Code);

        builder.HasDiscriminator(x => x.Type);

        builder.Property(x=> x.Code).IsFixedLength().HasMaxLength(3).IsUnicode(false);
        builder.Property(x => x.Type).HasMaxLength(50);
    }
}

internal class BankNoteMap : IEntityTypeConfiguration<BankNote>
{
    public void Configure(EntityTypeBuilder<BankNote> builder)
    {
        builder.Property(x=> x.Type).HasMaxLength(50).HasDefaultValue("BankNote");
        var data = new List<BankNote>() { new BankNote("USD",1)};
        builder.HasData(data);
    }
}

internal class CoinMap : IEntityTypeConfiguration<Coin>
{
    public void Configure(EntityTypeBuilder<Coin> builder)
    {
        builder.Property(x => x.Type).HasMaxLength(50).HasDefaultValue("Coin");
        var data = new List<Coin>() { new Coin("USD", 1) };
        builder.HasData(data);
    }
}