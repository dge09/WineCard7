using WineCard7.Bussines;
using WineCard7.DB.Entitys;

namespace WineCard7.DB.Services
{
    public static class MyServices
    {
        public static readonly DataContext context = new DataContext();
        public static readonly IBaseServices<Wine> wineServices = new WineServices(context);
        public static readonly IBaseServices<Card> cardServices = new CardServices(context);
        public static readonly IBaseServices<WOriginCountry> originCountryServices = new OriginCountryServices(context);
        public static readonly IBaseServices<WOriginFederalState> originFederalStateServices = new OriginFederalStateServices(context);
        public static readonly IBaseServices<WPrice> priceServices = new PriceServices(context);
        public static readonly IBaseServices<WType> typeServices = new TypeServices(context);
        public static readonly IBaseServices<WWinery> wineryServices = new WineryServices(context);
        public static readonly IBaseServices<WYear> yearServices = new YearServices(context);
        public static readonly IBaseServices<WGrapeVariety> grapeVarietyServices = new GrapeVarietyServices(context);
        public static readonly CsvServices csvServices = new();
        
    }
}
