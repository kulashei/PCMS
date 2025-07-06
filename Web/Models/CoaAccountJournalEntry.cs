using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class CoaAccountJournalEntry
{
    public int EntryId { get; set; }

    public int JournalFk { get; set; }

    public int FiscalPeriodFk { get; set; }

    public string RefNo { get; set; }

    public string EntryDesc { get; set; }

    public DateOnly EntryDate { get; set; }

    public string EntryState { get; set; }

    public double Balance { get; set; }

    public bool Edittable { get; set; }

    public string CreatedBy { get; set; }

    public DateOnly CreatedDate { get; set; }

    public string UpdatedBy { get; set; }

    public DateOnly? UpdatedDate { get; set; }

    public virtual ICollection<CoaAccountJournalEntryItem> CoaAccountJournalEntryItems { get; set; } = new List<CoaAccountJournalEntryItem>();

    public virtual CoaAccountPeriod FiscalPeriodFkNavigation { get; set; }

    public virtual CoaAccountJournal JournalFkNavigation { get; set; }
}
