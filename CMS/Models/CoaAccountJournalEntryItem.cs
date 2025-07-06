using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class CoaAccountJournalEntryItem
{
    public int EntryItemId { get; set; }

    public int EntryFk { get; set; }

    public int JournalFk { get; set; }

    public int AccountFk { get; set; }

    public string ItemRefNo { get; set; }

    public string ItemDesc { get; set; }

    public DateOnly ItemDate { get; set; }

    public double? CreditAmount { get; set; }

    public double? DebitAmount { get; set; }

    public bool Blocked { get; set; }

    public int? EntryItemReconcileFk { get; set; }

    public string CreatedBy { get; set; }

    public DateOnly CreatedDate { get; set; }

    public string UpdatedBy { get; set; }

    public DateOnly? UpdatedDate { get; set; }

    public virtual CoaAccount AccountFkNavigation { get; set; }

    public virtual CoaAccountJournalEntry EntryFkNavigation { get; set; }

    public virtual CoaAccountJournalEntryItemReconcile EntryItemReconcileFkNavigation { get; set; }

    public virtual CoaAccountJournal JournalFkNavigation { get; set; }
}
