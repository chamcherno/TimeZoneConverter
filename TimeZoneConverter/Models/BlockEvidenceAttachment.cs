using System;
using System.Collections.Generic;

namespace TimeZoneConverter.Models;

public partial class BlockEvidenceAttachment
{
    public long Id { get; set; }

    public long? EvidenceId { get; set; }

    public string? Attachment { get; set; }

    public long? AttachmentTypeId { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? WebPathRelative { get; set; }

    public string? AttachmentName { get; set; }

    public long? OldBlockEvidenceAttachmentId { get; set; }
}
