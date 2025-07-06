using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class PortalTab
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int Ordar { get; set; }

    public bool Active { get; set; }

    public int PortalFk { get; set; }

    public int ParentFk { get; set; }

    public int ModuleFk { get; set; }

    public string Disc { get; set; }

    public int MenuFk { get; set; }

    public int HoverFk { get; set; }

    public int GroupFk { get; set; }

    public virtual PortalTabGroup GroupFkNavigation { get; set; }

    public virtual PortalIcon HoverFkNavigation { get; set; }

    public virtual PortalIcon MenuFkNavigation { get; set; }

    public virtual PortalModule ModuleFkNavigation { get; set; }

    public virtual ICollection<PortalAuthTab> PortalAuthTabParentFkNavigations { get; set; } = new List<PortalAuthTab>();

    public virtual ICollection<PortalAuthTab> PortalAuthTabTabFkNavigations { get; set; } = new List<PortalAuthTab>();

    public virtual Portal PortalFkNavigation { get; set; }

    public virtual ICollection<PortalTabRole> PortalTabRoles { get; set; } = new List<PortalTabRole>();

    public virtual ICollection<PortalPageCate> CatFks { get; set; } = new List<PortalPageCate>();
}
