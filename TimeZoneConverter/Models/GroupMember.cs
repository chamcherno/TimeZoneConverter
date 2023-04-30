using System;
using System.Collections.Generic;

namespace TimeZoneConverter.Models;

public partial class GroupMember
{
    public long GroupMemberId { get; set; }

    public long GroupId { get; set; }

    public string UserId { get; set; } = null!;

    public DateTime CreatedOn { get; set; }
}
