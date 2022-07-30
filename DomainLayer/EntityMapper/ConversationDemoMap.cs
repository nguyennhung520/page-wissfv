using DomainLayer.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.EntityMapper
{
    public class ConversationDemoMap : IEntityTypeConfiguration<ConversationDemo>
    {
        public void Configure(EntityTypeBuilder<ConversationDemo> builder)
        {
            builder.HasKey(x => x.Id).HasName("pk_ConversationDemoId");
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id")
                .HasColumnType("INT");
        }
    }
}
