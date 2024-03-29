﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NerdStore.Pagamentos.Data;

namespace NerdStore.Pagamentos.Data.Migrations
{
    [DbContext(typeof(PagamentoContext))]
    [Migration("20210716090324_InitialPagamentos")]
    partial class InitialPagamentos
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("NerdStore.Pagamentos.Business.Pagamento", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CvvCartao")
                        .IsRequired()
                        .HasColumnType("varchar(4)");

                    b.Property<string>("ExpiracaoCartao")
                        .IsRequired()
                        .HasColumnType("varchar(10)");

                    b.Property<string>("NomeCartao")
                        .IsRequired()
                        .HasColumnType("varchar(250)");

                    b.Property<string>("NumeroCartao")
                        .IsRequired()
                        .HasColumnType("varchar(16)");

                    b.Property<Guid>("PedidoId");

                    b.Property<string>("Status")
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("Valor");

                    b.HasKey("Id");

                    b.ToTable("Pagamentos");
                });

            modelBuilder.Entity("NerdStore.Pagamentos.Business.Transacao", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<Guid>("PagamentoId");

                    b.Property<Guid>("PedidoId");

                    b.Property<int>("StatusTransacao");

                    b.Property<decimal>("Total");

                    b.HasKey("Id");

                    b.HasIndex("PagamentoId")
                        .IsUnique();

                    b.ToTable("Transacoes");
                });

            modelBuilder.Entity("NerdStore.Pagamentos.Business.Transacao", b =>
                {
                    b.HasOne("NerdStore.Pagamentos.Business.Pagamento", "Pagamento")
                        .WithOne("Transacao")
                        .HasForeignKey("NerdStore.Pagamentos.Business.Transacao", "PagamentoId");
                });
#pragma warning restore 612, 618
        }
    }
}
