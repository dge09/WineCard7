using WineCard7.DB.Entitys;

namespace WineCard7.DB.Services
{
    public class WineryServices : BaseServices<WWinery> 
    {
        private readonly DataContext _context;

        public WineryServices(DataContext context) : base(context)
        {
            _context = context;
        }
    }
}
