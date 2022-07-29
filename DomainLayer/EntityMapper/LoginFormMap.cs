﻿using DomainLayer.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace DomainLayer.EntityMapper
{
    public class LoginFormMap : IEntityTypeConfiguration<LoginForm>
    {
        public void Configure(EntityTypeBuilder<LoginForm> builder)
        {
            builder.HasKey(x => x.Id).HasName("pk_LoginFormid");
            builder.Property(x => x.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id")
                .HasColumnType("INT");
        }
    }
}