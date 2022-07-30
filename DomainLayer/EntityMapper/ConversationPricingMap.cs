using DomainLayer.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.EntityMapper
{
    public class ConversationPricingMap : IEntityTypeConfiguration<ConversationPricing>
    {
        public void Configure(EntityTypeBuilder<ConversationPricing> builder)
        {
            builder.HasKey(x => x.Id).HasName("pk_ConversationPricingId");
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id")
                .HasColumnType("INT");
        }
    }
}
