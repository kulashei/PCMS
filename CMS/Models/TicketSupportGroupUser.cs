using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class TicketSupportGroupUser
{
    public int Id { get; set; }

    public int GroupId { get; set; }

    public int UserId { get; set; }

    public virtual TicketSupportGroup Group { get; set; }

    public virtual PortalUser User { get; set; }
}
