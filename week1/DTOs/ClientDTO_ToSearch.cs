using System.ComponentModel.DataAnnotations;

namespace week1.DTOs
{
    public class ClientDTO_ToSearch
    {
        [Required(ErrorMessage="Id ReRequired")]
        public int Id { get; set; }

        [Required(ErrorMessage="FirstName ReRequired")]
        [StringLength(50,ErrorMessage="Must be under 50 characters")]
        public string UserName { get; set; }
    }
}