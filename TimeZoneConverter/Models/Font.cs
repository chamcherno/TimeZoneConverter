using System;
using System.Collections.Generic;

namespace TimeZoneConverter.Models;

public partial class Font
{
    public Guid FontId { get; set; }

    public string FontFamilyName { get; set; } = null!;

    public string FontUrl { get; set; } = null!;

    public string FontFormat { get; set; } = null!;
}
