using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class ContractAdvDoc
{
    public int FileId { get; set; }

    public int ContractFk { get; set; }

    public bool IsPlant { get; set; }

    public string FlName { get; set; }

    public string FlPath { get; set; }

    public string Comment { get; set; }

    public DateOnly DocDate { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }

    public bool Baked { get; set; }

    public virtual Contract ContractFkNavigation { get; set; }
}
