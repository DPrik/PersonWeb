using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace persons_with_adress.Models
{
    public class UserViewModel
    {
        public int Id { get; set; }

        public string RegId { set; get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public byte[] Photo { get; set; }

        public virtual List<PersoneViewModel> Persons { get; set; }
       
    }
}