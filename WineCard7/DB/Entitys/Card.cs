using System.ComponentModel.DataAnnotations;

namespace WineCard7.DB.Entitys
{
    public class Card : BaseModel
    {
        [Required]
        [MinLength(2)]
        [MaxLength(255)]
        public string Name { get; set; }

        [MaxLength(2500)]
        public string Description { get; set; }

        public ICollection<Wine> Wines { get; set; } = new List<Wine>();
    }
}
