using System;
using System.Collections.Generic;

namespace TimeZoneConverter.Models;

public partial class S3tempFileParent
{
    public Guid Id { get; set; }

    public string UserId { get; set; } = null!;
}
