using System;
using System.Collections.Generic;

namespace TimeZoneConverter.Models;

public partial class Theme
{
    public Guid ThemeId { get; set; }

    public string ThemeName { get; set; } = null!;
}
