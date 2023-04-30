using System;
using System.Collections.Generic;

namespace TimeZoneConverter.Models;

public partial class UserWheelLevelExclusion
{
    public long Id { get; set; }

    public long? WheelId { get; set; }

    public int? WheelLevel { get; set; }

    public string UserId { get; set; } = null!;
}
