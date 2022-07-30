using DomainLayer.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.EntityMapper
{
    public class BlogrightsidebarCategoriesMap : IEntityTypeConfiguration<BlogrightsidebarCategories>
    {
        public void Configure(EntityTypeBuilder<BlogrightsidebarCategories> builder)
        {
            builder.HasKey(x => x.Id).HasName("pk_BlogrightsidebarCategoriesid");
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id")
                .HasColumnType("INT");
        }
    }
}
