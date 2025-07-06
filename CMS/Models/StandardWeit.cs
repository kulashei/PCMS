using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class StandardWeit
{
    public int Id { get; set; }

    public string Code { get; set; }

    public string Name { get; set; }

    public double? X { get; set; }

    public double? Ll { get; set; }

    public double? Pl { get; set; }

    public double? Fu { get; set; }

    public double? Bi { get; set; }

    public double? Ce { get; set; }

    public double? Rs { get; set; }

    public double? Ti { get; set; }

    public double? Ch { get; set; }

    public double? Pc { get; set; }

    public double? Ro { get; set; }

    public double? Rl { get; set; }

    public double? Cb { get; set; }

    public double? Pg { get; set; }

    public double? Co { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual ICollection<BidWeit> BidWeits { get; set; } = new List<BidWeit>();

    public virtual ICollection<ContractAct> ContractActs { get; set; } = new List<ContractAct>();

    public virtual ICollection<VoAct> VoActs { get; set; } = new List<VoAct>();
}
