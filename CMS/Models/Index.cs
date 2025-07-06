using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class Index
{
    public int IndicesId { get; set; }

    public bool Editable { get; set; }

    public DateOnly Date { get; set; }

    public double Ll { get; set; }

    public double Ep { get; set; }

    public double F { get; set; }

    public double B { get; set; }

    public double Ch { get; set; }

    public double Re { get; set; }

    public double Ce { get; set; }

    public double Co { get; set; }

    public double Cogoods { get; set; }

    public double Fe { get; set; }

    public double Epnew { get; set; }

    public double Tinew { get; set; }

    public double Ronew { get; set; }

    public double Rlnew { get; set; }

    public double Cbnew { get; set; }

    public double Pgnew { get; set; }

    public double Pc { get; set; }
}
