using System;
using System.Collections.Generic;

namespace TimeZoneConverter.Models;

public partial class BlockExample
{
    public long Id { get; set; }

    public long? BlockId { get; set; }

    public long? WheelId { get; set; }

    public long? OrgId { get; set; }

    public DateTime DateCreated { get; set; }

    public string? LevelInfo { get; set; }

    public long? OldBlockExampleId { get; set; }
}
