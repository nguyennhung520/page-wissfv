using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.EntityMapper
{
    public class ListFooterMap : IEntityTypeConfiguration<ListFooter>
    {
        public void Configure(EntityTypeBuilder<ListFooter> builder)
        {
            builder.HasKey(x => x.Id).HasName("pk_ListFooterid");
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id")
                .HasColumnType("INT");
        }
    }
}
