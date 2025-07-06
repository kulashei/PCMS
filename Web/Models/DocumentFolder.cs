using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class DocumentFolder
{
    public int Id { get; set; }

    public string Name { get; set; }

    public string Desc { get; set; }

    public string FlPath { get; set; }

    public int StatusId { get; set; }

    public int ParentId { get; set; }

    public int Owna { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual ICollection<DocumentFolderRole> DocumentFolderRoles { get; set; } = new List<DocumentFolderRole>();

    public virtual ICollection<DocumentFolderUser> DocumentFolderUsers { get; set; } = new List<DocumentFolderUser>();

    public virtual ICollection<Document> Documents { get; set; } = new List<Document>();

    public virtual DocumentStatus Status { get; set; }
}
