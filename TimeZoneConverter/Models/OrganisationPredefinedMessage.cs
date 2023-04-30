using System;
using System.Collections.Generic;

namespace TimeZoneConverter.Models;

public partial class OrganisationPredefinedMessage
{
    public long Id { get; set; }

    public long OrganisationId { get; set; }

    public string Message { get; set; } = null!;

    public bool IsDeleted { get; set; }
}
