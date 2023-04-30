using System;
using System.Collections.Generic;

namespace TimeZoneConverter.Models;

public partial class DefinedBlocksOption
{
    public long Id { get; set; }

    public long WheelBlockId { get; set; }

    public string StatementOption { get; set; } = null!;

    public int Position { get; set; }

    public bool IsDeleted { get; set; }
}
