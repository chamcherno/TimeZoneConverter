using System;
using System.Collections.Generic;

namespace TimeZoneConverter.Models;

public partial class OrgRoleAlias
{
    public long Id { get; set; }

    public string? RoleId { get; set; }

    public string? NewAlias { get; set; }

    public long? OrganisationId { get; set; }

    public long? WheelId { get; set; }

    public bool IsActive { get; set; }

    public DateTime CreatedOn { get; set; }
}
