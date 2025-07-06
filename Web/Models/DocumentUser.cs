using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class DocumentUser
{
    public int Id { get; set; }

    public int DocumentId { get; set; }

    public int UserId { get; set; }

    public bool Modify { get; set; }

    public bool Dilete { get; set; }

    public virtual Document Document { get; set; }

    public virtual PortalUser User { get; set; }
}
