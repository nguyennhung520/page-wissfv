using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.EntityMapper
{
    public class SmartCiTyDigitalMap : IEntityTypeConfiguration<SmartCiTyDigital>
    {
        public void Configure(EntityTypeBuilder<SmartCiTyDigital> builder)
        {
            builder.HasKey(x => x.Id).HasName("pk_SmartCiTyDigitalid");
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id")
                .HasColumnType("INT");
        }
    }
}
