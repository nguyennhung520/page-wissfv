using DomainLayer.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.EntityMapper
{
    public class TexTSPricingMap : IEntityTypeConfiguration<TexTSPricing>
    {
        public void Configure(EntityTypeBuilder<TexTSPricing> builder)
        {
            builder.HasKey(x => x.Id).HasName("pk_TexTSPricingid");
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id")
                .HasColumnType("INT");
        }
    }
}
