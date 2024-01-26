using AuthenticationAPI.Models;

namespace AuthenticationAPI
{
    public static class GlobalData
    {
        public static List<UserModel> Admins = new List<UserModel>() { new UserModel("Joseph", "Ns rfr ,elnj") };
        public static List<CountryModel> Countries = new List<CountryModel>() { new CountryModel("Tajikistan", new ProvinceModel[] { new ProvinceModel("Khatlon"), new ProvinceModel("Bokhtar") })};
    }
}
