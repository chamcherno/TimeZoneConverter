using System;
using System.Collections.Generic;

namespace TimeZoneConverter.Models;

public partial class NotificationTemplate
{
    public long NotificationTemplateId { get; set; }

    public string Message { get; set; } = null!;

    public long? OrganisationId { get; set; }

    public bool IsDeleted { get; set; }

    public int SortOrder { get; set; }
}
