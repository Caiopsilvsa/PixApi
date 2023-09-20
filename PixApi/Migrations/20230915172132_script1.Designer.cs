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
    [Migration("20230915172132_script1")]
    partial class script1
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
                    b.Property<int>("clienteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("clienteId"));

                    b.Property<string>("clienteNome")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("pixId")
                        .HasColumnType("int");

                    b.Property<int>("saldo")
                        .HasColumnType("int");

                    b.HasKey("clienteId");

                    b.HasIndex("pixId");

                    b.ToTable("clientes");
                });

            modelBuilder.Entity("PixApi.Domain.Models.Pix", b =>
                {
                    b.Property<int>("pixId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("pixId"));

                    b.Property<string>("chave")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("dataCriacao")
                        .HasColumnType("datetime2");

                    b.HasKey("pixId");

                    b.ToTable("pix");
                });

            modelBuilder.Entity("PixApi.Domain.Models.Transacao", b =>
                {
                    b.Property<int>("transacaoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("transacaoId"));

                    b.Property<int?>("pixPagadorpixId")
                        .HasColumnType("int");

                    b.Property<int?>("pixRecebedorpixId")
                        .HasColumnType("int");

                    b.HasKey("transacaoId");

                    b.HasIndex("pixPagadorpixId");

                    b.HasIndex("pixRecebedorpixId");

                    b.ToTable("transasoes");
                });

            modelBuilder.Entity("PixApi.Domain.Models.Cliente", b =>
                {
                    b.HasOne("PixApi.Domain.Models.Pix", "pix")
                        .WithMany()
                        .HasForeignKey("pixId");

                    b.Navigation("pix");
                });

            modelBuilder.Entity("PixApi.Domain.Models.Transacao", b =>
                {
                    b.HasOne("PixApi.Domain.Models.Pix", "pixPagador")
                        .WithMany()
                        .HasForeignKey("pixPagadorpixId");

                    b.HasOne("PixApi.Domain.Models.Pix", "pixRecebedor")
                        .WithMany()
                        .HasForeignKey("pixRecebedorpixId");

                    b.Navigation("pixPagador");

                    b.Navigation("pixRecebedor");
                });
#pragma warning restore 612, 618
        }
    }
}
