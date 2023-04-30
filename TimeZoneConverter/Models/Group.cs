using System;
using System.Collections.Generic;

namespace TimeZoneConverter.Models;

public partial class Group
{
    public long Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public long? OrganisationId { get; set; }

    public DateTime CreatedOn { get; set; }

    public bool GlobalGroup { get; set; }

    public bool IsDeleted { get; set; }

    public long? OldGroupId { get; set; }
}
