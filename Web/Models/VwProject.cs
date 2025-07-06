using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class VwProject
{
    public int ProjectId { get; set; }

    public string ProjectCode { get; set; }

    public string ProjectName { get; set; }

    public string ProjectDesc { get; set; }

    public bool ProjectApproved { get; set; }

    public int ProjectUserId { get; set; }

    public int ProjectTypeId { get; set; }

    public string ProjectTypeName { get; set; }

    public int ProgramId { get; set; }

    public string ProgramCode { get; set; }

    public string ProgramName { get; set; }
}
