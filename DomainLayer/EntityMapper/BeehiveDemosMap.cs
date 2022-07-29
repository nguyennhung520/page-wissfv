using DomainLayer.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.EntityMapper
{
    public class BeehiveDemosMap : IEntityTypeConfiguration<BeehiveDemos>
    {
        public void Configure(EntityTypeBuilder<BeehiveDemos> builder)
        {
            builder.HasKey(x => x.Id).HasName("pk_BeehiveDemosid");
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id")
                .HasColumnType("INT");
        }
    }
}
