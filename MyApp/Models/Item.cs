using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyApp.Models
{
    public class Item
    {
        public int Id { get; set; }

        public string Name { get; set; } = null!;
        public int Age { get; set; }

        [EmailAddress]
        public string Email { get; set; } = null!;


        [Phone]
        [StringLength(10, MinimumLength = 10)]
        public string PhoneNumber { get; set; } = null!;

        public int? CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        public Category? Category { get; set; } 

    }
}
