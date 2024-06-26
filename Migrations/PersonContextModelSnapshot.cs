﻿// <auto-generated />
using EntityFrameworkSqlite;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EntityFrameworkSqlite.Migrations
{
    [DbContext(typeof(PersonContext))]
    partial class PersonContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.3");

            modelBuilder.Entity("EntityFrameworkSqlite.FluentApiTable", b =>
                {
                    b.Property<int>("Indetifier")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Value")
                        .IsRequired()
                        .HasColumnType("TEXT")
                        .HasColumnName("Thats the column name");

                    b.HasKey("Indetifier");

                    b.ToTable("FluentApiTable");
                });

            modelBuilder.Entity("EntityFrameworkSqlite.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Persons");
                });

            modelBuilder.Entity("EntityFrameworkSqlite.Table_One", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Table_One");
                });

            modelBuilder.Entity("EntityFrameworkSqlite.Table_Three", b =>
                {
                    b.Property<int>("Identifier")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Identifier");

                    b.ToTable("Table_Three");
                });

            modelBuilder.Entity("EntityFrameworkSqlite.Table_Two", b =>
                {
                    b.Property<int>("Table_TwoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.HasKey("Table_TwoId");

                    b.ToTable("Table_Two");
                });
#pragma warning restore 612, 618
        }
    }
}
