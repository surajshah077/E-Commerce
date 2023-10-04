using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models
{
    public class Gallery
    {
        [Key]
        public int GalleryId { get; set; }
        [ValidateNever]
        public string GalleryPicture { get; set; }
    }
}
