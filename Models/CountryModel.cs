namespace AuthenticationAPI.Models
{
    public class CountryModel
    {
        public string Name { get; set; }
        public List<ProvinceModel> Provinces { get; set; }

        public CountryModel(string name, ProvinceModel[] provinces) 
        { 
            Name = name;
            Provinces = provinces.ToList();
        }
    }
}
