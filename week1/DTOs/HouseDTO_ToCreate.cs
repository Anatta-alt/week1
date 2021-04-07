using System.ComponentModel.DataAnnotations;

namespace week1.DTOs
{
    public class HouseDTO_ToCreate
    {
        [Required]
        [StringLength(20)]
        public string Number { get; set; }

        [Required]
        [StringLength(50)]
        public string HouseDistric { get; set; }

        [Required]
        [StringLength(50)]
        public string RoadName { get; set; }

        [Required]
        [StringLength(50)]
        public string City { get; set; }
    }
    
}