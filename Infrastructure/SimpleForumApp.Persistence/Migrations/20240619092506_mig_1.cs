﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace SimpleForumApp.Persistence.Migrations
{
    /// <inheritdoc />
    public partial class mig_1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Statuses",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Statuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<long>(type: "bigint", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Action",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusId = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Action", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Action_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AuthorType",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusId = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorType", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AuthorType_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Countries",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusId = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Countries", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Countries_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusId = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Genders_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Persons",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusId = table.Column<long>(type: "bigint", nullable: false),
                    GenderId = table.Column<long>(type: "bigint", nullable: false),
                    CountryId = table.Column<long>(type: "bigint", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DateOfBirth = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProfileImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Persons", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Persons_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Persons_Genders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Genders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Persons_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PersonId = table.Column<long>(type: "bigint", nullable: false),
                    RefreshToken = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RefreshTokenEndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUsers_Persons_PersonId",
                        column: x => x.PersonId,
                        principalTable: "Persons",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    RoleId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Group",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusId = table.Column<long>(type: "bigint", nullable: false),
                    OwnerUserId = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GroupImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BackgroundImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Group", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Group_AspNetUsers_OwnerUserId",
                        column: x => x.OwnerUserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Group_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Author",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusId = table.Column<long>(type: "bigint", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: true),
                    GroupId = table.Column<long>(type: "bigint", nullable: true),
                    AuthorTypeId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.Id);
                    table.CheckConstraint("CK_Author_UserId_GroupId", "([UserId] IS NOT NULL AND [GroupId] IS NULL) OR ([UserId] IS NULL AND [GroupId] IS NOT NULL)");
                    table.ForeignKey(
                        name: "FK_Author_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Author_AuthorType_AuthorTypeId",
                        column: x => x.AuthorTypeId,
                        principalTable: "AuthorType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Author_Group_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Group",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Author_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "GroupMember",
                columns: table => new
                {
                    GroupId = table.Column<long>(type: "bigint", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    StatusId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GroupMember", x => new { x.UserId, x.GroupId });
                    table.ForeignKey(
                        name: "FK_GroupMember_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GroupMember_Group_GroupId",
                        column: x => x.GroupId,
                        principalTable: "Group",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_GroupMember_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Title",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusId = table.Column<long>(type: "bigint", nullable: false),
                    AuthorId = table.Column<long>(type: "bigint", nullable: false),
                    Subject = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Title", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Title_Author_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Author",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Title_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Entry",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusId = table.Column<long>(type: "bigint", nullable: false),
                    TitleId = table.Column<long>(type: "bigint", nullable: false),
                    AuthorId = table.Column<long>(type: "bigint", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Entry", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Entry_Author_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Author",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Entry_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Entry_Title_TitleId",
                        column: x => x.TitleId,
                        principalTable: "Title",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "TitleAction",
                columns: table => new
                {
                    ActionId = table.Column<long>(type: "bigint", nullable: false),
                    TitleId = table.Column<long>(type: "bigint", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    StatusId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TitleAction", x => new { x.ActionId, x.TitleId, x.UserId });
                    table.ForeignKey(
                        name: "FK_TitleAction_Action_ActionId",
                        column: x => x.ActionId,
                        principalTable: "Action",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TitleAction_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TitleAction_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TitleAction_Title_TitleId",
                        column: x => x.TitleId,
                        principalTable: "Title",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "EntryAction",
                columns: table => new
                {
                    ActionId = table.Column<long>(type: "bigint", nullable: false),
                    EntryId = table.Column<long>(type: "bigint", nullable: false),
                    UserId = table.Column<long>(type: "bigint", nullable: false),
                    StatusId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DeletedDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntryAction", x => new { x.ActionId, x.EntryId, x.UserId });
                    table.ForeignKey(
                        name: "FK_EntryAction_Action_ActionId",
                        column: x => x.ActionId,
                        principalTable: "Action",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EntryAction_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EntryAction_Entry_EntryId",
                        column: x => x.EntryId,
                        principalTable: "Entry",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_EntryAction_Statuses_StatusId",
                        column: x => x.StatusId,
                        principalTable: "Statuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.InsertData(
                table: "Statuses",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "UpdatedDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(2024, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Aktif", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2L, new DateTime(2024, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pasif", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3L, new DateTime(2024, 4, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Silindi", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Action",
                columns: new[] { "Id", "Name", "StatusId" },
                values: new object[,]
                {
                    { 1L, "Sevdi", 1L },
                    { 2L, "Sevmedi", 1L }
                });

            migrationBuilder.InsertData(
                table: "AuthorType",
                columns: new[] { "Id", "CreatedDate", "DeletedDate", "Name", "StatusId", "UpdatedDate" },
                values: new object[,]
                {
                    { 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Kullanıcı", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Grup", 1L, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Countries",
                columns: new[] { "Id", "Name", "StatusId" },
                values: new object[,]
                {
                    { 1L, "Abhazya", 1L },
                    { 2L, "Afganistan", 1L },
                    { 3L, "Almanya", 1L },
                    { 4L, "Amerika Birleşik Devletleri", 1L },
                    { 5L, "Andorra", 1L },
                    { 6L, "Angola", 1L },
                    { 7L, "Antigua ve Barbuda", 1L },
                    { 8L, "Arjantin", 1L },
                    { 9L, "Arnavutluk", 1L },
                    { 10L, "Avusturalya", 1L },
                    { 11L, "Avusturya", 1L },
                    { 12L, "Azerbaycan", 1L },
                    { 13L, "Bahamalar", 1L },
                    { 14L, "Bahreyn", 1L },
                    { 15L, "Bangladeş", 1L },
                    { 16L, "Barbados", 1L },
                    { 17L, "Belçika", 1L },
                    { 18L, "Belize", 1L },
                    { 19L, "Benin", 1L },
                    { 20L, "Belarus", 1L },
                    { 21L, "Bhutan", 1L },
                    { 22L, "Birleşik Arap Emirlikleri", 1L },
                    { 23L, "Birleşik Krallık", 1L },
                    { 24L, "Bolivya", 1L },
                    { 25L, "Bosna-Hersek", 1L },
                    { 26L, "Botsvana", 1L },
                    { 27L, "Brezilya", 1L },
                    { 28L, "Brunei", 1L },
                    { 29L, "Bulgaristan", 1L },
                    { 30L, "Burkina Faso", 1L },
                    { 31L, "Burundi", 1L },
                    { 32L, "Cezayir", 1L },
                    { 33L, "Cibuti", 1L },
                    { 34L, "Çad", 1L },
                    { 35L, "Çekya", 1L },
                    { 36L, "Çin", 1L },
                    { 37L, "Danimarka", 1L },
                    { 38L, "Doğu Timor", 1L },
                    { 39L, "Dominik Cumhuriyeti", 1L },
                    { 40L, "Dominika", 1L },
                    { 41L, "Ekvador", 1L },
                    { 42L, "Ekvator Ginesi", 1L },
                    { 43L, "El Salvador", 1L },
                    { 44L, "Endonezya", 1L },
                    { 45L, "Eritre", 1L },
                    { 46L, "Ermenistan", 1L },
                    { 47L, "Estonya", 1L },
                    { 48L, "Esvatini", 1L },
                    { 49L, "Etiyopya", 1L },
                    { 50L, "Fas", 1L },
                    { 51L, "Fiji", 1L },
                    { 52L, "Fildişi Sahili", 1L },
                    { 53L, "Filipinler", 1L },
                    { 54L, "Filistin", 1L },
                    { 55L, "Finlandiya", 1L },
                    { 56L, "Fransa", 1L },
                    { 57L, "Gabon", 1L },
                    { 58L, "Gambiya", 1L },
                    { 59L, "Gana", 1L },
                    { 60L, "Gine", 1L },
                    { 61L, "Gine-Bissau", 1L },
                    { 62L, "Girenada", 1L },
                    { 63L, "Guyana", 1L },
                    { 64L, "Guatemala", 1L },
                    { 65L, "Güney Afrika Cumhuriyeti", 1L },
                    { 66L, "Güney Kıbrıs", 1L },
                    { 67L, "Güney Kore", 1L },
                    { 68L, "Güney Osetya", 1L },
                    { 69L, "Güney Sudan", 1L },
                    { 70L, "Gürcistan", 1L },
                    { 71L, "Haiti", 1L },
                    { 72L, "Hırvatistan", 1L },
                    { 73L, "Hindistan", 1L },
                    { 74L, "Hollanda", 1L },
                    { 75L, "Honduras", 1L },
                    { 76L, "Irak", 1L },
                    { 77L, "İran", 1L },
                    { 78L, "İrlanda", 1L },
                    { 79L, "İspanya", 1L },
                    { 80L, "İsrail", 1L },
                    { 81L, "İsveç", 1L },
                    { 82L, "İsviçre", 1L },
                    { 83L, "İtalya", 1L },
                    { 84L, "İzlanda", 1L },
                    { 85L, "Jamaika", 1L },
                    { 86L, "Japonya", 1L },
                    { 87L, "Kamboçya", 1L },
                    { 88L, "Kamerun", 1L },
                    { 89L, "Kanada", 1L },
                    { 90L, "Karadağ", 1L },
                    { 91L, "Katar", 1L },
                    { 92L, "Kazakistan", 1L },
                    { 93L, "Kenya", 1L },
                    { 94L, "Kırgızistan", 1L },
                    { 95L, "Kiribati", 1L },
                    { 96L, "Kolombiya", 1L },
                    { 97L, "Komorlar", 1L },
                    { 98L, "Kongo Cumhuriyeti", 1L },
                    { 99L, "Kongo DC", 1L },
                    { 100L, "Kosova", 1L },
                    { 101L, "Kosta Rika", 1L },
                    { 102L, "Kuveyt", 1L },
                    { 103L, "Kuzey Kıbrık Türk Cumhuriyeti", 1L },
                    { 104L, "Kuzey Kore", 1L },
                    { 105L, "Kuzey Makedonya", 1L },
                    { 106L, "Küba", 1L },
                    { 107L, "Laos", 1L },
                    { 108L, "Lesotho", 1L },
                    { 109L, "Letonya", 1L },
                    { 110L, "Liberya", 1L },
                    { 111L, "Libya", 1L },
                    { 112L, "Lihtenştayn", 1L },
                    { 113L, "Litvanya", 1L },
                    { 114L, "Lübnan", 1L },
                    { 115L, "Lüksemburg", 1L },
                    { 116L, "Maceristan", 1L },
                    { 117L, "Madagaskar", 1L },
                    { 118L, "Matavi", 1L },
                    { 119L, "Maldivler", 1L },
                    { 120L, "Malezya", 1L },
                    { 121L, "Mali", 1L },
                    { 122L, "Malta", 1L },
                    { 123L, "Marshall Adaları", 1L },
                    { 124L, "Mauritius", 1L },
                    { 125L, "Meksika", 1L },
                    { 126L, "Mısır", 1L },
                    { 127L, "Mikronezya Federal Devletleri", 1L },
                    { 128L, "Moğolistan", 1L },
                    { 129L, "Moldova", 1L },
                    { 130L, "Monako", 1L },
                    { 131L, "Moritanya", 1L },
                    { 132L, "Mozambik", 1L },
                    { 133L, "Myanmar", 1L },
                    { 134L, "Namibya", 1L },
                    { 135L, "Nauru", 1L },
                    { 136L, "Nepal", 1L },
                    { 137L, "Nikaragua", 1L },
                    { 138L, "Nijer", 1L },
                    { 139L, "Nijerya", 1L },
                    { 140L, "Norveç", 1L },
                    { 141L, "Orta Afrika Cumhuriyeti", 1L },
                    { 142L, "Özbekistan", 1L },
                    { 143L, "Pakistan", 1L },
                    { 144L, "Palau", 1L },
                    { 145L, "Panama", 1L },
                    { 146L, "Papua Yeni Gine", 1L },
                    { 147L, "Paraguay", 1L },
                    { 148L, "Peru", 1L },
                    { 149L, "Polonya", 1L },
                    { 150L, "Portekiz", 1L },
                    { 151L, "Romanya", 1L },
                    { 152L, "Ruanda", 1L },
                    { 153L, "Rusya", 1L },
                    { 154L, "Sahra Demokratik Arap Cumhuriyeti", 1L },
                    { 155L, "Saint Kitts ve Nevis", 1L },
                    { 156L, "Saint Lucia", 1L },
                    { 157L, "Saint Vincent ve Grenadinler", 1L },
                    { 158L, "Samoa", 1L },
                    { 159L, "San Marino", 1L },
                    { 160L, "São Tomé ve Príncipe", 1L },
                    { 161L, "Senegal", 1L },
                    { 162L, "Seyşeller", 1L },
                    { 163L, "Sırbistan", 1L },
                    { 164L, "Sierra Leone", 1L },
                    { 165L, "Singapur", 1L },
                    { 166L, "Slovakya", 1L },
                    { 167L, "Slovenya", 1L },
                    { 168L, "Solomon Adaları", 1L },
                    { 169L, "Somali", 1L },
                    { 170L, "Somaliland", 1L },
                    { 171L, "Sri Lanka", 1L },
                    { 172L, "Sudan", 1L },
                    { 173L, "Surinam", 1L },
                    { 174L, "Suriye", 1L },
                    { 175L, "Suudi Arabistan", 1L },
                    { 176L, "Şili", 1L },
                    { 177L, "Tacikistan", 1L },
                    { 178L, "Tanzanya", 1L },
                    { 179L, "Tayland", 1L },
                    { 180L, "Tayvan", 1L },
                    { 181L, "Togo", 1L },
                    { 182L, "Tonga", 1L },
                    { 183L, "Transdinyester", 1L },
                    { 184L, "Trinidad ve Tobago", 1L },
                    { 185L, "Tunus", 1L },
                    { 186L, "Türkiye", 1L },
                    { 187L, "Türkmenistan", 1L },
                    { 188L, "Türkmenistan", 1L },
                    { 189L, "Uganda", 1L },
                    { 190L, "Ukrayna", 1L },
                    { 191L, "Umman", 1L },
                    { 192L, "Uruguay", 1L },
                    { 193L, "Ürdün", 1L },
                    { 194L, "Vanuatu", 1L },
                    { 195L, "Vatikan", 1L },
                    { 196L, "Venezüela", 1L },
                    { 197L, "Vietnam", 1L },
                    { 198L, "Yemen", 1L },
                    { 199L, "Yeni Zelanda", 1L },
                    { 200L, "Yeşil Burun Adaları", 1L },
                    { 201L, "Yunanistan", 1L },
                    { 202L, "Zambiya", 1L },
                    { 203L, "Zimbabve", 1L }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "Name", "StatusId" },
                values: new object[,]
                {
                    { 1L, "Erkek", 1L },
                    { 2L, "Kadın", 1L },
                    { 3L, "Belirsiz", 1L },
                    { 4L, "Belirtmek İstemiyorum", 1L }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Action_StatusId",
                table: "Action",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUsers_PersonId",
                table: "AspNetUsers",
                column: "PersonId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Author_AuthorTypeId",
                table: "Author",
                column: "AuthorTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Author_GroupId",
                table: "Author",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Author_StatusId",
                table: "Author",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Author_UserId",
                table: "Author",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AuthorType_StatusId",
                table: "AuthorType",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Countries_StatusId",
                table: "Countries",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Entry_AuthorId",
                table: "Entry",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Entry_StatusId",
                table: "Entry",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Entry_TitleId",
                table: "Entry",
                column: "TitleId");

            migrationBuilder.CreateIndex(
                name: "IX_EntryAction_EntryId",
                table: "EntryAction",
                column: "EntryId");

            migrationBuilder.CreateIndex(
                name: "IX_EntryAction_StatusId",
                table: "EntryAction",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_EntryAction_UserId",
                table: "EntryAction",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Genders_StatusId",
                table: "Genders",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Group_OwnerUserId",
                table: "Group",
                column: "OwnerUserId");

            migrationBuilder.CreateIndex(
                name: "IX_Group_StatusId",
                table: "Group",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupMember_GroupId",
                table: "GroupMember",
                column: "GroupId");

            migrationBuilder.CreateIndex(
                name: "IX_GroupMember_StatusId",
                table: "GroupMember",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_CountryId",
                table: "Persons",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_GenderId",
                table: "Persons",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Persons_StatusId",
                table: "Persons",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Title_AuthorId",
                table: "Title",
                column: "AuthorId");

            migrationBuilder.CreateIndex(
                name: "IX_Title_StatusId",
                table: "Title",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_TitleAction_StatusId",
                table: "TitleAction",
                column: "StatusId");

            migrationBuilder.CreateIndex(
                name: "IX_TitleAction_TitleId",
                table: "TitleAction",
                column: "TitleId");

            migrationBuilder.CreateIndex(
                name: "IX_TitleAction_UserId",
                table: "TitleAction",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "EntryAction");

            migrationBuilder.DropTable(
                name: "GroupMember");

            migrationBuilder.DropTable(
                name: "TitleAction");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "Entry");

            migrationBuilder.DropTable(
                name: "Action");

            migrationBuilder.DropTable(
                name: "Title");

            migrationBuilder.DropTable(
                name: "Author");

            migrationBuilder.DropTable(
                name: "AuthorType");

            migrationBuilder.DropTable(
                name: "Group");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Persons");

            migrationBuilder.DropTable(
                name: "Countries");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropTable(
                name: "Statuses");
        }
    }
}
