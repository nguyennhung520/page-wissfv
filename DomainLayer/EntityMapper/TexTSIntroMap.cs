using DomainLayer.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.EntityMapper
{
    public class TexTSIntroMap : IEntityTypeConfiguration<TexTSIntro>
    {
        public void Configure(EntityTypeBuilder<TexTSIntro> builder)
        {
            builder.HasKey(x => x.Id).HasName("pk_TexTSIntroid");
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id")
                .HasColumnType("INT");
        }
    }
}
