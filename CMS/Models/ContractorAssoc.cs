using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class ContractorAssoc
{
    public int AssociationId { get; set; }

    public string AssocCode { get; set; }

    public string AssocDesc { get; set; }

    public double AssocRate { get; set; }
}
