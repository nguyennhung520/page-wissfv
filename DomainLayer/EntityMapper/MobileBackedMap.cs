﻿using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.EntityMapper
{
    public class MobileBackedMap : IEntityTypeConfiguration<MobileBacked>
    {
        public void Configure(EntityTypeBuilder<MobileBacked> builder)
        {
            builder.HasKey(x => x.Id).HasName("pk_MobileBackedid");
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id")
                .HasColumnType("INT");
        }
    }
}