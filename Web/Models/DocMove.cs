using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class DocMove
{
    public int Id { get; set; }

    public int DocId { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public string Remarks { get; set; }

    public string Cat { get; set; }

    public virtual PortalUser CreatedByNavigation { get; set; }
}
