using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.EntityMapper
{
    public class MenuGroupMap : IEntityTypeConfiguration<MenuGroup>
    {
        public void Configure(EntityTypeBuilder<MenuGroup> builder)
        {
            builder.HasKey(x => x.Id).HasName("pk_MenuGroupid");
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id")
                .HasColumnType("INT");
        }
    }
}
