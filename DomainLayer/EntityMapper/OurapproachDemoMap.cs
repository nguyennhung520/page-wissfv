using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.EntityMapper
{
    public class OurapproachDemoMap : IEntityTypeConfiguration<OurapproachDemo>
    {
        public void Configure(EntityTypeBuilder<OurapproachDemo> builder)
        {
            builder.HasKey(x => x.Id).HasName("pk_OurapproachDemoid");
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id")
                .HasColumnType("INT");
        }
    }
}
