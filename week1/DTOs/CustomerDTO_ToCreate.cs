using System.ComponentModel.DataAnnotations;

namespace week1.DTOs
{
    public class CustomerDTO_ToCreate
    {
        // [Key]
        // [Required(ErrorMessage="Id ReRequired")]
        // [Range(1 , 10, ErrorMessage="ID Between 1-10")]
        // public int Id { get; set; }

        [Required(ErrorMessage="FirstName ReRequired")]
        [StringLength(100,ErrorMessage="Must be under 50 characters")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(15,ErrorMessage="Must be under 15 characters")]
        public string BankAccount { get; set; }

        [Required]
        [StringLength(6,ErrorMessage="Must be under 6 characters")]
        public string ATMCode { get; set; }

        [Required]
        public double Balance { get; set; }
    }
}