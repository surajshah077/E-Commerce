using E_Commerce.Models.Enum;
using System.ComponentModel.DataAnnotations;

namespace E_Commerce.Models
{
    public class Register
    {
        [Key]
        public int RegisterId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        //[Required(ErrorMessage = "Phone number is required.")]
        //[RegularExpression(@"^\d{10}$", ErrorMessage = "Phone number must be 10 digits.")]
        public int phoneNumber { get; set; }
        public string Address { get; set; }
        public Role role { get; set; }
    }
}
