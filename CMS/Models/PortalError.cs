using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class PortalError
{
    public int Id { get; set; }

    public DateTime ErrorTime { get; set; }

    public int? ErrorLine { get; set; }

    public string ErrorMessage { get; set; }

    public int? ErrorNumber { get; set; }

    public string ErrorProcedure { get; set; }

    public int? ErrorSeverity { get; set; }

    public string MiscInfo { get; set; }
}
