using DomainLayer.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.EntityMapper
{
    public class ChatbotBlogMap : IEntityTypeConfiguration<ChatbotBlog>
    {
        public void Configure(EntityTypeBuilder<ChatbotBlog> builder)
        {
            builder.HasKey(x => x.Id).HasName("pk_ChatbotBlogId");
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id")
                .HasColumnType("INT");
        }
    }
}
