using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class TicketNote
{
    public int Id { get; set; }

    public int TicketId { get; set; }

    public string Status { get; set; }

    public string Author { get; set; }

    public string Receiva { get; set; }

    public string Msg { get; set; }

    public string Cate { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual Ticket Ticket { get; set; }
}
