using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class DocumentStatus
{
    public int Id { get; set; }

    public string Name { get; set; }

    public virtual ICollection<DocumentFolder> DocumentFolders { get; set; } = new List<DocumentFolder>();

    public virtual ICollection<Document> Documents { get; set; } = new List<Document>();
}
