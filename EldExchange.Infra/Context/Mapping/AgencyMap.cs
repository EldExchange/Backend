using EldExchange.Domain.Models.DALs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EldExchange.Infra.Context.Mapping;

internal class AgencyMap : IEntityTypeConfiguration<Agency>
{
    public void Configure(EntityTypeBuilder<Agency> builder)
    {
        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name).HasMaxLength(250);
        builder.Property(x => x.CNPJ).IsUnicode(false).IsFixedLength().HasMaxLength(18);

        builder.HasOne(x => x.Address).WithOne().HasForeignKey<Address>(x => x.Id).IsRequired().OnDelete(DeleteBehavior.Cascade);
        builder.HasMany(x => x.Phones).WithOne().HasForeignKey(x => x.AgencyId).OnDelete(DeleteBehavior.Cascade);
        builder.HasMany<Safe>().WithOne(x => x.Agency).HasForeignKey(x => x.AgencyId);
    }
}
