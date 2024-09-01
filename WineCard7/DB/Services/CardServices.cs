using WineCard7.DB.Entitys;

namespace WineCard7.DB.Services
{
    public class CardServices : BaseServices<Card> 
    {
        private readonly DataContext _context;

        public CardServices(DataContext context) : base(context)
        {
            _context = context;
        }
    }
}
