using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace TimeZoneConverter.Models;

public partial class WheelCopyContext : DbContext
{
    public WheelCopyContext()
    {
    }

    public WheelCopyContext(DbContextOptions<WheelCopyContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AgeGroup> AgeGroups { get; set; }

    public virtual DbSet<AspNetRole> AspNetRoles { get; set; }

    public virtual DbSet<AspNetUser> AspNetUsers { get; set; }

    public virtual DbSet<AspNetUserClaim> AspNetUserClaims { get; set; }

    public virtual DbSet<AspNetUserLogin> AspNetUserLogins { get; set; }

    public virtual DbSet<AspNetUserRole> AspNetUserRoles { get; set; }

    public virtual DbSet<AspNetUsersPending> AspNetUsersPendings { get; set; }

    public virtual DbSet<Assessment> Assessments { get; set; }

    public virtual DbSet<AssessmentComment> AssessmentComments { get; set; }

    public virtual DbSet<AssessmentType> AssessmentTypes { get; set; }

    public virtual DbSet<AttachmentType> AttachmentTypes { get; set; }

    public virtual DbSet<BlockEvidence> BlockEvidences { get; set; }

    public virtual DbSet<BlockEvidenceAttachment> BlockEvidenceAttachments { get; set; }

    public virtual DbSet<BlockExample> BlockExamples { get; set; }

    public virtual DbSet<BlockExampleAttachment> BlockExampleAttachments { get; set; }

    public virtual DbSet<BlockExampleAttachmentGroup> BlockExampleAttachmentGroups { get; set; }

    public virtual DbSet<BlockLevelInfo> BlockLevelInfos { get; set; }

    public virtual DbSet<BlockLevelInfoGroup> BlockLevelInfoGroups { get; set; }

    public virtual DbSet<BlockOptionEvidence> BlockOptionEvidences { get; set; }

    public virtual DbSet<BlockScore> BlockScores { get; set; }

    public virtual DbSet<CategoriesForOrganisation> CategoriesForOrganisations { get; set; }

    public virtual DbSet<CategoriesForWheel> CategoriesForWheels { get; set; }

    public virtual DbSet<DatesOfInterest> DatesOfInterests { get; set; }

    public virtual DbSet<DefinedBlock> DefinedBlocks { get; set; }

    public virtual DbSet<DefinedBlocksAttachment> DefinedBlocksAttachments { get; set; }

    public virtual DbSet<DefinedBlocksOption> DefinedBlocksOptions { get; set; }

    public virtual DbSet<DefinedSector> DefinedSectors { get; set; }

    public virtual DbSet<DefinedSubSector> DefinedSubSectors { get; set; }

    public virtual DbSet<DefinedWheel> DefinedWheels { get; set; }

    public virtual DbSet<DefinedWheelStageIndicator> DefinedWheelStageIndicators { get; set; }

    public virtual DbSet<DemoExpiryNotification> DemoExpiryNotifications { get; set; }

    public virtual DbSet<DemoExpiryNotificationStatus> DemoExpiryNotificationStatuses { get; set; }

    public virtual DbSet<DemoSignup> DemoSignups { get; set; }

    public virtual DbSet<ExistingBlockState> ExistingBlockStates { get; set; }

    public virtual DbSet<Font> Fonts { get; set; }

    public virtual DbSet<GlobalCentralFile> GlobalCentralFiles { get; set; }

    public virtual DbSet<Group> Groups { get; set; }

    public virtual DbSet<GroupMember> GroupMembers { get; set; }

    public virtual DbSet<HistoricalBlockState> HistoricalBlockStates { get; set; }

    public virtual DbSet<LockedUser> LockedUsers { get; set; }

    public virtual DbSet<Note> Notes { get; set; }

    public virtual DbSet<Notification> Notifications { get; set; }

    public virtual DbSet<NotificationTemplate> NotificationTemplates { get; set; }

    public virtual DbSet<NotificationType> NotificationTypes { get; set; }

    public virtual DbSet<OrgAssessmentAlias> OrgAssessmentAliases { get; set; }

    public virtual DbSet<OrgGroupAlias> OrgGroupAliases { get; set; }

    public virtual DbSet<OrgLevelAlias> OrgLevelAliases { get; set; }

    public virtual DbSet<OrgProgressionAlias> OrgProgressionAliases { get; set; }

    public virtual DbSet<OrgRoleAlias> OrgRoleAliases { get; set; }

    public virtual DbSet<OrgWheelAlias> OrgWheelAliases { get; set; }

    public virtual DbSet<Organisation> Organisations { get; set; }

    public virtual DbSet<OrganisationCategory> OrganisationCategories { get; set; }

    public virtual DbSet<OrganisationCentralFile> OrganisationCentralFiles { get; set; }

    public virtual DbSet<OrganisationLogo> OrganisationLogos { get; set; }

    public virtual DbSet<OrganisationPredefinedMessage> OrganisationPredefinedMessages { get; set; }

    public virtual DbSet<OrganisationProfilePicture> OrganisationProfilePictures { get; set; }

    public virtual DbSet<OrganisationWheelDescription> OrganisationWheelDescriptions { get; set; }

    public virtual DbSet<OrganisationWheelDescriptionGroup> OrganisationWheelDescriptionGroups { get; set; }

    public virtual DbSet<S3queue> S3queues { get; set; }

    public virtual DbSet<S3tempFile> S3tempFiles { get; set; }

    public virtual DbSet<S3tempFileParent> S3tempFileParents { get; set; }

    public virtual DbSet<ScoreType> ScoreTypes { get; set; }

    public virtual DbSet<SiteErrorLog> SiteErrorLogs { get; set; }

    public virtual DbSet<SubCategoriesForOrganisation> SubCategoriesForOrganisations { get; set; }

    public virtual DbSet<SubCategoriesForWheel> SubCategoriesForWheels { get; set; }

    public virtual DbSet<Theme> Themes { get; set; }

    public virtual DbSet<UserConnection> UserConnections { get; set; }

    public virtual DbSet<UserGroup> UserGroups { get; set; }

    public virtual DbSet<UserLocation> UserLocations { get; set; }

    public virtual DbSet<UserProfilePicture> UserProfilePictures { get; set; }

    public virtual DbSet<UserWheelLevelExclusion> UserWheelLevelExclusions { get; set; }

    public virtual DbSet<WheelAssessment> WheelAssessments { get; set; }

    public virtual DbSet<WheelAssessmentsCurrent> WheelAssessmentsCurrents { get; set; }

    public virtual DbSet<WheelCategory> WheelCategories { get; set; }

    public virtual DbSet<WheelExcelExport> WheelExcelExports { get; set; }

    public virtual DbSet<WheelGroup> WheelGroups { get; set; }

    public virtual DbSet<WheelGroupCompletionEvent> WheelGroupCompletionEvents { get; set; }

    public virtual DbSet<WheelOrgEvidenceCentralFile> WheelOrgEvidenceCentralFiles { get; set; }

    public virtual DbSet<WheelOrgExampleCentralFile> WheelOrgExampleCentralFiles { get; set; }

    public virtual DbSet<WheelOrgExampleCentralFileGroup> WheelOrgExampleCentralFileGroups { get; set; }

    public virtual DbSet<WheelOrganisation> WheelOrganisations { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=CHERNO-WM;Database=WheelCopy;Trust Server Certificate=True;Trusted_Connection=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AgeGroup>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.AgeGroup1)
                .HasMaxLength(50)
                .HasColumnName("AgeGroup");
        });

        modelBuilder.Entity<AspNetRole>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Description).HasMaxLength(255);
            entity.Property(e => e.Id).HasMaxLength(128);
            entity.Property(e => e.Name).HasMaxLength(256);
        });

        modelBuilder.Entity<AspNetUser>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.AppAuthenticationKey).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.CurrentConnectionId).HasMaxLength(128);
            entity.Property(e => e.Description).HasMaxLength(256);
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.EnableMfaDueDate).HasColumnType("datetime");
            entity.Property(e => e.FirstName).HasMaxLength(100);
            entity.Property(e => e.Id).HasMaxLength(128);
            entity.Property(e => e.LastActive).HasColumnType("datetime");
            entity.Property(e => e.LastName).HasMaxLength(100);
            entity.Property(e => e.LastViewedNotifications).HasColumnType("datetime");
            entity.Property(e => e.LockoutEndDateUtc).HasColumnType("datetime");
            entity.Property(e => e.OldPasswordHash).HasMaxLength(32);
            entity.Property(e => e.OtherNames).HasMaxLength(100);
            entity.Property(e => e.ProfileImageUrl)
                .HasMaxLength(256)
                .HasColumnName("ProfileImageURL");
            entity.Property(e => e.ResetPasswordDueDate).HasColumnType("datetime");
            entity.Property(e => e.UserName).HasMaxLength(256);
        });

        modelBuilder.Entity<AspNetUserClaim>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.UserId).HasMaxLength(128);
        });

        modelBuilder.Entity<AspNetUserLogin>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.LoginProvider).HasMaxLength(128);
            entity.Property(e => e.ProviderKey).HasMaxLength(128);
            entity.Property(e => e.UserId).HasMaxLength(128);
        });

        modelBuilder.Entity<AspNetUserRole>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.RoleId).HasMaxLength(128);
            entity.Property(e => e.UserId).HasMaxLength(128);
            entity.Property(e => e.UserRoleId).HasMaxLength(128);
        });

        modelBuilder.Entity<AspNetUsersPending>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AspNetUsersPending");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.Email).HasMaxLength(256);
            entity.Property(e => e.FirstName).HasMaxLength(100);
            entity.Property(e => e.Id).HasMaxLength(128);
            entity.Property(e => e.LastName).HasMaxLength(100);
            entity.Property(e => e.OtherNames).HasMaxLength(100);
            entity.Property(e => e.ProfileImageUrl)
                .HasMaxLength(256)
                .HasColumnName("ProfileImageURL");
            entity.Property(e => e.ProfileImageUrlsmall)
                .HasMaxLength(256)
                .HasColumnName("ProfileImageURLSmall");
            entity.Property(e => e.RequestId).HasMaxLength(128);
            entity.Property(e => e.UserName).HasMaxLength(256);
        });

        modelBuilder.Entity<Assessment>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.AssessorId).HasMaxLength(128);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(50);
            entity.Property(e => e.UserAssessedId).HasMaxLength(128);
        });

        modelBuilder.Entity<AssessmentComment>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.AssessorId).HasMaxLength(128);
            entity.Property(e => e.Comment).HasMaxLength(2000);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.UserAssessedId).HasMaxLength(128);
        });

        modelBuilder.Entity<AssessmentType>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Type).HasMaxLength(10);
        });

        modelBuilder.Entity<AttachmentType>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.AttachmentType1)
                .HasMaxLength(50)
                .HasColumnName("attachmentType");
        });

        modelBuilder.Entity<BlockEvidence>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BlockEvidence");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasMaxLength(128);
        });

        modelBuilder.Entity<BlockEvidenceAttachment>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BlockEvidenceAttachment");

            entity.Property(e => e.AttachmentName).HasMaxLength(255);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.WebPathRelative).HasMaxLength(500);
        });

        modelBuilder.Entity<BlockExample>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.LevelInfo).HasMaxLength(2000);
            entity.Property(e => e.OldBlockExampleId).HasColumnName("OldBlockExampleID");
        });

        modelBuilder.Entity<BlockExampleAttachment>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.AttachmentName).HasMaxLength(255);
            entity.Property(e => e.BlockExampleId).HasColumnName("BlockExampleID");
            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.WebPath).HasMaxLength(500);
        });

        modelBuilder.Entity<BlockExampleAttachmentGroup>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<BlockLevelInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BlockLevelInfo");

            entity.Property(e => e.DateCreated).HasColumnType("datetime");
        });

        modelBuilder.Entity<BlockLevelInfoGroup>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<BlockOptionEvidence>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BlockOptionEvidence");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasMaxLength(128);
        });

        modelBuilder.Entity<BlockScore>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.ColourHex).HasMaxLength(50);
            entity.Property(e => e.Name).HasMaxLength(20);
        });

        modelBuilder.Entity<CategoriesForOrganisation>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CategoryName).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<CategoriesForWheel>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CategoryName).HasMaxLength(50);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<DatesOfInterest>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DatesOfInterest");

            entity.Property(e => e.DateOfInterest).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(100);
            entity.Property(e => e.UserId).HasMaxLength(128);
        });

        modelBuilder.Entity<DefinedBlock>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Body).IsUnicode(false);
            entity.Property(e => e.Label)
                .HasMaxLength(100)
                .IsUnicode(false);
            entity.Property(e => e.LevelInfo).IsUnicode(false);
        });

        modelBuilder.Entity<DefinedBlocksAttachment>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.AttachmentName).HasMaxLength(255);
            entity.Property(e => e.WebPathRelative).HasMaxLength(255);
        });

        modelBuilder.Entity<DefinedBlocksOption>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.StatementOption).HasMaxLength(2000);
        });

        modelBuilder.Entity<DefinedSector>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.SectorLabel).HasMaxLength(175);
        });

        modelBuilder.Entity<DefinedSubSector>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Label)
                .HasMaxLength(175)
                .IsUnicode(false);
            entity.Property(e => e.OldSubSectorId)
                .HasMaxLength(10)
                .IsUnicode(false)
                .IsFixedLength();
        });

        modelBuilder.Entity<DefinedWheel>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CreatedBy)
                .HasMaxLength(128)
                .IsUnicode(false);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(1000);
            entity.Property(e => e.DescriptionHtml).HasColumnName("DescriptionHTML");
            entity.Property(e => e.LastEdited).HasColumnType("datetime");
            entity.Property(e => e.LogoFileName)
                .HasMaxLength(255)
                .IsUnicode(false);
            entity.Property(e => e.Name).HasMaxLength(100);
        });

        modelBuilder.Entity<DefinedWheelStageIndicator>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DefinedWheelStageIndicator");

            entity.Property(e => e.ToolTipText).HasMaxLength(2000);
            entity.Property(e => e.TooltipTitle).HasMaxLength(255);
        });

        modelBuilder.Entity<DemoExpiryNotification>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.DateUpdated).HasColumnType("datetime");
        });

        modelBuilder.Entity<DemoExpiryNotificationStatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DemoExpiryNotificationStatus");

            entity.Property(e => e.Description).HasMaxLength(200);
        });

        modelBuilder.Entity<DemoSignup>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.AdminEmail)
                .HasMaxLength(258)
                .IsUnicode(false);
            entity.Property(e => e.AdminName)
                .HasMaxLength(258)
                .IsUnicode(false);
            entity.Property(e => e.AdminPhone)
                .HasMaxLength(258)
                .IsUnicode(false);
            entity.Property(e => e.County)
                .HasMaxLength(258)
                .IsUnicode(false);
            entity.Property(e => e.OrganisationName)
                .HasMaxLength(258)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ExistingBlockState>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateUpdated).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasMaxLength(128);
        });

        modelBuilder.Entity<Font>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Font");

            entity.Property(e => e.FontFamilyName).HasMaxLength(50);
            entity.Property(e => e.FontFormat).HasMaxLength(50);
            entity.Property(e => e.FontId).HasColumnName("Font_Id");
            entity.Property(e => e.FontUrl).HasMaxLength(250);
        });

        modelBuilder.Entity<GlobalCentralFile>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Attachment).HasMaxLength(255);
            entity.Property(e => e.AttachmentName).HasMaxLength(255);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.WebPath).HasMaxLength(255);
        });

        modelBuilder.Entity<Group>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.Name).HasMaxLength(200);
        });

        modelBuilder.Entity<GroupMember>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasMaxLength(128);
        });

        modelBuilder.Entity<HistoricalBlockState>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.DateCreated).HasColumnType("datetime");
            entity.Property(e => e.DateUpdated).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasMaxLength(128);
        });

        modelBuilder.Entity<LockedUser>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.UserId).HasMaxLength(128);
        });

        modelBuilder.Entity<Note>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Note1)
                .HasMaxLength(2000)
                .HasColumnName("Note");
            entity.Property(e => e.UserId).HasMaxLength(128);
        });

        modelBuilder.Entity<Notification>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Link).HasMaxLength(500);
            entity.Property(e => e.Message).HasMaxLength(4000);
            entity.Property(e => e.RecieverId).HasMaxLength(128);
            entity.Property(e => e.SenderId).HasMaxLength(128);
            entity.Property(e => e.Title).HasMaxLength(400);
        });

        modelBuilder.Entity<NotificationTemplate>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.NotificationTemplateId).HasColumnName("NotificationTemplate_Id");
        });

        modelBuilder.Entity<NotificationType>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.FontAwesomeClassName).HasMaxLength(50);
            entity.Property(e => e.Type).HasMaxLength(50);
        });

        modelBuilder.Entity<OrgAssessmentAlias>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<OrgGroupAlias>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<OrgLevelAlias>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<OrgProgressionAlias>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<OrgRoleAlias>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.RoleId).HasMaxLength(128);
        });

        modelBuilder.Entity<OrgWheelAlias>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<Organisation>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CompleteColour).HasMaxLength(7);
            entity.Property(e => e.Contact).HasMaxLength(50);
            entity.Property(e => e.DemoExpiry).HasColumnType("datetime");
            entity.Property(e => e.Description).HasMaxLength(200);
            entity.Property(e => e.DomainUrl)
                .HasMaxLength(255)
                .HasColumnName("DomainURL");
            entity.Property(e => e.FontId).HasColumnName("Font_Id");
            entity.Property(e => e.Information).HasMaxLength(2000);
            entity.Property(e => e.LastOnline).HasColumnType("datetime");
            entity.Property(e => e.OldOrgUrn)
                .HasMaxLength(50)
                .HasColumnName("OldOrgURN");
            entity.Property(e => e.PartialColour).HasMaxLength(7);
            entity.Property(e => e.PhoneContact).HasMaxLength(200);
            entity.Property(e => e.PostCode).HasMaxLength(50);
            entity.Property(e => e.TargetColour).HasMaxLength(7);
            entity.Property(e => e.ThemeColour).HasMaxLength(7);
            entity.Property(e => e.ThemeId).HasColumnName("Theme_Id");
            entity.Property(e => e.Urn)
                .HasMaxLength(50)
                .HasColumnName("URN");
        });

        modelBuilder.Entity<OrganisationCategory>(entity =>
        {
            entity.HasNoKey();
        });

        modelBuilder.Entity<OrganisationCentralFile>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Attachment).HasMaxLength(255);
            entity.Property(e => e.AttachmentName).HasMaxLength(255);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.WebPath).HasMaxLength(255);
        });

        modelBuilder.Entity<OrganisationLogo>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.Logo).HasMaxLength(255);
        });

        modelBuilder.Entity<OrganisationPredefinedMessage>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Message).HasMaxLength(4000);
        });

        modelBuilder.Entity<OrganisationProfilePicture>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.LinkToImage).HasMaxLength(255);
        });

        modelBuilder.Entity<OrganisationWheelDescription>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.DescriptionHtml).HasColumnName("DescriptionHTML");
        });

        modelBuilder.Entity<OrganisationWheelDescriptionGroup>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<S3queue>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("S3Queue");

            entity.Property(e => e.AwsKey).HasMaxLength(500);
            entity.Property(e => e.BucketName).HasMaxLength(150);
            entity.Property(e => e.FilePath).HasMaxLength(500);
            entity.Property(e => e.FilePathAlt).HasMaxLength(500);
            entity.Property(e => e.S3queueId).HasColumnName("S3QueueId");
            entity.Property(e => e.Status).HasMaxLength(150);
        });

        modelBuilder.Entity<S3tempFile>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("S3TempFiles");

            entity.Property(e => e.ParentId).HasColumnName("ParentID");
            entity.Property(e => e.S3path)
                .HasMaxLength(1024)
                .HasColumnName("S3Path");
        });

        modelBuilder.Entity<S3tempFileParent>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("S3TempFileParents");

            entity.Property(e => e.UserId).HasMaxLength(128);
        });

        modelBuilder.Entity<ScoreType>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.ScoreType1)
                .HasMaxLength(50)
                .HasColumnName("ScoreType");
        });

        modelBuilder.Entity<SiteErrorLog>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Contenttype)
                .HasMaxLength(255)
                .HasColumnName("contenttype");
            entity.Property(e => e.DateRecorded).HasColumnType("datetime");
            entity.Property(e => e.Httpmethod)
                .HasMaxLength(255)
                .HasColumnName("httpmethod");
            entity.Property(e => e.Id).HasColumnName("ID");
            entity.Property(e => e.InnerExceptionMessage)
                .HasMaxLength(255)
                .HasColumnName("innerExceptionMessage");
            entity.Property(e => e.InnerExceptionStackTrace).HasColumnName("innerExceptionStackTrace");
            entity.Property(e => e.InnerExceptionType)
                .HasMaxLength(255)
                .HasColumnName("innerExceptionType");
            entity.Property(e => e.Message)
                .HasMaxLength(255)
                .HasColumnName("message");
            entity.Property(e => e.Origin)
                .HasMaxLength(255)
                .HasColumnName("origin");
            entity.Property(e => e.StackTrace).HasColumnName("stackTrace");
            entity.Property(e => e.Statuscode)
                .HasMaxLength(10)
                .HasColumnName("statuscode");
            entity.Property(e => e.TargetSite)
                .HasMaxLength(255)
                .HasColumnName("targetSite");
            entity.Property(e => e.Type)
                .HasMaxLength(255)
                .HasColumnName("type");
            entity.Property(e => e.Useragent)
                .HasMaxLength(255)
                .HasColumnName("useragent");
            entity.Property(e => e.Userhostip)
                .HasMaxLength(255)
                .HasColumnName("userhostip");
            entity.Property(e => e.Userid).HasColumnName("userid");
        });

        modelBuilder.Entity<SubCategoriesForOrganisation>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.SubCategoryName).HasMaxLength(50);
        });

        modelBuilder.Entity<SubCategoriesForWheel>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.SubCategoryName).HasMaxLength(50);
        });

        modelBuilder.Entity<Theme>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Theme");

            entity.Property(e => e.ThemeId).HasColumnName("Theme_Id");
            entity.Property(e => e.ThemeName)
                .HasMaxLength(50)
                .IsUnicode(false);
        });

        modelBuilder.Entity<UserConnection>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.ConnectionId).HasMaxLength(128);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasMaxLength(128);
        });

        modelBuilder.Entity<UserGroup>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.FirstName).HasMaxLength(100);
            entity.Property(e => e.LastName).HasMaxLength(100);
            entity.Property(e => e.Name).HasMaxLength(200);
            entity.Property(e => e.UserId).HasMaxLength(128);
        });

        modelBuilder.Entity<UserLocation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("UserLocation");

            entity.Property(e => e.Coordinates).HasMaxLength(60);
            entity.Property(e => e.CreatedAt).HasColumnType("datetime");
            entity.Property(e => e.UpdatedAt).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasMaxLength(900);
        });

        modelBuilder.Entity<UserProfilePicture>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.LinkToImage).HasMaxLength(255);
            entity.Property(e => e.UserId).HasMaxLength(128);
        });

        modelBuilder.Entity<UserWheelLevelExclusion>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.UserId).HasMaxLength(128);
        });

        modelBuilder.Entity<WheelAssessment>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.UpdaterUserId).HasMaxLength(128);
            entity.Property(e => e.UserId).HasMaxLength(128);
        });

        modelBuilder.Entity<WheelAssessmentsCurrent>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("WheelAssessmentsCurrent");

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.UpdaterUserId).HasMaxLength(128);
            entity.Property(e => e.UserId).HasMaxLength(128);
        });

        modelBuilder.Entity<WheelCategory>(entity =>
        {
            entity.HasNoKey();
        });

        modelBuilder.Entity<WheelExcelExport>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.PersonId).HasMaxLength(128);
            entity.Property(e => e.S3link)
                .HasMaxLength(1024)
                .HasColumnName("S3Link");
            entity.Property(e => e.S3parentFolderGuid)
                .HasMaxLength(128)
                .HasColumnName("S3ParentFolderGUID");
        });

        modelBuilder.Entity<WheelGroup>(entity =>
        {
            entity.HasNoKey();
        });

        modelBuilder.Entity<WheelGroupCompletionEvent>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CompletionDate).HasColumnType("datetime");
            entity.Property(e => e.File).HasMaxLength(100);
            entity.Property(e => e.Message).HasMaxLength(2000);
        });

        modelBuilder.Entity<WheelOrgEvidenceCentralFile>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.AttachmentName).HasMaxLength(255);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasMaxLength(128);
            entity.Property(e => e.WebPath).HasMaxLength(500);
        });

        modelBuilder.Entity<WheelOrgExampleCentralFile>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Attachment).HasMaxLength(255);
            entity.Property(e => e.AttachmentName).HasMaxLength(255);
            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.WebPath).HasMaxLength(500);
        });

        modelBuilder.Entity<WheelOrgExampleCentralFileGroup>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CreatedOn).HasColumnType("datetime");
            entity.Property(e => e.UpdatedOn).HasColumnType("datetime");
        });

        modelBuilder.Entity<WheelOrganisation>(entity =>
        {
            entity.HasNoKey();
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
