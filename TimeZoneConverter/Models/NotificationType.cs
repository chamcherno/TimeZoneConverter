using System;
using System.Collections.Generic;

namespace TimeZoneConverter.Models;

public partial class NotificationType
{
    public long Id { get; set; }

    public string Type { get; set; } = null!;

    public string FontAwesomeClassName { get; set; } = null!;

    public bool IsDeleted { get; set; }
}
