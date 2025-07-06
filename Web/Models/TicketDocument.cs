using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class TicketDocument
{
    public int Id { get; set; }

    public int TicketId { get; set; }

    public string FlName { get; set; }

    public string FlPath { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public bool Baked { get; set; }

    public virtual PortalUser CreatedByNavigation { get; set; }

    public virtual Ticket Ticket { get; set; }
}
