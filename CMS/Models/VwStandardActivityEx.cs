using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class VwStandardActivityEx
{
    public int ParentId { get; set; }

    public string ParentCode { get; set; }

    public string ParentName { get; set; }

    public bool ParentActive { get; set; }

    public string ParentDesc { get; set; }

    public string ActOrder { get; set; }

    public int Id { get; set; }

    public int ActId { get; set; }

    public string ActCode { get; set; }

    public string ActName { get; set; }

    public string ActUnit { get; set; }

    public bool ActActive { get; set; }
}
