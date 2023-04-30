using System;
using System.Collections.Generic;

namespace TimeZoneConverter.Models;

public partial class Note
{
    public long Id { get; set; }

    public string Note1 { get; set; } = null!;

    public string? UserId { get; set; }

    public long? GroupId { get; set; }

    public long? OrganisationId { get; set; }

    public bool IsDeleted { get; set; }

    public long? WheelId { get; set; }
}
