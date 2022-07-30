﻿using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.EntityMapper
{
    public class SmartCiTySolutionMap : IEntityTypeConfiguration<SmartCiTySolution>
    {
        public void Configure(EntityTypeBuilder<SmartCiTySolution> builder)
        {
            builder.HasKey(x => x.Id).HasName("pk_SmartCiTySolutionid");
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id")
                .HasColumnType("INT");
        }
    }
}
