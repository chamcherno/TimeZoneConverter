using System;
using System.Collections.Generic;

namespace TimeZoneConverter.Models;

public partial class Assessment
{
    public long Id { get; set; }

    public string? AssessorId { get; set; }

    public string Description { get; set; } = null!;

    public bool Locked { get; set; }

    public string? UserAssessedId { get; set; }

    public long? GroupAssessedId { get; set; }

    public DateTime CreatedOn { get; set; }

    public int Collation { get; set; }

    public long AssessmentTypeId { get; set; }

    public bool IsDeleted { get; set; }

    public long? OldAssessmentId { get; set; }
}
