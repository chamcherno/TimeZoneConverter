using System;
using System.Collections.Generic;

namespace TimeZoneConverter.Models;

public partial class UserConnection
{
    public long Id { get; set; }

    public string UserId { get; set; } = null!;

    public string ConnectionId { get; set; } = null!;

    public DateTime CreatedOn { get; set; }
}
