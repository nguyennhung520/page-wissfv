using DomainLayer.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.EntityMapper
{
    public class ChatbotRelatedMap : IEntityTypeConfiguration<ChatbotRelated>
    {
        public void Configure(EntityTypeBuilder<ChatbotRelated> builder)
        {
            builder.HasKey(x => x.Id).HasName("pk_ChatbotRelatedId");
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id")
                .HasColumnType("INT");
        }
    }
}
