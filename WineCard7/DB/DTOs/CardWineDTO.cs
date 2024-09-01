using WineCard7.DB.Entitys;

namespace WineCard7.DB.DTOs
{
    public class CardWineDTO
    {
        public Wine Wine { get; set; }
        public bool IsPartOfCard { get; set; }
    }
}
