﻿using System;
using System.Collections.Generic;

namespace TimeZoneConverter.Models;

public partial class OrgAssessmentAlias
{
    public long Id { get; set; }

    public long OrganisationId { get; set; }

    public long? WheelId { get; set; }

    public string NewAssessmentAlias { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime CreatedOn { get; set; }
}
