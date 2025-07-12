using System.ComponentModel.DataAnnotations;
using CMS.Models;

namespace CMS.Areas.Admin.ViewModels;

public partial class ContractorViewModel
{
    public int? ContractorId { get; set; }

    [Required, StringLength(255, MinimumLength = 3)]
    public string TinNo { get; set; }
    [Required, StringLength(255, MinimumLength = 3)]
    public string ContractorName { get; set; }
    [Required, StringLength(255, MinimumLength = 3)]
    public string Address { get; set; }
    [Required, StringLength(255, MinimumLength = 3)]
    public string ContactPerson { get; set; }
    [Required, StringLength(255, MinimumLength = 3), EmailAddress]
    public string Email { get; set; }
    [Required, StringLength(15, MinimumLength = 10)]
    public string Phone { get; set; }
    [Required, StringLength(255, MinimumLength = 3)]
    public string Type { get; set; }
    [Required, StringLength(255, MinimumLength = 3)]
    public string Classification { get; set; }
    
    public DateTime? ExpirationDate { get; set; }
}