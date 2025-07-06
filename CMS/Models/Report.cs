using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class Report
{
    public int Id { get; set; }

    public string Code { get; set; }

    public int CatFk { get; set; }

    public string Name { get; set; }

    public string Desc { get; set; }

    public string Url { get; set; }

    public bool Active { get; set; }

    public int Orda { get; set; }

    public virtual ReportCat CatFkNavigation { get; set; }

    public virtual ICollection<ReportRole> ReportRoles { get; set; } = new List<ReportRole>();
}
