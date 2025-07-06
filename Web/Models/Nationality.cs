using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class Nationality
{
    public int NationalityId { get; set; }

    public string NationalityName { get; set; }

    public string CountryName { get; set; }
}
