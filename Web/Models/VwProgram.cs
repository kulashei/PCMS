using System;
using System.Collections.Generic;

namespace Web.Models;

public partial class VwProgram
{
    public int ProgramId { get; set; }

    public string ProgramCode { get; set; }

    public string ProgramName { get; set; }

    public string ProgramDesc { get; set; }

    public string ProgramObj { get; set; }

    public string ProgramBen { get; set; }

    public DateOnly? ProgramStartDate { get; set; }

    public DateOnly? ProgramEndDate { get; set; }

    public bool ProgramApproved { get; set; }

    public int ProgramUserId { get; set; }

    public DateOnly? ProgramCreatedAt { get; set; }

    public int ProgramTypeId { get; set; }

    public string ProgramTypeName { get; set; }

    public int ProgramCoverageId { get; set; }

    public string ProgramCoverageName { get; set; }
}
