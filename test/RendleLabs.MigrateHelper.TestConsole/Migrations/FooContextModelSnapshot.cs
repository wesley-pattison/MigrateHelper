﻿// <auto-generated />

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;

namespace RendleLabs.EntityFrameworkCore.MigrateHelper.TestConsole.Migrations
{
    [DbContext(typeof(FooContext))]
    partial class FooContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.SerialColumn)
                .HasAnnotation("ProductVersion", "2.0.0-rtm-26452");

            modelBuilder.Entity("RendleLabs.MigrateHelper.TestConsole.Foo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.ToTable("Foos");
                });
#pragma warning restore 612, 618
        }
    }
}
