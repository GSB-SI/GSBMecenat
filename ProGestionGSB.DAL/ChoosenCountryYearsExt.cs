namespace ProGestionGSB.DAL
{
    public partial class ChoosenCountryYear
    {
        public string CountryName
        {
            get { return Country.name; }
        }


        public string CountryNameYear
        {
            get { return Country.name + " - " + choosenYear; }
        }
    }
}