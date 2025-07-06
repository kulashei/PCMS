using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class PortalPageCate
{
    public int Id { get; set; }

    public string Name { get; set; }

    public virtual ICollection<PortalTab> TabFks { get; set; } = new List<PortalTab>();
}
