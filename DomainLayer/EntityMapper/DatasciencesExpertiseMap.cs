using DomainLayer.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.EntityMapper
{
    public class DatasciencesExpertiseMap : IEntityTypeConfiguration<DatasciencesExpertise>
    {
        public void Configure(EntityTypeBuilder<DatasciencesExpertise> builder)
        {
            builder.HasKey(x => x.Id).HasName("pk_DatasciencesExpertiseId");
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id")
                .HasColumnType("INT");
        }
    }
}
