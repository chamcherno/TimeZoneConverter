using System;
using System.Collections.Generic;

namespace TimeZoneConverter.Models;

public partial class UserLocation
{
    public long Id { get; set; }

    public string UserId { get; set; } = null!;

    public string Coordinates { get; set; } = null!;

    public DateTime? CreatedAt { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public bool? IsDeleted { get; set; }
}
