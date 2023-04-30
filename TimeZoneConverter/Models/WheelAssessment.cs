using System;
using System.Collections.Generic;

namespace TimeZoneConverter.Models;

public partial class WheelAssessment
{
    public long Id { get; set; }

    public string UserId { get; set; } = null!;

    public long AssessmentId { get; set; }

    public long WheelId { get; set; }

    public string UpdaterUserId { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public bool UpdateAnyBlock { get; set; }
}
