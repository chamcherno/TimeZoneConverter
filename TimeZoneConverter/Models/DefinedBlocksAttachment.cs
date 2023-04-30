using System;
using System.Collections.Generic;

namespace TimeZoneConverter.Models;

public partial class DefinedBlocksAttachment
{
    public long Id { get; set; }

    public long WheelBlockId { get; set; }

    public string Attachment { get; set; } = null!;

    public long AttatchmentTypeId { get; set; }

    public string? WebPathRelative { get; set; }

    public int AttachmentPosition { get; set; }

    public bool IsDeleted { get; set; }

    public string? AttachmentName { get; set; }

    public int? OldBlockAttachmentId { get; set; }
}
