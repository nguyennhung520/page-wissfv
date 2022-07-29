using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.EntityMapper
{
    public class BeehiveFeaturesMap : IEntityTypeConfiguration<BeehiveFeatures>
    {
        public void Configure(EntityTypeBuilder<BeehiveFeatures> builder)
        {
            builder.HasKey(x => x.Id).HasName("pk_BeehiveFeaturesid");
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id")
                .HasColumnType("INT");
        }
    }
}
