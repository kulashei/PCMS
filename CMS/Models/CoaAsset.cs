using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class CoaAsset
{
    public int AssetId { get; set; }

    public int AccountFk { get; set; }

    public double Amount { get; set; }

    public DateTime AssetDate { get; set; }

    public string AssetRefNo { get; set; }

    public string AssetDesc { get; set; }

    public string Remarks { get; set; }

    public string CreatedBy { get; set; }

    public DateTime CreatedDate { get; set; }

    public string UpdatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public virtual CoaAccount AccountFkNavigation { get; set; }
}
