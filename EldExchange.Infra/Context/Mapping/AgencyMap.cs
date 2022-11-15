using EldExchange.Domain.Models.DALs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EldExchange.Infra.Context.Mapping;

internal class AgencyMap : IEntityTypeConfiguration<Agency>
{
    public void Configure(EntityTypeBuilder<Agency> builder)
    {
        builder.ToTable("agency");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name).HasMaxLength(250);
        builder.Property(x => x.CNPJ).IsUnicode(false).IsFixedLength().HasMaxLength(18);

        builder.HasOne(x => x.Address).WithOne().HasForeignKey<Address>(x => x.Id).IsRequired().OnDelete(DeleteBehavior.Cascade);
        builder.HasMany(x => x.Phones).WithOne().HasForeignKey(x => x.AgencyId).OnDelete(DeleteBehavior.Cascade);
    }
}

internal class TelephoneMap : IEntityTypeConfiguration<Telephone>
{
    public void Configure(EntityTypeBuilder<Telephone> builder)
    {
        builder.ToTable("telephone");

        builder.HasKey(x =>x.Id);

        builder.Property(x=> x.Number).IsUnicode(false).HasMaxLength(20);
        builder.Property(x => x.RegionCode).IsUnicode(false).HasMaxLength(10).IsRequired(false);
        builder.Property(x => x.CountryCode).IsUnicode(false).HasMaxLength(10);
        builder.Property(x => x.Type).IsUnicode(false).HasMaxLength(50).IsRequired(false);

        builder.HasIndex(x => new { x.Number, x.RegionCode, x.CountryCode }).IsUnique();

    }
}