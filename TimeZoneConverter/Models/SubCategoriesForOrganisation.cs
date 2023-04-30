using System;
using System.Collections.Generic;

namespace TimeZoneConverter.Models;

public partial class SubCategoriesForOrganisation
{
    public long Id { get; set; }

    public long CategoryId { get; set; }

    public string SubCategoryName { get; set; } = null!;

    public bool IsDeleted { get; set; }

    public DateTime CreatedOn { get; set; }
}
