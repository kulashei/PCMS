using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class IpcaddOmit
{
    public int Id { get; set; }

    public int ContractFk { get; set; }

    public int BoqFk { get; set; }

    public int CertFk { get; set; }

    public string Cat { get; set; }

    public string AddItem { get; set; }

    public double AddAmnt { get; set; }

    public string OmiItem { get; set; }

    public double OmiAmnt { get; set; }

    public virtual Boq BoqFkNavigation { get; set; }

    public virtual Ipcback CertFkNavigation { get; set; }

    public virtual Contract ContractFkNavigation { get; set; }
}
