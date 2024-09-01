using WineCard7.DB.Entitys;

namespace WineCard7.DB.Services
{
    public class YearServices : BaseServices<WYear> 
    {
        private readonly DataContext _context;

        public YearServices(DataContext context) : base(context)
        {
            _context = context;
        }
    }
}
