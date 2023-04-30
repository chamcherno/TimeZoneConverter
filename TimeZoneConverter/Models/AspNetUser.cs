using System;
using System.Collections.Generic;

namespace TimeZoneConverter.Models;

public partial class AspNetUser
{
    public string Id { get; set; } = null!;

    public long? OrganisationId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public bool EmailConfirmed { get; set; }

    public string? PasswordHash { get; set; }

    public string? SecurityStamp { get; set; }

    public string? PhoneNumber { get; set; }

    public bool PhoneNumberConfirmed { get; set; }

    public bool TwoFactorEnabled { get; set; }

    public DateTime? LockoutEndDateUtc { get; set; }

    public bool LockoutEnabled { get; set; }

    public int AccessFailedCount { get; set; }

    public bool? Gender { get; set; }

    public DateTime? Dob { get; set; }

    public string? UserName { get; set; }

    public string? OldPasswordHash { get; set; }

    public int TimesLoggedIn { get; set; }

    public DateTime? LastActive { get; set; }

    public DateTime CreatedOn { get; set; }

    public bool IsDeleted { get; set; }

    public bool AllowQuickUpdating { get; set; }

    public string? OtherNames { get; set; }

    public string? Description { get; set; }

    public string? ProfileImageUrl { get; set; }

    public DateTime? LastViewedNotifications { get; set; }

    public string? CurrentConnectionId { get; set; }

    public bool PasswordPrompt { get; set; }

    public bool AllowStudentCreation { get; set; }

    public bool EnableNotifications { get; set; }

    public bool EnableTimeout { get; set; }

    public bool IsAppAuthenticationEnabled { get; set; }

    public string? AppAuthenticationKey { get; set; }

    public DateTime? ResetPasswordDueDate { get; set; }

    public DateTime? EnableMfaDueDate { get; set; }
}
