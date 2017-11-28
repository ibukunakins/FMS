﻿// <auto-generated />
using FMS.Core.Context;
using FMS.Utilities.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using System;

namespace FMS.Core.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20171128045838_AddedCommentOnPayableWorkFlow")]
    partial class AddedCommentOnPayableWorkFlow
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("FMS.Core.Model.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<bool>("IsActive");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("PicturePixUrl");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.Property<string>("UserType");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("FMS.Core.Model.AppUserBank", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("NEWSEQUENTIALID()");

                    b.Property<string>("AccountName");

                    b.Property<string>("AccountNumber");

                    b.Property<string>("AppUserId");

                    b.Property<string>("BVN");

                    b.Property<Guid?>("BankId");

                    b.Property<string>("TIN");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.HasIndex("BankId");

                    b.ToTable("AppUserBanks");
                });

            modelBuilder.Entity("FMS.Core.Model.AppUserFile", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("NEWSEQUENTIALID()");

                    b.Property<string>("AppUserId");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.ToTable("AppUserFiles");
                });

            modelBuilder.Entity("FMS.Core.Model.AppUserProfile", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("NEWSEQUENTIALID()");

                    b.Property<string>("Address");

                    b.Property<string>("AppUserId");

                    b.Property<string>("City");

                    b.Property<int?>("CountryId");

                    b.Property<string>("EmailAddress");

                    b.Property<string>("Fax");

                    b.Property<string>("FileId");

                    b.Property<string>("FirstName");

                    b.Property<Guid?>("LGAId");

                    b.Property<string>("LastName");

                    b.Property<string>("MiddleName");

                    b.Property<string>("Phone");

                    b.Property<string>("PostalAddress");

                    b.Property<int?>("StateId");

                    b.Property<string>("Website");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.HasIndex("CountryId");

                    b.HasIndex("LGAId");

                    b.HasIndex("StateId");

                    b.ToTable("AppUserProfiles");
                });

            modelBuilder.Entity("FMS.Core.Model.AppUserRole", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("NEWSEQUENTIALID()");

                    b.Property<string>("AppRoleId");

                    b.Property<string>("AppUserId");

                    b.HasKey("Id");

                    b.HasIndex("AppRoleId");

                    b.HasIndex("AppUserId");

                    b.ToTable("AppUserRoles");
                });

            modelBuilder.Entity("FMS.Core.Model.Bank", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("NEWSEQUENTIALID()");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Banks");
                });

            modelBuilder.Entity("FMS.Core.Model.BillPayable", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("NEWSEQUENTIALID()");

                    b.Property<decimal>("Amount");

                    b.Property<string>("BillNumber");

                    b.Property<string>("Description");

                    b.Property<string>("Economic");

                    b.Property<string>("Function");

                    b.Property<string>("Fund");

                    b.Property<string>("GeoCode");

                    b.Property<string>("Organisation");

                    b.Property<string>("PayerId");

                    b.Property<string>("Quantity");

                    b.Property<string>("Rate");

                    b.Property<int>("Status");

                    b.Property<string>("TransactionDate");

                    b.HasKey("Id");

                    b.ToTable("BillPayables");
                });

            modelBuilder.Entity("FMS.Core.Model.BillReceivable", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("NEWSEQUENTIALID()");

                    b.Property<decimal>("Amount");

                    b.Property<string>("BillNumber");

                    b.Property<string>("Description");

                    b.Property<string>("Economic");

                    b.Property<string>("Function");

                    b.Property<string>("Fund");

                    b.Property<string>("GeoCode");

                    b.Property<string>("Organisation");

                    b.Property<string>("PayeeId");

                    b.Property<string>("Quantity");

                    b.Property<string>("Rate");

                    b.Property<int>("Status");

                    b.Property<string>("TransactionDate");

                    b.HasKey("Id");

                    b.ToTable("BillReceivable");
                });

            modelBuilder.Entity("FMS.Core.Model.City", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.Property<int>("StateId");

                    b.HasKey("Id");

                    b.HasIndex("StateId");

                    b.ToTable("City");
                });

            modelBuilder.Entity("FMS.Core.Model.Country", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool?>("IsActive")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(true);

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.ToTable("Country");
                });

            modelBuilder.Entity("FMS.Core.Model.Journal", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("NEWSEQUENTIALID()");

                    b.Property<int>("Code");

                    b.Property<string>("Description");

                    b.Property<string>("Economic");

                    b.Property<string>("Fund");

                    b.Property<string>("TransactionDate");

                    b.HasKey("Id");

                    b.ToTable("Journal");
                });

            modelBuilder.Entity("FMS.Core.Model.JournalLineItem", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("NEWSEQUENTIALID()");

                    b.Property<decimal>("Amount");

                    b.Property<string>("Economic");

                    b.Property<string>("Fund");

                    b.Property<Guid?>("JournalId");

                    b.Property<int>("Type");

                    b.HasKey("Id");

                    b.HasIndex("JournalId");

                    b.ToTable("JournalLineItem");
                });

            modelBuilder.Entity("FMS.Core.Model.LGA", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("NEWSEQUENTIALID()");

                    b.Property<string>("Name");

                    b.Property<int?>("StateId");

                    b.HasKey("Id");

                    b.HasIndex("StateId");

                    b.ToTable("LGAs");
                });

            modelBuilder.Entity("FMS.Core.Model.PayableWorkFlow", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("NEWSEQUENTIALID()");

                    b.Property<Guid?>("BillPayableId");

                    b.Property<string>("Comment");

                    b.Property<DateTime?>("Date");

                    b.HasKey("Id");

                    b.HasIndex("BillPayableId");

                    b.ToTable("PayableWorkFlows");
                });

            modelBuilder.Entity("FMS.Core.Model.Payment", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("NEWSEQUENTIALID()");

                    b.Property<decimal>("Amount");

                    b.Property<Guid?>("BillPayableId");

                    b.Property<string>("Description");

                    b.Property<decimal>("OutstandingAmount");

                    b.Property<string>("TransactionDate");

                    b.HasKey("Id");

                    b.HasIndex("BillPayableId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("FMS.Core.Model.PublicHoliday", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CountryId");

                    b.Property<DateTime>("EndDate");

                    b.Property<string>("Name");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("PublicHoliday");
                });

            modelBuilder.Entity("FMS.Core.Model.Receipt", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("NEWSEQUENTIALID()");

                    b.Property<decimal>("Amount");

                    b.Property<Guid?>("BillPayableId");

                    b.Property<string>("Description");

                    b.Property<string>("TransactionDate");

                    b.HasKey("Id");

                    b.HasIndex("BillPayableId");

                    b.ToTable("Receipts");
                });

            modelBuilder.Entity("FMS.Core.Model.ReceivableWorkFlow", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("NEWSEQUENTIALID()");

                    b.Property<Guid?>("BillReceivableId");

                    b.Property<string>("Comment");

                    b.Property<DateTime?>("Date");

                    b.HasKey("Id");

                    b.HasIndex("BillReceivableId");

                    b.ToTable("ReceivableWorkFlows");
                });

            modelBuilder.Entity("FMS.Core.Model.Staff", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("NEWSEQUENTIALID()");

                    b.Property<string>("AppUserId");

                    b.Property<int>("Code");

                    b.Property<DateTime?>("DateOfCurrentAppoint");

                    b.Property<DateTime?>("DateOfFirstAppoint");

                    b.Property<string>("Department");

                    b.Property<string>("Division");

                    b.Property<string>("GradeLevel");

                    b.Property<string>("Notes");

                    b.Property<string>("Rank");

                    b.Property<string>("Section");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.ToTable("Staffs");
                });

            modelBuilder.Entity("FMS.Core.Model.State", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CountryId");

                    b.Property<string>("Name");

                    b.HasKey("Id");

                    b.HasIndex("CountryId");

                    b.ToTable("States");
                });

            modelBuilder.Entity("FMS.Core.Model.Supplier", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValueSql("NEWSEQUENTIALID()");

                    b.Property<string>("Address");

                    b.Property<string>("AppUserId");

                    b.Property<string>("City");

                    b.Property<string>("CompanyName");

                    b.Property<string>("ContactName");

                    b.Property<int?>("CountryId");

                    b.Property<string>("Email");

                    b.Property<string>("Fax");

                    b.Property<string>("Mobile");

                    b.Property<string>("Notes");

                    b.Property<string>("OfficePhone");

                    b.Property<int?>("StateId");

                    b.Property<string>("Website");

                    b.HasKey("Id");

                    b.HasIndex("AppUserId");

                    b.HasIndex("CountryId");

                    b.HasIndex("StateId");

                    b.ToTable("Suppliers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Discriminator")
                        .IsRequired();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");

                    b.HasDiscriminator<string>("Discriminator").HasValue("IdentityRole");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider");

                    b.Property<string>("ProviderKey");

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider");

                    b.Property<string>("Name");

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("FMS.Core.Model.AppRole", b =>
                {
                    b.HasBaseType("Microsoft.AspNetCore.Identity.IdentityRole");

                    b.Property<string>("Description");

                    b.ToTable("AppRole");

                    b.HasDiscriminator().HasValue("AppRole");
                });

            modelBuilder.Entity("FMS.Core.Model.AppUserBank", b =>
                {
                    b.HasOne("FMS.Core.Model.AppUser", "AppUser")
                        .WithMany()
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("FMS.Core.Model.Bank", "Bank")
                        .WithMany()
                        .HasForeignKey("BankId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("FMS.Core.Model.AppUserFile", b =>
                {
                    b.HasOne("FMS.Core.Model.AppUser", "AppUser")
                        .WithMany()
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("FMS.Core.Model.AppUserProfile", b =>
                {
                    b.HasOne("FMS.Core.Model.AppUser", "AppUser")
                        .WithMany()
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("FMS.Core.Model.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("FMS.Core.Model.LGA", "LGA")
                        .WithMany()
                        .HasForeignKey("LGAId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("FMS.Core.Model.State", "State")
                        .WithMany()
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("FMS.Core.Model.AppUserRole", b =>
                {
                    b.HasOne("FMS.Core.Model.AppRole", "AppRole")
                        .WithMany()
                        .HasForeignKey("AppRoleId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("FMS.Core.Model.AppUser", "AppUser")
                        .WithMany()
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("FMS.Core.Model.City", b =>
                {
                    b.HasOne("FMS.Core.Model.State", "State")
                        .WithMany("Cities")
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("FMS.Core.Model.JournalLineItem", b =>
                {
                    b.HasOne("FMS.Core.Model.Journal", "Journal")
                        .WithMany()
                        .HasForeignKey("JournalId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("FMS.Core.Model.LGA", b =>
                {
                    b.HasOne("FMS.Core.Model.State", "State")
                        .WithMany()
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("FMS.Core.Model.PayableWorkFlow", b =>
                {
                    b.HasOne("FMS.Core.Model.BillPayable", "BillPayable")
                        .WithMany()
                        .HasForeignKey("BillPayableId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("FMS.Core.Model.Payment", b =>
                {
                    b.HasOne("FMS.Core.Model.BillPayable", "BillPayable")
                        .WithMany()
                        .HasForeignKey("BillPayableId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("FMS.Core.Model.PublicHoliday", b =>
                {
                    b.HasOne("FMS.Core.Model.Country", "Country")
                        .WithMany("PublicHolidays")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("FMS.Core.Model.Receipt", b =>
                {
                    b.HasOne("FMS.Core.Model.BillReceivable", "BillPayable")
                        .WithMany()
                        .HasForeignKey("BillPayableId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("FMS.Core.Model.ReceivableWorkFlow", b =>
                {
                    b.HasOne("FMS.Core.Model.BillReceivable", "BillReceivable")
                        .WithMany()
                        .HasForeignKey("BillReceivableId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("FMS.Core.Model.Staff", b =>
                {
                    b.HasOne("FMS.Core.Model.AppUser", "AppUser")
                        .WithMany()
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("FMS.Core.Model.State", b =>
                {
                    b.HasOne("FMS.Core.Model.Country", "Country")
                        .WithMany("States")
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("FMS.Core.Model.Supplier", b =>
                {
                    b.HasOne("FMS.Core.Model.AppUser", "AppUser")
                        .WithMany()
                        .HasForeignKey("AppUserId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("FMS.Core.Model.Country", "Country")
                        .WithMany()
                        .HasForeignKey("CountryId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("FMS.Core.Model.State", "State")
                        .WithMany()
                        .HasForeignKey("StateId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("FMS.Core.Model.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("FMS.Core.Model.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("FMS.Core.Model.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("FMS.Core.Model.AppUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Restrict);
                });
#pragma warning restore 612, 618
        }
    }
}
