using System.ComponentModel.DataAnnotations;

namespace CMS.Areas.Admin
{
    public class StandardBillViewModel
    {
        public int? Id { get; set; }

        [Required]
        [StringLength(255, MinimumLength = 3)]
        public string Name { get; set; }
    }
}