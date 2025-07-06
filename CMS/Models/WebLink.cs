using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class WebLink
{
    public int LinkId { get; set; }

    public string LinkTitle { get; set; }

    public string LinkUrl { get; set; }

    public bool Active { get; set; }
}
