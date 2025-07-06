using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class VoProgress
{
    public int VoProgressId { get; set; }

    public int VoFk { get; set; }

    public int? VoBaseFk { get; set; }

    public int? BidBaseFk { get; set; }

    public int? ContractProgressFk { get; set; }

    public int StandardProgressFk { get; set; }

    public string Unit { get; set; }

    public double PrevSchedule { get; set; }

    public double CurrSchedule { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual BidBase BidBaseFkNavigation { get; set; }

    public virtual ContractProgress ContractProgressFkNavigation { get; set; }

    public virtual StandardProgress StandardProgressFkNavigation { get; set; }

    public virtual VoBase VoBaseFkNavigation { get; set; }

    public virtual Vo VoFkNavigation { get; set; }
}
