using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models
{
    public class Menu
    {
        [Key]
        public int MenuId { get; set; }
        [Required]
        public string Topic { get; set; }
        [ValidateNever]
        public string itemPhoto { get; set; }
        [Required]
        public string itemName { get; set; }
        [Required]
        public string Ingredients { get; set; }
        [Required]
        public string price { get; set; }
        public string description { get; set; }
        public string Name { get; set; }
        public string Designation { get; set; }
        [ValidateNever]
        public string profileImage { get; set; }
    }
}
