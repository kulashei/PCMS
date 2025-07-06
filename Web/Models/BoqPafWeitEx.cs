using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class BoqPafWeitEx
{
    public int ContractFk { get; set; }

    public virtual Contract ContractFkNavigation { get; set; }
}
