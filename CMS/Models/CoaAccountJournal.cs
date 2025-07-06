using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class CoaAccountJournal
{
    public int JournalId { get; set; }

    public string JournalCode { get; set; }

    public string JournalDesc { get; set; }

    public int DebitAccountFk { get; set; }

    public int CreditAccountFk { get; set; }

    public bool Active { get; set; }

    public virtual ICollection<CoaAccountJournalEntry> CoaAccountJournalEntries { get; set; } = new List<CoaAccountJournalEntry>();

    public virtual ICollection<CoaAccountJournalEntryItem> CoaAccountJournalEntryItems { get; set; } = new List<CoaAccountJournalEntryItem>();

    public virtual CoaAccount CreditAccountFkNavigation { get; set; }

    public virtual CoaAccount DebitAccountFkNavigation { get; set; }
}
