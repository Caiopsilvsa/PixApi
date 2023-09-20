﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PixApi.Data;

#nullable disable

namespace PixApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230915231422_script3")]
    partial class script3
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("PixApi.Domain.Models.Cliente", b =>
                {
                    b.Property<int>("ClienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ClienteId"));

                    b.Property<string>("ClienteNome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PixId")
                        .HasColumnType("int");

                    b.Property<int>("Saldo")
                        .HasColumnType("int");

                    b.HasKey("ClienteId");

                    b.HasIndex("PixId");

                    b.ToTable("clientes");
                });

            modelBuilder.Entity("PixApi.Domain.Models.Pix", b =>
                {
                    b.Property<int>("PixId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PixId"));

                    b.Property<string>("Chave")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataCriacao")
                        .HasColumnType("datetime2");

                    b.HasKey("PixId");

                    b.ToTable("pix");
                });

            modelBuilder.Entity("PixApi.Domain.Models.Transacao", b =>
                {
                    b.Property<int>("TransacaoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TransacaoId"));

                    b.Property<int?>("PixPagadorPixId")
                        .HasColumnType("int");

                    b.Property<int?>("PixRecebedorPixId")
                        .HasColumnType("int");

                    b.HasKey("TransacaoId");

                    b.HasIndex("PixPagadorPixId");

                    b.HasIndex("PixRecebedorPixId");

                    b.ToTable("transasoes");
                });

            modelBuilder.Entity("PixApi.Domain.Models.Cliente", b =>
                {
                    b.HasOne("PixApi.Domain.Models.Pix", "pix")
                        .WithMany()
                        .HasForeignKey("PixId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("pix");
                });

            modelBuilder.Entity("PixApi.Domain.Models.Transacao", b =>
                {
                    b.HasOne("PixApi.Domain.Models.Pix", "PixPagador")
                        .WithMany()
                        .HasForeignKey("PixPagadorPixId");

                    b.HasOne("PixApi.Domain.Models.Pix", "PixRecebedor")
                        .WithMany()
                        .HasForeignKey("PixRecebedorPixId");

                    b.Navigation("PixPagador");

                    b.Navigation("PixRecebedor");
                });
#pragma warning restore 612, 618
        }
    }
}
