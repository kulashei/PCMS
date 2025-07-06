using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class VoDocument
{
    public int FileId { get; set; }

    public int VoFk { get; set; }

    public string DocName { get; set; }

    public string FilePath { get; set; }

    public string Remarks { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public bool Baked { get; set; }

    public bool Afta { get; set; }

    public virtual Vo VoFkNavigation { get; set; }
}
