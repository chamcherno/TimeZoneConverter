using System;
using System.Collections.Generic;

namespace TimeZoneConverter.Models;

public partial class DefinedSubSector
{
    public long Id { get; set; }

    public long SectorId { get; set; }

    public string? Label { get; set; }

    public long? Position { get; set; }

    public long? Colour { get; set; }

    public string? OldSubSectorId { get; set; }

    public bool IsDeleted { get; set; }
}
