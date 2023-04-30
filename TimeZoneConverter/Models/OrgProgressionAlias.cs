using System;
using System.Collections.Generic;

namespace TimeZoneConverter.Models;

public partial class OrgProgressionAlias
{
    public long Id { get; set; }

    public long OrganisationId { get; set; }

    public long? WheelId { get; set; }

    public string? CompletedAlias { get; set; }

    public string? PartialAlias { get; set; }

    public string? TargetAlias { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedOn { get; set; }
}
