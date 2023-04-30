using System;
using System.Collections.Generic;

namespace TimeZoneConverter.Models;

public partial class Notification
{
    public long Id { get; set; }

    public string SenderId { get; set; } = null!;

    public string RecieverId { get; set; } = null!;

    public long? GroupRecieverId { get; set; }

    public long TypeId { get; set; }

    public string Message { get; set; } = null!;

    public bool SoftRead { get; set; }

    public bool IsRead { get; set; }

    public bool IsDeleted { get; set; }

    public DateTime CreatedOn { get; set; }

    public string? Title { get; set; }

    public string? Link { get; set; }
}
