using EldExchange.Domain.Models.DALs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EldExchange.Infra.Context.Mapping
{
    public class AgencyMap : IEntityTypeConfiguration<Agency>
    {
        public void Configure(EntityTypeBuilder<Agency> builder)
        {
            builder.ToTable("agency");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id).HasColumnName("id").IsUnicode(false).IsFixedLength().HasMaxLength(36);
            builder.Property(x => x.Name).HasColumnName("name").HasMaxLength(250);
            builder.Property(x => x.CNPJ).HasColumnName("cnpj").IsUnicode(false).IsFixedLength().HasMaxLength(18);

            //builder.HasOne(x => x.Address).WithOne(x=> x.Agency).HasForeignKey("address_id").HasConstraintName("fk_agency_address");
        }
    }
}
