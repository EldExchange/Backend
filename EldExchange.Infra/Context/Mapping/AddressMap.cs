using EldExchange.Domain.Models.DALs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EldExchange.Infra.Context.Mapping;

internal class AddressMap : IEntityTypeConfiguration<Address>
{
    public void Configure(EntityTypeBuilder<Address> builder)
    {
        builder.ToTable("address");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Number).HasMaxLength(50);
        builder.Property(x => x.StreetName).HasMaxLength(150);
        builder.Property(x => x.City).HasMaxLength(150);
        builder.Property(x => x.Country).HasMaxLength(150);
        builder.Property(x => x.Complement).HasMaxLength(150);
    }
}