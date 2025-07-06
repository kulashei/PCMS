using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class BidWeitEx
{
    public int BidFk { get; set; }

    public int? ContractFk { get; set; }

    public string Plchoice { get; set; }

    public string Cochoice { get; set; }

    public virtual Bid BidFkNavigation { get; set; }

    public virtual Contract ContractFkNavigation { get; set; }
}
