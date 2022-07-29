using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.EntityMapper
{
    public class SpeechtotextPricingMap : IEntityTypeConfiguration<SpeechtotextPricing>
    {
        public void Configure(EntityTypeBuilder<SpeechtotextPricing> builder)
        {
            builder.HasKey(x => x.Id).HasName("pk_SpeechtotextPricingid");
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id")
                .HasColumnType("INT");
        }
    }
}
