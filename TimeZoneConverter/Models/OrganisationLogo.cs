using System;
using System.Collections.Generic;

namespace TimeZoneConverter.Models;

public partial class OrganisationLogo
{
    public long Id { get; set; }

    public long OrganisationId { get; set; }

    public string Logo { get; set; } = null!;

    public long AttachmentTypeId { get; set; }

    public DateTime CreatedOn { get; set; }
}
