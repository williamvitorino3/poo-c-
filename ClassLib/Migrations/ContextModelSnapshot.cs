﻿// <auto-generated />
using DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using System;

namespace ClassLib.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("conta.Conta", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<double>("saldo");

                    b.Property<string>("titular");

                    b.HasKey("Id");

                    b.ToTable("Contas");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Conta");
                });

            modelBuilder.Entity("conta.ContaCorrente", b =>
                {
                    b.HasBaseType("conta.Conta");


                    b.ToTable("ContaCorrente");

                    b.HasDiscriminator().HasValue("ContaCorrente");
                });

            modelBuilder.Entity("conta.ContaPoupanca", b =>
                {
                    b.HasBaseType("conta.Conta");


                    b.ToTable("ContaPoupanca");

                    b.HasDiscriminator().HasValue("ContaPoupanca");
                });
#pragma warning restore 612, 618
        }
    }
}
