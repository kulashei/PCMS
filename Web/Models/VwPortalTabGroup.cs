using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class VwPortalTabGroup
{
    public int TabId { get; set; }

    public string TabName { get; set; }

    public int TabOrdar { get; set; }

    public bool TabActive { get; set; }

    public string TabDisc { get; set; }

    public int GroupId { get; set; }

    public string GroupName { get; set; }

    public int GroupOrdar { get; set; }

    public bool GroupActive { get; set; }

    public int IconId { get; set; }

    public string IconName { get; set; }

    public string IconUrl { get; set; }

    public string IconAlt { get; set; }

    public int HovaId { get; set; }

    public string HovaName { get; set; }

    public string HovaUrl { get; set; }

    public string HovaAlt { get; set; }

    public int PortalId { get; set; }

    public string PortalName { get; set; }

    public bool PortalActive { get; set; }
}
