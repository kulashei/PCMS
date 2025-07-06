using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class DocumentFolderRole
{
    public int Id { get; set; }

    public int FolderId { get; set; }

    public int RoleId { get; set; }

    public bool Modify { get; set; }

    public bool Dilete { get; set; }

    public virtual DocumentFolder Folder { get; set; }

    public virtual PortalRole Role { get; set; }
}
