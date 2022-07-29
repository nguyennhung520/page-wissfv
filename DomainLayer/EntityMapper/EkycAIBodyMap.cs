using DomainLayer.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.EntityMapper
{
    public class EkycAIBodyMap : IEntityTypeConfiguration<EkycAIBody>
    {
        public void Configure(EntityTypeBuilder<EkycAIBody> builder)
        {
            builder.HasKey(x => x.Id).HasName("pk_ekycAIBodyId");
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id")
                .HasColumnType("INT");
        }
    }
}
