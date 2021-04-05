using System;
using System.ComponentModel.DataAnnotations;

namespace week1.Models
{
    public class Book
    {
        [Range(1,int.MaxValue)]
        public int Id { get; set; }

        [Required]
        [MinLength(10)]
        public string Name { get; set; }

        [Range(1,55000)]
        public double Price { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}