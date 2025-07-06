using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class VwStandardActivity
{
    public int MajorId { get; set; }

    public string MajorCode { get; set; }

    public string MajorName { get; set; }

    public bool MajorActive { get; set; }

    public string ActOrder { get; set; }

    public int ActId { get; set; }

    public string ActCode { get; set; }

    public string ActName { get; set; }

    public string ActUnit { get; set; }

    public bool ActActive { get; set; }

    public int WeitId { get; set; }

    public string WeitCode { get; set; }

    public string WeitName { get; set; }

    public int ProgressId { get; set; }

    public string ProgressCode { get; set; }

    public string ProgressName { get; set; }

    public string ProgressDesc { get; set; }

    public string ProgressCat { get; set; }

    public string ProgressUnit { get; set; }

    public bool ProgressActive { get; set; }

    public string ProgressRemarks { get; set; }
}
