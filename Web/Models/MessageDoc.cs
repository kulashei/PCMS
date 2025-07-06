using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class MessageDoc
{
    public int Id { get; set; }

    public int MessageFk { get; set; }

    public string Code { get; set; }

    public string Name { get; set; }

    public bool Baked { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual Massage MessageFkNavigation { get; set; }
}
