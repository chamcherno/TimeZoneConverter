using System;
using System.Collections.Generic;

namespace TimeZoneConverter.Models;

public partial class WheelGroup
{
    public long WheelGroupId { get; set; }

    public long GroupId { get; set; }

    public long WheelId { get; set; }

    public bool Locked { get; set; }
}
