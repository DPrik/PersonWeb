using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public class CityDTO
    {
        public int Id { set; get; }
        public string Name { get; set; }
        public int CountryId { get; set; }
        public virtual List<StreetDTO> Streets { get; set; }
        public virtual CountryDTO Country { get; set; }
    }
}
