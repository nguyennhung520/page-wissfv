using DomainLayer.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.EntityMapper
{
    public class ComputervisonFormcontactMap : IEntityTypeConfiguration<ComputervisonFormcontact>
    {
        public void Configure(EntityTypeBuilder<ComputervisonFormcontact> builder)
        {
            builder.HasKey(x => x.Id).HasName("pk_ComputervisonFormcontactId");
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id")
                .HasColumnType("INT");
        }
    }
}
