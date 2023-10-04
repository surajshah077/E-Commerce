using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models
{
    public class About
    {
        [Key]
        public int AboutId { get; set; }
        [MaxLength(100)]
        public string AboutTitle1 { get; set; }  
        [MaxLength(100)]
        public string AboutTitle2 { get; set; }
        [ValidateNever]
        public string Image {  get; set; }
        [MaxLength(100)]
        public string Message { get; set; }
      
        [DisplayName("Phone Number")]
        public long phoneNumber { get; set; }
        [Required]
        public string shortDescription { get; set; }
        public string description { get; set; }
        [ValidateNever]
        public string Image2 { get; set; }
        [Display(Name ="Please upload a video link")]
        public string Video { get; set; }   
    }
}
