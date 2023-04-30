using System;
using System.Collections.Generic;

namespace TimeZoneConverter.Models;

public partial class DefinedWheel
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime LastEdited { get; set; }

    public string? LogoFileName { get; set; }

    public int StartingLevel { get; set; }

    public bool IsDeleted { get; set; }

    public long? OldWheelId { get; set; }

    public bool IsJasmine { get; set; }

    public string? DescriptionHtml { get; set; }
}
