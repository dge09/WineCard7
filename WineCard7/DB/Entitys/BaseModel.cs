using System.ComponentModel.DataAnnotations;

namespace WineCard7.DB.Entitys
{
    public class BaseModel
    {
        [Key]
        public int ID { get; set; }
    }
}
