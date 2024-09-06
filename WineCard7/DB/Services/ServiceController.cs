using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;
using WineCard7.DB.Entitys;
using WineCard7.DB.Services;

namespace WineCard7.DB.Services
{
    public class ServiceController : ControllerBase
    {
        private readonly IBaseServices<Card> _CardServices;
        private readonly IBaseServices<WGrapeVariety> _GrapeVarietyServices;
        private readonly IBaseServices<Wine> _WineServices;
        private readonly IBaseServices<Location> _LocationServices;
        private readonly IBaseServices<WOriginCountry> _OriginCountryServices;
        private readonly IBaseServices<WOriginFederalState> _OriginFederalStateServices;
        private readonly IBaseServices<WPrice> _PriceServices;
        private readonly IBaseServices<WType> _TypeServices;
        private readonly IBaseServices<WWinery> _WineryServices;
        private readonly IBaseServices<WYear> _YearServices;


        public ServiceController(IBaseServices<Card> CardServices, IBaseServices<WGrapeVariety> GrapeVarietyServices, IBaseServices<Wine> WineServices, IBaseServices<Location> LocationServices, IBaseServices<WOriginCountry> OriginCountryServices, IBaseServices<WOriginFederalState> OriginFederalStateServices, IBaseServices<WPrice> PriceServices, IBaseServices<WType> TypeServices, IBaseServices<WWinery> WineryServices, IBaseServices<WYear> YearServices)
        {
            _CardServices = CardServices;
            _GrapeVarietyServices = GrapeVarietyServices;
            _WineServices = WineServices;
            _LocationServices = LocationServices;
            _OriginCountryServices = OriginCountryServices;
            _OriginFederalStateServices = OriginFederalStateServices;
            _PriceServices = PriceServices;
            _TypeServices = TypeServices;
            _WineryServices = WineryServices;
            _YearServices = YearServices;
        }
    }
}