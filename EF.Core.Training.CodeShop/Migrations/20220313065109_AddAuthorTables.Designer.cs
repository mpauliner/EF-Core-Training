﻿// <auto-generated />
using EF.Core.Training;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EF.Core.Training.Migrations
{
    [DbContext(typeof(ApiContext))]
    [Migration("20220313065109_AddAuthorTables")]
    partial class AddAuthorTables
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.1");

            modelBuilder.Entity("EF.Core.Training.BlackBox.Book", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Description")
                        .HasColumnType("TEXT");

                    b.Property<string>("ISBN")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Pages")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("Price")
                        .HasColumnType("TEXT");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Book", (string)null);
                });

            modelBuilder.Entity("EF.Core.Training.BlackBox.BookGenreLink", b =>
                {
                    b.Property<int>("BookID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("GenreID")
                        .HasColumnType("INTEGER");

                    b.HasKey("BookID", "GenreID");

                    b.HasIndex("GenreID");

                    b.ToTable("BookGenreLink", (string)null);
                });

            modelBuilder.Entity("EF.Core.Training.BlackBox.Genre", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ID");

                    b.ToTable("Genre", (string)null);
                });

            modelBuilder.Entity("EF.Core.Training.BlackBox.BookGenreLink", b =>
                {
                    b.HasOne("EF.Core.Training.BlackBox.Book", "Book")
                        .WithMany("GenreLinks")
                        .HasForeignKey("BookID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EF.Core.Training.BlackBox.Genre", "Genre")
                        .WithMany("BookLinks")
                        .HasForeignKey("GenreID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Book");

                    b.Navigation("Genre");
                });

            modelBuilder.Entity("EF.Core.Training.BlackBox.Book", b =>
                {
                    b.Navigation("GenreLinks");
                });

            modelBuilder.Entity("EF.Core.Training.BlackBox.Genre", b =>
                {
                    b.Navigation("BookLinks");
                });
#pragma warning restore 612, 618
        }
    }
}
