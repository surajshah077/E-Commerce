using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models
{
    public class Main
    {
        [Key]
        public int MainId { get; set; }
        [MaxLength(100)]
        public string AboutHeading1 { get; set; }
        [MaxLength(100)]
        public string AboutHeading2 { get; set; }
        [MaxLength(500)]
        public string AboutDescription { get; set; }
        [ValidateNever]
        public string Image {  get; set; }
        [ValidateNever]
        [Display(Name ="Please upload video link")]
        public string Video { get; set; }
    }
}
