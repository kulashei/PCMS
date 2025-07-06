using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class PortalAuthTab
{
    public int Id { get; set; }

    public int UserFk { get; set; }

    public int ParentFk { get; set; }

    public int TabFk { get; set; }

    public int RoleFk { get; set; }

    public DateTime CheckedTime { get; set; }

    public string SessionId { get; set; }

    public virtual PortalTab ParentFkNavigation { get; set; }

    public virtual PortalRole RoleFkNavigation { get; set; }

    public virtual PortalTab TabFkNavigation { get; set; }

    public virtual PortalUser UserFkNavigation { get; set; }
}
