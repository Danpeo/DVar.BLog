﻿// <auto-generated />
using System;
using DVar.BLog.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace DVar.BLog.Infrastructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240517093915_AddFeedbackProcessing")]
    partial class AddFeedbackProcessing
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("DVar.BLog.Domain.Entities.Feedback", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("FeedbackCratedDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("FeedbackType")
                        .HasColumnType("integer");

                    b.Property<string>("MessageBody")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("MessageTitle")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("UserEmail")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Feedbacks");
                });

            modelBuilder.Entity("DVar.BLog.Domain.Entities.FeedbackProcessing", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<DateTime>("DueDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.Property<Guid>("FeedbackId")
                        .HasColumnType("uuid");

                    b.HasKey("Id");

                    b.HasIndex("FeedbackId");

                    b.ToTable("FeedbackProcessings");
                });

            modelBuilder.Entity("DVar.BLog.Domain.Entities.FeedbackResponse", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid>("FeedbackId")
                        .HasColumnType("uuid");

                    b.Property<string>("Response")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("ResponseDateTime")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.HasIndex("FeedbackId");

                    b.ToTable("FeedbackResponses");
                });

            modelBuilder.Entity("DVar.BLog.Domain.Entities.Feedback", b =>
                {
                    b.OwnsOne("DVar.BLog.Domain.ValueObjects.FullName", "UserFullName", b1 =>
                        {
                            b1.Property<Guid>("FeedbackId")
                                .HasColumnType("uuid");

                            b1.Property<string>("FirstName")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.Property<string>("MiddleName")
                                .HasColumnType("text");

                            b1.Property<string>("Surname")
                                .IsRequired()
                                .HasColumnType("text");

                            b1.HasKey("FeedbackId");

                            b1.ToTable("Feedbacks");

                            b1.WithOwner()
                                .HasForeignKey("FeedbackId");
                        });

                    b.Navigation("UserFullName")
                        .IsRequired();
                });

            modelBuilder.Entity("DVar.BLog.Domain.Entities.FeedbackProcessing", b =>
                {
                    b.HasOne("DVar.BLog.Domain.Entities.Feedback", "Feedback")
                        .WithMany()
                        .HasForeignKey("FeedbackId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Feedback");
                });

            modelBuilder.Entity("DVar.BLog.Domain.Entities.FeedbackResponse", b =>
                {
                    b.HasOne("DVar.BLog.Domain.Entities.Feedback", "Feedback")
                        .WithMany()
                        .HasForeignKey("FeedbackId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Feedback");
                });
#pragma warning restore 612, 618
        }
    }
}
