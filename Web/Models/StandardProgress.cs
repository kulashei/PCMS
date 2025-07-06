using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class StandardProgress
{
    public int StandardProgressId { get; set; }

    public string ProgressCode { get; set; }

    public string ProgressName { get; set; }

    public string ProgressDesc { get; set; }

    public string Pfcode { get; set; }

    public string Unit { get; set; }

    public string Remarks { get; set; }

    public bool Active { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public int CatFk { get; set; }

    public virtual StandardProgressCat CatFkNavigation { get; set; }

    public virtual ICollection<ContractProgress> ContractProgresses { get; set; } = new List<ContractProgress>();

    public virtual ICollection<VoAct> VoActs { get; set; } = new List<VoAct>();

    public virtual ICollection<VoProgress> VoProgresses { get; set; } = new List<VoProgress>();
}
