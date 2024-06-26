﻿// <auto-generated />
using System;
using ControleDeEstoque.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ControleDeEstoque.Migrations
{
    [DbContext(typeof(ControleContext))]
    [Migration("20221025204824_05")]
    partial class _05
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ControleDeEstoque.Models.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CepCliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CidadeCliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CodigoCliente")
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
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UfCliente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Cliente");
                });

            modelBuilder.Entity("ControleDeEstoque.Models.Compra", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoriaProd")
                        .HasColumnType("nvarchar(max)");

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

                    b.Property<int?>("VendasId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ComprasId");

                    b.HasIndex("FuncionariosId");

                    b.HasIndex("ProdutosId");

                    b.HasIndex("VendasId");

                    b.ToTable("Estoque");
                });

            modelBuilder.Entity("ControleDeEstoque.Models.Funcionario", b =>
                {
                    b.Property<int?>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CepCliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CidadeCliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CodigoCliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EnderecoCliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TelefoneCliente")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UfCliente")
                        .HasColumnType("nvarchar(max)");

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
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CodPedido")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("ComprasId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Data")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ProdutosId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ComprasId");

                    b.HasIndex("ProdutosId");

                    b.ToTable("ItensComprados");
                });

            modelBuilder.Entity("ControleDeEstoque.Models.ItemVendido", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoriaProd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescricaoProd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeProd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PrecoProd")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("ProdutosId")
                        .HasColumnType("int");

                    b.Property<long>("QtdProd")
                        .HasColumnType("bigint");

                    b.Property<int?>("VendasId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProdutosId");

                    b.HasIndex("VendasId");

                    b.ToTable("ItensVendidos");
                });

            modelBuilder.Entity("ControleDeEstoque.Models.NotaFiscal", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataEmissao")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ItemsCompradosId")
                        .HasColumnType("int");

                    b.Property<int>("NumeroNota")
                        .HasColumnType("int");

                    b.Property<int?>("PagamentosId")
                        .HasColumnType("int");

                    b.Property<int?>("ProdutosId")
                        .HasColumnType("int");

                    b.Property<int?>("VendasId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ItemsCompradosId");

                    b.HasIndex("PagamentosId");

                    b.HasIndex("ProdutosId");

                    b.HasIndex("VendasId");

                    b.ToTable("NotasFiscais");
                });

            modelBuilder.Entity("ControleDeEstoque.Models.Pagamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoriaProd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DescricaoProd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NomeProd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PrecoProd")
                        .HasColumnType("decimal(18,2)");

                    b.Property<long>("QtdProd")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.ToTable("Produto");
                });

            modelBuilder.Entity("ControleDeEstoque.Models.Usuario", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("EmaildoUsuario")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Login")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Senha")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("ControleDeEstoque.Models.Venda", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.Property<int?>("ProdutosId")
                        .HasColumnType("int");

                    b.Property<long>("QtdProd")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("ProdutosId");

                    b.ToTable("Vendas");
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

                    b.HasOne("ControleDeEstoque.Models.Venda", "Vendas")
                        .WithMany()
                        .HasForeignKey("VendasId");

                    b.Navigation("Compras");

                    b.Navigation("Funcionarios");

                    b.Navigation("Produtos");

                    b.Navigation("Vendas");
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

            modelBuilder.Entity("ControleDeEstoque.Models.ItemVendido", b =>
                {
                    b.HasOne("ControleDeEstoque.Models.Produto", "Produtos")
                        .WithMany()
                        .HasForeignKey("ProdutosId");

                    b.HasOne("ControleDeEstoque.Models.Venda", "Vendas")
                        .WithMany()
                        .HasForeignKey("VendasId");

                    b.Navigation("Produtos");

                    b.Navigation("Vendas");
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

                    b.HasOne("ControleDeEstoque.Models.Venda", "Vendas")
                        .WithMany()
                        .HasForeignKey("VendasId");

                    b.Navigation("ItemsComprados");

                    b.Navigation("Pagamentos");

                    b.Navigation("Produtos");

                    b.Navigation("Vendas");
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

            modelBuilder.Entity("ControleDeEstoque.Models.Venda", b =>
                {
                    b.HasOne("ControleDeEstoque.Models.Produto", "Produtos")
                        .WithMany()
                        .HasForeignKey("ProdutosId");

                    b.Navigation("Produtos");
                });
#pragma warning restore 612, 618
        }
    }
}
