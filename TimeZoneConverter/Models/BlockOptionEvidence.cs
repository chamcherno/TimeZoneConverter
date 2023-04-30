using System;
using System.Collections.Generic;

namespace TimeZoneConverter.Models;

public partial class BlockOptionEvidence
{
    public long Id { get; set; }

    public long? BlockOptionId { get; set; }

    public long? BlockId { get; set; }

    public long? WheelId { get; set; }

    public string? UserId { get; set; }

    public long? OrganisationId { get; set; }

    public bool? Complete { get; set; }

    public DateTime? CreatedOn { get; set; }

    public long AssessmentId { get; set; }
}
