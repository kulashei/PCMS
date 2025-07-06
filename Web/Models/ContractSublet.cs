using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class ContractSublet
{
    public int Id { get; set; }

    public int ContractFk { get; set; }

    public int ContractorFk { get; set; }

    public double GrossAmount { get; set; }

    public double GrossRet { get; set; }

    public double NetAmount { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public virtual ICollection<BoqSublet> BoqSublets { get; set; } = new List<BoqSublet>();

    public virtual Contract ContractFkNavigation { get; set; }

    public virtual Contractor ContractorFkNavigation { get; set; }
}
