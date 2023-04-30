using System;
using System.Collections.Generic;

namespace TimeZoneConverter.Models;

public partial class WheelOrganisation
{
    public long WheelOrganisationId { get; set; }

    public long WheelId { get; set; }

    public long OrganisationId { get; set; }

    public bool IsDeleted { get; set; }
}
