using System.ComponentModel.DataAnnotations;

namespace week1.Models
{
    public class Client
    {
        [Required(ErrorMessage="Id ReRequired")]
        [Range(1 , 10, ErrorMessage="ID Between 1-10")]

        public int Id { get; set; }
        [Required(ErrorMessage="FirstName ReRequired")]
        [StringLength(50,ErrorMessage="Must be under 50 characters")]
        public string UserName { get; set; }
        [Required(ErrorMessage="Email ReRequired")]
        [StringLength(50,ErrorMessage="Must be under 50 characters")]
        public string Email { get; set; }
        [Required(ErrorMessage="Password ReRequired")]
        [StringLength(8,ErrorMessage="Must be under 8 characters")]
        public string Password { get; set; }

        
    }
}