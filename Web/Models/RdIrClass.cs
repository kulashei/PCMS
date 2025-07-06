using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class RdIrClass
{
    public int ClassId { get; set; }

    public string ClassCode { get; set; }

    public string ClassDesc { get; set; }

    public virtual ICollection<Road> Roads { get; set; } = new List<Road>();
}
