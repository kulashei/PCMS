using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class PortalSetting
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Value { get; set; }

    public string Disc { get; set; }
}
