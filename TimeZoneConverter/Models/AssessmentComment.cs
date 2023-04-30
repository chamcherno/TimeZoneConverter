using System;
using System.Collections.Generic;

namespace TimeZoneConverter.Models;

public partial class AssessmentComment
{
    public long Id { get; set; }

    public long AssessmentId { get; set; }

    public long? WheelId { get; set; }

    public string? UserAssessedId { get; set; }

    public long? GroupAssessedId { get; set; }

    public string AssessorId { get; set; } = null!;

    public string? Comment { get; set; }

    public bool Locked { get; set; }

    public DateTime CreatedOn { get; set; }
}
