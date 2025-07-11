using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class VoBase
{
    public int VoBaseId { get; set; }

    public int? BidBaseFk { get; set; }

    public int VoFk { get; set; }

    public int DistrictFk { get; set; }

    public int RoadFk { get; set; }

    public int CatId { get; set; }

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

    public int BaseTypeFk { get; set; }

    public virtual ContractType BaseTypeFkNavigation { get; set; }

    public virtual BidBase BidBaseFkNavigation { get; set; }

    public virtual PortalUser CreatedByNavigation { get; set; }

    public virtual District DistrictFkNavigation { get; set; }

    public virtual Road RoadFkNavigation { get; set; }

    public virtual ICollection<VoBill> VoBills { get; set; } = new List<VoBill>();

    public virtual Vo VoFkNavigation { get; set; }

    public virtual ICollection<VoProgress> VoProgresses { get; set; } = new List<VoProgress>();
}
