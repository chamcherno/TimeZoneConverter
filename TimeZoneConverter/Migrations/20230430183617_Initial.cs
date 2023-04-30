using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace TimeZoneConverter.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AgeGroups",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    AgeGroup = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: false),
                    IncludeInAverage = table.Column<bool>(type: "bit", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    IsRenameable = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserRoleId = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    OrganisationId = table.Column<long>(type: "bigint", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEndDateUtc = table.Column<DateTime>(type: "datetime", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false),
                    Gender = table.Column<bool>(type: "bit", nullable: true),
                    DOB = table.Column<DateTime>(type: "datetime", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    OldPasswordHash = table.Column<string>(type: "nvarchar(32)", maxLength: 32, nullable: true),
                    TimesLoggedIn = table.Column<int>(type: "int", nullable: false),
                    LastActive = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    AllowQuickUpdating = table.Column<bool>(type: "bit", nullable: false),
                    OtherNames = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ProfileImageURL = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    LastViewedNotifications = table.Column<DateTime>(type: "datetime", nullable: true),
                    CurrentConnectionId = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    PasswordPrompt = table.Column<bool>(type: "bit", nullable: false),
                    AllowStudentCreation = table.Column<bool>(type: "bit", nullable: false),
                    EnableNotifications = table.Column<bool>(type: "bit", nullable: false),
                    EnableTimeout = table.Column<bool>(type: "bit", nullable: false),
                    IsAppAuthenticationEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AppAuthenticationKey = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ResetPasswordDueDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    EnableMfaDueDate = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsersPending",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    OrganisationId = table.Column<long>(type: "bigint", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<bool>(type: "bit", nullable: true),
                    DOB = table.Column<DateTime>(type: "datetime", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: false),
                    OtherNames = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    ProfileImageURL = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ProfileImageURLSmall = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    GroupId = table.Column<long>(type: "bigint", nullable: true),
                    RequestId = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "AssessmentComments",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    AssessmentId = table.Column<long>(type: "bigint", nullable: false),
                    WheelId = table.Column<long>(type: "bigint", nullable: true),
                    UserAssessedId = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    GroupAssessedId = table.Column<long>(type: "bigint", nullable: true),
                    AssessorId = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    Locked = table.Column<bool>(type: "bit", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Assessments",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    AssessorId = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Locked = table.Column<bool>(type: "bit", nullable: false),
                    UserAssessedId = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    GroupAssessedId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: false),
                    Collation = table.Column<int>(type: "int", nullable: false),
                    AssessmentTypeId = table.Column<long>(type: "bigint", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    OldAssessmentId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "AssessmentTypes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "AttachmentTypes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    attachmentType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "BlockEvidence",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    BlockId = table.Column<long>(type: "bigint", nullable: true),
                    WheelId = table.Column<long>(type: "bigint", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    OrganisationId = table.Column<long>(type: "bigint", nullable: true),
                    Statement = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    OldBlockEvidenceId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "BlockEvidenceAttachment",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    EvidenceId = table.Column<long>(type: "bigint", nullable: true),
                    Attachment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AttachmentTypeId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    WebPathRelative = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    AttachmentName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    OldBlockEvidenceAttachmentId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "BlockExampleAttachmentGroups",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    BlockExampleAttachmentId = table.Column<long>(type: "bigint", nullable: false),
                    GroupId = table.Column<long>(type: "bigint", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "BlockExampleAttachments",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    BlockExampleID = table.Column<long>(type: "bigint", nullable: false),
                    Attachment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AttachmentType = table.Column<long>(type: "bigint", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime", nullable: false),
                    WebPath = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    AttachmentName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    OldBlockExampleId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "BlockExamples",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    BlockId = table.Column<long>(type: "bigint", nullable: true),
                    WheelId = table.Column<long>(type: "bigint", nullable: true),
                    OrgId = table.Column<long>(type: "bigint", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime", nullable: false),
                    LevelInfo = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    OldBlockExampleID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "BlockLevelInfo",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    BlockId = table.Column<long>(type: "bigint", nullable: false),
                    WheelId = table.Column<long>(type: "bigint", nullable: false),
                    OrgId = table.Column<long>(type: "bigint", nullable: false),
                    LevelInfo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "BlockLevelInfoGroups",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    BlockLevelInfoId = table.Column<long>(type: "bigint", nullable: true),
                    GroupId = table.Column<long>(type: "bigint", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "BlockOptionEvidence",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    BlockOptionId = table.Column<long>(type: "bigint", nullable: true),
                    BlockId = table.Column<long>(type: "bigint", nullable: true),
                    WheelId = table.Column<long>(type: "bigint", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    OrganisationId = table.Column<long>(type: "bigint", nullable: true),
                    Complete = table.Column<bool>(type: "bit", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    AssessmentId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "BlockScores",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    Scorable = table.Column<bool>(type: "bit", nullable: false),
                    ColourHex = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CategoriesForOrganisations",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "CategoriesForWheels",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    CategoryName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "DatesOfInterest",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    GroupId = table.Column<long>(type: "bigint", nullable: true),
                    DateOfInterest = table.Column<DateTime>(type: "datetime", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "DefinedBlocks",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    SubSectorId = table.Column<long>(type: "bigint", nullable: false),
                    Label = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    AgeGroupId = table.Column<long>(type: "bigint", nullable: true),
                    Body = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    Position = table.Column<short>(type: "smallint", nullable: true),
                    LevelInfo = table.Column<string>(type: "varchar(max)", unicode: false, nullable: true),
                    OldBlockId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "DefinedBlocksAttachments",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    WheelBlockId = table.Column<long>(type: "bigint", nullable: false),
                    Attachment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AttatchmentTypeId = table.Column<long>(type: "bigint", nullable: false),
                    WebPathRelative = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    AttachmentPosition = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    AttachmentName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    OldBlockAttachmentId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "DefinedBlocksOptions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    WheelBlockId = table.Column<long>(type: "bigint", nullable: false),
                    StatementOption = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    Position = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "DefinedSectors",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    WheelId = table.Column<long>(type: "bigint", nullable: false),
                    SectorPosition = table.Column<long>(type: "bigint", nullable: true),
                    SectorLabel = table.Column<string>(type: "nvarchar(175)", maxLength: 175, nullable: true),
                    SectorColour = table.Column<long>(type: "bigint", nullable: false),
                    OldSectorId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "DefinedSubSectors",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    SectorId = table.Column<long>(type: "bigint", nullable: false),
                    Label = table.Column<string>(type: "varchar(175)", unicode: false, maxLength: 175, nullable: true),
                    Position = table.Column<long>(type: "bigint", nullable: true),
                    Colour = table.Column<long>(type: "bigint", nullable: true),
                    OldSubSectorId = table.Column<string>(type: "char(10)", unicode: false, fixedLength: true, maxLength: 10, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "DefinedWheels",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(1000)", maxLength: 1000, nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: true),
                    CreatedBy = table.Column<string>(type: "varchar(128)", unicode: false, maxLength: 128, nullable: true),
                    LastEdited = table.Column<DateTime>(type: "datetime", nullable: false),
                    LogoFileName = table.Column<string>(type: "varchar(255)", unicode: false, maxLength: 255, nullable: true),
                    StartingLevel = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    OldWheelId = table.Column<long>(type: "bigint", nullable: true),
                    IsJasmine = table.Column<bool>(type: "bit", nullable: false),
                    DescriptionHTML = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "DefinedWheelStageIndicator",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    WheelId = table.Column<long>(type: "bigint", nullable: false),
                    StageLevel = table.Column<int>(type: "int", nullable: false),
                    TooltipTitle = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ToolTipText = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "DemoExpiryNotifications",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    OrganisationId = table.Column<long>(type: "bigint", nullable: false),
                    StatusId = table.Column<int>(type: "int", nullable: true),
                    DateUpdated = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "DemoExpiryNotificationStatus",
                columns: table => new
                {
                    StatusId = table.Column<int>(type: "int", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "DemoSignups",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AdminName = table.Column<string>(type: "varchar(258)", unicode: false, maxLength: 258, nullable: false),
                    AdminEmail = table.Column<string>(type: "varchar(258)", unicode: false, maxLength: 258, nullable: false),
                    AdminPhone = table.Column<string>(type: "varchar(258)", unicode: false, maxLength: 258, nullable: true),
                    OrganisationName = table.Column<string>(type: "varchar(258)", unicode: false, maxLength: 258, nullable: false),
                    County = table.Column<string>(type: "varchar(258)", unicode: false, maxLength: 258, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ExistingBlockStates",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    OrganisationId = table.Column<long>(type: "bigint", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    WheelId = table.Column<long>(type: "bigint", nullable: false),
                    BlockId = table.Column<long>(type: "bigint", nullable: false),
                    BlockScore = table.Column<long>(type: "bigint", nullable: true),
                    OldBlockStateId = table.Column<long>(type: "bigint", nullable: true),
                    DateCreated = table.Column<DateTime>(type: "datetime", nullable: true),
                    DateUpdated = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Font",
                columns: table => new
                {
                    Font_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FontFamilyName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FontUrl = table.Column<string>(type: "nvarchar(250)", maxLength: 250, nullable: false),
                    FontFormat = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "GlobalCentralFiles",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    WebPath = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    AttachmentType = table.Column<long>(type: "bigint", nullable: false),
                    AttachmentName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Attachment = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: false),
                    AttachmentPosition = table.Column<int>(type: "int", nullable: false),
                    WheelId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "GroupMembers",
                columns: table => new
                {
                    GroupMemberId = table.Column<long>(type: "bigint", nullable: false),
                    GroupId = table.Column<long>(type: "bigint", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Groups",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    OrganisationId = table.Column<long>(type: "bigint", nullable: true),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: false),
                    GlobalGroup = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    OldGroupId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "HistoricalBlockStates",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    OrganisationId = table.Column<long>(type: "bigint", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    WheelId = table.Column<long>(type: "bigint", nullable: false),
                    BlockId = table.Column<long>(type: "bigint", nullable: false),
                    BlockScore = table.Column<long>(type: "bigint", nullable: true),
                    AssessmentId = table.Column<long>(type: "bigint", nullable: false),
                    DateCreated = table.Column<DateTime>(type: "datetime", nullable: true),
                    OldBlockStateId = table.Column<long>(type: "bigint", nullable: true),
                    DateUpdated = table.Column<DateTime>(type: "datetime", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "LockedUsers",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    WheelId = table.Column<long>(type: "bigint", nullable: false),
                    Locked = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Notes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    GroupId = table.Column<long>(type: "bigint", nullable: true),
                    OrganisationId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    WheelId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Notifications",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    SenderId = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    RecieverId = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    GroupRecieverId = table.Column<long>(type: "bigint", nullable: true),
                    TypeId = table.Column<long>(type: "bigint", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    SoftRead = table.Column<bool>(type: "bit", nullable: false),
                    IsRead = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: true),
                    Link = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "NotificationTemplates",
                columns: table => new
                {
                    NotificationTemplate_Id = table.Column<long>(type: "bigint", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrganisationId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    SortOrder = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "NotificationTypes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    FontAwesomeClassName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OrganisationCategories",
                columns: table => new
                {
                    OrganisationCategoryId = table.Column<long>(type: "bigint", nullable: false),
                    OrganisationId = table.Column<long>(type: "bigint", nullable: false),
                    CategoryId = table.Column<long>(type: "bigint", nullable: false),
                    SubCategoryId = table.Column<long>(type: "bigint", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OrganisationCentralFiles",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    OrganisationId = table.Column<long>(type: "bigint", nullable: false),
                    WebPath = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    AttachmentType = table.Column<long>(type: "bigint", nullable: false),
                    AttachmentName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Attachment = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OrganisationLogos",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    OrganisationId = table.Column<long>(type: "bigint", nullable: false),
                    Logo = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    AttachmentTypeId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OrganisationPredefinedMessages",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    OrganisationId = table.Column<long>(type: "bigint", nullable: false),
                    Message = table.Column<string>(type: "nvarchar(4000)", maxLength: 4000, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OrganisationProfilePictures",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    OrganisationId = table.Column<long>(type: "bigint", nullable: false),
                    IsSmall = table.Column<bool>(type: "bit", nullable: false),
                    LinkToImage = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Organisations",
                columns: table => new
                {
                    OrganisationId = table.Column<long>(type: "bigint", nullable: false),
                    URN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    Contact = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    PhoneContact = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    OnHold = table.Column<bool>(type: "bit", nullable: false),
                    ScoreType = table.Column<long>(type: "bigint", nullable: false),
                    ScoreShowStudent = table.Column<bool>(type: "bit", nullable: false),
                    CompleteColour = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: true),
                    TargetColour = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: true),
                    PartialColour = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: true),
                    LastOnline = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsDemo = table.Column<bool>(type: "bit", nullable: false),
                    DemoExpiry = table.Column<DateTime>(type: "datetime", nullable: true),
                    DomainURL = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Font_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ThemeColour = table.Column<string>(type: "nvarchar(7)", maxLength: 7, nullable: true),
                    Theme_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IsJasmine = table.Column<bool>(type: "bit", nullable: false),
                    OldOrgURN = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Information = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsPrimary = table.Column<bool>(type: "bit", nullable: false),
                    DemoExpired = table.Column<bool>(type: "bit", nullable: true),
                    BulkImportId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    PostCode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    SupportEnabled = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OrganisationWheelDescriptionGroups",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    WheelDescriptionId = table.Column<long>(type: "bigint", nullable: false),
                    GroupId = table.Column<long>(type: "bigint", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OrganisationWheelDescriptions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    WheelId = table.Column<long>(type: "bigint", nullable: false),
                    OrganisationId = table.Column<long>(type: "bigint", nullable: false),
                    DescriptionHTML = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OrgAssessmentAliases",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    OrganisationId = table.Column<long>(type: "bigint", nullable: false),
                    WheelId = table.Column<long>(type: "bigint", nullable: true),
                    NewAssessmentAlias = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OrgGroupAliases",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    OrganisationId = table.Column<long>(type: "bigint", nullable: false),
                    WheelId = table.Column<long>(type: "bigint", nullable: true),
                    NewGroupAlias = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OrgLevelAliases",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    OrganisationId = table.Column<long>(type: "bigint", nullable: false),
                    WheelId = table.Column<long>(type: "bigint", nullable: true),
                    NewLevelAlias = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OrgProgressionAliases",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    OrganisationId = table.Column<long>(type: "bigint", nullable: false),
                    WheelId = table.Column<long>(type: "bigint", nullable: true),
                    CompletedAlias = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PartialAlias = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TargetAlias = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OrgRoleAliases",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: true),
                    NewAlias = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    OrganisationId = table.Column<long>(type: "bigint", nullable: true),
                    WheelId = table.Column<long>(type: "bigint", nullable: true),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "OrgWheelAliases",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    OrganisationId = table.Column<long>(type: "bigint", nullable: false),
                    WheelId = table.Column<long>(type: "bigint", nullable: true),
                    NewWheelAlias = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "S3Queue",
                columns: table => new
                {
                    S3QueueId = table.Column<long>(type: "bigint", nullable: false),
                    ImportId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrganisationId = table.Column<long>(type: "bigint", nullable: false),
                    BucketName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    FilePath = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    FilePathAlt = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    AwsKey = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: false),
                    WheelId = table.Column<long>(type: "bigint", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: true),
                    OldBlockAttachmentId = table.Column<long>(type: "bigint", nullable: true),
                    OldEvidenceId = table.Column<long>(type: "bigint", nullable: true),
                    OldExampleId = table.Column<long>(type: "bigint", nullable: true),
                    OldCentralExampleId = table.Column<long>(type: "bigint", nullable: true),
                    OldCentralEvidenceId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "S3TempFileParents",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "S3TempFiles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ParentID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    S3Path = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "ScoreTypes",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    ScoreType = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SiteErrorLogs",
                columns: table => new
                {
                    ID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DateRecorded = table.Column<DateTime>(type: "datetime", nullable: true),
                    stackTrace = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    message = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    targetSite = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    type = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    innerExceptionMessage = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    innerExceptionStackTrace = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    innerExceptionType = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    origin = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    userhostip = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    statuscode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    userid = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    useragent = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    httpmethod = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    contenttype = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SubCategoriesForOrganisations",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    CategoryId = table.Column<long>(type: "bigint", nullable: false),
                    SubCategoryName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "SubCategoriesForWheels",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    CategoryId = table.Column<long>(type: "bigint", nullable: false),
                    SubCategoryName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "Theme",
                columns: table => new
                {
                    Theme_Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ThemeName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "UserConnections",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    ConnectionId = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "UserGroups",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Name = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: false),
                    OrganisationId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "UserLocation",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(900)", maxLength: 900, nullable: false),
                    Coordinates = table.Column<string>(type: "nvarchar(60)", maxLength: 60, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "UserProfilePictures",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    IsSmall = table.Column<bool>(type: "bit", nullable: false),
                    LinkToImage = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "UserWheelLevelExclusions",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    WheelId = table.Column<long>(type: "bigint", nullable: true),
                    WheelLevel = table.Column<int>(type: "int", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "WheelAssessments",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    AssessmentId = table.Column<long>(type: "bigint", nullable: false),
                    WheelId = table.Column<long>(type: "bigint", nullable: false),
                    UpdaterUserId = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateAnyBlock = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "WheelAssessmentsCurrent",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    WheelId = table.Column<long>(type: "bigint", nullable: false),
                    UpdaterUserId = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdateAnyBlock = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "WheelCategories",
                columns: table => new
                {
                    WheelCategoryId = table.Column<long>(type: "bigint", nullable: false),
                    CategoryId = table.Column<long>(type: "bigint", nullable: false),
                    WheelId = table.Column<long>(type: "bigint", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    SubCategoryId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "WheelExcelExports",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    PersonId = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    S3ParentFolderGUID = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    S3Link = table.Column<string>(type: "nvarchar(1024)", maxLength: 1024, nullable: false),
                    IsValid = table.Column<bool>(type: "bit", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "WheelGroupCompletionEvents",
                columns: table => new
                {
                    GroupCompletionEventId = table.Column<long>(type: "bigint", nullable: false),
                    WheelId = table.Column<long>(type: "bigint", nullable: true),
                    GroupId = table.Column<long>(type: "bigint", nullable: true),
                    CompletionDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Message = table.Column<string>(type: "nvarchar(2000)", maxLength: 2000, nullable: true),
                    File = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "WheelGroups",
                columns: table => new
                {
                    WheelGroupId = table.Column<long>(type: "bigint", nullable: false),
                    GroupId = table.Column<long>(type: "bigint", nullable: false),
                    WheelId = table.Column<long>(type: "bigint", nullable: false),
                    Locked = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "WheelOrganisations",
                columns: table => new
                {
                    WheelOrganisationId = table.Column<long>(type: "bigint", nullable: false),
                    WheelId = table.Column<long>(type: "bigint", nullable: false),
                    OrganisationId = table.Column<long>(type: "bigint", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "WheelOrgEvidenceCentralFiles",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    WheelId = table.Column<long>(type: "bigint", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(128)", maxLength: 128, nullable: false),
                    AttachmentType = table.Column<long>(type: "bigint", nullable: false),
                    AttachmentName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Attachment = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    WebPath = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    OldBlockEvidenceAttachmentId = table.Column<long>(type: "bigint", nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "WheelOrgExampleCentralFileGroups",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    WheelOrgExampleCentralFilesId = table.Column<long>(type: "bigint", nullable: false),
                    GroupId = table.Column<long>(type: "bigint", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: false),
                    UpdatedOn = table.Column<DateTime>(type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                });

            migrationBuilder.CreateTable(
                name: "WheelOrgExampleCentralFiles",
                columns: table => new
                {
                    Id = table.Column<long>(type: "bigint", nullable: false),
                    OrganisationId = table.Column<long>(type: "bigint", nullable: false),
                    WheelId = table.Column<long>(type: "bigint", nullable: false),
                    WebPath = table.Column<string>(type: "nvarchar(500)", maxLength: 500, nullable: true),
                    AttachmentType = table.Column<long>(type: "bigint", nullable: false),
                    AttachmentName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    Attachment = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedOn = table.Column<DateTime>(type: "datetime", nullable: false),
                    OldBlockExampleAttachmentId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AgeGroups");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "AspNetUsersPending");

            migrationBuilder.DropTable(
                name: "AssessmentComments");

            migrationBuilder.DropTable(
                name: "Assessments");

            migrationBuilder.DropTable(
                name: "AssessmentTypes");

            migrationBuilder.DropTable(
                name: "AttachmentTypes");

            migrationBuilder.DropTable(
                name: "BlockEvidence");

            migrationBuilder.DropTable(
                name: "BlockEvidenceAttachment");

            migrationBuilder.DropTable(
                name: "BlockExampleAttachmentGroups");

            migrationBuilder.DropTable(
                name: "BlockExampleAttachments");

            migrationBuilder.DropTable(
                name: "BlockExamples");

            migrationBuilder.DropTable(
                name: "BlockLevelInfo");

            migrationBuilder.DropTable(
                name: "BlockLevelInfoGroups");

            migrationBuilder.DropTable(
                name: "BlockOptionEvidence");

            migrationBuilder.DropTable(
                name: "BlockScores");

            migrationBuilder.DropTable(
                name: "CategoriesForOrganisations");

            migrationBuilder.DropTable(
                name: "CategoriesForWheels");

            migrationBuilder.DropTable(
                name: "DatesOfInterest");

            migrationBuilder.DropTable(
                name: "DefinedBlocks");

            migrationBuilder.DropTable(
                name: "DefinedBlocksAttachments");

            migrationBuilder.DropTable(
                name: "DefinedBlocksOptions");

            migrationBuilder.DropTable(
                name: "DefinedSectors");

            migrationBuilder.DropTable(
                name: "DefinedSubSectors");

            migrationBuilder.DropTable(
                name: "DefinedWheels");

            migrationBuilder.DropTable(
                name: "DefinedWheelStageIndicator");

            migrationBuilder.DropTable(
                name: "DemoExpiryNotifications");

            migrationBuilder.DropTable(
                name: "DemoExpiryNotificationStatus");

            migrationBuilder.DropTable(
                name: "DemoSignups");

            migrationBuilder.DropTable(
                name: "ExistingBlockStates");

            migrationBuilder.DropTable(
                name: "Font");

            migrationBuilder.DropTable(
                name: "GlobalCentralFiles");

            migrationBuilder.DropTable(
                name: "GroupMembers");

            migrationBuilder.DropTable(
                name: "Groups");

            migrationBuilder.DropTable(
                name: "HistoricalBlockStates");

            migrationBuilder.DropTable(
                name: "LockedUsers");

            migrationBuilder.DropTable(
                name: "Notes");

            migrationBuilder.DropTable(
                name: "Notifications");

            migrationBuilder.DropTable(
                name: "NotificationTemplates");

            migrationBuilder.DropTable(
                name: "NotificationTypes");

            migrationBuilder.DropTable(
                name: "OrganisationCategories");

            migrationBuilder.DropTable(
                name: "OrganisationCentralFiles");

            migrationBuilder.DropTable(
                name: "OrganisationLogos");

            migrationBuilder.DropTable(
                name: "OrganisationPredefinedMessages");

            migrationBuilder.DropTable(
                name: "OrganisationProfilePictures");

            migrationBuilder.DropTable(
                name: "Organisations");

            migrationBuilder.DropTable(
                name: "OrganisationWheelDescriptionGroups");

            migrationBuilder.DropTable(
                name: "OrganisationWheelDescriptions");

            migrationBuilder.DropTable(
                name: "OrgAssessmentAliases");

            migrationBuilder.DropTable(
                name: "OrgGroupAliases");

            migrationBuilder.DropTable(
                name: "OrgLevelAliases");

            migrationBuilder.DropTable(
                name: "OrgProgressionAliases");

            migrationBuilder.DropTable(
                name: "OrgRoleAliases");

            migrationBuilder.DropTable(
                name: "OrgWheelAliases");

            migrationBuilder.DropTable(
                name: "S3Queue");

            migrationBuilder.DropTable(
                name: "S3TempFileParents");

            migrationBuilder.DropTable(
                name: "S3TempFiles");

            migrationBuilder.DropTable(
                name: "ScoreTypes");

            migrationBuilder.DropTable(
                name: "SiteErrorLogs");

            migrationBuilder.DropTable(
                name: "SubCategoriesForOrganisations");

            migrationBuilder.DropTable(
                name: "SubCategoriesForWheels");

            migrationBuilder.DropTable(
                name: "Theme");

            migrationBuilder.DropTable(
                name: "UserConnections");

            migrationBuilder.DropTable(
                name: "UserGroups");

            migrationBuilder.DropTable(
                name: "UserLocation");

            migrationBuilder.DropTable(
                name: "UserProfilePictures");

            migrationBuilder.DropTable(
                name: "UserWheelLevelExclusions");

            migrationBuilder.DropTable(
                name: "WheelAssessments");

            migrationBuilder.DropTable(
                name: "WheelAssessmentsCurrent");

            migrationBuilder.DropTable(
                name: "WheelCategories");

            migrationBuilder.DropTable(
                name: "WheelExcelExports");

            migrationBuilder.DropTable(
                name: "WheelGroupCompletionEvents");

            migrationBuilder.DropTable(
                name: "WheelGroups");

            migrationBuilder.DropTable(
                name: "WheelOrganisations");

            migrationBuilder.DropTable(
                name: "WheelOrgEvidenceCentralFiles");

            migrationBuilder.DropTable(
                name: "WheelOrgExampleCentralFileGroups");

            migrationBuilder.DropTable(
                name: "WheelOrgExampleCentralFiles");
        }
    }
}
