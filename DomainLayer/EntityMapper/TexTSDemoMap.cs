using DomainLayer.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.EntityMapper
{
    public class TexTSDemoMap : IEntityTypeConfiguration<TexTSDemo>
    {
        public void Configure(EntityTypeBuilder<TexTSDemo> builder)
        {
            builder.HasKey(x => x.Id).HasName("pk_TexTSDemoid");
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id")
                .HasColumnType("INT");
        }
    }
}
