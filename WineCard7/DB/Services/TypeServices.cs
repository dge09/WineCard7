using WineCard7.DB.Entitys;

namespace WineCard7.DB.Services
{
    public class TypeServices : BaseServices<WType> 
    {
        private readonly DataContext _context;

        public TypeServices(DataContext context) : base(context)
        {
            _context = context;
        }
    }
}
