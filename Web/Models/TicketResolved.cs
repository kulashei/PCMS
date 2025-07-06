using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class TicketResolved
{
    public int Id { get; set; }

    public int TicketId { get; set; }

    public int ResolverId { get; set; }

    public string Resolution { get; set; }

    public DateOnly? ResolvedDate { get; set; }

    public bool Confirmed { get; set; }

    public DateTime? ConfirmedDate { get; set; }

    public bool Reopened { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public int? UpatedBy { get; set; }

    public DateTime? UpatedAt { get; set; }

    public virtual PortalUser Resolver { get; set; }

    public virtual Ticket Ticket { get; set; }

    public virtual ICollection<TicketReopen> TicketReopens { get; set; } = new List<TicketReopen>();
}
