using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entities
{
   public class City
    {
        [Key]
        public int Id { set; get; }
        public string Name { get; set; }     
        public int CountryId { get; set; }

        public virtual List<Street> Streets { get; set; }


        [ForeignKey("CountryId")]
        public virtual Country Country { get; set; }

        public City()
        {
            Streets = new List<Street>();
        }

    }
}
