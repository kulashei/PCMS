using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class CoaAccount
{
    public int AccountId { get; set; }

    public string AccountCode { get; set; }

    public string AccountDesc { get; set; }

    public int? NodeLevel { get; set; }

    public int? ParentAccountId { get; set; }

    public bool IsHeader { get; set; }

    public bool Active { get; set; }

    public virtual ICollection<CoaAccountJournal> CoaAccountJournalCreditAccountFkNavigations { get; set; } = new List<CoaAccountJournal>();

    public virtual ICollection<CoaAccountJournal> CoaAccountJournalDebitAccountFkNavigations { get; set; } = new List<CoaAccountJournal>();

    public virtual ICollection<CoaAccountJournalEntryItem> CoaAccountJournalEntryItems { get; set; } = new List<CoaAccountJournalEntryItem>();

    public virtual ICollection<CoaAsset> CoaAssets { get; set; } = new List<CoaAsset>();

    public virtual ICollection<CoaExpenditure> CoaExpenditures { get; set; } = new List<CoaExpenditure>();

    public virtual ICollection<CoaLiability> CoaLiabilities { get; set; } = new List<CoaLiability>();

    public virtual ICollection<CoaRevenue> CoaRevenues { get; set; } = new List<CoaRevenue>();

    public virtual ICollection<CoaAccount> InverseParentAccount { get; set; } = new List<CoaAccount>();

    public virtual CoaAccount ParentAccount { get; set; }
}
