using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class TicketStatus
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Desc { get; set; }

    public string SmsMsg { get; set; }

    public string EmailMsg { get; set; }

    public virtual ICollection<Ticket> Tickets { get; set; } = new List<Ticket>();
}
