using System.ComponentModel.DataAnnotations;

namespace week1.DTOs
{
    public class EmployeeDTO_ToCreate
    {
        // [Required(ErrorMessage="Id ReRequired")]
        // public int Id { get; set; }

        [Required(ErrorMessage="FirstName ReRequired")]
        [StringLength(50,ErrorMessage="Must be under 50 characters")]
        public string FirstName { get; set; }

        [Required(ErrorMessage="LastName ReRequired")]
        [StringLength(50,ErrorMessage="Must be under 50 characters")]
        public string LastName { get; set; }

        [Required(ErrorMessage="Age ReRequired")]
        [Range(0 , 120, ErrorMessage="Age Between 0-120")]
        public int Age { get; set; }

        [Required(ErrorMessage="IdCard ReRequired")]
        [StringLength(13,ErrorMessage="Must be under 13 characters")]
        public string IdCard { get; set; }
    }
    
}