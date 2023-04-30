using System;
using System.Collections.Generic;

namespace TimeZoneConverter.Models;

public partial class OrganisationWheelDescription
{
    public long Id { get; set; }

    public long WheelId { get; set; }

    public long OrganisationId { get; set; }

    public string DescriptionHtml { get; set; } = null!;

    public DateTime CreatedOn { get; set; }
}
