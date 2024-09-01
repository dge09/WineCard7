using System.ComponentModel.DataAnnotations;

namespace WineCard7.DB.Entitys
{
    public class WPrice : BaseModel
    {
        [Required]
        [Range(1,100000)]
        public float PriceperBottle { get; set; }
    }
}
