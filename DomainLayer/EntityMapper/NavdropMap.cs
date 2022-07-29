using DomainLayer.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.EntityMapper
{
    public class NavdropMap : IEntityTypeConfiguration<Navdrop>
    {
        public void Configure(EntityTypeBuilder<Navdrop> builder)
        {
            builder.HasKey(x => x.Id).HasName("pk_navdropid");
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id")
                .HasColumnType("INT");
        }
    }
}
