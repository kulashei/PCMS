using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class DocPoss
{
    public int Id { get; set; }

    public int DocId { get; set; }

    public int InitId { get; set; }

    public int DestId { get; set; }

    public string Cat { get; set; }

    public string Remarks { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual PortalUser Dest { get; set; }

    public virtual PortalUser Init { get; set; }
}
