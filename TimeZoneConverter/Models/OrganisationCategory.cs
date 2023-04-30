using System;
using System.Collections.Generic;

namespace TimeZoneConverter.Models;

public partial class OrganisationCategory
{
    public long OrganisationCategoryId { get; set; }

    public long OrganisationId { get; set; }

    public long CategoryId { get; set; }

    public long? SubCategoryId { get; set; }

    public bool IsActive { get; set; }
}
