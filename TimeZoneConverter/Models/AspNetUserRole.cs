using System;
using System.Collections.Generic;

namespace TimeZoneConverter.Models;

public partial class AspNetUserRole
{
    public string UserRoleId { get; set; } = null!;

    public string UserId { get; set; } = null!;

    public string RoleId { get; set; } = null!;

    public bool IsDeleted { get; set; }
}
