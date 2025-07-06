using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class Ticket
{
    public int Id { get; set; }

    public string Code { get; set; }

    public string Email { get; set; }

    public string Phone { get; set; }

    public string Subj { get; set; }

    public string Content { get; set; }

    public bool Editable { get; set; }

    public DateOnly ReceivedAt { get; set; }

    public int StatusId { get; set; }

    public int OwnerId { get; set; }

    public int PriorityId { get; set; }

    public int CategoryId { get; set; }

    public int SupportGroupId { get; set; }

    public DateOnly? SupportGroupExpiryDate { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual TicketCategory Category { get; set; }

    public virtual PortalUser CreatedByNavigation { get; set; }

    public virtual PortalUser Owner { get; set; }

    public virtual TicketPriority Priority { get; set; }

    public virtual TicketStatus Status { get; set; }

    public virtual TicketSupportGroup SupportGroup { get; set; }

    public virtual TicketAProcess TicketAProcess { get; set; }

    public virtual ICollection<TicketComment> TicketComments { get; set; } = new List<TicketComment>();

    public virtual ICollection<TicketDocument> TicketDocuments { get; set; } = new List<TicketDocument>();

    public virtual ICollection<TicketEscalated> TicketEscalateds { get; set; } = new List<TicketEscalated>();

    public virtual ICollection<TicketNote> TicketNotes { get; set; } = new List<TicketNote>();

    public virtual ICollection<TicketResolved> TicketResolveds { get; set; } = new List<TicketResolved>();
}
