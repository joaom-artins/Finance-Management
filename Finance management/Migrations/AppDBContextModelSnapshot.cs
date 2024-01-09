﻿// <auto-generated />
using Finance_management.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Finance_management.Migrations
{
    [DbContext(typeof(AppDBContext))]
    partial class AppDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("Finance_management.Model.Finance", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<double>("Debts")
                        .HasPrecision(18, 2)
                        .HasColumnType("double");

                    b.Property<double>("EmergencyReserve")
                        .HasPrecision(18, 2)
                        .HasColumnType("double");

                    b.Property<double>("MoneyInvested")
                        .HasPrecision(18, 2)
                        .HasColumnType("double");

                    b.Property<int>("PersonId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PersonId")
                        .IsUnique();

                    b.ToTable("Finance");
                });

            modelBuilder.Entity("Finance_management.Model.Person", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Job")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(128)
                        .HasColumnType("varchar(128)");

                    b.Property<double>("Salary")
                        .HasPrecision(18, 2)
                        .HasColumnType("double");

                    b.HasKey("Id");

                    b.ToTable("Person");
                });

            modelBuilder.Entity("Finance_management.Model.Finance", b =>
                {
                    b.HasOne("Finance_management.Model.Person", "Person")
                        .WithOne("Finance")
                        .HasForeignKey("Finance_management.Model.Finance", "PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("Finance_management.Model.Person", b =>
                {
                    b.Navigation("Finance");
                });
#pragma warning restore 612, 618
        }
    }
}
