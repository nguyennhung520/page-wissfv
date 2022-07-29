using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.EntityMapper
{
    public class ListMenuMap : IEntityTypeConfiguration<ListMenu>
    {
        public void Configure(EntityTypeBuilder<ListMenu> builder)
        {
            builder.HasKey(x => x.Id).HasName("pk_ListMenuid");
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id")
                .HasColumnType("INT");
        }
    }
}
