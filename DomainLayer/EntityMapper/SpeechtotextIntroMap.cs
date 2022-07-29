using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.EntityMapper
{
    public class SpeechtotextIntroMap : IEntityTypeConfiguration<SpeechtotextIntro>
    {
        public void Configure(EntityTypeBuilder<SpeechtotextIntro> builder)
        {
            builder.HasKey(x => x.Id).HasName("pk_SpeechtotextIntroid");
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id")
                .HasColumnType("INT");
        }
    }
}
