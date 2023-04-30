using System;
using System.Collections.Generic;

namespace TimeZoneConverter.Models;

public partial class AssessmentType
{
    public long Id { get; set; }

    public string Type { get; set; } = null!;

    public bool IsDeleted { get; set; }
}
