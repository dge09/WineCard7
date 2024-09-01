using WineCard7.DB.Entitys;

namespace WineCard7.DB.Services
{
    public class OriginCountryServices : BaseServices<WOriginCountry> 
    {
        private readonly DataContext _context;

        public OriginCountryServices(DataContext context) : base(context)
        {
            _context = context;
        }
    }
}
