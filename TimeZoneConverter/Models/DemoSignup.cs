using System;
using System.Collections.Generic;

namespace TimeZoneConverter.Models;

public partial class DemoSignup
{
    public Guid? Id { get; set; }

    public string AdminName { get; set; } = null!;

    public string AdminEmail { get; set; } = null!;

    public string? AdminPhone { get; set; }

    public string OrganisationName { get; set; } = null!;

    public string County { get; set; } = null!;
}
