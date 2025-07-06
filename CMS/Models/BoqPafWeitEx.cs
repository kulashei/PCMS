using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class BoqPafWeitEx
{
    public int ContractFk { get; set; }

    public virtual Contract ContractFkNavigation { get; set; }
}
