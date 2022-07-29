using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.EntityMapper
{
    public class OurapproachSolutionMap : IEntityTypeConfiguration<OurapproachSolution>
    {
        public void Configure(EntityTypeBuilder<OurapproachSolution> builder)
        {
            builder.HasKey(x => x.Id).HasName("pk_OurapproachSolutionid");
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id")
                .HasColumnType("INT");
        }
    }
}
