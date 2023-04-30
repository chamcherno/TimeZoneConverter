using System;
using System.Collections.Generic;

namespace TimeZoneConverter.Models;

public partial class UserProfilePicture
{
    public long Id { get; set; }

    public string UserId { get; set; } = null!;

    public bool IsSmall { get; set; }

    public string LinkToImage { get; set; } = null!;

    public bool IsDeleted { get; set; }
}
