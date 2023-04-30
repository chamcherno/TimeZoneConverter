using System;
using System.Collections.Generic;

namespace TimeZoneConverter.Models;

public partial class SiteErrorLog
{
    public Guid Id { get; set; }

    public DateTime? DateRecorded { get; set; }

    public string? StackTrace { get; set; }

    public string? Message { get; set; }

    public string? TargetSite { get; set; }

    public string? Type { get; set; }

    public string? InnerExceptionMessage { get; set; }

    public string? InnerExceptionStackTrace { get; set; }

    public string? InnerExceptionType { get; set; }

    public string? Origin { get; set; }

    public string? Userhostip { get; set; }

    public string? Statuscode { get; set; }

    public Guid? Userid { get; set; }

    public string? Useragent { get; set; }

    public string? Httpmethod { get; set; }

    public string? Contenttype { get; set; }
}
