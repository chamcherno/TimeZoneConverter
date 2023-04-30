using System;
using System.Collections.Generic;

namespace TimeZoneConverter.Models;

public partial class AspNetUsersPending
{
    public string Id { get; set; } = null!;

    public long? OrganisationId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public string? PasswordHash { get; set; }

    public string? SecurityStamp { get; set; }

    public string? PhoneNumber { get; set; }

    public bool? Gender { get; set; }

    public DateTime? Dob { get; set; }

    public string? UserName { get; set; }

    public DateTime CreatedOn { get; set; }

    public string? OtherNames { get; set; }

    public string? ProfileImageUrl { get; set; }

    public string? ProfileImageUrlsmall { get; set; }

    public long? GroupId { get; set; }

    public string? RequestId { get; set; }
}
