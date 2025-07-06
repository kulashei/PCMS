using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class PortalModule
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Url { get; set; }

    public virtual ICollection<PortalTab> PortalTabs { get; set; } = new List<PortalTab>();

    public virtual ICollection<ReportCat> ReportCats { get; set; } = new List<ReportCat>();
}
