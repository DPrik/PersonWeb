using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace persons_with_adress.Models
{
    public class PhoneViewModel
    {
        public int Id { set; get; }
        public string Number { get; set; }
        public string Type { get; set; }

        public int PersonId { get; set; }
      

        public PersoneViewModel Person { get; set; }
    }
}