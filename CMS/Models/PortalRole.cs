using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class PortalRole
{
    public int Id { get; set; }

    public string Name { get; set; }

    public virtual ICollection<DocumentFolderRole> DocumentFolderRoles { get; set; } = new List<DocumentFolderRole>();

    public virtual ICollection<PortalAuthTab> PortalAuthTabs { get; set; } = new List<PortalAuthTab>();

    public virtual ICollection<PortalTabRole> PortalTabRoles { get; set; } = new List<PortalTabRole>();

    public virtual ICollection<PortalUserRole> PortalUserRoles { get; set; } = new List<PortalUserRole>();

    public virtual ICollection<ReportRole> ReportRoles { get; set; } = new List<ReportRole>();
}
