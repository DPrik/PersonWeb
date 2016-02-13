using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
   public class Address
    {
        [Key]
        public int Id { get; set; }
        public int StreetId { get; set; }
        public int Build { get; set; }
        public int Apartments { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }

        public virtual int PersonId { get; set; }
        [ForeignKey("PersonId")]
        public virtual Person Person { get; set; }


        [ForeignKey("StreetId")]
        public virtual Street Street { get; set; }
    }
}
