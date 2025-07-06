using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class ResDeptFlow
{
    public int SourceId { get; set; }

    public int DestinationId { get; set; }

    public virtual ResDept Source { get; set; }
}
