using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.EntityMapper
{
    public class RoBertAIPricingMap : IEntityTypeConfiguration<RoBertAIPricing>
    {
        public void Configure(EntityTypeBuilder<RoBertAIPricing> builder)
        {
            builder.HasKey(x => x.Id).HasName("pk_RoBertAIPricingid");
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id")
                .HasColumnType("INT");
        }
    }
}
