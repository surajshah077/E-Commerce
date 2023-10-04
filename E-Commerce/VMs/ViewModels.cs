using E_Commerce.Models;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce.VMs
{
    public class ViewModels
    {
        [Key]
        public int VMId { get; set; }
        public Main main { get; set; }
        public About about { get; set; }
        public Static Static { get; set; }
        public List<Menu> menu { get; set; }
        public List<Event> events { get; set; }
        public List<Chefs> chefs { get; set; }
        public List<Gallery> gallery { get; set; }
        public bookTable booking { get; set; }
        public Contact contact { get; set; }
    }
}
