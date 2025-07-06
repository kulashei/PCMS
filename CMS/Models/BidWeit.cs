using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class BidWeit
{
    public int BidWeitId { get; set; }

    public int BidFk { get; set; }

    public int WeitFk { get; set; }

    public int? ContractFk { get; set; }

    public double X { get; set; }

    public double Ll { get; set; }

    public double Pl { get; set; }

    public double Fu { get; set; }

    public double Bi { get; set; }

    public double Ce { get; set; }

    public double Rs { get; set; }

    public double Ti { get; set; }

    public double Ch { get; set; }

    public double Pc { get; set; }

    public double Ro { get; set; }

    public double Rl { get; set; }

    public double Cb { get; set; }

    public double Pg { get; set; }

    public double Co { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual Bid BidFkNavigation { get; set; }

    public virtual ICollection<BoqPafCalc> BoqPafCalcs { get; set; } = new List<BoqPafCalc>();

    public virtual ICollection<BoqPafWeit> BoqPafWeits { get; set; } = new List<BoqPafWeit>();

    public virtual Contract ContractFkNavigation { get; set; }

    public virtual StandardWeit WeitFkNavigation { get; set; }
}
