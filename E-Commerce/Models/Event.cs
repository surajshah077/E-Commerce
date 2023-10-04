using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models
{
    public class Event
    {
        [Key]
        public int EventId { get; set; }
        public string eventName {  get; set; }
        public string eventPrice { get; set; }
        public string eventDescription {  get; set; }
        [ValidateNever]
        public string eventPicture { get; set; }
    }
}
