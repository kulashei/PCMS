using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class VwStandarddaywork
{
    public int CatId { get; set; }

    public string CatCode { get; set; }

    public string CatName { get; set; }

    public string CatCodeName { get; set; }

    public int DayWorkId { get; set; }

    public string DayWorkCode { get; set; }

    public string DayWorkName { get; set; }

    public string DayWorkUnit { get; set; }

    public string DayWorkCodeName { get; set; }
}
