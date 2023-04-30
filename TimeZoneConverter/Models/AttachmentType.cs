using System;
using System.Collections.Generic;

namespace TimeZoneConverter.Models;

public partial class AttachmentType
{
    public long Id { get; set; }

    public string AttachmentType1 { get; set; } = null!;

    public bool IsDeleted { get; set; }
}
