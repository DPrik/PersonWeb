using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PersUI.Models
{
    public class StreetViewModel
    {
        public int Id { set; get; }
        public string Name { get; set; }
        public int CityId { get; set; }
    }
}