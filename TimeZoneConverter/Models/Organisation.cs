using System;
using System.Collections.Generic;

namespace TimeZoneConverter.Models;

public partial class Organisation
{
    public long OrganisationId { get; set; }

    public string Urn { get; set; } = null!;

    public string Description { get; set; } = null!;

    public string Contact { get; set; } = null!;

    public string PhoneContact { get; set; } = null!;

    public bool OnHold { get; set; }

    public long ScoreType { get; set; }

    public bool ScoreShowStudent { get; set; }

    public string? CompleteColour { get; set; }

    public string? TargetColour { get; set; }

    public string? PartialColour { get; set; }

    public DateTime? LastOnline { get; set; }

    public bool IsDemo { get; set; }

    public DateTime? DemoExpiry { get; set; }

    public string? DomainUrl { get; set; }

    public Guid? FontId { get; set; }

    public string? ThemeColour { get; set; }

    public Guid? ThemeId { get; set; }

    public bool IsJasmine { get; set; }

    public string? OldOrgUrn { get; set; }

    public string? Information { get; set; }

    public bool IsDeleted { get; set; }

    public bool IsPrimary { get; set; }

    public bool? DemoExpired { get; set; }

    public Guid? BulkImportId { get; set; }

    public string? PostCode { get; set; }

    public bool SupportEnabled { get; set; }
}
