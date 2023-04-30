using System;
using System.Collections.Generic;

namespace TimeZoneConverter.Models;

public partial class BlockLevelInfoGroup
{
    public long Id { get; set; }

    public long? BlockLevelInfoId { get; set; }

    public long GroupId { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime UpdatedOn { get; set; }
}
