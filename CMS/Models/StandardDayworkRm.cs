using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class StandardDayworkRm
{
    public int Id { get; set; }

    public int CatFk { get; set; }

    public string Code { get; set; }

    public string Name { get; set; }

    public string Unit { get; set; }

    public virtual StandardDayworkEx CatFkNavigation { get; set; }
}
