using EldExchange.Domain.Models.DALs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EldExchange.Infra.Context.Mapping;

internal class TelephoneMap : IEntityTypeConfiguration<Telephone>
{
    public void Configure(EntityTypeBuilder<Telephone> builder)
    {
        builder.HasKey(x =>x.Id);

        builder.Property(x=> x.Number).IsUnicode(false).HasMaxLength(20);
        builder.Property(x => x.RegionCode).IsUnicode(false).HasMaxLength(10).IsRequired(false);
        builder.Property(x => x.CountryCode).IsUnicode(false).HasMaxLength(10);
        builder.Property(x => x.Type).IsUnicode(false).HasMaxLength(50).IsRequired(false);

        builder.HasIndex(x => new { x.Number, x.RegionCode, x.CountryCode }).IsUnique();

    }
}