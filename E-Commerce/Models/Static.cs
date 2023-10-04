using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Reflection.Metadata.Ecma335;

namespace E_Commerce.Models
{
    public class Static
    {
        [Key]
        public int StaticId { get; set; }
        public string Menu{ get; set; }
        public string MenuTitle { get; set; }
        public string MenuTitle2 { get; set; }
        public string MenuTopic1 { get; set; }
        public string MenuTopic2 { get; set; }
        public string MenuTopic3 { get; set; }
        public string MenuTopic4 { get; set; }
        public string Testimonials { get; set; }    
        public string TestimonialsTitle{ get; set; }
        public string TestimonialsTitle2 { get; set; }
        public string Event {  get; set; }
        public string eventTitle { get; set; }
        public string eventTitle2 { get; set; }
        public string eventTitle3 { get; set; }
        public string chefs { get; set; }
        public string chefsTitle { get; set;}
        public string chefsTitle2 { get; set;}
        public string chefsTitle3 { get; set;}
        public string Gallery { get; set; }
        public string GalleryTitle { get; set;}
        public string GalleryTitle2 { get; set;}
        public string Table { get; set; }
        public string TableTitle { get; set; }
        public string TableTitle2 { get; set; }
        public string TableTitle3 { get; set; }
        public string ContactAddress { get; set; }   
        public string ContactEmail { get; set; }
        public string ContactPhone { get; set; }
        public TimeSpan WorkingDays {  get; set; }
        public TimeSpan Weekend {  get; set; }
    };
}
