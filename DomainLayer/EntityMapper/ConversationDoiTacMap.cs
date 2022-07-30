using DomainLayer.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.EntityMapper
{
    public class ConversationDoiTacMap : IEntityTypeConfiguration<ConversationDoiTac>
    {
        public void Configure(EntityTypeBuilder<ConversationDoiTac> builder)
        {
            builder.HasKey(x => x.Id).HasName("pk_ConversationDoiTacId");
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id")
                .HasColumnType("INT");
        }
    }
}
