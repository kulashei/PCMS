using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class VwDocument
{
    public int DocumentId { get; set; }

    public string Subj { get; set; }

    public string Title { get; set; }

    public string Brief { get; set; }

    public string Ref { get; set; }

    public int? VersionId { get; set; }

    public int VsNo { get; set; }

    public double VsSize { get; set; }

    public string VsPath { get; set; }

    public int FolderId { get; set; }

    public string FolderName { get; set; }

    public string FolderDesc { get; set; }

    public string FolderPath { get; set; }

    public int FolderParentId { get; set; }

    public int StatusId { get; set; }

    public string StatusName { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public string CreatedName { get; set; }

    public int? LastUpdatedBy { get; set; }

    public DateTime? LastUpdatedAt { get; set; }

    public string LastUpdatedName { get; set; }

    public int? LastAccessedBy { get; set; }

    public DateTime? LastAccessedAt { get; set; }

    public string LastAccessedName { get; set; }

    public bool CheckedOut { get; set; }

    public DateTime? CheckedOutDate { get; set; }

    public int? CheckedOutBy { get; set; }

    public string CheckedOutName { get; set; }
}
