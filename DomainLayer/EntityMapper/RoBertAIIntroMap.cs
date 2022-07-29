using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.EntityMapper
{
    public class RoBertAIIntroMap : IEntityTypeConfiguration<RoBertAIIntro>
    {
        public void Configure(EntityTypeBuilder<RoBertAIIntro> builder)
        {
            builder.HasKey(x => x.Id).HasName("pk_RoBertAIIntroid");
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id")
                .HasColumnType("INT");
        }
    }
}
