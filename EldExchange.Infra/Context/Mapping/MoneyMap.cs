using EldExchange.Domain.Models.DALs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EldExchange.Infra.Context.Mapping;

internal class MoneyMap : IEntityTypeConfiguration<Money>
{
    public void Configure(EntityTypeBuilder<Money> builder)
    {
        builder.HasKey(x => new { x.Code, x.Value, x.Type });

        builder.HasOne(x=> x.Currency).WithMany(x=> x.Money).HasForeignKey(x => x.Code);

        builder.HasDiscriminator(x => x.Type);

        builder.Property(x=> x.Code).IsFixedLength().HasMaxLength(3).IsUnicode(false);
        builder.Property(x => x.Type).HasMaxLength(50);

        builder.HasMany<Safe>().WithOne(x => x.Money).HasForeignKey(x => new { x.Code, x.Value, x.Type });
    }
}


internal class BankNoteMap : IEntityTypeConfiguration<BankNote>
{
    public void Configure(EntityTypeBuilder<BankNote> builder)
    {
        builder.Property(x => x.Type).HasMaxLength(50).HasDefaultValue("BankNote");
        var list = Initializer.ReadFile<BankNote>("BankNote.json");
        //var data = new List<BankNote>() { new BankNote("USD", 1) };
        if(list!= null) builder.HasData(list);
    }
}

internal class CoinMap : IEntityTypeConfiguration<Coin>
{
    public void Configure(EntityTypeBuilder<Coin> builder)
    {
        builder.Property(x => x.Type).HasMaxLength(50).HasDefaultValue("Coin");
        var list = Initializer.ReadFile<Coin>("Coin.json");
        //var data = new List<BankNote>() { new BankNote("USD", 1) };
        if (list != null) builder.HasData(list);
    }
}

internal class SafeMap : IEntityTypeConfiguration<Safe>
{
    public void Configure(EntityTypeBuilder<Safe> builder)
    {
        builder.HasKey(x => new { x.Code, x.Value, x.Type, x.AgencyId });

        builder.Property(x => x.Code).IsFixedLength().HasMaxLength(3).IsUnicode(false);
        builder.Property(x => x.Type).HasMaxLength(50);

        //builder.HasOne(x => x.Agency).WithMany().HasForeignKey<Safe>(x => x.AgencyId);
        //builder.HasOne(x => x.Money).WithMany().HasForeignKey<Safe>(x => new { x.Code, x.Value, x.Type });
    }
}