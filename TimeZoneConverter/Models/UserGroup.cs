using System;
using System.Collections.Generic;

namespace TimeZoneConverter.Models;

public partial class UserGroup
{
    public string UserId { get; set; } = null!;

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string Name { get; set; } = null!;

    public long? OrganisationId { get; set; }
}
