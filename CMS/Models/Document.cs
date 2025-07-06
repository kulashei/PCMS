using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class Document
{
    public int Id { get; set; }

    public int FolderId { get; set; }

    public string Subj { get; set; }

    public string Title { get; set; }

    public string Brief { get; set; }

    public string Ref { get; set; }

    public int StatusId { get; set; }

    public int? VersionId { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public int? LastUpdatedBy { get; set; }

    public DateTime? LastUpdatedAt { get; set; }

    public int? LastAccessedBy { get; set; }

    public DateTime? LastAccessedAt { get; set; }

    public bool CheckedOut { get; set; }

    public int? CheckedOutBy { get; set; }

    public DateTime? CheckedOutDate { get; set; }

    public virtual ICollection<DocumentRole> DocumentRoles { get; set; } = new List<DocumentRole>();

    public virtual ICollection<DocumentUser> DocumentUsers { get; set; } = new List<DocumentUser>();

    public virtual ICollection<DocumentVersion> DocumentVersions { get; set; } = new List<DocumentVersion>();

    public virtual DocumentFolder Folder { get; set; }

    public virtual DocumentStatus Status { get; set; }

    public virtual DocumentVersion Version { get; set; }
}
