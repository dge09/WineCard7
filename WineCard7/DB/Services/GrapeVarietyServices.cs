using WineCard7.DB.Entitys;

namespace WineCard7.DB.Services
{
    public class GrapeVarietyServices : BaseServices<WGrapeVariety> 
    {
        private readonly DataContext _context;

        public GrapeVarietyServices(DataContext context) : base(context)
        {
            _context = context;
        }
    }
}
