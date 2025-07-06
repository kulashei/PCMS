using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class DocumentVersion
{
    public int Id { get; set; }

    public int DocumentId { get; set; }

    public bool Active { get; set; }

    public int Vs { get; set; }

    public double Size { get; set; }

    public string VsPath { get; set; }

    public string Comments { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public byte[] VsSourceData { get; set; }

    public virtual Document Document { get; set; }

    public virtual ICollection<Document> Documents { get; set; } = new List<Document>();
}
