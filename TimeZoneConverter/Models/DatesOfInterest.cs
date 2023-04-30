using System;
using System.Collections.Generic;

namespace TimeZoneConverter.Models;

public partial class DatesOfInterest
{
    public long Id { get; set; }

    public string? UserId { get; set; }

    public long? GroupId { get; set; }

    public DateTime DateOfInterest { get; set; }

    public string Description { get; set; } = null!;
}
