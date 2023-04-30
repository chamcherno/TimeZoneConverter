using System;
using System.Collections.Generic;

namespace TimeZoneConverter.Models;

public partial class S3queue
{
    public long S3queueId { get; set; }

    public Guid ImportId { get; set; }

    public long OrganisationId { get; set; }

    public string BucketName { get; set; } = null!;

    public string FilePath { get; set; } = null!;

    public string FilePathAlt { get; set; } = null!;

    public string AwsKey { get; set; } = null!;

    public long WheelId { get; set; }

    public string? Status { get; set; }

    public long? OldBlockAttachmentId { get; set; }

    public long? OldEvidenceId { get; set; }

    public long? OldExampleId { get; set; }

    public long? OldCentralExampleId { get; set; }

    public long? OldCentralEvidenceId { get; set; }
}
