using System;
using System.Collections.Generic;

namespace TimeZoneConverter.Models;

public partial class WheelExcelExport
{
    public long Id { get; set; }

    public string PersonId { get; set; } = null!;

    public string S3parentFolderGuid { get; set; } = null!;

    public string S3link { get; set; } = null!;

    public bool IsValid { get; set; }

    public DateTime CreatedOn { get; set; }
}
