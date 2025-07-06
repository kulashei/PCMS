using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class BoqPafExcept
{
    public int ActivityFk { get; set; }

    public virtual StandardActivity ActivityFkNavigation { get; set; }
}
