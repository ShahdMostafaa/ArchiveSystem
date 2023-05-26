﻿// <auto-generated />
using System;
using ArchiveSystem.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ArchiveSystem.Migrations
{
    [DbContext(typeof(ArchiveContext))]
    [Migration("20230520211057_dataAnnotation")]
    partial class dataAnnotation
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ArchiveSystem.Models.ListUserMes", b =>
                {
                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<int>("MessageId")
                        .HasColumnType("int");

                    b.HasKey("UserId", "MessageId");

                    b.HasIndex("MessageId");

                    b.ToTable("ListUserMes");
                });

            modelBuilder.Entity("ArchiveSystem.Models.Message", b =>
                {
                    b.Property<int>("MessageId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("MessageAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MessageDestination")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MessageText")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool?>("Rcv")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("RcvTime")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("Seen")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("SendDate")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.HasKey("MessageId");

                    b.HasIndex("UserId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("ArchiveSystem.Models.RemovedUser", b =>
                {
                    b.Property<int>("RemovedUserID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AcadMail")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("JobTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RemovedUserID");

                    b.ToTable("RemoveUsers");
                });

            modelBuilder.Entity("ArchiveSystem.Models.UserAcc", b =>
                {
                    b.Property<int>("UserAccID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AcadMail")
                        .HasColumnType("nvarchar(450)");

                    b.Property<bool>("Active")
                        .HasColumnType("bit");

                    b.Property<string>("Department")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("bit");

                    b.Property<string>("JobTitle")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pass")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasMaxLength(11)
                        .HasColumnType("nvarchar(11)");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("userGender")
                        .HasColumnType("int");

                    b.HasKey("UserAccID");

                    b.HasIndex("AcadMail")
                        .IsUnique()
                        .HasFilter("[AcadMail] IS NOT NULL");

                    b.ToTable("UserAccs");
                });

            modelBuilder.Entity("ArchiveSystem.Models._Attachment", b =>
                {
                    b.Property<int>("_AttachmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AttDesc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("AttFile")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("MessageId")
                        .HasColumnType("int");

                    b.HasKey("_AttachmentId");

                    b.HasIndex("MessageId");

                    b.ToTable("Attachments");
                });

            modelBuilder.Entity("ArchiveSystem.Models.ListUserMes", b =>
                {
                    b.HasOne("ArchiveSystem.Models.Message", "Message")
                        .WithMany("ListUserMes")
                        .HasForeignKey("MessageId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ArchiveSystem.Models.UserAcc", "User")
                        .WithMany("ListUserMes")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Message");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ArchiveSystem.Models.Message", b =>
                {
                    b.HasOne("ArchiveSystem.Models.UserAcc", "User")
                        .WithMany("Messages")
                        .HasForeignKey("UserId");

                    b.Navigation("User");
                });

            modelBuilder.Entity("ArchiveSystem.Models._Attachment", b =>
                {
                    b.HasOne("ArchiveSystem.Models.Message", "Message")
                        .WithMany("Attachments")
                        .HasForeignKey("MessageId");

                    b.Navigation("Message");
                });

            modelBuilder.Entity("ArchiveSystem.Models.Message", b =>
                {
                    b.Navigation("Attachments");

                    b.Navigation("ListUserMes");
                });

            modelBuilder.Entity("ArchiveSystem.Models.UserAcc", b =>
                {
                    b.Navigation("ListUserMes");

                    b.Navigation("Messages");
                });
#pragma warning restore 612, 618
        }
    }
}
