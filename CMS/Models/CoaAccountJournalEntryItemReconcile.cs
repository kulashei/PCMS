using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class CoaAccountJournalEntryItemReconcile
{
    public int EntryItemReconcileId { get; set; }

    public int TransCount { get; set; }

    public double Credits { get; set; }

    public double Debits { get; set; }

    public double WriteOff { get; set; }

    public string RefName { get; set; }

    public string EntryType { get; set; }

    public bool OpenReconciliation { get; set; }

    public string CreatedBy { get; set; }

    public DateOnly CreatedDate { get; set; }

    public string UpdatedBy { get; set; }

    public DateOnly? UpdatedDate { get; set; }

    public virtual ICollection<CoaAccountJournalEntryItem> CoaAccountJournalEntryItems { get; set; } = new List<CoaAccountJournalEntryItem>();
}
