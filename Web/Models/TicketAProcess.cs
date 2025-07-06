using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class TicketAProcess
{
    public int TicketId { get; set; }

    public int ProcessedBy { get; set; }

    public DateTime ProcessedDate { get; set; }

    public int OwnerId { get; set; }

    public int PriorityId { get; set; }

    public int CategoryId { get; set; }

    public int SupportGroupId { get; set; }

    public DateOnly SupportGroupExpiryDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual TicketCategory Category { get; set; }

    public virtual PortalUser Owner { get; set; }

    public virtual TicketPriority Priority { get; set; }

    public virtual PortalUser ProcessedByNavigation { get; set; }

    public virtual TicketSupportGroup SupportGroup { get; set; }

    public virtual Ticket Ticket { get; set; }
}
