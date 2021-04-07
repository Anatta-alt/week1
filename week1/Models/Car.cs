using System.ComponentModel.DataAnnotations;

namespace week1.Models
{
    public class Car
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Brand { get; set; }

        [Required]
        public string Model { get; set; }

        [Required]
        [Range(1800,2500)]
        public int Year { get; set; }
        public string Fuel { get; set; }
        public string Gear { get; set; }
        public string Color { get; set; }
        [Range(1,200000000)]
        public double Price { get; set; }
        public bool Issell { get; set; }

    }
}