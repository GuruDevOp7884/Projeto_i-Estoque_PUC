﻿// <auto-generated />
using System;
using ControleDeEstoque.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ControleDeEstoque.Migrations
{
    [DbContext(typeof(ControleContext))]
    [Migration("20221117154925_M08_excel")]
    partial class M08_excel
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ControleDeEstoque.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CepCliente")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar(9)");

                    b.Property<string>("CidadeCliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("DataCadastroCliente")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("EmailCliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnderecoCliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeOuRazaoSocial")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelefoneCliente")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("UfCliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("ControleDeEstoque.Models.Fornecedor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CidadeFornecedor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTimeOffset>("DataCadastroFornecedor")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("EmailFornecedor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RazaoSocial")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelefoneFornecedor")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int>("UfFornecedor")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Fornecedores");
                });

            modelBuilder.Entity("ControleDeEstoque.Models.Produto", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoriaProd")
                        .HasColumnType("int");

                    b.Property<string>("DescricaoProd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FornecedorId")
                        .HasColumnType("int");

                    b.Property<string>("NomeProd")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PrecoProd")
                        .HasColumnType("decimal(18,2)");

                    b.Property<long>("QtdProd")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("FornecedorId");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("ControleDeEstoque.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTimeOffset>("DataCadastro")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("EmaildoUsuario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PerfilUsuario")
                        .HasColumnType("int");

                    b.Property<string>("Senha")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("ControleDeEstoque.Models.Produto", b =>
                {
                    b.HasOne("ControleDeEstoque.Models.Fornecedor", "Fornecedor")
                        .WithMany("Produtos")
                        .HasForeignKey("FornecedorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Fornecedor");
                });

            modelBuilder.Entity("ControleDeEstoque.Models.Fornecedor", b =>
                {
                    b.Navigation("Produtos");
                });
#pragma warning restore 612, 618
        }
    }
}
