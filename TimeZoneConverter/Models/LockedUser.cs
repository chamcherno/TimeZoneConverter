using System;
using System.Collections.Generic;

namespace TimeZoneConverter.Models;

public partial class LockedUser
{
    public long Id { get; set; }

    public string UserId { get; set; } = null!;

    public long WheelId { get; set; }

    public bool Locked { get; set; }
}
