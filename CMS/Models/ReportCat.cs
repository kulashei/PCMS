using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class ReportCat
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Desc { get; set; }

    public bool Active { get; set; }

    public int ModuleFk { get; set; }

    public virtual PortalModule ModuleFkNavigation { get; set; }

    public virtual ICollection<Report> Reports { get; set; } = new List<Report>();
}
