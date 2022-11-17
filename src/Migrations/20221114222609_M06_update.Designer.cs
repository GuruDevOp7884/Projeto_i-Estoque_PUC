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
    [Migration("20221114222609_M06_update")]
    partial class M06_update
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

                    b.Property<int>("UfCliente")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("ControleDeEstoque.Models.Compra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CategoriaProd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CodigoCompra")
                        .HasColumnType("int");

                    b.Property<string>("DescricaoProd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeProd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PrecoProd")
                        .HasColumnType("decimal(18,2)");

                    b.Property<long>("QtdProd")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Compras");
                });

            modelBuilder.Entity("ControleDeEstoque.Models.Estoque", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CategoriaProd")
                        .HasColumnType("int");

                    b.Property<int>("CodigoCompra")
                        .HasColumnType("int");

                    b.Property<int?>("ComprasId")
                        .HasColumnType("int");

                    b.Property<string>("DescricaoProd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FuncionariosId")
                        .HasColumnType("int");

                    b.Property<string>("NomeProd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PrecoProd")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("ProdutosId")
                        .HasColumnType("int");

                    b.Property<long>("QtdProd")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("ComprasId");

                    b.HasIndex("FuncionariosId");

                    b.HasIndex("ProdutosId");

                    b.ToTable("Estoque");
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

            modelBuilder.Entity("ControleDeEstoque.Models.Funcionario", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int?>("Id"), 1L, 1);

                    b.Property<string>("CepFuncionario")
                        .IsRequired()
                        .HasMaxLength(9)
                        .HasColumnType("nvarchar(9)");

                    b.Property<string>("CidadeFuncionario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CodigoFuncionario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmailFuncionario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnderecoFuncionario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeFuncionario")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelefoneFuncionario")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<int>("UfFuncionario")
                        .HasColumnType("int");

                    b.Property<int?>("UsuariosId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UsuariosId");

                    b.ToTable("Funcionarios");
                });

            modelBuilder.Entity("ControleDeEstoque.Models.ItemComprado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("CodPedido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ComprasId")
                        .HasColumnType("int");

                    b.Property<DateTimeOffset>("Data")
                        .HasColumnType("datetimeoffset");

                    b.Property<int?>("ProdutosId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ComprasId");

                    b.HasIndex("ProdutosId");

                    b.ToTable("ItensComprados");
                });

            modelBuilder.Entity("ControleDeEstoque.Models.NotaFiscal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTimeOffset>("DataEmissao")
                        .HasColumnType("datetimeoffset");

                    b.Property<int?>("ItemsCompradosId")
                        .HasColumnType("int");

                    b.Property<int>("NumeroNota")
                        .HasColumnType("int");

                    b.Property<int?>("PagamentosId")
                        .HasColumnType("int");

                    b.Property<int?>("ProdutosId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ItemsCompradosId");

                    b.HasIndex("PagamentosId");

                    b.HasIndex("ProdutosId");

                    b.ToTable("NotasFiscais");
                });

            modelBuilder.Entity("ControleDeEstoque.Models.Pagamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("ComprasId")
                        .HasColumnType("int");

                    b.Property<string>("FormaPagamento")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("PagamentosId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ComprasId");

                    b.HasIndex("PagamentosId");

                    b.ToTable("Pagamentos");
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

            modelBuilder.Entity("ControleDeEstoque.Models.Estoque", b =>
                {
                    b.HasOne("ControleDeEstoque.Models.Compra", "Compras")
                        .WithMany()
                        .HasForeignKey("ComprasId");

                    b.HasOne("ControleDeEstoque.Models.Funcionario", "Funcionarios")
                        .WithMany()
                        .HasForeignKey("FuncionariosId");

                    b.HasOne("ControleDeEstoque.Models.Produto", "Produtos")
                        .WithMany()
                        .HasForeignKey("ProdutosId");

                    b.Navigation("Compras");

                    b.Navigation("Funcionarios");

                    b.Navigation("Produtos");
                });

            modelBuilder.Entity("ControleDeEstoque.Models.Funcionario", b =>
                {
                    b.HasOne("ControleDeEstoque.Models.Usuario", "Usuarios")
                        .WithMany()
                        .HasForeignKey("UsuariosId");

                    b.Navigation("Usuarios");
                });

            modelBuilder.Entity("ControleDeEstoque.Models.ItemComprado", b =>
                {
                    b.HasOne("ControleDeEstoque.Models.Compra", "Compras")
                        .WithMany()
                        .HasForeignKey("ComprasId");

                    b.HasOne("ControleDeEstoque.Models.Produto", "Produtos")
                        .WithMany()
                        .HasForeignKey("ProdutosId");

                    b.Navigation("Compras");

                    b.Navigation("Produtos");
                });

            modelBuilder.Entity("ControleDeEstoque.Models.NotaFiscal", b =>
                {
                    b.HasOne("ControleDeEstoque.Models.ItemComprado", "ItemsComprados")
                        .WithMany()
                        .HasForeignKey("ItemsCompradosId");

                    b.HasOne("ControleDeEstoque.Models.Pagamento", "Pagamentos")
                        .WithMany()
                        .HasForeignKey("PagamentosId");

                    b.HasOne("ControleDeEstoque.Models.Produto", "Produtos")
                        .WithMany()
                        .HasForeignKey("ProdutosId");

                    b.Navigation("ItemsComprados");

                    b.Navigation("Pagamentos");

                    b.Navigation("Produtos");
                });

            modelBuilder.Entity("ControleDeEstoque.Models.Pagamento", b =>
                {
                    b.HasOne("ControleDeEstoque.Models.Compra", "Compras")
                        .WithMany()
                        .HasForeignKey("ComprasId");

                    b.HasOne("ControleDeEstoque.Models.Pagamento", "Pagamentos")
                        .WithMany()
                        .HasForeignKey("PagamentosId");

                    b.Navigation("Compras");

                    b.Navigation("Pagamentos");
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
