using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class VoextCost
{
    public int Id { get; set; }

    public int ExtFk { get; set; }

    public DateOnly ExtDate { get; set; }

    public virtual Voext ExtFkNavigation { get; set; }
}
