using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.EntityMapper
{
    public class SpeechtotextDemoMap : IEntityTypeConfiguration<SpeechtotextDemo>
    {
        public void Configure(EntityTypeBuilder<SpeechtotextDemo> builder)
        {
            builder.HasKey(x => x.Id).HasName("pk_SpeechtotextDemoid");
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id")
                .HasColumnType("INT");
        }
    }
}
