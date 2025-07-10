﻿using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class PortalTabRole
{
    public int Id { get; set; }

    public int TabFk { get; set; }

    public int RoleFk { get; set; }

    public bool Created { get; set; }

    public bool Updated { get; set; }

    public bool Deleted { get; set; }

    public bool Viewed { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? ModifiedBy { get; set; }

    public DateTime? ModifiedDate { get; set; }

    public virtual PortalRole RoleFkNavigation { get; set; }

    public virtual PortalTab TabFkNavigation { get; set; }
}
