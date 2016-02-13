using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
    public   class CountryDTO
    {
        public int Id { set; get; }
        public string Name { get; set; }
        public virtual List<CityDTO> Cities { get; set; }
    }
}
