using System;
using System.Collections.Generic;

namespace TimeZoneConverter.Models;

public partial class WheelGroupCompletionEvent
{
    public long GroupCompletionEventId { get; set; }

    public long? WheelId { get; set; }

    public long? GroupId { get; set; }

    public DateTime? CompletionDate { get; set; }

    public string? Message { get; set; }

    public string? File { get; set; }
}
