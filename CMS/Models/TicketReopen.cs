using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class TicketReopen
{
    public int Id { get; set; }

    public int ResolvedId { get; set; }

    public int ReopenBy { get; set; }

    public DateTime ReopenDate { get; set; }

    public string Reason { get; set; }

    public virtual PortalUser ReopenByNavigation { get; set; }

    public virtual TicketResolved Resolved { get; set; }
}
