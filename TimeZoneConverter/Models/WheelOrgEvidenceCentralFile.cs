using System;
using System.Collections.Generic;

namespace TimeZoneConverter.Models;

public partial class WheelOrgEvidenceCentralFile
{
    public long Id { get; set; }

    public long WheelId { get; set; }

    public string UserId { get; set; } = null!;

    public long AttachmentType { get; set; }

    public string? AttachmentName { get; set; }

    public string Attachment { get; set; } = null!;

    public string? WebPath { get; set; }

    public long? OldBlockEvidenceAttachmentId { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreatedOn { get; set; }
}
