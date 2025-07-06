using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class ContractProgress
{
    public int ContractProgressId { get; set; }

    public int ContractFk { get; set; }

    public int? BidBaseFk { get; set; }

    public int StandardProgressFk { get; set; }

    public string Unit { get; set; }

    public double PlannedSchedule { get; set; }

    public double VoSchedule { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public virtual BidBase BidBaseFkNavigation { get; set; }

    public virtual ICollection<BoqProgress> BoqProgresses { get; set; } = new List<BoqProgress>();

    public virtual ICollection<ContractAct> ContractActs { get; set; } = new List<ContractAct>();

    public virtual Contract ContractFkNavigation { get; set; }

    public virtual StandardProgress StandardProgressFkNavigation { get; set; }

    public virtual ICollection<VoAct> VoActs { get; set; } = new List<VoAct>();

    public virtual ICollection<VoProgress> VoProgresses { get; set; } = new List<VoProgress>();
}
