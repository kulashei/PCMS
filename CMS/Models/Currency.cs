using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class Currency
{
    public int Id { get; set; }

    public string Code { get; set; }

    public string Description { get; set; }

    public bool DefaultCurrency { get; set; }
}
