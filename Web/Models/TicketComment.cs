using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class TicketComment
{
    public int Id { get; set; }

    public int TicketId { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public string Comments { get; set; }

    public virtual PortalUser CreatedByNavigation { get; set; }

    public virtual Ticket Ticket { get; set; }
}
