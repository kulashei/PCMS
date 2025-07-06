using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class ReportRole
{
    public int Id { get; set; }

    public int? ReportFk { get; set; }

    public int? RoleFk { get; set; }

    public virtual Report ReportFkNavigation { get; set; }

    public virtual PortalRole RoleFkNavigation { get; set; }
}
