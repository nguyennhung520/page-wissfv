using DomainLayer.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.EntityMapper
{
    public class ConversationIntroMap : IEntityTypeConfiguration<ConversationIntro>
    {
        public void Configure(EntityTypeBuilder<ConversationIntro> builder)
        {
            builder.HasKey(x => x.Id).HasName("pk_ConversationIntroId");
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id")
                .HasColumnType("INT");
        }
    }
}
