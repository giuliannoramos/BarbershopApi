﻿// <auto-generated />
using System;
using Barbearia.Persistence.DbContexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Barbearia.Persistence.Migrations
{
    [DbContext(typeof(PersonContext))]
    partial class PersonContextModelSnapshot : ModelSnapshot
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
                        .HasMaxLength(8)
                        .HasColumnType("character varying(8)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("character varying(60)");

                    b.Property<string>("Complement")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("character varying(80)");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasMaxLength(60)
                        .HasColumnType("character varying(60)");

                    b.Property<int>("Number")
                        .HasColumnType("integer");

                    b.Property<int>("PersonId")
                        .HasColumnType("integer");

                    b.Property<string>("State")
                        .IsRequired()
                        .HasMaxLength(2)
                        .HasColumnType("character varying(2)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("character varying(80)");

                    b.HasKey("AddressId");

                    b.HasIndex("PersonId");

                    b.ToTable("Address", (string)null);

                    b.HasData(
                        new
                        {
                            AddressId = 1,
                            Cep = "88888888",
                            City = "Bc",
                            Complement = "Perto de la",
                            District = "Teste",
                            Number = 100,
                            PersonId = 1,
                            State = "SC",
                            Street = "Rua logo ali"
                        },
                        new
                        {
                            AddressId = 2,
                            Cep = "88888888",
                            City = "Itajaí",
                            Complement = "Longe de la",
                            District = "Perto",
                            Number = 300,
                            PersonId = 2,
                            State = "SC",
                            Street = "Rua longe"
                        },
                        new
                        {
                            AddressId = 3,
                            Cep = "80888088",
                            City = "Bc",
                            Complement = "Perto",
                            District = "Asilo",
                            Number = 100,
                            PersonId = 3,
                            State = "SC",
                            Street = "Rua velha"
                        },
                        new
                        {
                            AddressId = 4,
                            Cep = "88123888",
                            City = "Floripa",
                            Complement = "Longe",
                            District = "soft",
                            Number = 300,
                            PersonId = 4,
                            State = "SC",
                            Street = "Rua micro"
                        });
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
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.HasKey("ItemId");

                    b.ToTable("Item", null, t =>
                        {
                            t.ExcludeFromMigrations();
                        });

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
                        .HasMaxLength(14)
                        .HasColumnType("character varying(14)");

                    b.Property<string>("Cpf")
                        .IsRequired()
                        .HasMaxLength(11)
                        .HasColumnType("character varying(11)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("character varying(80)");

                    b.Property<int>("Gender")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("character varying(80)");

                    b.Property<int>("PersonType")
                        .HasColumnType("integer");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.HasKey("PersonId");

                    b.ToTable("Person", (string)null);

                    b.HasDiscriminator<int>("PersonType").HasValue(1);

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("Barbearia.Domain.Entities.Role", b =>
                {
                    b.Property<int>("RoleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("RoleId"));

                    b.Property<int?>("CustomerPersonId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("character varying(80)");

                    b.Property<int?>("SupplierPersonId")
                        .HasColumnType("integer");

                    b.HasKey("RoleId");

                    b.HasIndex("CustomerPersonId");

                    b.HasIndex("SupplierPersonId");

                    b.ToTable("Role", (string)null);

                    b.HasData(
                        new
                        {
                            RoleId = 1,
                            Name = "Barbeiro"
                        },
                        new
                        {
                            RoleId = 2,
                            Name = "Barbeiro Mestre?Sla"
                        });
                });

            modelBuilder.Entity("Barbearia.Domain.Entities.RoleEmployee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .HasColumnType("integer");

                    b.Property<int>("RoleId")
                        .HasColumnType("integer");

                    b.HasKey("EmployeeId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("RoleEmployee");

                    b.HasData(
                        new
                        {
                            EmployeeId = 5,
                            RoleId = 1
                        },
                        new
                        {
                            EmployeeId = 6,
                            RoleId = 2
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

                    b.HasIndex("WorkingDayId")
                        .IsUnique();

                    b.ToTable("Schedule", (string)null);

                    b.HasData(
                        new
                        {
                            ScheduleId = 1,
                            Status = 1,
                            WorkingDayId = 1
                        },
                        new
                        {
                            ScheduleId = 2,
                            Status = 2,
                            WorkingDayId = 2
                        });
                });

            modelBuilder.Entity("Barbearia.Domain.Entities.Telephone", b =>
                {
                    b.Property<int>("TelephoneId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("TelephoneId"));

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasMaxLength(80)
                        .HasColumnType("character varying(80)");

                    b.Property<int>("PersonId")
                        .HasColumnType("integer");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.HasKey("TelephoneId");

                    b.HasIndex("PersonId");

                    b.ToTable("Telephone", (string)null);

                    b.HasData(
                        new
                        {
                            TelephoneId = 1,
                            Number = "47988887777",
                            PersonId = 1,
                            Type = 0
                        },
                        new
                        {
                            TelephoneId = 2,
                            Number = "47988887777",
                            PersonId = 2,
                            Type = 1
                        },
                        new
                        {
                            TelephoneId = 3,
                            Number = "47944887777",
                            PersonId = 3,
                            Type = 0
                        },
                        new
                        {
                            TelephoneId = 4,
                            Number = "55988844777",
                            PersonId = 4,
                            Type = 1
                        });
                });

            modelBuilder.Entity("Barbearia.Domain.Entities.TimeOff", b =>
                {
                    b.Property<int>("TimeOffId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("TimeOffId"));

                    b.Property<TimeOnly>("FinishTime")
                        .HasColumnType("time without time zone");

                    b.Property<TimeOnly>("StartTime")
                        .HasColumnType("time without time zone");

                    b.Property<int>("WorkingDayId")
                        .HasColumnType("integer");

                    b.HasKey("TimeOffId");

                    b.HasIndex("WorkingDayId");

                    b.ToTable("TimeOff", (string)null);

                    b.HasData(
                        new
                        {
                            TimeOffId = 1,
                            FinishTime = new TimeOnly(14, 0, 0),
                            StartTime = new TimeOnly(11, 30, 0),
                            WorkingDayId = 1
                        },
                        new
                        {
                            TimeOffId = 2,
                            FinishTime = new TimeOnly(15, 0, 0),
                            StartTime = new TimeOnly(12, 0, 0),
                            WorkingDayId = 2
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

                    b.ToTable("WorkingDay", (string)null);

                    b.HasData(
                        new
                        {
                            WorkingDayId = 1,
                            FinishTime = new TimeOnly(18, 30, 0),
                            PersonId = 5,
                            StartTime = new TimeOnly(7, 23, 11),
                            WorkDate = new DateOnly(2023, 10, 10)
                        },
                        new
                        {
                            WorkingDayId = 2,
                            FinishTime = new TimeOnly(19, 30, 0),
                            PersonId = 5,
                            StartTime = new TimeOnly(8, 23, 11),
                            WorkDate = new DateOnly(2023, 11, 11)
                        });
                });

            modelBuilder.Entity("Barbearia.Domain.Entities.Product", b =>
                {
                    b.HasBaseType("Barbearia.Domain.Entities.Item");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("text");

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
                        .HasColumnType("text");

                    b.Property<int>("Status")
                        .HasColumnType("integer");

                    b.HasIndex("PersonId");

                    b.ToTable("Product", null, t =>
                        {
                            t.ExcludeFromMigrations();
                        });
                });

            modelBuilder.Entity("Barbearia.Domain.Entities.Customer", b =>
                {
                    b.HasBaseType("Barbearia.Domain.Entities.Person");

                    b.HasDiscriminator().HasValue(2);

                    b.HasData(
                        new
                        {
                            PersonId = 1,
                            BirthDate = new DateOnly(1999, 8, 7),
                            Cnpj = "",
                            Cpf = "73473943096",
                            Email = "veio@hotmail.com",
                            Gender = 1,
                            Name = "Linus Torvalds",
                            Status = 0
                        },
                        new
                        {
                            PersonId = 2,
                            BirthDate = new DateOnly(2000, 1, 1),
                            Cnpj = "",
                            Cpf = "73473003096",
                            Email = "bill@gmail.com",
                            Gender = 2,
                            Name = "Bill Gates",
                            Status = 0
                        });
                });

            modelBuilder.Entity("Barbearia.Domain.Entities.Employee", b =>
                {
                    b.HasBaseType("Barbearia.Domain.Entities.Person");

                    b.HasDiscriminator().HasValue(4);

                    b.HasData(
                        new
                        {
                            PersonId = 5,
                            BirthDate = new DateOnly(2000, 8, 7),
                            Cnpj = "",
                            Cpf = "73473943096",
                            Email = "joao@hotmail.com",
                            Gender = 1,
                            Name = "João cabeça",
                            Status = 1
                        },
                        new
                        {
                            PersonId = 6,
                            BirthDate = new DateOnly(1990, 1, 1),
                            Cnpj = "",
                            Cpf = "73473003096",
                            Email = "billdoidao@gmail.com",
                            Gender = 1,
                            Name = "Bill Maluco",
                            Status = 2
                        });
                });

            modelBuilder.Entity("Barbearia.Domain.Entities.Supplier", b =>
                {
                    b.HasBaseType("Barbearia.Domain.Entities.Person");

                    b.HasDiscriminator().HasValue(3);

                    b.HasData(
                        new
                        {
                            PersonId = 3,
                            BirthDate = new DateOnly(1973, 2, 1),
                            Cnpj = "73473003096986",
                            Cpf = "",
                            Email = "josefacraft@hotmail.com",
                            Gender = 0,
                            Name = "Josefina",
                            Status = 1
                        },
                        new
                        {
                            PersonId = 4,
                            BirthDate = new DateOnly(1975, 4, 4),
                            Cnpj = "73473003096986",
                            Cpf = "",
                            Email = "micro@so.ft",
                            Gender = 0,
                            Name = "Microsoft",
                            Status = 2
                        });
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
                        .HasForeignKey("PersonId");

                    b.Navigation("Person");
                });

            modelBuilder.Entity("Barbearia.Domain.Entities.Role", b =>
                {
                    b.HasOne("Barbearia.Domain.Entities.Customer", null)
                        .WithMany("Roles")
                        .HasForeignKey("CustomerPersonId");

                    b.HasOne("Barbearia.Domain.Entities.Supplier", null)
                        .WithMany("Roles")
                        .HasForeignKey("SupplierPersonId");
                });

            modelBuilder.Entity("Barbearia.Domain.Entities.RoleEmployee", b =>
                {
                    b.HasOne("Barbearia.Domain.Entities.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Barbearia.Domain.Entities.Role", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Role");
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

            modelBuilder.Entity("Barbearia.Domain.Entities.TimeOff", b =>
                {
                    b.HasOne("Barbearia.Domain.Entities.WorkingDay", "WorkingDay")
                        .WithMany("TimeOffs")
                        .HasForeignKey("WorkingDayId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("WorkingDay");
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

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("Barbearia.Domain.Entities.Person", b =>
                {
                    b.Navigation("Addresses");

                    b.Navigation("Orders");

                    b.Navigation("Products");

                    b.Navigation("Telephones");

                    b.Navigation("WorkingDays");
                });

            modelBuilder.Entity("Barbearia.Domain.Entities.WorkingDay", b =>
                {
                    b.Navigation("Schedule");

                    b.Navigation("TimeOffs");
                });

            modelBuilder.Entity("Barbearia.Domain.Entities.Customer", b =>
                {
                    b.Navigation("Roles");
                });

            modelBuilder.Entity("Barbearia.Domain.Entities.Supplier", b =>
                {
                    b.Navigation("Roles");
                });
#pragma warning restore 612, 618
        }
    }
}
