using System.ComponentModel.DataAnnotations;

namespace WineCard7.DB.Entitys
{
    public class WYear : BaseModel
    {
        [Required]
        [Range(0,2024)]
        public int Year { get; set; }
    }
}
