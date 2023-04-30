using System;
using System.Collections.Generic;

namespace TimeZoneConverter.Models;

public partial class AspNetRole
{
    public string Id { get; set; } = null!;

    public string Name { get; set; } = null!;

    public bool IncludeInAverage { get; set; }

    public string? Description { get; set; }

    public bool IsRenameable { get; set; }
}
