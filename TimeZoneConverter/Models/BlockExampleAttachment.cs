using System;
using System.Collections.Generic;

namespace TimeZoneConverter.Models;

public partial class BlockExampleAttachment
{
    public long Id { get; set; }

    public long BlockExampleId { get; set; }

    public string? Attachment { get; set; }

    public long? AttachmentType { get; set; }

    public DateTime DateCreated { get; set; }

    public string? WebPath { get; set; }

    public string? AttachmentName { get; set; }

    public long? OldBlockExampleId { get; set; }

    public bool IsDeleted { get; set; }
}
