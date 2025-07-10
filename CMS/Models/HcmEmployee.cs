using System;
using System.Collections.Generic;

namespace CMS.Models;

public partial class HcmEmployee
{
    public int Id { get; set; }

    public string Number { get; set; }

    public string LastName { get; set; }

    public string FirstName { get; set; }

    public string OtherNames { get; set; }

    public string Email { get; set; }

    public string Home { get; set; }

    public string Office { get; set; }

    public string Mobile { get; set; }

    public DateTime? BirthDate { get; set; }

    public string Sex { get; set; }

    public string Title { get; set; }

    public string MaritalStatus { get; set; }

    public string Nationality { get; set; }

    public int DeptFk { get; set; }

    public virtual ResDept DeptFkNavigation { get; set; }
}
