﻿// <auto-generated />
using System;
using AsriATS.Persistance;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace AsriATS.Persistance.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("AsriATS.Domain.Entities.AppRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("AsriATS.Domain.Entities.AppUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("integer");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("CompanyId")
                        .HasColumnType("integer");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("text");

                    b.Property<DateOnly>("Dob")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("boolean");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("text");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("boolean");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("text");

                    b.Property<string>("Sex")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("boolean");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("character varying(256)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("AsriATS.Domain.Entities.Company", b =>
                {
                    b.Property<int>("CompanyId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CompanyId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("CompanyId");

                    b.ToTable("Companys");
                });

            modelBuilder.Entity("AsriATS.Domain.Entities.NextStepRule", b =>
                {
                    b.Property<int>("RuleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("RuleId"));

                    b.Property<string>("ConditionType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("ConditionValue")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("CurrentStepId")
                        .HasColumnType("integer");

                    b.Property<int>("NextStepId")
                        .HasColumnType("integer");

                    b.HasKey("RuleId");

                    b.HasIndex("CurrentStepId");

                    b.HasIndex("NextStepId");

                    b.ToTable("NextStepsRules");
                });

            modelBuilder.Entity("AsriATS.Domain.Entities.Process", b =>
                {
                    b.Property<int>("ProcessId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ProcessId"));

                    b.Property<int>("CurrentStepId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("RequestDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<int>("RequestId")
                        .HasColumnType("integer");

                    b.Property<string>("RequestType")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RequesterId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("WorkflowId")
                        .HasColumnType("integer");

                    b.HasKey("ProcessId");

                    b.HasIndex("CurrentStepId");

                    b.HasIndex("RequestId")
                        .IsUnique();

                    b.HasIndex("RequesterId");

                    b.HasIndex("WorkflowId");

                    b.ToTable("Processes");
                });

            modelBuilder.Entity("AsriATS.Domain.Entities.Request", b =>
                {
                    b.Property<int>("RequestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("RequestId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime?>("EndDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ProcessName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("StartDate")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("RequestId");

                    b.ToTable("Requests");
                });

            modelBuilder.Entity("AsriATS.Domain.Entities.Workflow", b =>
                {
                    b.Property<int>("WorkflowId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("WorkflowId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("WorkflowName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("WorkflowId");

                    b.ToTable("Workflows");
                });

            modelBuilder.Entity("AsriATS.Domain.Entities.WorkflowAction", b =>
                {
                    b.Property<int>("ActionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ActionId"));

                    b.Property<string>("Action")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateTime>("ActionDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("ActorId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Comments")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("ProcessId")
                        .HasColumnType("integer");

                    b.Property<int>("StepId")
                        .HasColumnType("integer");

                    b.HasKey("ActionId");

                    b.HasIndex("ActorId");

                    b.HasIndex("ProcessId");

                    b.HasIndex("StepId");

                    b.ToTable("WorkflowActions");
                });

            modelBuilder.Entity("AsriATS.Domain.Entities.WorkflowSequence", b =>
                {
                    b.Property<int>("StepId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("StepId"));

                    b.Property<string>("RequiredRole")
                        .HasColumnType("text");

                    b.Property<string>("StepName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("StepOrder")
                        .HasColumnType("integer");

                    b.Property<int>("WorkflowId")
                        .HasColumnType("integer");

                    b.HasKey("StepId");

                    b.HasIndex("RequiredRole")
                        .IsUnique();

                    b.HasIndex("WorkflowId");

                    b.ToTable("WorkflowSequences");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("text");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("text");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("text");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("RoleId")
                        .HasColumnType("text");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("text");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("text");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.Property<string>("Value")
                        .HasColumnType("text");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("AsriATS.Domain.Entities.AppUser", b =>
                {
                    b.HasOne("AsriATS.Domain.Entities.Company", "CompanyIdNavigation")
                        .WithMany("AppUsers")
                        .HasForeignKey("CompanyId");

                    b.Navigation("CompanyIdNavigation");
                });

            modelBuilder.Entity("AsriATS.Domain.Entities.NextStepRule", b =>
                {
                    b.HasOne("AsriATS.Domain.Entities.WorkflowSequence", "CurrentStep")
                        .WithMany()
                        .HasForeignKey("CurrentStepId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("next_step_rule_id_currentstep_fkey");

                    b.HasOne("AsriATS.Domain.Entities.WorkflowSequence", "NextStep")
                        .WithMany()
                        .HasForeignKey("NextStepId")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired()
                        .HasConstraintName("next_step_rule_id_nextstep_fkey");

                    b.Navigation("CurrentStep");

                    b.Navigation("NextStep");
                });

            modelBuilder.Entity("AsriATS.Domain.Entities.Process", b =>
                {
                    b.HasOne("AsriATS.Domain.Entities.WorkflowSequence", "WorkflowSequence")
                        .WithMany()
                        .HasForeignKey("CurrentStepId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AsriATS.Domain.Entities.Request", "Request")
                        .WithOne("Process")
                        .HasForeignKey("AsriATS.Domain.Entities.Process", "RequestId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Process_Request");

                    b.HasOne("AsriATS.Domain.Entities.AppUser", "Requester")
                        .WithMany("Processes")
                        .HasForeignKey("RequesterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Process_Requester");

                    b.HasOne("AsriATS.Domain.Entities.Workflow", "Workflow")
                        .WithMany("Processes")
                        .HasForeignKey("WorkflowId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_Process_Workflow");

                    b.Navigation("Request");

                    b.Navigation("Requester");

                    b.Navigation("Workflow");

                    b.Navigation("WorkflowSequence");
                });

            modelBuilder.Entity("AsriATS.Domain.Entities.WorkflowAction", b =>
                {
                    b.HasOne("AsriATS.Domain.Entities.AppUser", "Actor")
                        .WithMany("WorkflowActions")
                        .HasForeignKey("ActorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("FK_WorkflowAction_User");

                    b.HasOne("AsriATS.Domain.Entities.Process", "Process")
                        .WithMany("WorkflowActions")
                        .HasForeignKey("ProcessId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("workflow_action_id_request_fkey");

                    b.HasOne("AsriATS.Domain.Entities.WorkflowSequence", "WorkflowSequence")
                        .WithMany()
                        .HasForeignKey("StepId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Actor");

                    b.Navigation("Process");

                    b.Navigation("WorkflowSequence");
                });

            modelBuilder.Entity("AsriATS.Domain.Entities.WorkflowSequence", b =>
                {
                    b.HasOne("AsriATS.Domain.Entities.AppRole", "Role")
                        .WithOne()
                        .HasForeignKey("AsriATS.Domain.Entities.WorkflowSequence", "RequiredRole")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AsriATS.Domain.Entities.Workflow", "Workflow")
                        .WithMany("WorkflowSequences")
                        .HasForeignKey("WorkflowId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired()
                        .HasConstraintName("workflow_sequence_id_workflow_fkey");

                    b.Navigation("Role");

                    b.Navigation("Workflow");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("AsriATS.Domain.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("AsriATS.Domain.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("AsriATS.Domain.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("AsriATS.Domain.Entities.AppRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("AsriATS.Domain.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("AsriATS.Domain.Entities.AppUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("AsriATS.Domain.Entities.AppUser", b =>
                {
                    b.Navigation("Processes");

                    b.Navigation("WorkflowActions");
                });

            modelBuilder.Entity("AsriATS.Domain.Entities.Company", b =>
                {
                    b.Navigation("AppUsers");
                });

            modelBuilder.Entity("AsriATS.Domain.Entities.Process", b =>
                {
                    b.Navigation("WorkflowActions");
                });

            modelBuilder.Entity("AsriATS.Domain.Entities.Request", b =>
                {
                    b.Navigation("Process")
                        .IsRequired();
                });

            modelBuilder.Entity("AsriATS.Domain.Entities.Workflow", b =>
                {
                    b.Navigation("Processes");

                    b.Navigation("WorkflowSequences");
                });
#pragma warning restore 612, 618
        }
    }
}
