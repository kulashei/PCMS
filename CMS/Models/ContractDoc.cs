using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class ContractDoc
{
    public int Id { get; set; }

    public int ContractFk { get; set; }

    public int CatFk { get; set; }

    public string Name { get; set; }

    public string FlPath { get; set; }

    public string Remarks { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedAt { get; set; }

    public bool Baked { get; set; }

    public virtual ContractDocCat CatFkNavigation { get; set; }

    public virtual Contract ContractFkNavigation { get; set; }
}
