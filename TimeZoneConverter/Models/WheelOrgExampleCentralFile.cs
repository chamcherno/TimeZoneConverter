using System;
using System.Collections.Generic;

namespace TimeZoneConverter.Models;

public partial class WheelOrgExampleCentralFile
{
    public long Id { get; set; }

    public long OrganisationId { get; set; }

    public long WheelId { get; set; }

    public string? WebPath { get; set; }

    public long AttachmentType { get; set; }

    public string? AttachmentName { get; set; }

    public string Attachment { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public DateTime CreatedOn { get; set; }

    public long? OldBlockExampleAttachmentId { get; set; }
}
