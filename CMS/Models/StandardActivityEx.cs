using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class StandardActivityEx
{
    public int Id { get; set; }

    public int ParentAct { get; set; }

    public int SubAct { get; set; }

    public virtual StandardActivity ParentActNavigation { get; set; }

    public virtual StandardActivity SubActNavigation { get; set; }
}
