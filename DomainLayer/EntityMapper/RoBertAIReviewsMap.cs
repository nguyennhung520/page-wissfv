using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.EntityMapper
{
    public class RoBertAIReviewsMap : IEntityTypeConfiguration<RoBertAIReviews>
    {
        public void Configure(EntityTypeBuilder<RoBertAIReviews> builder)
        {
            builder.HasKey(x => x.Id).HasName("pk_RoBertAIReviewsid");
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id")
                .HasColumnType("INT");
        }
    }

}
