using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersUI.Models
{
    public class CityViewModel
    {
        public int Id { set; get; }
        public string Name { get; set; }
        public int CountryId { get; set; }
        public virtual List<StreetViewModel> Streets { get; set; }
        public CityViewModel()
        {
            Streets = new List<StreetViewModel>();
        }
    }
}