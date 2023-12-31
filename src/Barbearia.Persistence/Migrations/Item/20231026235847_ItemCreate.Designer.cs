﻿// <auto-generated />
using System;
using Barbearia.Persistence.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Barbearia.Persistence.Migrations.Item
{
    [DbContext(typeof(ItemContext))]
    [Migration("20231026235847_ItemCreate")]
    partial class ItemCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Barbearia.Domain.Entities.Appointment", b =>
                {
                    b.Property<int>("AppointmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("AppointmentId"));

                    b.Property<DateTime>("CancellationDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("ConfirmedDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("FinishDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("FinishServiceDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("PersonId")
                        .HasColumnType("integer");

                    b.Property<int>("ScheduleId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("StartServiceDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.HasKey("AppointmentId");

                    b.HasIndex("PersonId");

                    b.HasIndex("ScheduleId");

                    b.ToTable("Appointment", (string)null);

                    b.HasData(
                        new
                        {
                            AppointmentId = 1,
                            CancellationDate = new DateTime(2023, 10, 26, 23, 58, 47, 446, DateTimeKind.Utc).AddTicks(7373),
                            ConfirmedDate = new DateTime(2023, 10, 26, 23, 58, 47, 446, DateTimeKind.Utc).AddTicks(7372),
                            FinishDate = new DateTime(2023, 10, 26, 23, 58, 47, 446, DateTimeKind.Utc).AddTicks(7369),
                            FinishServiceDate = new DateTime(2023, 10, 26, 23, 58, 47, 446, DateTimeKind.Utc).AddTicks(7371),
                            PersonId = 2,
                            ScheduleId = 1,
                            StartDate = new DateTime(2023, 10, 26, 23, 58, 47, 446, DateTimeKind.Utc).AddTicks(7365),
                            StartServiceDate = new DateTime(2023, 10, 26, 23, 58, 47, 446, DateTimeKind.Utc).AddTicks(7370),
                            Status = 1
                        });
                });

            modelBuilder.Entity("Barbearia.Domain.Entities.AppointmentOrder", b =>
                {
                    b.Property<int>("AppointmentId")
                        .HasColumnType("integer");

                    b.Property<int>("OrderId")
                        .HasColumnType("integer");

                    b.HasKey("AppointmentId", "OrderId");

                    b.HasIndex("OrderId");

                    b.ToTable("AppointmentOrder", (string)null);

                    b.HasData(
                        new
                        {
                            AppointmentId = 1,
                            OrderId = 1
                        });
                });

            modelBuilder.Entity("Barbearia.Domain.Entities.AppointmentService", b =>
                {
                    b.Property<int>("AppointmentServiceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("AppointmentServiceId"));

                    b.Property<int>("AppointmentId")
                        .HasColumnType("integer");

                    b.Property<decimal>("CurrentPrice")
                        .HasColumnType("numeric");

                    b.Property<int>("DurationMinutes")
                        .HasColumnType("integer");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ServiceId")
                        .HasColumnType("integer");

                    b.HasKey("AppointmentServiceId");

                    b.HasIndex("AppointmentId");

                    b.HasIndex("ServiceId");

                    b.ToTable("AppointmentService", (string)null);

                    b.HasData(
                        new
                        {
                            AppointmentServiceId = 1,
                            AppointmentId = 1,
                            CurrentPrice = 20m,
                            DurationMinutes = 30,
                            EmployeeId = 4,
                            Name = "Confesso que não sei que nome é pra colocar aqui",
                            ServiceId = 3
                        });
                });

            modelBuilder.Entity("Barbearia.Domain.Entities.EmployeeService", b =>
                {
                    b.Property<int>("PersonId")
                        .HasColumnType("integer");

                    b.Property<int>("ServiceId")
                        .HasColumnType("integer");

                    b.HasKey("PersonId", "ServiceId");

                    b.HasIndex("ServiceId");

                    b.ToTable("EmployeeService");
                });

            modelBuilder.Entity("Barbearia.Domain.Entities.Item", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ItemId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("character varying(80)");

                    b.Property<decimal>("Price")
                        .HasPrecision(8, 2)
                        .HasColumnType("numeric(8,2)");

                    b.HasKey("ItemId");

                    b.ToTable("Item");

                    b.UseTptMappingStrategy();
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
                        .HasColumnType("integer");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.HasKey("OrderId");

                    b.HasIndex("PersonId");

                    b.ToTable("Order", null, t =>
                        {
                            t.ExcludeFromMigrations();
                        });
                });

            modelBuilder.Entity("Barbearia.Domain.Entities.OrderProduct", b =>
                {
                    b.Property<int>("OrderId")
                        .HasColumnType("integer");

                    b.Property<int>("ItemId")
                        .HasColumnType("integer");

                    b.HasKey("OrderId", "ItemId");

                    b.HasIndex("ItemId");

                    b.ToTable("OrderProduct", (string)null);

                    b.HasData(
                        new
                        {
                            OrderId = 1,
                            ItemId = 1
                        },
                        new
                        {
                            OrderId = 2,
                            ItemId = 1
                        },
                        new
                        {
                            OrderId = 1,
                            ItemId = 2
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

                    b.Property<int>("PersonType")
                        .HasColumnType("integer");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.HasKey("PersonId");

                    b.ToTable("Person", null, t =>
                        {
                            t.ExcludeFromMigrations();
                        });

                    b.HasDiscriminator<int>("PersonType").HasValue(1);

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Barbearia.Domain.Entities.ProductCategory", b =>
                {
                    b.Property<int>("ProductCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ProductCategoryId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("ProductCategoryId");

                    b.ToTable("ProductCategory", (string)null);

                    b.HasData(
                        new
                        {
                            ProductCategoryId = 1,
                            Name = "Comida"
                        },
                        new
                        {
                            ProductCategoryId = 2,
                            Name = "Gel"
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

                    b.ToTable("Role", null, t =>
                        {
                            t.ExcludeFromMigrations();
                        });
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

                    b.ToTable("Schedule", null, t =>
                        {
                            t.ExcludeFromMigrations();
                        });
                });

            modelBuilder.Entity("Barbearia.Domain.Entities.ServiceCategory", b =>
                {
                    b.Property<int>("ServiceCategoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ServiceCategoryId"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("ServiceCategoryId");

                    b.ToTable("ServiceCategory", (string)null);

                    b.HasData(
                        new
                        {
                            ServiceCategoryId = 1,
                            Name = "Corte"
                        });
                });

            modelBuilder.Entity("Barbearia.Domain.Entities.StockHistory", b =>
                {
                    b.Property<int>("StockHistoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("StockHistoryId"));

                    b.Property<int>("Amount")
                        .HasColumnType("integer");

                    b.Property<decimal>("CurrentPrice")
                        .HasPrecision(8, 2)
                        .HasColumnType("numeric(8,2)");

                    b.Property<int>("LastStockQuantity")
                        .HasColumnType("integer");

                    b.Property<int>("Operation")
                        .HasColumnType("integer");

                    b.Property<int>("ProductId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("Timestamp")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("StockHistoryId");

                    b.HasIndex("ProductId");

                    b.ToTable("StockHistory", (string)null);

                    b.UseTptMappingStrategy();
                });

            modelBuilder.Entity("Barbearia.Domain.Entities.Product", b =>
                {
                    b.HasBaseType("Barbearia.Domain.Entities.Item");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("character varying(80)");

                    b.Property<int>("PersonId")
                        .HasColumnType("integer");

                    b.Property<int>("ProductCategoryId")
                        .HasColumnType("integer");

                    b.Property<int>("QuantityInStock")
                        .HasColumnType("integer");

                    b.Property<int>("QuantityReserved")
                        .HasColumnType("integer");

                    b.Property<string>("SKU")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.HasIndex("PersonId");

                    b.HasIndex("ProductCategoryId");

                    b.ToTable("Product", (string)null);

                    b.HasData(
                        new
                        {
                            ItemId = 1,
                            Description = "é bom e te deixa ligadão",
                            Name = "Bombomzinho de energético",
                            Price = 20m,
                            Brand = "Josefa doces para gamers",
                            PersonId = 3,
                            ProductCategoryId = 1,
                            QuantityInStock = 40,
                            QuantityReserved = 35,
                            SKU = "G4M3R5",
                            Status = 1
                        },
                        new
                        {
                            ItemId = 2,
                            Description = "deixa o cabelo duro",
                            Name = "Gel Mil Grau",
                            Price = 40m,
                            Brand = "Microsoft Cooporations",
                            PersonId = 4,
                            ProductCategoryId = 2,
                            QuantityInStock = 400,
                            QuantityReserved = 20,
                            SKU = "S0FT",
                            Status = 2
                        });
                });

            modelBuilder.Entity("Barbearia.Domain.Entities.Service", b =>
                {
                    b.HasBaseType("Barbearia.Domain.Entities.Item");

                    b.Property<int>("DurationMinutes")
                        .HasColumnType("integer");

                    b.Property<int>("ServiceCategoryId")
                        .HasColumnType("integer");

                    b.HasIndex("ServiceCategoryId");

                    b.ToTable("Service", (string)null);

                    b.HasData(
                        new
                        {
                            ItemId = 3,
                            Description = "Um corte para testas o sistema",
                            Name = "corte qualquer",
                            Price = 20m,
                            DurationMinutes = 30,
                            ServiceCategoryId = 1
                        });
                });

            modelBuilder.Entity("Barbearia.Domain.Entities.Customer", b =>
                {
                    b.HasBaseType("Barbearia.Domain.Entities.Person");

                    b.HasDiscriminator().HasValue(2);
                });

            modelBuilder.Entity("Barbearia.Domain.Entities.Supplier", b =>
                {
                    b.HasBaseType("Barbearia.Domain.Entities.Person");

                    b.HasDiscriminator().HasValue(3);
                });

            modelBuilder.Entity("Barbearia.Domain.Entities.StockHistoryOrder", b =>
                {
                    b.HasBaseType("Barbearia.Domain.Entities.StockHistory");

                    b.Property<int>("OrderId")
                        .HasColumnType("integer");

                    b.HasIndex("OrderId");

                    b.ToTable("StockHistoryOrder", (string)null);

                    b.HasData(
                        new
                        {
                            StockHistoryId = 1,
                            Amount = 20,
                            CurrentPrice = 23.5m,
                            LastStockQuantity = 10,
                            Operation = 1,
                            ProductId = 1,
                            Timestamp = new DateTime(2023, 10, 26, 23, 58, 47, 447, DateTimeKind.Utc).AddTicks(4162),
                            OrderId = 1
                        });
                });

            modelBuilder.Entity("Barbearia.Domain.Entities.StockHistorySupplier", b =>
                {
                    b.HasBaseType("Barbearia.Domain.Entities.StockHistory");

                    b.Property<int>("PersonId")
                        .HasColumnType("integer");

                    b.HasIndex("PersonId");

                    b.ToTable("StockHistorySupplier", (string)null);

                    b.HasData(
                        new
                        {
                            StockHistoryId = 2,
                            Amount = 40,
                            CurrentPrice = 200.2m,
                            LastStockQuantity = 32,
                            Operation = 3,
                            ProductId = 2,
                            Timestamp = new DateTime(2023, 10, 26, 23, 58, 47, 447, DateTimeKind.Utc).AddTicks(4195),
                            PersonId = 4
                        });
                });

            modelBuilder.Entity("Barbearia.Domain.Entities.Appointment", b =>
                {
                    b.HasOne("Barbearia.Domain.Entities.Person", "Person")
                        .WithMany("Appointments")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Barbearia.Domain.Entities.Schedule", "Schedule")
                        .WithMany("Appointments")
                        .HasForeignKey("ScheduleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Person");

                    b.Navigation("Schedule");
                });

            modelBuilder.Entity("Barbearia.Domain.Entities.AppointmentOrder", b =>
                {
                    b.HasOne("Barbearia.Domain.Entities.Appointment", null)
                        .WithMany()
                        .HasForeignKey("AppointmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Barbearia.Domain.Entities.Order", null)
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Barbearia.Domain.Entities.AppointmentService", b =>
                {
                    b.HasOne("Barbearia.Domain.Entities.Appointment", null)
                        .WithMany()
                        .HasForeignKey("AppointmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Barbearia.Domain.Entities.Service", null)
                        .WithMany()
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Barbearia.Domain.Entities.EmployeeService", b =>
                {
                    b.HasOne("Barbearia.Domain.Entities.Person", null)
                        .WithMany()
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Barbearia.Domain.Entities.Service", null)
                        .WithMany()
                        .HasForeignKey("ServiceId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Barbearia.Domain.Entities.Order", b =>
                {
                    b.HasOne("Barbearia.Domain.Entities.Person", "Person")
                        .WithMany("Orders")
                        .HasForeignKey("PersonId");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("Barbearia.Domain.Entities.OrderProduct", b =>
                {
                    b.HasOne("Barbearia.Domain.Entities.Product", "Product")
                        .WithMany("OrderProducts")
                        .HasForeignKey("ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Barbearia.Domain.Entities.Order", "Order")
                        .WithMany("OrderProducts")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Barbearia.Domain.Entities.Role", b =>
                {
                    b.HasOne("Barbearia.Domain.Entities.Person", null)
                        .WithMany("Roles")
                        .HasForeignKey("PersonId");
                });

            modelBuilder.Entity("Barbearia.Domain.Entities.StockHistory", b =>
                {
                    b.HasOne("Barbearia.Domain.Entities.Product", "Product")
                        .WithMany("StockHistories")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");
                });

            modelBuilder.Entity("Barbearia.Domain.Entities.Product", b =>
                {
                    b.HasOne("Barbearia.Domain.Entities.Item", null)
                        .WithOne()
                        .HasForeignKey("Barbearia.Domain.Entities.Product", "ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Barbearia.Domain.Entities.Person", "Supplier")
                        .WithMany("Products")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Barbearia.Domain.Entities.ProductCategory", "ProductCategory")
                        .WithMany("Product")
                        .HasForeignKey("ProductCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductCategory");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("Barbearia.Domain.Entities.Service", b =>
                {
                    b.HasOne("Barbearia.Domain.Entities.Item", null)
                        .WithOne()
                        .HasForeignKey("Barbearia.Domain.Entities.Service", "ItemId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Barbearia.Domain.Entities.ServiceCategory", "ServiceCategory")
                        .WithMany("Services")
                        .HasForeignKey("ServiceCategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ServiceCategory");
                });

            modelBuilder.Entity("Barbearia.Domain.Entities.StockHistoryOrder", b =>
                {
                    b.HasOne("Barbearia.Domain.Entities.Order", "Order")
                        .WithMany("StockHistoriesOrder")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Barbearia.Domain.Entities.StockHistory", null)
                        .WithOne()
                        .HasForeignKey("Barbearia.Domain.Entities.StockHistoryOrder", "StockHistoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");
                });

            modelBuilder.Entity("Barbearia.Domain.Entities.StockHistorySupplier", b =>
                {
                    b.HasOne("Barbearia.Domain.Entities.Person", "Supplier")
                        .WithMany("StockHistoriesSupplier")
                        .HasForeignKey("PersonId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Barbearia.Domain.Entities.StockHistory", null)
                        .WithOne()
                        .HasForeignKey("Barbearia.Domain.Entities.StockHistorySupplier", "StockHistoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("Barbearia.Domain.Entities.Order", b =>
                {
                    b.Navigation("OrderProducts");

                    b.Navigation("StockHistoriesOrder");
                });

            modelBuilder.Entity("Barbearia.Domain.Entities.Person", b =>
                {
                    b.Navigation("Appointments");

                    b.Navigation("Orders");

                    b.Navigation("Products");

                    b.Navigation("Roles");

                    b.Navigation("StockHistoriesSupplier");
                });

            modelBuilder.Entity("Barbearia.Domain.Entities.ProductCategory", b =>
                {
                    b.Navigation("Product");
                });

            modelBuilder.Entity("Barbearia.Domain.Entities.Schedule", b =>
                {
                    b.Navigation("Appointments");
                });

            modelBuilder.Entity("Barbearia.Domain.Entities.ServiceCategory", b =>
                {
                    b.Navigation("Services");
                });

            modelBuilder.Entity("Barbearia.Domain.Entities.Product", b =>
                {
                    b.Navigation("OrderProducts");

                    b.Navigation("StockHistories");
                });
#pragma warning restore 612, 618
        }
    }
}
