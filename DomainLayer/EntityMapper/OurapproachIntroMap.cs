using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.EntityMapper
{
    public class OurapproachIntroMap : IEntityTypeConfiguration<OurapproachIntro>
    {
        public void Configure(EntityTypeBuilder<OurapproachIntro> builder)
        {
            builder.HasKey(x => x.Id).HasName("pk_OurapproachIntroid");
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id")
                .HasColumnType("INT");
        }
    }
}
