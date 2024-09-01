using WineCard7.DB.DTOs;
using WineCard7.DB.Entitys;
using WineCard7.DB.Services;

namespace WineCard7.Bussines
{
    public class CsvServices
    {
        private List<Card> Cards = new List<Card>();
        private List<Wine> Wines = new List<Wine>();
        private List<WGrapeVariety> GrapeVarietys = new List<WGrapeVariety>();
        private List<WOriginCountry> OriginCountrys = new List<WOriginCountry>();
        private List<WOriginFederalState> OriginFederalStates = new List<WOriginFederalState>();
        private List<WPrice> Prices = new List<WPrice>();
        private List<WType> Types = new List<WType>();
        private List<WWinery> Winerys = new List<WWinery>();
        private List<WYear> Years = new List<WYear>();

        public async Task ImportDataAsync(string filepath)
        {
            List<CsvDTO> csvDTOs = new List<CsvDTO>();

            await UpdateListsAsync();

            using (StreamReader streamReader = new StreamReader(filepath))
            {
                streamReader.ReadLine();// skip header
                string line = streamReader.ReadLine();

                while (line != null)
                {
                    string[] splitLine = line.Split(';');

                    CsvDTO dto = new();

                    dto.Name = splitLine[0];
                    dto.PricePerBottle = float.Parse(splitLine[1].Trim('€').Trim(' '));
                    dto.Type = splitLine[2];
                    dto.OriginCountry = splitLine[3];
                    dto.Year = int.Parse(splitLine[4]);
                    dto.Winery = splitLine[5];
                    dto.OriginFederalState = splitLine[6];
                    dto.GrapeVariety = splitLine[7];

                    csvDTOs.Add(dto);

                    line = streamReader.ReadLine();
                }

                foreach (CsvDTO dto in csvDTOs)
                {
                    await SecureAttributeExistance(dto);

                    Wine wine = new Wine();

                    wine.Name = dto.Name;
                    wine.PriceID = Prices.Where(x => x.PriceperBottle == dto.PricePerBottle).First().ID;
                    wine.Price = Prices.Where(x => x.PriceperBottle == dto.PricePerBottle).First();
                    wine.TypeID = Types.Where(x => x.Name == dto.Type).First().ID;
                    wine.Type = Types.Where(x => x.Name == dto.Type).First();
                    wine.OriginCountryID = OriginCountrys.Where(x => x.Name == dto.OriginCountry).First().ID;
                    wine.OriginCountry = OriginCountrys.Where(x => x.Name == dto.OriginCountry).First();
                    wine.YearÎD = Years.Where(x => x.Year == dto.Year).First().ID;
                    wine.Year = Years.Where(x => x.Year == dto.Year).First();
                    wine.WineryID = Winerys.Where(x => x.Name == dto.Winery).First().ID;
                    wine.Winery = Winerys.Where(x => x.Name == dto.Winery).First();
                    wine.OriginFederalStateID = OriginFederalStates.Where(x => x.Name == dto.OriginFederalState).First().ID;
                    wine.OriginFederalState = OriginFederalStates.Where(x => x.Name == dto.OriginFederalState).First();
                    wine.GrapeVarietyID = GrapeVarietys.Where(x => x.Name == dto.GrapeVariety).First().ID;
                    wine.GrapeVariety = GrapeVarietys.Where(x => x.Name == dto.GrapeVariety).First();

                    await MyServices.wineServices.CreateAsync(wine);
                }
            }
        }

        private async Task SecureAttributeExistance(CsvDTO dto)
        {
            await UpdateListsAsync();
            
            if (GrapeVarietys.Where(x => x.Name == dto.GrapeVariety).Count() < 1)
            {
                WGrapeVariety newGV = new WGrapeVariety();
                newGV.Name = dto.GrapeVariety;
                await MyServices.grapeVarietyServices.CreateAsync(newGV);
                await UpdateListsAsync();
            }

            if (OriginCountrys.Where(x => x.Name == dto.OriginCountry).Count() < 1)
            {
                WOriginCountry newOC = new WOriginCountry();
                newOC.Name = dto.OriginCountry;
                await MyServices.originCountryServices.CreateAsync(newOC);
                await UpdateListsAsync();
            }

            if (OriginFederalStates.Where(x => x.Name == dto.OriginFederalState).Count() < 1)
            {
                WOriginFederalState newOFS = new WOriginFederalState();
                newOFS.Name = dto.OriginFederalState;
                await MyServices.originFederalStateServices.CreateAsync(newOFS);
                await UpdateListsAsync();
            }

            if (Types.Where(x => x.Name == dto.Type).Count() < 1)
            {
                WType newT = new WType();
                newT.Name = dto.Type;
                await MyServices.typeServices.CreateAsync(newT);
                await UpdateListsAsync();
            }

            if (Winerys.Where(x => x.Name == dto.Winery).Count() < 1)
            {
                WWinery newW = new WWinery();
                newW.Name = dto.Winery;
                await MyServices.wineryServices.CreateAsync(newW);
                await UpdateListsAsync();
            }

            if (Prices.Where(x => x.PriceperBottle == dto.PricePerBottle).Count() < 1)
            {
                WPrice newP = new WPrice();
                newP.PriceperBottle = dto.PricePerBottle;
                await MyServices.priceServices.CreateAsync(newP);
                await UpdateListsAsync();
            }

            if (Years.Where(x => x.Year == dto.Year).Count() < 1)
            {
                WYear newY = new WYear();
                newY.Year = dto.Year;
                await MyServices.yearServices.CreateAsync(newY);
                await UpdateListsAsync();
            }
        }

        private async Task UpdateListsAsync()
        {
            GrapeVarietys = await MyServices.grapeVarietyServices.GetAllAsync();
            OriginCountrys = await MyServices.originCountryServices.GetAllAsync();
            OriginFederalStates = await MyServices.originFederalStateServices.GetAllAsync();
            Types = await MyServices.typeServices.GetAllAsync();
            Winerys = await MyServices.wineryServices.GetAllAsync();
            Prices = await MyServices.priceServices.GetAllAsync();
            Years = await MyServices.yearServices.GetAllAsync();
            Cards = await MyServices.cardServices.GetAllAsync();
            Wines = await MyServices.wineServices.GetAllAsync();
        }
    }
}
