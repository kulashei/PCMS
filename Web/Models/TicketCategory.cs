using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class TicketCategory
{
    public int Id { get; set; }

    public string Name { get; set; }

    public virtual ICollection<TicketAProcess> TicketAProcesses { get; set; } = new List<TicketAProcess>();

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}
