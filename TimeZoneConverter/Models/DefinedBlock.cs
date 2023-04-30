using System;
using System.Collections.Generic;

namespace TimeZoneConverter.Models;

public partial class DefinedBlock
{
    public long Id { get; set; }

    public long SubSectorId { get; set; }

    public string? Label { get; set; }

    public long? AgeGroupId { get; set; }

    public string? Body { get; set; }

    public short? Position { get; set; }

    public string? LevelInfo { get; set; }

    public long? OldBlockId { get; set; }

    public bool IsDeleted { get; set; }
}
