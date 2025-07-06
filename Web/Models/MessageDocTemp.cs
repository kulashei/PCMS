using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class MessageDocTemp
{
    public int Id { get; set; }

    public string Grope { get; set; }

    public string Pathe { get; set; }

    public string Name { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedAt { get; set; }
}
