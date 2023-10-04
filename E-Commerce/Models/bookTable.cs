using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models
{
    public class bookTable
    {
        [Key]
        public int bookTableId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Phone { get; set; }
        public DateTime Date { get; set; }
        public TimeSpan Time { get; set; }
        public int People { get; set; }
        public string Message { get; set; }
      
    }
}
