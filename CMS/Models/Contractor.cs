using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class Contractor
{
    public int ContractorId { get; set; }

    public string TinNo { get; set; }

    public string ContractorName { get; set; }

    public string Address { get; set; }

    public string ContactPerson { get; set; }

    public string Email { get; set; }

    public string Phone { get; set; }

    public string Type { get; set; }

    public string Classification { get; set; }

    public DateTime? ExpirationDate { get; set; }

    public virtual ICollection<BidSublet> BidSublets { get; set; } = new List<BidSublet>();

    public virtual ICollection<Bidder> Bidders { get; set; } = new List<Bidder>();

    public virtual ICollection<ContractSublet> ContractSublets { get; set; } = new List<ContractSublet>();

    public virtual ICollection<ContractorBank> ContractorBanks { get; set; } = new List<ContractorBank>();

    public virtual ICollection<Contract> Contracts { get; set; } = new List<Contract>();
}
