using System;
using System.Collections.Generic;

namespace TimeZoneConverter.Models;

public partial class GlobalCentralFile
{
    public long Id { get; set; }

    public string WebPath { get; set; } = null!;

    public long AttachmentType { get; set; }

    public string? AttachmentName { get; set; }

    public string Attachment { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public DateTime CreatedOn { get; set; }

    public int AttachmentPosition { get; set; }

    public long? WheelId { get; set; }
}
