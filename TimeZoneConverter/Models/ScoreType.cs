using System;
using System.Collections.Generic;

namespace TimeZoneConverter.Models;

public partial class ScoreType
{
    public long Id { get; set; }

    public string ScoreType1 { get; set; } = null!;

    public bool IsDeleted { get; set; }
}
