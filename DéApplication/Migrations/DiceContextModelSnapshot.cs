﻿// <auto-generated />
using DéApplication.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DéApplication.Migrations
{
    [DbContext(typeof(DiceContext))]
    partial class DiceContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DéApplication.Entities.ColoredDieColoredFace", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("ColoredFaceId")
                        .HasColumnType("int");

                    b.Property<int>("DieId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ColoredFaceId");

                    b.HasIndex("DieId");

                    b.ToTable("ColoredDieColoredFace");
                });

            modelBuilder.Entity("DéApplication.Entities.ColoredFace", b =>
                {
                    b.Property<int>("ColoredFaceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ColoredFaceId"), 1L, 1);

                    b.Property<string>("Color")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ColoredFaceId");

                    b.ToTable("ColoredFace");
                });

            modelBuilder.Entity("DéApplication.Entities.Die", b =>
                {
                    b.Property<int>("DieId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DieId"), 1L, 1);

                    b.Property<string>("Die_Type")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DieId");

                    b.ToTable("Dies");

                    b.HasDiscriminator<string>("Die_Type").HasValue("die_base");
                });

            modelBuilder.Entity("DéApplication.Entities.DieGroupOfDice", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DieId")
                        .HasColumnType("int");

                    b.Property<int>("GroupOfDiceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DieId");

                    b.HasIndex("GroupOfDiceId");

                    b.ToTable("DieGroupOfDice");
                });

            modelBuilder.Entity("DéApplication.Entities.GroupOfDice", b =>
                {
                    b.Property<int>("GroupOfDiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GroupOfDiceId"), 1L, 1);

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GroupOfDiceId");

                    b.ToTable("GroupOfDices");
                });

            modelBuilder.Entity("DéApplication.Entities.NumberedDieNumberedFace", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DieId")
                        .HasColumnType("int");

                    b.Property<int>("NumberedFaceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DieId");

                    b.HasIndex("NumberedFaceId");

                    b.ToTable("NumberedDieNumberedFace");
                });

            modelBuilder.Entity("DéApplication.Entities.NumberedFace", b =>
                {
                    b.Property<int>("NumberedFaceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NumberedFaceId"), 1L, 1);

                    b.Property<int>("FaceNumber")
                        .HasColumnType("int");

                    b.HasKey("NumberedFaceId");

                    b.ToTable("NumberedFace");
                });

            modelBuilder.Entity("DéApplication.Entities.PicturedDiePictuedFace", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("DieId")
                        .HasColumnType("int");

                    b.Property<int>("PicturedFaceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DieId");

                    b.HasIndex("PicturedFaceId");

                    b.ToTable("PicturedDiePictuedFace");
                });

            modelBuilder.Entity("DéApplication.Entities.PicturedFace", b =>
                {
                    b.Property<int>("PicturedFaceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PicturedFaceId"), 1L, 1);

                    b.Property<int>("FaceId")
                        .HasColumnType("int");

                    b.Property<string>("Picture")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PicturedFaceId");

                    b.ToTable("PicturedFace");
                });

            modelBuilder.Entity("DéApplication.Entities.ColoredDie", b =>
                {
                    b.HasBaseType("DéApplication.Entities.Die");

                    b.HasDiscriminator().HasValue("die_color");
                });

            modelBuilder.Entity("DéApplication.Entities.NumberedDie", b =>
                {
                    b.HasBaseType("DéApplication.Entities.Die");

                    b.HasDiscriminator().HasValue("die_number");
                });

            modelBuilder.Entity("DéApplication.Entities.PicturedDie", b =>
                {
                    b.HasBaseType("DéApplication.Entities.Die");

                    b.HasDiscriminator().HasValue("die_picture");
                });

            modelBuilder.Entity("DéApplication.Entities.ColoredDieColoredFace", b =>
                {
                    b.HasOne("DéApplication.Entities.ColoredFace", "ColoredFace")
                        .WithMany("coloredDieColoredFaces")
                        .HasForeignKey("ColoredFaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DéApplication.Entities.ColoredDie", "ColoredDie")
                        .WithMany("ColoredDieColoredFaces")
                        .HasForeignKey("DieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ColoredDie");

                    b.Navigation("ColoredFace");
                });

            modelBuilder.Entity("DéApplication.Entities.DieGroupOfDice", b =>
                {
                    b.HasOne("DéApplication.Entities.Die", "Die")
                        .WithMany("dieGroupOfDices")
                        .HasForeignKey("DieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DéApplication.Entities.GroupOfDice", "GroupOfDice")
                        .WithMany("DieGroupOfDices")
                        .HasForeignKey("GroupOfDiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Die");

                    b.Navigation("GroupOfDice");
                });

            modelBuilder.Entity("DéApplication.Entities.NumberedDieNumberedFace", b =>
                {
                    b.HasOne("DéApplication.Entities.NumberedDie", "NumberedDie")
                        .WithMany("NumberedDieNumberedFaces")
                        .HasForeignKey("DieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DéApplication.Entities.NumberedFace", "NumberedFace")
                        .WithMany("numberedDieNumberedFaces")
                        .HasForeignKey("NumberedFaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("NumberedDie");

                    b.Navigation("NumberedFace");
                });

            modelBuilder.Entity("DéApplication.Entities.PicturedDiePictuedFace", b =>
                {
                    b.HasOne("DéApplication.Entities.PicturedDie", "PicturedDie")
                        .WithMany("PicturedDiePictuedFaces")
                        .HasForeignKey("DieId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DéApplication.Entities.PicturedFace", "PicturedFace")
                        .WithMany("picturedDiePictuedFaces")
                        .HasForeignKey("PicturedFaceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PicturedDie");

                    b.Navigation("PicturedFace");
                });

            modelBuilder.Entity("DéApplication.Entities.ColoredFace", b =>
                {
                    b.Navigation("coloredDieColoredFaces");
                });

            modelBuilder.Entity("DéApplication.Entities.Die", b =>
                {
                    b.Navigation("dieGroupOfDices");
                });

            modelBuilder.Entity("DéApplication.Entities.GroupOfDice", b =>
                {
                    b.Navigation("DieGroupOfDices");
                });

            modelBuilder.Entity("DéApplication.Entities.NumberedFace", b =>
                {
                    b.Navigation("numberedDieNumberedFaces");
                });

            modelBuilder.Entity("DéApplication.Entities.PicturedFace", b =>
                {
                    b.Navigation("picturedDiePictuedFaces");
                });

            modelBuilder.Entity("DéApplication.Entities.ColoredDie", b =>
                {
                    b.Navigation("ColoredDieColoredFaces");
                });

            modelBuilder.Entity("DéApplication.Entities.NumberedDie", b =>
                {
                    b.Navigation("NumberedDieNumberedFaces");
                });

            modelBuilder.Entity("DéApplication.Entities.PicturedDie", b =>
                {
                    b.Navigation("PicturedDiePictuedFaces");
                });
#pragma warning restore 612, 618
        }
    }
}
