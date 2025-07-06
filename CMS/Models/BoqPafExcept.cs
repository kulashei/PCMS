using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class BoqPafExcept
{
    public int ActivityFk { get; set; }

    public virtual StandardActivity ActivityFkNavigation { get; set; }
}
