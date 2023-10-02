﻿// <auto-generated />
using System;
using Barbearia.Persistence.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Barbearia.Persistence.Migrations.Order
{
    [DbContext(typeof(OrderContext))]
    partial class OrderContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Barbearia.Domain.Entities.Address", b =>
                {
                    b.Property<int>("AddressId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("AddressId"));

                    b.Property<string>("Cep")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Complement")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Number")
                        .HasColumnType("integer");

                    b.Property<int>("PersonId")
                        .HasColumnType("integer");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("AddressId");

                    b.HasIndex("PersonId");

                    b.ToTable("Address", null, t =>
                        {
                            t.ExcludeFromMigrations();
                        });
                });

            modelBuilder.Entity("Barbearia.Domain.Entities.Coupon", b =>
                {
                    b.Property<int>("CouponId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CouponId"));

                    b.Property<string>("CouponCode")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<DateTime>("CreationDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("DiscountPercent")
                        .HasColumnType("integer");

                    b.Property<DateTime>("ExpirationDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("CouponId");

                    b.ToTable("Coupon", (string)null);

                    b.HasData(
                        new
                        {
                            CouponId = 1,
                            CouponCode = "teste3",
                            CreationDate = new DateTime(2023, 10, 2, 0, 0, 24, 333, DateTimeKind.Utc).AddTicks(9543),
                            DiscountPercent = 10,
                            ExpirationDate = new DateTime(2023, 10, 2, 0, 0, 24, 333, DateTimeKind.Utc).AddTicks(9543)
                        });
                });

            modelBuilder.Entity("Barbearia.Domain.Entities.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("OrderId"));

                    b.Property<DateTime>("BuyDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Number")
                        .HasColumnType("integer");

                    b.Property<int?>("PersonId")
                        .IsRequired()
                        .HasColumnType("integer");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.HasKey("OrderId");

                    b.HasIndex("PersonId");

                    b.ToTable("Order", (string)null);

                    b.HasData(
                        new
                        {
                            OrderId = 1,
                            BuyDate = new DateTime(2023, 10, 2, 0, 0, 24, 333, DateTimeKind.Utc).AddTicks(9359),
                            Number = 500,
                            PersonId = 1,
                            Status = 2
                        },
                        new
                        {
                            OrderId = 2,
                            BuyDate = new DateTime(2023, 10, 2, 0, 0, 24, 333, DateTimeKind.Utc).AddTicks(9384),
                            Number = 501,
                            PersonId = 2,
                            Status = 2
                        });
                });

            modelBuilder.Entity("Barbearia.Domain.Entities.Payment", b =>
                {
                    b.Property<int>("PaymentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("PaymentId"));

                    b.Property<DateTime>("BuyDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int?>("CouponId")
                        .HasColumnType("integer");

                    b.Property<string>("Description")
                        .HasColumnType("text");

                    b.Property<decimal>("GrossTotal")
                        .HasColumnType("numeric");

                    b.Property<decimal>("NetTotal")
                        .HasColumnType("numeric");

                    b.Property<int?>("OrderId")
                        .IsRequired()
                        .HasColumnType("integer");

                    b.Property<string>("PaymentMethod")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.HasKey("PaymentId");

                    b.HasIndex("CouponId");

                    b.HasIndex("OrderId")
                        .IsUnique();

                    b.ToTable("Payment", (string)null);

                    b.HasData(
                        new
                        {
                            PaymentId = 1,
                            BuyDate = new DateTime(2023, 10, 2, 0, 0, 24, 333, DateTimeKind.Utc).AddTicks(9530),
                            Description = "Para de ler isso aqui e vai programar",
                            GrossTotal = 80m,
                            NetTotal = 60m,
                            OrderId = 1,
                            PaymentMethod = "Dinheiro",
                            Status = 1
                        });
                });

            modelBuilder.Entity("Barbearia.Domain.Entities.Person", b =>
                {
                    b.Property<int>("PersonId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("PersonId"));

                    b.Property<DateOnly>("BirthDate")
                        .HasColumnType("date");

                    b.Property<string>("Cnpj")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Gender")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("PersonId");

                    b.ToTable("Person", null, t =>
                        {
                            t.ExcludeFromMigrations();
                        });
                });

            modelBuilder.Entity("Barbearia.Domain.Entities.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("RoleId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("PersonId")
                        .HasColumnType("integer");

                    b.HasKey("RoleId");

                    b.HasIndex("PersonId");

                    b.ToTable("Role");
                });

            modelBuilder.Entity("Barbearia.Domain.Entities.Schedule", b =>
                {
                    b.Property<int>("ScheduleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ScheduleId"));

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.Property<int>("WorkingDayId")
                        .HasColumnType("integer");

                    b.HasKey("ScheduleId");

                    b.HasIndex("WorkingDayId")
                        .IsUnique();

                    b.ToTable("Schedule");
                });

            modelBuilder.Entity("Barbearia.Domain.Entities.Telephone", b =>
                {
                    b.Property<int>("TelephoneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("TelephoneId"));

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("PersonId")
                        .HasColumnType("integer");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.HasKey("TelephoneId");

                    b.HasIndex("PersonId");

                    b.ToTable("Telephone", null, t =>
                        {
                            t.ExcludeFromMigrations();
                        });
                });

            modelBuilder.Entity("Barbearia.Domain.Entities.WorkingDay", b =>
                {
                    b.Property<int>("WorkingDayId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("WorkingDayId"));

                    b.Property<TimeOnly>("FinishTime")
                        .HasColumnType("time without time zone");

                    b.Property<int>("PersonId")
                        .HasColumnType("integer");

                    b.Property<TimeOnly>("StartTime")
                        .HasColumnType("time without time zone");

                    b.Property<DateOnly>("WorkDate")
                        .HasColumnType("date");

                    b.HasKey("WorkingDayId");

                    b.HasIndex("PersonId");

                    b.ToTable("WorkingDay");
                });

            modelBuilder.Entity("Barbearia.Domain.Entities.Address", b =>
                {
                    b.HasOne("Barbearia.Domain.Entities.Person", "Person")
                        .WithMany("Addresses")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("Barbearia.Domain.Entities.Order", b =>
                {
                    b.HasOne("Barbearia.Domain.Entities.Person", "Person")
                        .WithMany("Orders")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("Barbearia.Domain.Entities.Payment", b =>
                {
                    b.HasOne("Barbearia.Domain.Entities.Coupon", "Coupon")
                        .WithMany("Payments")
                        .HasForeignKey("CouponId");

                    b.HasOne("Barbearia.Domain.Entities.Order", "Order")
                        .WithOne("Payment")
                        .HasForeignKey("Barbearia.Domain.Entities.Payment", "OrderId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Coupon");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Barbearia.Domain.Entities.Role", b =>
                {
                    b.HasOne("Barbearia.Domain.Entities.Person", null)
                        .WithMany("Roles")
                        .HasForeignKey("PersonId");
                });

            modelBuilder.Entity("Barbearia.Domain.Entities.Schedule", b =>
                {
                    b.HasOne("Barbearia.Domain.Entities.WorkingDay", "WorkingDay")
                        .WithOne("Schedule")
                        .HasForeignKey("Barbearia.Domain.Entities.Schedule", "WorkingDayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("WorkingDay");
                });

            modelBuilder.Entity("Barbearia.Domain.Entities.Telephone", b =>
                {
                    b.HasOne("Barbearia.Domain.Entities.Person", "Person")
                        .WithMany("Telephones")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");
                });

            modelBuilder.Entity("Barbearia.Domain.Entities.WorkingDay", b =>
                {
                    b.HasOne("Barbearia.Domain.Entities.Person", "Employee")
                        .WithMany("WorkingDays")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");
                });

            modelBuilder.Entity("Barbearia.Domain.Entities.Coupon", b =>
                {
                    b.Navigation("Payments");
                });

            modelBuilder.Entity("Barbearia.Domain.Entities.Order", b =>
                {
                    b.Navigation("Payment");
                });

            modelBuilder.Entity("Barbearia.Domain.Entities.Person", b =>
                {
                    b.Navigation("Addresses");

                    b.Navigation("Orders");

                    b.Navigation("Roles");

                    b.Navigation("Telephones");

                    b.Navigation("WorkingDays");
                });

            modelBuilder.Entity("Barbearia.Domain.Entities.WorkingDay", b =>
                {
                    b.Navigation("Schedule");
                });
#pragma warning restore 612, 618
        }
    }
}
