using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DAL.Entities
{
    public class Country
    {
        [Key]
        public int Id { set; get; }
        public string Name { get; set; }

        public virtual List<City> Cities { get; set; }

        public Country()
        {
            Cities = new List<City>();
        }
    }
}