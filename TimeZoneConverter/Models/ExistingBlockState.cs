using System;
using System.Collections.Generic;

namespace TimeZoneConverter.Models;

public partial class ExistingBlockState
{
    public long Id { get; set; }

    public long OrganisationId { get; set; }

    public string UserId { get; set; } = null!;

    public long WheelId { get; set; }

    public long BlockId { get; set; }

    public long? BlockScore { get; set; }

    public long? OldBlockStateId { get; set; }

    public DateTime? DateCreated { get; set; }

    public DateTime? DateUpdated { get; set; }
}
