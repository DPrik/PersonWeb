using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTO
{
   public class AddressDTO
    {
     
        public int Id { get; set; }
        public int StreetId { get; set; }
        public int Build { get; set; }
        public int Apartments { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }


        public virtual int PersonId { get; set; }
     
        public virtual PersonDTO Person { get; set; }
  
        public virtual StreetDTO Street { get; set; }

    }
}
