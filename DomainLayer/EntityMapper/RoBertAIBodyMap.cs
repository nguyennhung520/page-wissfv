using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.EntityMapper
{
    public class RoBertAIBodyMap : IEntityTypeConfiguration<RoBertAIBody>
    {
        public void Configure(EntityTypeBuilder<RoBertAIBody> builder)
        {
            builder.HasKey(x => x.Id).HasName("pk_RoBertAIBodyid");
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id")
                .HasColumnType("INT");
        }
    }
}
