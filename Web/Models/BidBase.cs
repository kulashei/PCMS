using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class BidBase
{
    public int BidBaseId { get; set; }

    public int? BidFk { get; set; }

    public int? ContractFk { get; set; }

    public int AssemblyFk { get; set; }

    public int RoadFk { get; set; }

    public int CatFk { get; set; }

    public int ContractTypeFk { get; set; }

    public int Namba { get; set; }

    /// <summary>
    /// This represents the Road or Bridge or component number or ID
    /// </summary>
    public string BaseNo { get; set; }

    /// <summary>
    /// This is the component tile of d road or river name
    /// </summary>
    public string BaseTitle { get; set; }

    public int Culverts { get; set; }

    /// <summary>
    /// This is the Road Length(km) or Bridge Length (m)
    /// </summary>
    public double Distance { get; set; }

    /// <summary>
    /// The is the start section of the Road but will be zero 4 Bridge
    /// </summary>
    public double DistStart { get; set; }

    /// <summary>
    /// The is the end section of the Road but in Bridge it is the No. of Spans
    /// </summary>
    public double DistEnd { get; set; }

    public string Notes { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Assembly AssemblyFkNavigation { get; set; }

    public virtual ICollection<BidBill> BidBills { get; set; } = new List<BidBill>();

    public virtual BidClone BidCloneDestinationFkNavigation { get; set; }

    public virtual ICollection<BidClone> BidCloneSourceFkNavigations { get; set; } = new List<BidClone>();

    public virtual ICollection<BidDaywork> BidDayworks { get; set; } = new List<BidDaywork>();

    public virtual Bid BidFkNavigation { get; set; }

    public virtual ICollection<ContractDaywork> ContractDayworks { get; set; } = new List<ContractDaywork>();

    public virtual Contract ContractFkNavigation { get; set; }

    public virtual ICollection<ContractProgress> ContractProgresses { get; set; } = new List<ContractProgress>();

    public virtual ContractType ContractTypeFkNavigation { get; set; }

    public virtual PortalUser CreatedByNavigation { get; set; }

    public virtual Road RoadFkNavigation { get; set; }

    public virtual ICollection<VoBase> VoBases { get; set; } = new List<VoBase>();

    public virtual ICollection<VoBill> VoBills { get; set; } = new List<VoBill>();

    public virtual ICollection<VoProgress> VoProgresses { get; set; } = new List<VoProgress>();
}
