using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class PortalUserFlow
{
    public int Id { get; set; }

    public int Sourx { get; set; }

    public int Dest { get; set; }

    public string Reason { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }
}
