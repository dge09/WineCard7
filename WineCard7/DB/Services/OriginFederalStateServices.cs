using WineCard7.DB.Entitys;

namespace WineCard7.DB.Services
{
    public class OriginFederalStateServices : BaseServices<WOriginFederalState> 
    {
        private readonly DataContext _context;

        public OriginFederalStateServices(DataContext context) : base(context)
        {
            _context = context;
        }
    }
}
