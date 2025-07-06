using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class DocumentFolderUser
{
    public int Id { get; set; }

    public int FolderId { get; set; }

    public int UserId { get; set; }

    public bool Modify { get; set; }

    public bool Dilete { get; set; }

    public virtual DocumentFolder Folder { get; set; }

    public virtual PortalUser User { get; set; }
}
