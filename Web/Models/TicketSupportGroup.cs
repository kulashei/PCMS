using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class TicketSupportGroup
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Desc { get; set; }

    public bool Active { get; set; }

    public int Number { get; set; }

    public virtual ICollection<TicketAProcess> TicketAProcesses { get; set; } = new List<TicketAProcess>();

    public virtual ICollection<TicketSupportGroupUser> TicketSupportGroupUsers { get; set; } = new List<TicketSupportGroupUser>();

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}
