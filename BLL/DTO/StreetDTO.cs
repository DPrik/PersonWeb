namespace BLL.DTO
{
    public class StreetDTO
    {
       
        public int Id { set; get; }
        public string Name { get; set; }
        public int CityId { get; set; }

        public virtual CityDTO City { get; set; }
    }
}