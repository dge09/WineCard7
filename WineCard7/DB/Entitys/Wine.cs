using System.ComponentModel.DataAnnotations;

namespace WineCard7.DB.Entitys
{
    public class Wine : BaseModel
    {
        
        [Required]
        public string Name { get; set; }
        
        [Required]
        public int PriceID { get; set; }
        
        [Required]
        public WPrice Price { get; set; }
        
        [Required]
        public int TypeID { get; set; }
        
        [Required]
        public WType Type { get; set; }
        
        [Required]
        public int OriginCountryID { get; set; }
        
        [Required]
        public WOriginCountry OriginCountry { get; set; }
        
        [Required]
        public int YearÎD { get; set; }
        
        [Required]
        public WYear Year { get; set; }
        
        [Required]
        public int WineryID { get; set; }
        
        [Required]
        public WWinery Winery { get; set; }
        
        [Required]
        public int OriginFederalStateID { get; set; }
        
        [Required]
        public WOriginFederalState OriginFederalState { get; set; }
        
        [Required]
        public int GrapeVarietyID { get; set; }

        [Required]
        public WGrapeVariety GrapeVariety { get; set; }

        public ICollection<Card> Cards { get; set; } = new List<Card>();
    }
}
