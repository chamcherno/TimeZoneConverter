using System;
using System.Collections.Generic;

namespace TimeZoneConverter.Models;

public partial class DemoExpiryNotification
{
    public long Id { get; set; }

    public long OrganisationId { get; set; }

    public int? StatusId { get; set; }

    public DateTime? DateUpdated { get; set; }
}
