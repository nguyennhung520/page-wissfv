using DomainLayer.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.EntityMapper
{
    public class BlogrightsidebarIntroMap : IEntityTypeConfiguration<BlogrightsidebarIntro>
    {
        public void Configure(EntityTypeBuilder<BlogrightsidebarIntro> builder)
        {
            builder.HasKey(x => x.Id).HasName("BlogrightsidebarCategoriesid");
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id")
                .HasColumnType("INT");
        }
    }
}
