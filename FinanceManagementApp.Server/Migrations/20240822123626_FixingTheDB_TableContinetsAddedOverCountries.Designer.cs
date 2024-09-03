﻿// <auto-generated />
using System;
using DbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FinanceManagementApp.Server.Migrations
{
    [DbContext(typeof(FMADbContext))]
    [Migration("20240822123626_FixingTheDB_TableContinetsAddedOverCountries")]
    partial class FixingTheDB_TableContinetsAddedOverCountries
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Models.Accounts", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<decimal>("Ballance")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("IncomeHistoryId")
                        .HasColumnType("int");

                    b.Property<decimal>("MonthlyIncome")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("PaymentHistoryId")
                        .HasColumnType("int");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TransactionHistoryId")
                        .HasColumnType("int");

                    b.Property<string>("UserName")
                        .IsRequired()
                        .HasMaxLength(55)
                        .HasColumnType("nvarchar(55)");

                    b.HasKey("id");

                    b.HasIndex("IncomeHistoryId");

                    b.HasIndex("PaymentHistoryId");

                    b.HasIndex("TransactionHistoryId");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("Models.Continents", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("Continent")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.ToTable("Countries");
                });

            modelBuilder.Entity("Models.ElementsI", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("IncomeId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(55)
                        .HasColumnType("nvarchar(55)");

                    b.Property<string>("Price")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("IncomeId");

                    b.ToTable("ElementsI");
                });

            modelBuilder.Entity("Models.ElementsP", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(55)
                        .HasColumnType("nvarchar(55)");

                    b.Property<int>("PaymentId")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("id");

                    b.HasIndex("PaymentId");

                    b.ToTable("ElementsP");
                });

            modelBuilder.Entity("Models.Income", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<decimal>("IncomeBalance")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("IncomeDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("IncomeHistoryId")
                        .HasColumnType("int");

                    b.Property<string>("MoneySource")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.HasKey("id");

                    b.HasIndex("IncomeHistoryId");

                    b.ToTable("Incomes");
                });

            modelBuilder.Entity("Models.IncomeHistory", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(55)
                        .HasColumnType("nvarchar(55)");

                    b.HasKey("id");

                    b.ToTable("IncomeHistory");
                });

            modelBuilder.Entity("Models.Payment", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<DateTime>("DateOfPayment")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("MoneySpend")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("PaymentHistoryId")
                        .HasColumnType("int");

                    b.Property<string>("SpendTo")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.HasKey("id");

                    b.HasIndex("PaymentHistoryId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("Models.PaymentHistory", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(55)
                        .HasColumnType("nvarchar(55)");

                    b.HasKey("id");

                    b.ToTable("PaymentHistories");
                });

            modelBuilder.Entity("Models.TransactionHistory", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<decimal>("Balance")
                        .HasPrecision(18, 2)
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(55)
                        .HasColumnType("nvarchar(55)");

                    b.Property<string>("To")
                        .IsRequired()
                        .HasMaxLength(120)
                        .HasColumnType("nvarchar(120)");

                    b.Property<DateTime>("TransactionMadeDate")
                        .HasColumnType("datetime2");

                    b.HasKey("id");

                    b.ToTable("TransactionHistories");
                });

            modelBuilder.Entity("Models.Users", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("id"));

                    b.Property<int>("AccountId")
                        .HasColumnType("int");

                    b.Property<int>("ContinentId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(55)
                        .HasColumnType("nvarchar(55)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondName")
                        .IsRequired()
                        .HasMaxLength(75)
                        .HasColumnType("nvarchar(75)");

                    b.Property<string>("ThirdName")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("id");

                    b.HasIndex("AccountId");

                    b.HasIndex("ContinentId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Models.Accounts", b =>
                {
                    b.HasOne("Models.IncomeHistory", "IncomeHistory")
                        .WithMany()
                        .HasForeignKey("IncomeHistoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.PaymentHistory", "PaymentHistory")
                        .WithMany()
                        .HasForeignKey("PaymentHistoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.TransactionHistory", "TransactionHistory")
                        .WithMany()
                        .HasForeignKey("TransactionHistoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IncomeHistory");

                    b.Navigation("PaymentHistory");

                    b.Navigation("TransactionHistory");
                });

            modelBuilder.Entity("Models.ElementsI", b =>
                {
                    b.HasOne("Models.Income", "Income")
                        .WithMany()
                        .HasForeignKey("IncomeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Income");
                });

            modelBuilder.Entity("Models.ElementsP", b =>
                {
                    b.HasOne("Models.Payment", "Payment")
                        .WithMany()
                        .HasForeignKey("PaymentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Payment");
                });

            modelBuilder.Entity("Models.Income", b =>
                {
                    b.HasOne("Models.IncomeHistory", "IncomeHistory")
                        .WithMany()
                        .HasForeignKey("IncomeHistoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("IncomeHistory");
                });

            modelBuilder.Entity("Models.Payment", b =>
                {
                    b.HasOne("Models.PaymentHistory", "PaymentHistory")
                        .WithMany()
                        .HasForeignKey("PaymentHistoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PaymentHistory");
                });

            modelBuilder.Entity("Models.Users", b =>
                {
                    b.HasOne("Models.Accounts", "Accounts")
                        .WithMany()
                        .HasForeignKey("AccountId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Models.Continents", "Continents")
                        .WithMany()
                        .HasForeignKey("ContinentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Accounts");

                    b.Navigation("Continents");
                });
#pragma warning restore 612, 618
        }
    }
}
