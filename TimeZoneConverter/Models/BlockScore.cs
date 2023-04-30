using System;
using System.Collections.Generic;

namespace TimeZoneConverter.Models;

public partial class BlockScore
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public bool Scorable { get; set; }

    public string? ColourHex { get; set; }

    public bool IsDeleted { get; set; }
}
