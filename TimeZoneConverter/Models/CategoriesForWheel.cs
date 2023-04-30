using System;
using System.Collections.Generic;

namespace TimeZoneConverter.Models;

public partial class CategoriesForWheel
{
    public long Id { get; set; }

    public string CategoryName { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public DateTime CreatedOn { get; set; }
}
