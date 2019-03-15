﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace evetool.db.sqlite.Migrations
{
    [DbContext(typeof(EVEToolDbContext))]
    [Migration("20190315064549_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.3-servicing-35854");

            modelBuilder.Entity("evetool.core.model.ExpressCareOption", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<decimal>("MinPrice");

                    b.Property<double>("Ratio");

                    b.HasKey("ID");

                    b.ToTable("ExpressCareOptions");
                });

            modelBuilder.Entity("evetool.core.model.ExpressFeeOption", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("CareID");

                    b.Property<double>("FloatingVolume");

                    b.Property<double>("FreeVolume");

                    b.Property<bool>("IsCare");

                    b.Property<decimal>("UnitPrice");

                    b.HasKey("ID");

                    b.HasIndex("CareID");

                    b.ToTable("ExpressFeeOptions");
                });

            modelBuilder.Entity("evetool.core.model.ExpressFeeOption", b =>
                {
                    b.HasOne("evetool.core.model.ExpressCareOption", "Care")
                        .WithMany()
                        .HasForeignKey("CareID");
                });
#pragma warning restore 612, 618
        }
    }
}