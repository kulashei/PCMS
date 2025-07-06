using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class VwStandardProgress
{
    public int ProgressId { get; set; }

    public string ProgressCode { get; set; }

    public string ProgressName { get; set; }

    public string ProgressUnit { get; set; }

    public string ProgressDesc { get; set; }

    public string ProgressRemarks { get; set; }

    public bool ProgressActive { get; set; }

    public string ProgressCat { get; set; }

    public int ProgressCatId { get; set; }

    public string ProgressCatName { get; set; }

    public string ProgressCatRemarks { get; set; }

    public int ProgressCatOrda { get; set; }

    public bool ProgressCatActive { get; set; }
}
