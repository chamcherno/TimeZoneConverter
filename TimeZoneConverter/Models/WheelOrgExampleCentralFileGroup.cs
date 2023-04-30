using System;
using System.Collections.Generic;

namespace TimeZoneConverter.Models;

public partial class WheelOrgExampleCentralFileGroup
{
    public long Id { get; set; }

    public long WheelOrgExampleCentralFilesId { get; set; }

    public long GroupId { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreatedOn { get; set; }

    public DateTime UpdatedOn { get; set; }
}
