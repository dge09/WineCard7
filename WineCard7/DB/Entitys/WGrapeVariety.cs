using System.ComponentModel.DataAnnotations;

namespace WineCard7.DB.Entitys
{
    public class WGrapeVariety : BaseModel
    {
        [Required]
        [MinLength(2)]
        [MaxLength(255)]
        public string Name { get; set; }
    }
}
