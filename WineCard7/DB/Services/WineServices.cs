using WineCard7.DB.Entitys;

namespace WineCard7.DB.Services
{
    public class WineServices : BaseServices<Wine> 
    {
        private readonly DataContext _context;

        public WineServices(DataContext context) : base(context)
        {
            _context = context;
        }
    }
}
