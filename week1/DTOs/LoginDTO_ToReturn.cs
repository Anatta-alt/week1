using System.ComponentModel.DataAnnotations;

namespace week1.DTOs
{
    public class LoginDTO_ToReturn
    {
        [Required]
        [StringLength(50)]
        public string Username { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

    }
}