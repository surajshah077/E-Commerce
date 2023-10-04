using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models
{
    public class Chefs
    {
        [Key]
        public int ChefsId { get; set; }
        [ValidateNever]
        public string profileImage { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        public string Description { get; set; }
        public string socialMediaLink { get; set; }
    }
}
