﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Persistence;

namespace Persistence.Migrations.ProcessFlowData
{
    [DbContext(typeof(ProcessFlowDataContext))]
    partial class ProcessFlowDataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Domain.Models.ProcessFlow.PFActivity", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AltExternalId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ByUserHierarchy")
                        .HasColumnType("int");

                    b.Property<bool>("CanReloadWorkItem")
                        .HasColumnType("bit");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("EditScreenId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("EnterEventId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("ExitEventId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ExternalId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ProcessTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("ViewScreenId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.ToTable("PFActivities");
                });

            modelBuilder.Entity("Domain.Models.ProcessFlow.PFProcessType", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AltExternalId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("ApplicationTypeId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("EndActivityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("ExternalId")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool?>("Islocked")
                        .HasColumnType("bit");

                    b.Property<string>("ProcessTypeName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("StartActivityId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("UpdatedBy")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.ToTable("PFProcessTypes");
                });
#pragma warning restore 612, 618
        }
    }
}
