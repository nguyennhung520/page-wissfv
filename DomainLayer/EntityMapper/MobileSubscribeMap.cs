using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.EntityMapper
{
    public class MobileSubscribeMap : IEntityTypeConfiguration<MobileSubscribe>
    {
        public void Configure(EntityTypeBuilder<MobileSubscribe> builder)
        {
            builder.HasKey(x => x.Id).HasName("pk_MobileSubscribeid");
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id")
                .HasColumnType("INT");
        }
    }
}
