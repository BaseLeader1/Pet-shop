using System.ComponentModel.DataAnnotations;

namespace PetShop.Models
{
    public class Animal
    {
        public int AnimalId { get; set; }
        [Display(Name ="Animal name: ")]
        [Required]
        public string? Name { get; set; }
        [Display(Name = "Animal age: ")]
        [Required]
        public int Age { get; set; }
        public string? PictureName { get; set; }
        [Display(Name = "Animal Description: ")]
        [Required]
        [DataType(DataType.MultilineText)]
        public string? Description { get; set; }
        public int CategoryId { get; set; }
        public virtual Category? Category { get; set; }
        public virtual ICollection<Comment>? Comment { get; set; } = new List<Comment>();

    }
}
