using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class VwDocumentFolder
{
    public int FolderId { get; set; }

    public string FolderName { get; set; }

    public string FolderDesc { get; set; }

    public int Owna { get; set; }

    public string FolderPath { get; set; }

    public string FolderPath2 { get; set; }

    public int SubFolderCount { get; set; }

    public int FileCount { get; set; }

    public double FileSize { get; set; }

    public int StatusId { get; set; }

    public string StatusName { get; set; }

    public int ParentId { get; set; }

    public int? ParentStatusId { get; set; }

    public string ParentName { get; set; }

    public string OwnaName { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public string CreatedName { get; set; }
}
