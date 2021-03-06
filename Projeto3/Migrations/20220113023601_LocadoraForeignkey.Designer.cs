// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Projeto3.Data;

namespace Projeto3.Migrations
{
    [DbContext(typeof(Projeto3Context))]
    [Migration("20220113023601_LocadoraForeignkey")]
    partial class LocadoraForeignkey
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.14-servicing-32113")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Projeto3.Models.Automoveis", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("AnoFabricacao");

                    b.Property<int>("LocadoraId");

                    b.Property<string>("Modelo");

                    b.Property<double>("ValorAluguel");

                    b.Property<int>("placa");

                    b.HasKey("Id");

                    b.HasIndex("LocadoraId");

                    b.ToTable("Automovel");
                });

            modelBuilder.Entity("Projeto3.Models.Locadora", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Locadora");
                });

            modelBuilder.Entity("Projeto3.Models.VeiculoAlugado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<double>("Amount");

                    b.Property<int?>("AutomoveisId");

                    b.Property<DateTime>("Date");

                    b.Property<int>("Status");

                    b.HasKey("Id");

                    b.HasIndex("AutomoveisId");

                    b.ToTable("VeiculoAlugados");
                });

            modelBuilder.Entity("Projeto3.Models.Automoveis", b =>
                {
                    b.HasOne("Projeto3.Models.Locadora", "Locadora")
                        .WithMany("Automovel")
                        .HasForeignKey("LocadoraId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Projeto3.Models.VeiculoAlugado", b =>
                {
                    b.HasOne("Projeto3.Models.Automoveis", "Automoveis")
                        .WithMany("Aluguel")
                        .HasForeignKey("AutomoveisId");
                });
#pragma warning restore 612, 618
        }
    }
}
