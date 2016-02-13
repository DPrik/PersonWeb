namespace persons_with_adress.Models
{
    public class AddressViewModel
    {
        public int Id { get; set; }
        public int StreetId { get; set; }
        public int Build { get; set; }
        public int Apartments { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }

    }
}