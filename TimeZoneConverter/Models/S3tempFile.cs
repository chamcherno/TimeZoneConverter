using System;
using System.Collections.Generic;

namespace TimeZoneConverter.Models;

public partial class S3tempFile
{
    public Guid Id { get; set; }

    public Guid ParentId { get; set; }

    public string S3path { get; set; } = null!;
}
