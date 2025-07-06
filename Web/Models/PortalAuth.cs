using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class PortalAuth
{
    public int Id { get; set; }

    public int? PortalFk { get; set; }

    public int? UserFk { get; set; }

    public bool? Success { get; set; }

    public DateTime? Access { get; set; }

    public string Ip { get; set; }

    public string Comp { get; set; }

    public string SessionId { get; set; }

    public virtual PortalUser UserFkNavigation { get; set; }
}
