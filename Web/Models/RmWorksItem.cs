using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class RmWorksItem
{
    public int WorksItemId { get; set; }

    public int WorkFk { get; set; }

    public string WorksItemCode { get; set; }

    public string WorksItemDesc { get; set; }

    public string Unit { get; set; }

    public bool Active { get; set; }

    public virtual RmWork WorkFkNavigation { get; set; }
}
