using System;
using System.Collections.Generic;

namespace TimeZoneConverter.Models;

public partial class WheelCategory
{
    public long WheelCategoryId { get; set; }

    public long CategoryId { get; set; }

    public long WheelId { get; set; }

    public bool IsActive { get; set; }

    public long? SubCategoryId { get; set; }
}
