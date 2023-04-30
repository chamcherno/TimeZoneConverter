using System;
using System.Collections.Generic;

namespace TimeZoneConverter.Models;

public partial class BlockExampleAttachmentGroup
{
    public long Id { get; set; }

    public long BlockExampleAttachmentId { get; set; }

    public long GroupId { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime UpdatedOn { get; set; }
}
