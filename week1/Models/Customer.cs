using System.ComponentModel.DataAnnotations;

namespace week1.Models
{
    public class Customer
    {
        [Required(ErrorMessage="Id ReRequired")]
        [Range(1 , 10, ErrorMessage="ID Between 1-10")]
        public int Id { get; set; }

        [Required(ErrorMessage="FirstName ReRequired")]
        [StringLength(50,ErrorMessage="Must be under 50 characters")]
        public string FirstName { get; set; }

        [StringLength(10,ErrorMessage="Must be under 10 characters")]
        public string BankAccount { get; set; }
        public string ATMCode { get; set; }
        public double Balance { get; set; }
    }
}