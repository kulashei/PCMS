using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class TicketEscalated
{
    public int Id { get; set; }

    public int TicketId { get; set; }

    public int RecevaId { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public string Reason { get; set; }

    public virtual PortalUser CreatedByNavigation { get; set; }

    public virtual PortalUser Receva { get; set; }

    public virtual Ticket Ticket { get; set; }
}
