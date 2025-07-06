using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class Photograph
{
    public int PhotographId { get; set; }

    public int ContractFk { get; set; }

    public string PhotoName { get; set; }

    public string PhotoTitle { get; set; }

    public string PhotoDesc { get; set; }

    public string PhotoExt { get; set; }

    public string PhotoMime { get; set; }

    public string PhotoUrl { get; set; }

    public bool Active { get; set; }

    public byte[] PhotoData { get; set; }
}
