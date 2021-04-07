using System.ComponentModel.DataAnnotations;

namespace week1.DTOs
{
    public class LoginDTO_ToCreate
    {
        [Required]
        [StringLength(50)]
        public string Username { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Required]
        [StringLength(20)]
        public string Password { get; set; }
    }
}