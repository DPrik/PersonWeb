using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersUI.Models
{
    public class CountryViewModel
    {
        public int Id { set; get; }
        public string Name { get; set; }
        public  List<CityViewModel> Cities { get; set; }
        public CountryViewModel()
        {
            Cities = new List<CityViewModel>();
        }
    }
}