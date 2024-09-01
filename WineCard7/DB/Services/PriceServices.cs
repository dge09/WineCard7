using WineCard7.DB.Entitys;

namespace WineCard7.DB.Services
{
    public class PriceServices : BaseServices<WPrice> 
    {
        private readonly DataContext _context;

        public PriceServices(DataContext context) : base(context)
        {
            _context = context;
        }
    }
}
