using System;
using System.Collections.Generic;

namespace TimeZoneConverter.Models;

public partial class DefinedSector
{
    public long Id { get; set; }

    public long WheelId { get; set; }

    public long? SectorPosition { get; set; }

    public string? SectorLabel { get; set; }

    public long SectorColour { get; set; }

    public long? OldSectorId { get; set; }

    public bool IsDeleted { get; set; }
}
