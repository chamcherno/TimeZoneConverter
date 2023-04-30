using System;
using System.Collections.Generic;

namespace TimeZoneConverter.Models;

public partial class OrganisationProfilePicture
{
    public long Id { get; set; }

    public long OrganisationId { get; set; }

    public bool IsSmall { get; set; }

    public string LinkToImage { get; set; } = null!;

    public bool IsDeleted { get; set; }
}
