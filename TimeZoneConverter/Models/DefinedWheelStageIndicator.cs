using System;
using System.Collections.Generic;

namespace TimeZoneConverter.Models;

public partial class DefinedWheelStageIndicator
{
    public long Id { get; set; }

    public long WheelId { get; set; }

    public int StageLevel { get; set; }

    public string? TooltipTitle { get; set; }

    public string? ToolTipText { get; set; }
}
